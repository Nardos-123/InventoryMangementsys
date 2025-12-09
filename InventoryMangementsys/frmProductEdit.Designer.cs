namespace InventoryMangementsys
{
    partial class frmProductEdit
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
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtCost = new TextBox();
            txtSell = new TextBox();
            txtDesc = new TextBox();
            cmbCategory = new ComboBox();
            cmbSupplier = new ComboBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(0, 375);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(394, 75);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            btnSave.DialogResult = DialogResult.OK;            // ← ADD THIS LINE
            this.AcceptButton = btnSave;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(400, 375);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(394, 75);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.DialogResult = DialogResult.Cancel;      // ← ADD THIS LINE
            this.CancelButton = btnCancel;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(35, 36);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(28, 87);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(35, 149);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 4;
            label3.Text = "Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(35, 213);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 5;
            label4.Text = "Sell";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(6, 273);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 6;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(399, 36);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 7;
            label6.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(406, 119);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 8;
            label7.Text = "Supplier";
            // 
            // txtName
            // 
            txtName.Location = new Point(114, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 31);
            txtName.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(114, 87);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(190, 31);
            txtQuantity.TabIndex = 10;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(114, 149);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(190, 31);
            txtCost.TabIndex = 11;
            // 
            // txtSell
            // 
            txtSell.Location = new Point(114, 213);
            txtSell.Name = "txtSell";
            txtSell.Size = new Size(190, 31);
            txtSell.TabIndex = 12;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(114, 273);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(190, 31);
            txtDesc.TabIndex = 13;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(502, 36);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(182, 33);
            cmbCategory.TabIndex = 14;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(502, 129);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(182, 33);
            cmbSupplier.TabIndex = 15;
            // 
            // frmProductEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbCategory);
            Controls.Add(txtDesc);
            Controls.Add(txtSell);
            Controls.Add(txtCost);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmProductEdit";
            Text = "frmProductEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtCost;
        private TextBox txtSell;
        private TextBox txtDesc;
        private ComboBox cmbCategory;
        private ComboBox cmbSupplier;
    }
}