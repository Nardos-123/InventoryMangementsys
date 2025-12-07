namespace InventoryMangementsys
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            chkShowPassword = new CheckBox();
            btnlogin = new Button();
            txtpassword = new TextBox();
            label3 = new Label();
            txtusername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(chkShowPassword);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(352, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 446);
            panel1.TabIndex = 1;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(245, 214);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(216, 36);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.Window;
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = SystemColors.MenuHighlight;
            btnlogin.Location = new Point(175, 263);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(190, 50);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(175, 169);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(305, 31);
            txtpassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 166);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(175, 95);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(305, 31);
            txtusername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 0);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(175, 22);
            label2.Name = "label2";
            label2.Size = new Size(219, 32);
            label2.TabIndex = 1;
            label2.Text = "Registration Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 95);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(887, 461);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnlogin;
        private TextBox txtpassword;
        private Label label3;
        private TextBox txtusername;
        private CheckBox chkShowPassword;
    }
}
