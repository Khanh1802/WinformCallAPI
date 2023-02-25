namespace ConnectToAPI.FormLogins
{
    partial class FormLogin
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
            this.BtPageRegister = new System.Windows.Forms.Button();
            this.BtLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbPassword = new System.Windows.Forms.CheckBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtPageRegister
            // 
            this.BtPageRegister.Location = new System.Drawing.Point(523, 257);
            this.BtPageRegister.Name = "BtPageRegister";
            this.BtPageRegister.Size = new System.Drawing.Size(117, 32);
            this.BtPageRegister.TabIndex = 84;
            this.BtPageRegister.Text = "Register";
            this.BtPageRegister.UseVisualStyleBackColor = true;
            // 
            // BtLogin
            // 
            this.BtLogin.Location = new System.Drawing.Point(103, 257);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(117, 32);
            this.BtLogin.TabIndex = 83;
            this.BtLogin.Text = "Login";
            this.BtLogin.UseVisualStyleBackColor = true;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.CbPassword);
            this.panel1.Controls.Add(this.TbPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TbUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(103, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 131);
            this.panel1.TabIndex = 82;
            // 
            // CbPassword
            // 
            this.CbPassword.AutoSize = true;
            this.CbPassword.Location = new System.Drawing.Point(458, 85);
            this.CbPassword.Name = "CbPassword";
            this.CbPassword.Size = new System.Drawing.Size(63, 24);
            this.CbPassword.TabIndex = 68;
            this.CbPassword.Text = "View";
            this.CbPassword.UseVisualStyleBackColor = true;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(144, 83);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(290, 27);
            this.TbPassword.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 66;
            this.label3.Text = "Password";
            // 
            // TbUserName
            // 
            this.TbUserName.Location = new System.Drawing.Point(144, 19);
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(290, 27);
            this.TbUserName.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(287, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 81;
            this.label1.Text = "PAGE LOGIN";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtPageRegister);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtPageRegister;
        private Button BtLogin;
        private Panel panel1;
        private CheckBox CbPassword;
        private TextBox TbPassword;
        private Label label3;
        private TextBox TbUserName;
        private Label label2;
        private Label label1;
    }
}