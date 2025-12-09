using Datalayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace InventoryMangementsys
{
    public partial class frmProduct : Form
    {
        private readonly HttpClient _http;
        private readonly string _apiProduct = "https://localhost:7002/api/products";
        private readonly string _apiCategory = "https://localhost:7002/api/categories";
        private readonly string _apiSupplier = "https://localhost:7002/api/suppliers";

        private List<Product> products;
        private List<Category> categories;
        private List<Supplier> suppliers;
        public frmProduct()
        {
            InitializeComponent();
            _http = new HttpClient();
            this.Load += FrmProduct_Load;
        }

        private async void FrmProduct_Load(object? sender, EventArgs e)

        {
            await LoadDropdowns();
            await LoadProducts();
        }

        private async Task LoadDropdowns()
        {
            try
            {
                categories = await _http.GetFromJsonAsync<List<Category>>(_apiCategory) ?? new();
                suppliers = await _http.GetFromJsonAsync<List<Supplier>>(_apiSupplier) ?? new();

                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";

                cmbSupplier.DataSource = suppliers;
                cmbSupplier.DisplayMember = "SupplierName"; // assuming Supplier has SupplierName
                cmbSupplier.ValueMember = "SupplierId";
            }
            catch { /* ignore for now */ }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new frmProductEdit(categories, suppliers);
            if (f.ShowDialog() == DialogResult.OK)
            {
                var response = await _http.PostAsJsonAsync(_apiProduct, f.Product);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Product added successfully!");
                    await LoadProducts();
                }
            }
        }

        private async Task LoadProducts(string search = "")
        {
            try
            {
                btnRefresh.Enabled = false;
                dgvProducts.DataSource = null;

                // Load from API
                products = await _http.GetFromJsonAsync<List<Product>>(_apiProduct) ?? new();

                // SEARCH
                if (!string.IsNullOrWhiteSpace(search))
                {
                    products = products.Where(p =>
                        (p.Name?.Contains(search, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (p.Category?.CategoryName?.Contains(search, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (p.Supplier?.SupplierName?.Contains(search, StringComparison.OrdinalIgnoreCase) ?? false)
                    ).ToList();
                }

                dgvProducts.DataSource = products;

                // Beautify columns
                dgvProducts.Columns["ProductId"].HeaderText = "ID";
                dgvProducts.Columns["Name"].HeaderText = "Product Name";
                dgvProducts.Columns["Quantity"].HeaderText = "Stock";
                dgvProducts.Columns["CostPrice"].HeaderText = "Cost Price";
                dgvProducts.Columns["SellingPrice"].HeaderText = "Selling Price";
                dgvProducts.Columns["CreatedAt"].HeaderText = "Added On";
                dgvProducts.Columns["CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvProducts.Columns["CostPrice"].DefaultCellStyle.Format = "N2";
                dgvProducts.Columns["SellingPrice"].DefaultCellStyle.Format = "N2";

                // Hide unneeded columns
                dgvProducts.Columns["Category"].Visible = false;
                dgvProducts.Columns["Supplier"].Visible = false;
                dgvProducts.Columns["Description"].Visible = false;
                dgvProducts.Columns["CategoryId"].Visible = false;
                dgvProducts.Columns["SupplierId"].Visible = false;

                // Add CategoryName column (ONLY ONCE)
                if (!dgvProducts.Columns.Contains("CategoryName"))
                {
                    dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "CategoryName",
                        HeaderText = "Category"
                    });
                }

                if (!dgvProducts.Columns.Contains("SupplierName"))
                {
                    dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "SupplierName",
                        HeaderText = "Supplier"
                    });
                }

                // Fill CategoryName + SupplierName
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    var p = (Product)row.DataBoundItem;
                    row.Cells["CategoryName"].Value = p.Category?.CategoryName ?? "";
                    row.Cells["SupplierName"].Value = p.Supplier?.SupplierName ?? "";
                }

                dgvProducts.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally
            {
                btnRefresh.Enabled = true;
            }

        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) return;

            var selected = (Product)dgvProducts.SelectedRows[0].DataBoundItem;
            var f = new frmProductEdit(categories, suppliers, selected);
            if (f.ShowDialog() == DialogResult.OK)
            {
                var response = await _http.PutAsJsonAsync($"{_apiProduct}/{selected.ProductId}", f.Product);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Product updated!");
                    await LoadProducts();
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) return;

            var p = (Product)dgvProducts.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show($"Delete '{p.Name}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var response = await _http.DeleteAsync($"{_apiProduct}/{p.ProductId}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Product deleted!");
                    await LoadProducts();
                }
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadProducts();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            await LoadProducts(txtSearch.Text);
        }
    }
}
