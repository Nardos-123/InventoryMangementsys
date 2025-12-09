using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMangementsys
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void OpenFormInPanel(Form form)
        {
            // Clear previous form
            panel2.Controls.Clear();

            // Settings for child form
            form.TopLevel = false;        // Important!
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;   // Fill the panel
            form.BackColor = Color.White;

            // Add and show
            panel2.Controls.Add(form);
            form.Show();
        }

        private void frmCategory_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmCategory());
        }

        private void frmProduct_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmProduct());
        }

        private void frmStockHistory_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmStockHistory());
        }

        private void frmSupplier_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmSupplier());
        }

        private void frmUser_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmUser());
        }
    }
}
