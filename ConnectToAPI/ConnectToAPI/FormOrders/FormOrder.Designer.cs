namespace ConnectToAPI.FormOrders
{
    partial class FormOrder
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
            this.BtCancel = new System.Windows.Forms.Button();
            this.BtAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CbbSearch = new System.Windows.Forms.ComboBox();
            this.BtFind = new System.Windows.Forms.Button();
            this.BtAddCart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtRemove = new System.Windows.Forms.Button();
            this.TbTotalBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.TbAddress = new System.Windows.Forms.TextBox();
            this.CbbDelivery = new System.Windows.Forms.ComboBox();
            this.TbCurrentPage = new System.Windows.Forms.TextBox();
            this.BtNextPage = new System.Windows.Forms.Button();
            this.BtReversePage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // BtCancel
            // 
            this.BtCancel.Location = new System.Drawing.Point(1042, 492);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(113, 46);
            this.BtCancel.TabIndex = 0;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = true;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // BtAccept
            // 
            this.BtAccept.Enabled = false;
            this.BtAccept.Location = new System.Drawing.Point(722, 492);
            this.BtAccept.Name = "BtAccept";
            this.BtAccept.Size = new System.Drawing.Size(113, 46);
            this.BtAccept.TabIndex = 1;
            this.BtAccept.Text = "Accept";
            this.BtAccept.UseVisualStyleBackColor = true;
            this.BtAccept.Click += new System.EventHandler(this.BtAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total bill";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(10, 103);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1145, 383);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // CbbSearch
            // 
            this.CbbSearch.FormattingEnabled = true;
            this.CbbSearch.Location = new System.Drawing.Point(166, 13);
            this.CbbSearch.Name = "CbbSearch";
            this.CbbSearch.Size = new System.Drawing.Size(488, 28);
            this.CbbSearch.TabIndex = 4;
            // 
            // BtFind
            // 
            this.BtFind.Location = new System.Drawing.Point(930, 60);
            this.BtFind.Name = "BtFind";
            this.BtFind.Size = new System.Drawing.Size(94, 37);
            this.BtFind.TabIndex = 5;
            this.BtFind.Text = "Find";
            this.BtFind.UseVisualStyleBackColor = true;
            this.BtFind.Click += new System.EventHandler(this.BtFind_Click);
            // 
            // BtAddCart
            // 
            this.BtAddCart.Location = new System.Drawing.Point(1065, 60);
            this.BtAddCart.Name = "BtAddCart";
            this.BtAddCart.Size = new System.Drawing.Size(94, 37);
            this.BtAddCart.TabIndex = 6;
            this.BtAddCart.Text = "Add cart";
            this.BtAddCart.UseVisualStyleBackColor = true;
            this.BtAddCart.Click += new System.EventHandler(this.BtAddCart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name and price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            // 
            // NUDQuantity
            // 
            this.NUDQuantity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDQuantity.Location = new System.Drawing.Point(166, 55);
            this.NUDQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDQuantity.Name = "NUDQuantity";
            this.NUDQuantity.Size = new System.Drawing.Size(488, 27);
            this.NUDQuantity.TabIndex = 63;
            this.NUDQuantity.ThousandsSeparator = true;
            this.NUDQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtRemove
            // 
            this.BtRemove.Location = new System.Drawing.Point(882, 492);
            this.BtRemove.Name = "BtRemove";
            this.BtRemove.Size = new System.Drawing.Size(113, 46);
            this.BtRemove.TabIndex = 64;
            this.BtRemove.Text = "Remove";
            this.BtRemove.UseVisualStyleBackColor = true;
            this.BtRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // TbTotalBill
            // 
            this.TbTotalBill.Enabled = false;
            this.TbTotalBill.Location = new System.Drawing.Point(83, 502);
            this.TbTotalBill.Name = "TbTotalBill";
            this.TbTotalBill.Size = new System.Drawing.Size(175, 27);
            this.TbTotalBill.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 66;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 642);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 28);
            this.label5.TabIndex = 67;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(415, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 28);
            this.label6.TabIndex = 68;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(415, 642);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 28);
            this.label7.TabIndex = 69;
            this.label7.Text = "Delivery";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(82, 569);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(273, 27);
            this.TbName.TabIndex = 70;
            // 
            // TbPhone
            // 
            this.TbPhone.Location = new System.Drawing.Point(85, 643);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(273, 27);
            this.TbPhone.TabIndex = 71;
            // 
            // TbAddress
            // 
            this.TbAddress.Location = new System.Drawing.Point(534, 569);
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.Size = new System.Drawing.Size(273, 27);
            this.TbAddress.TabIndex = 72;
            // 
            // CbbDelivery
            // 
            this.CbbDelivery.FormattingEnabled = true;
            this.CbbDelivery.Location = new System.Drawing.Point(534, 642);
            this.CbbDelivery.Name = "CbbDelivery";
            this.CbbDelivery.Size = new System.Drawing.Size(273, 28);
            this.CbbDelivery.TabIndex = 73;
            // 
            // TbCurrentPage
            // 
            this.TbCurrentPage.Enabled = false;
            this.TbCurrentPage.Location = new System.Drawing.Point(831, 16);
            this.TbCurrentPage.Name = "TbCurrentPage";
            this.TbCurrentPage.Size = new System.Drawing.Size(125, 27);
            this.TbCurrentPage.TabIndex = 98;
            // 
            // BtNextPage
            // 
            this.BtNextPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtNextPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtNextPage.Location = new System.Drawing.Point(971, 12);
            this.BtNextPage.Name = "BtNextPage";
            this.BtNextPage.Size = new System.Drawing.Size(123, 35);
            this.BtNextPage.TabIndex = 97;
            this.BtNextPage.Text = "Next page";
            this.BtNextPage.UseVisualStyleBackColor = true;
            // 
            // BtReversePage
            // 
            this.BtReversePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtReversePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtReversePage.Location = new System.Drawing.Point(693, 12);
            this.BtReversePage.Name = "BtReversePage";
            this.BtReversePage.Size = new System.Drawing.Size(123, 35);
            this.BtReversePage.TabIndex = 96;
            this.BtReversePage.Text = "Reverse page";
            this.BtReversePage.UseVisualStyleBackColor = true;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 743);
            this.Controls.Add(this.TbCurrentPage);
            this.Controls.Add(this.BtNextPage);
            this.Controls.Add(this.BtReversePage);
            this.Controls.Add(this.CbbDelivery);
            this.Controls.Add(this.TbAddress);
            this.Controls.Add(this.TbPhone);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbTotalBill);
            this.Controls.Add(this.BtRemove);
            this.Controls.Add(this.NUDQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtAddCart);
            this.Controls.Add(this.BtFind);
            this.Controls.Add(this.CbbSearch);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtAccept);
            this.Controls.Add(this.BtCancel);
            this.Name = "FormOrder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtCancel;
        private Button BtAccept;
        private Label label1;
        private ListView listView1;
        private ComboBox CbbSearch;
        private Button BtFind;
        private Button BtAddCart;
        private Label label2;
        private Label label3;
        private NumericUpDown NUDQuantity;
        private Button BtRemove;
        private TextBox TbTotalBill;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TbName;
        private TextBox TbPhone;
        private TextBox TbAddress;
        private ComboBox CbbDelivery;
        private TextBox TbCurrentPage;
        private Button BtNextPage;
        private Button BtReversePage;
    }
}