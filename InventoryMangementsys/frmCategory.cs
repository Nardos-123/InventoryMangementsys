using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using Datalayer.Model; // Your Category model

namespace InventoryMangementsys
{
    public partial class frmCategory : Form
    {
        private readonly HttpClient _http;
        private readonly string _apiUrl = "https://localhost:7002/api/categories"; // Change port if needed
        private List<Category> categories;

        public frmCategory()
        {
            InitializeComponent();
            _http = new HttpClient();
            this.Load += FrmCategory_Load;
        }

        private async void FrmCategory_Load(object sender, EventArgs e)
        {
            await LoadCategories();
        }

        private async Task LoadCategories()
        {
            try
            {
                btnRefresh.Enabled = false;
                dgvCategories.DataSource = null;
                dgvCategories.Rows.Clear();

                var response = await _http.GetFromJsonAsync<List<Category>>(_apiUrl);
                categories = response ?? new List<Category>();

                dgvCategories.DataSource = categories;
                dgvCategories.Columns["CategoryId"].HeaderText = "ID";
                dgvCategories.Columns["CategoryName"].HeaderText = "Category Name";
                dgvCategories.Columns["Products"].Visible = false; // Hide navigation property

                // Beautify
                dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCategories.BackgroundColor = Color.White;
                dgvCategories.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot connect to server!\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRefresh.Enabled = true;
            }
        }


        private async void btnAdd_Click_1(object sender, EventArgs e)
        {
            var input = Microsoft.VisualBasic.Interaction.InputBox(
        "Enter new category name:", "Add Category", "");

            if (string.IsNullOrWhiteSpace(input)) return;

            var newCat = new Category { CategoryName = input };

            try
            {
                var response = await _http.PostAsJsonAsync(_apiUrl, newCat);

                string error = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        $"Failed to add category.\n\nStatus: {response.StatusCode}\nError: {error}",
                        "API Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                MessageBox.Show("Category added successfully!", "Success");

                await LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error:\n" + ex.Message);
            }
        }

        private async void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Category)dgvCategories.SelectedRows[0].DataBoundItem;
            var input = Microsoft.VisualBasic.Interaction.InputBox(
                "Edit category name:", "Edit Category", selected.CategoryName);

            if (string.IsNullOrWhiteSpace(input) || input == selected.CategoryName) return;

            selected.CategoryName = input;
            var response = await _http.PutAsJsonAsync($"{_apiUrl}/{selected.CategoryId}", selected);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Category updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadCategories();
            }

        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = (Category)dgvCategories.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show($"Delete category '{selected.CategoryName}'?\nThis cannot be undone!",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var response = await _http.DeleteAsync($"{_apiUrl}/{selected.CategoryId}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Category deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadCategories();
                }
                else
                {
                    MessageBox.Show("Cannot delete: Category may be used by products.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnRefresh_Click_1(object sender, EventArgs e)
        {
            await LoadCategories();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (categories == null) return;

            var filtered = categories
                .Where(c => c.CategoryName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvCategories.DataSource = null;
            dgvCategories.DataSource = filtered;
        }
    }
}