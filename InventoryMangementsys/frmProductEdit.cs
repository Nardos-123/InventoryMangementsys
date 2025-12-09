using Datalayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryMangementsys
{
    public partial class frmProductEdit : Form
    {
        public Product Product { get; set; }

        private readonly List<Category> _categories;
        private readonly List<Supplier> _suppliers;
        public frmProductEdit(List<Category> categories, List<Supplier> suppliers)
        {
            InitializeComponent();

            _categories = categories;
            _suppliers = suppliers;

            LoadDropdowns();

            Product = new Product
            {
                CreatedAt = DateTime.Now
            };
        }

        public frmProductEdit(List<Category> categories, List<Supplier> suppliers, Product existing)
        {
            InitializeComponent();

            _categories = categories;
            _suppliers = suppliers;

            LoadDropdowns();

            Product = existing;

            LoadProductData();
        }

        // ---------- Load dropdown data ----------
        private void LoadDropdowns()
        {
            cmbCategory.DataSource = _categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

            cmbSupplier.DataSource = _suppliers;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierId";
        }

        // ---------- Fill form fields (EDIT mode) ----------
        private void LoadProductData()
        {
            txtName.Text = Product.Name;
            txtQuantity.Text = Product.Quantity.ToString();
            txtCost.Text = Product.CostPrice.ToString();
            txtSell.Text = Product.SellingPrice.ToString();
            txtDesc.Text = Product.Description;

            cmbCategory.SelectedValue = Product.CategoryId;
            cmbSupplier.SelectedValue = Product.SupplierId;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Product name is required!");
                return;
            }

            Product.Name = txtName.Text;
            Product.Quantity = int.TryParse(txtQuantity.Text, out int q) ? q : 0;
            Product.CostPrice = decimal.TryParse(txtCost.Text, out decimal c) ? c : 0;
            Product.SellingPrice = decimal.TryParse(txtSell.Text, out decimal s) ? s : 0;
            Product.Description = txtDesc.Text;
            Product.CategoryId = (int)cmbCategory.SelectedValue;
            Product.SupplierId = (int)cmbSupplier.SelectedValue;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    
    }
}
