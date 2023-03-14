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
            // 
            // BtAccept
            // 
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
            this.TbTotalBill.Location = new System.Drawing.Point(83, 502);
            this.TbTotalBill.Name = "TbTotalBill";
            this.TbTotalBill.Size = new System.Drawing.Size(175, 27);
            this.TbTotalBill.TabIndex = 65;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 743);
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
    }
}