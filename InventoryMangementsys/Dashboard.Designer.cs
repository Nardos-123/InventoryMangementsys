namespace InventoryMangementsys
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            frmUser = new Button();
            frmSupplier = new Button();
            frmStockHistory = new Button();
            frmProduct = new Button();
            frmCategory = new Button();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(frmUser);
            panel1.Controls.Add(frmSupplier);
            panel1.Controls.Add(frmStockHistory);
            panel1.Controls.Add(frmProduct);
            panel1.Controls.Add(frmCategory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 581);
            panel1.TabIndex = 0;
            // 
            // frmUser
            // 
            frmUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            frmUser.Location = new Point(102, 496);
            frmUser.Name = "frmUser";
            frmUser.Size = new Size(287, 71);
            frmUser.TabIndex = 6;
            frmUser.Text = "User";
            frmUser.UseVisualStyleBackColor = true;
            frmUser.Click += frmUser_Click;
            // 
            // frmSupplier
            // 
            frmSupplier.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            frmSupplier.Location = new Point(102, 405);
            frmSupplier.Name = "frmSupplier";
            frmSupplier.Size = new Size(287, 76);
            frmSupplier.TabIndex = 5;
            frmSupplier.Text = "Supplier";
            frmSupplier.UseVisualStyleBackColor = true;
            frmSupplier.Click += frmSupplier_Click;
            // 
            // frmStockHistory
            // 
            frmStockHistory.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            frmStockHistory.Location = new Point(102, 329);
            frmStockHistory.Name = "frmStockHistory";
            frmStockHistory.Size = new Size(287, 70);
            frmStockHistory.TabIndex = 4;
            frmStockHistory.Text = "StockHistory";
            frmStockHistory.UseVisualStyleBackColor = true;
            frmStockHistory.Click += frmStockHistory_Click;
            // 
            // frmProduct
            // 
            frmProduct.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            frmProduct.Location = new Point(102, 247);
            frmProduct.Name = "frmProduct";
            frmProduct.Size = new Size(287, 76);
            frmProduct.TabIndex = 3;
            frmProduct.Text = "Product";
            frmProduct.UseVisualStyleBackColor = true;
            frmProduct.Click += frmProduct_Click;
            // 
            // frmCategory
            // 
            frmCategory.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            frmCategory.Location = new Point(102, 159);
            frmCategory.Name = "frmCategory";
            frmCategory.Size = new Size(287, 82);
            frmCategory.TabIndex = 2;
            frmCategory.Text = "Catagory";
            frmCategory.UseVisualStyleBackColor = true;
            frmCategory.Click += frmCategory_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 64);
            label3.Name = "label3";
            label3.Size = new Size(145, 60);
            label3.TabIndex = 1;
            label3.Text = "Menu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 64);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(389, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(749, 581);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 200);
            label2.Name = "label2";
            label2.Size = new Size(357, 45);
            label2.TabIndex = 0;
            label2.Text = "Welcome To Inventory";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(749, 581);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1138, 581);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Button frmUser;
        private Button frmSupplier;
        private Button frmStockHistory;
        private Button frmProduct;
        private Button frmCategory;
    }
}