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
<<<<<<< HEAD
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TbFindOrderID = new System.Windows.Forms.TextBox();
            this.BtFindOrderId = new System.Windows.Forms.Button();
            this.listViewOrderDetail = new System.Windows.Forms.ListView();
            this.TabBill = new System.Windows.Forms.TabPage();
            this.TbPageBill = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtNextPageBill = new System.Windows.Forms.Button();
            this.BtReversePageBill = new System.Windows.Forms.Button();
            this.Dtg = new System.Windows.Forms.DataGridView();
            this.FindOrder = new System.Windows.Forms.Button();
            this.DTPToDate = new System.Windows.Forms.DateTimePicker();
            this.DTPFormDate = new System.Windows.Forms.DateTimePicker();
=======
            this.Tab = new System.Windows.Forms.TabControl();
>>>>>>> fa404197f3b308806d068fa3826a8da4743f068d
            this.TabOrder = new System.Windows.Forms.TabPage();
            this.TbCurrentPage = new System.Windows.Forms.TextBox();
            this.TbAddress = new System.Windows.Forms.TextBox();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbTotalBill = new System.Windows.Forms.TextBox();
            this.BtNextPage = new System.Windows.Forms.Button();
            this.BtReversePage = new System.Windows.Forms.Button();
            this.CbbDelivery = new System.Windows.Forms.ComboBox();
<<<<<<< HEAD
=======
            this.TbAddress = new System.Windows.Forms.TextBox();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.TbName = new System.Windows.Forms.TextBox();
>>>>>>> fa404197f3b308806d068fa3826a8da4743f068d
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
<<<<<<< HEAD
=======
            this.TbTotalBill = new System.Windows.Forms.TextBox();
>>>>>>> fa404197f3b308806d068fa3826a8da4743f068d
            this.BtRemove = new System.Windows.Forms.Button();
            this.NUDQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtAddCart = new System.Windows.Forms.Button();
            this.BtFind = new System.Windows.Forms.Button();
            this.CbbSearch = new System.Windows.Forms.ComboBox();
<<<<<<< HEAD
            this.listViewCart = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtAccept = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.TabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg)).BeginInit();
            this.TabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).BeginInit();
            this.Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TbFindOrderID);
            this.tabPage1.Controls.Add(this.BtFindOrderId);
            this.tabPage1.Controls.Add(this.listViewOrderDetail);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1200, 686);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "DetailBill";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TbFindOrderID
            // 
            this.TbFindOrderID.Location = new System.Drawing.Point(28, 20);
            this.TbFindOrderID.Name = "TbFindOrderID";
            this.TbFindOrderID.Size = new System.Drawing.Size(431, 27);
            this.TbFindOrderID.TabIndex = 123;
            // 
            // BtFindOrderId
            // 
            this.BtFindOrderId.Location = new System.Drawing.Point(492, 15);
            this.BtFindOrderId.Name = "BtFindOrderId";
            this.BtFindOrderId.Size = new System.Drawing.Size(94, 37);
            this.BtFindOrderId.TabIndex = 105;
            this.BtFindOrderId.Text = "Find";
            this.BtFindOrderId.UseVisualStyleBackColor = true;
            this.BtFindOrderId.Click += new System.EventHandler(this.BtFindOrderId_Click);
            // 
            // listViewOrderDetail
            // 
            this.listViewOrderDetail.Location = new System.Drawing.Point(28, 70);
            this.listViewOrderDetail.Name = "listViewOrderDetail";
            this.listViewOrderDetail.Size = new System.Drawing.Size(1145, 610);
            this.listViewOrderDetail.TabIndex = 103;
            this.listViewOrderDetail.UseCompatibleStateImageBehavior = false;
            // 
            // TabBill
            // 
            this.TabBill.Controls.Add(this.TbPageBill);
            this.TabBill.Controls.Add(this.textBox2);
            this.TabBill.Controls.Add(this.textBox1);
            this.TabBill.Controls.Add(this.BtNextPageBill);
            this.TabBill.Controls.Add(this.BtReversePageBill);
            this.TabBill.Controls.Add(this.Dtg);
            this.TabBill.Controls.Add(this.FindOrder);
            this.TabBill.Controls.Add(this.DTPToDate);
            this.TabBill.Controls.Add(this.DTPFormDate);
            this.TabBill.Location = new System.Drawing.Point(4, 29);
            this.TabBill.Name = "TabBill";
            this.TabBill.Padding = new System.Windows.Forms.Padding(3);
            this.TabBill.Size = new System.Drawing.Size(1200, 686);
            this.TabBill.TabIndex = 1;
            this.TabBill.Text = "Bill";
            this.TabBill.UseVisualStyleBackColor = true;
            // 
            // TbPageBill
            // 
            this.TbPageBill.Enabled = false;
            this.TbPageBill.Location = new System.Drawing.Point(566, 642);
            this.TbPageBill.Name = "TbPageBill";
            this.TbPageBill.Size = new System.Drawing.Size(125, 27);
            this.TbPageBill.TabIndex = 132;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(609, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 127;
            this.textBox2.Text = "To date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 126;
            this.textBox1.Text = "Form date";
            // 
            // BtNextPageBill
            // 
            this.BtNextPageBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtNextPageBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtNextPageBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtNextPageBill.Location = new System.Drawing.Point(863, 634);
            this.BtNextPageBill.Name = "BtNextPageBill";
            this.BtNextPageBill.Size = new System.Drawing.Size(123, 35);
            this.BtNextPageBill.TabIndex = 131;
            this.BtNextPageBill.Text = "Next page";
            this.BtNextPageBill.UseVisualStyleBackColor = true;
            this.BtNextPageBill.Click += new System.EventHandler(this.NextPageBill_Click);
            // 
            // BtReversePageBill
            // 
            this.BtReversePageBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtReversePageBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtReversePageBill.Location = new System.Drawing.Point(231, 634);
            this.BtReversePageBill.Name = "BtReversePageBill";
            this.BtReversePageBill.Size = new System.Drawing.Size(123, 35);
            this.BtReversePageBill.TabIndex = 130;
            this.BtReversePageBill.Text = "Reverse page";
            this.BtReversePageBill.UseVisualStyleBackColor = true;
            this.BtReversePageBill.Click += new System.EventHandler(this.ReversePageBill_Click);
            // 
            // Dtg
            // 
            this.Dtg.BackgroundColor = System.Drawing.Color.White;
            this.Dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg.Location = new System.Drawing.Point(6, 47);
            this.Dtg.Name = "Dtg";
            this.Dtg.ReadOnly = true;
            this.Dtg.RowHeadersWidth = 51;
            this.Dtg.RowTemplate.Height = 29;
            this.Dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg.Size = new System.Drawing.Size(1188, 581);
            this.Dtg.TabIndex = 129;
            // 
            // FindOrder
            // 
            this.FindOrder.Location = new System.Drawing.Point(1028, 14);
            this.FindOrder.Name = "FindOrder";
            this.FindOrder.Size = new System.Drawing.Size(94, 27);
            this.FindOrder.TabIndex = 111;
            this.FindOrder.Text = "Find";
            this.FindOrder.UseVisualStyleBackColor = true;
            this.FindOrder.Click += new System.EventHandler(this.FindOrder_Click);
            // 
            // DTPToDate
            // 
            this.DTPToDate.Location = new System.Drawing.Point(754, 14);
            this.DTPToDate.Name = "DTPToDate";
            this.DTPToDate.Size = new System.Drawing.Size(250, 27);
            this.DTPToDate.TabIndex = 125;
            this.DTPToDate.Value = new System.DateTime(2023, 1, 10, 0, 0, 0, 0);
            // 
            // DTPFormDate
            // 
            this.DTPFormDate.Location = new System.Drawing.Point(321, 14);
            this.DTPFormDate.Name = "DTPFormDate";
            this.DTPFormDate.Size = new System.Drawing.Size(250, 27);
            this.DTPFormDate.TabIndex = 124;
            this.DTPFormDate.Value = new System.DateTime(2023, 1, 10, 0, 0, 0, 0);
            // 
            // TabOrder
            // 
            this.TabOrder.Controls.Add(this.TbCurrentPage);
            this.TabOrder.Controls.Add(this.TbAddress);
            this.TabOrder.Controls.Add(this.TbPhone);
            this.TabOrder.Controls.Add(this.TbName);
            this.TabOrder.Controls.Add(this.TbTotalBill);
            this.TabOrder.Controls.Add(this.BtNextPage);
            this.TabOrder.Controls.Add(this.BtReversePage);
            this.TabOrder.Controls.Add(this.CbbDelivery);
            this.TabOrder.Controls.Add(this.label7);
            this.TabOrder.Controls.Add(this.label6);
            this.TabOrder.Controls.Add(this.label5);
            this.TabOrder.Controls.Add(this.label4);
            this.TabOrder.Controls.Add(this.BtRemove);
            this.TabOrder.Controls.Add(this.NUDQuantity);
            this.TabOrder.Controls.Add(this.label3);
            this.TabOrder.Controls.Add(this.label2);
            this.TabOrder.Controls.Add(this.BtAddCart);
            this.TabOrder.Controls.Add(this.BtFind);
            this.TabOrder.Controls.Add(this.CbbSearch);
            this.TabOrder.Controls.Add(this.listViewCart);
            this.TabOrder.Controls.Add(this.label1);
            this.TabOrder.Controls.Add(this.BtAccept);
            this.TabOrder.Controls.Add(this.BtCancel);
            this.TabOrder.Location = new System.Drawing.Point(4, 29);
            this.TabOrder.Name = "TabOrder";
            this.TabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.TabOrder.Size = new System.Drawing.Size(1200, 686);
            this.TabOrder.TabIndex = 0;
            this.TabOrder.Text = "Order";
            this.TabOrder.UseVisualStyleBackColor = true;
            // 
            // TbCurrentPage
            // 
            this.TbCurrentPage.Enabled = false;
            this.TbCurrentPage.Location = new System.Drawing.Point(847, 18);
            this.TbCurrentPage.Name = "TbCurrentPage";
            this.TbCurrentPage.Size = new System.Drawing.Size(125, 27);
            this.TbCurrentPage.TabIndex = 121;
            // 
            // TbAddress
            // 
            this.TbAddress.Location = new System.Drawing.Point(550, 571);
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.Size = new System.Drawing.Size(273, 27);
            this.TbAddress.TabIndex = 117;
            // 
            // TbPhone
            // 
            this.TbPhone.Location = new System.Drawing.Point(101, 645);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(273, 27);
            this.TbPhone.TabIndex = 116;
            // 
            // TbName
            // 
=======
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtAccept = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.TabBill = new System.Windows.Forms.TabPage();
            this.Dtg = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DTPToDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DTPFormDate = new System.Windows.Forms.DateTimePicker();
            this.Tab.SuspendLayout();
            this.TabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).BeginInit();
            this.TabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.TabOrder);
            this.Tab.Controls.Add(this.TabBill);
            this.Tab.Location = new System.Drawing.Point(12, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1208, 719);
            this.Tab.TabIndex = 0;
            this.Tab.Click += new System.EventHandler(this.Tab_Click);
            // 
            // TabOrder
            // 
            this.TabOrder.Controls.Add(this.TbCurrentPage);
            this.TabOrder.Controls.Add(this.BtNextPage);
            this.TabOrder.Controls.Add(this.BtReversePage);
            this.TabOrder.Controls.Add(this.CbbDelivery);
            this.TabOrder.Controls.Add(this.TbAddress);
            this.TabOrder.Controls.Add(this.TbPhone);
            this.TabOrder.Controls.Add(this.TbName);
            this.TabOrder.Controls.Add(this.label7);
            this.TabOrder.Controls.Add(this.label6);
            this.TabOrder.Controls.Add(this.label5);
            this.TabOrder.Controls.Add(this.label4);
            this.TabOrder.Controls.Add(this.TbTotalBill);
            this.TabOrder.Controls.Add(this.BtRemove);
            this.TabOrder.Controls.Add(this.NUDQuantity);
            this.TabOrder.Controls.Add(this.label3);
            this.TabOrder.Controls.Add(this.label2);
            this.TabOrder.Controls.Add(this.BtAddCart);
            this.TabOrder.Controls.Add(this.BtFind);
            this.TabOrder.Controls.Add(this.CbbSearch);
            this.TabOrder.Controls.Add(this.listView1);
            this.TabOrder.Controls.Add(this.label1);
            this.TabOrder.Controls.Add(this.BtAccept);
            this.TabOrder.Controls.Add(this.BtCancel);
            this.TabOrder.Location = new System.Drawing.Point(4, 29);
            this.TabOrder.Name = "TabOrder";
            this.TabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.TabOrder.Size = new System.Drawing.Size(1200, 686);
            this.TabOrder.TabIndex = 0;
            this.TabOrder.Text = "Order";
            this.TabOrder.UseVisualStyleBackColor = true;
            // 
            // TbCurrentPage
            // 
            this.TbCurrentPage.Enabled = false;
            this.TbCurrentPage.Location = new System.Drawing.Point(847, 18);
            this.TbCurrentPage.Name = "TbCurrentPage";
            this.TbCurrentPage.Size = new System.Drawing.Size(125, 27);
            this.TbCurrentPage.TabIndex = 121;
            // 
            // BtNextPage
            // 
            this.BtNextPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtNextPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtNextPage.Location = new System.Drawing.Point(987, 14);
            this.BtNextPage.Name = "BtNextPage";
            this.BtNextPage.Size = new System.Drawing.Size(123, 35);
            this.BtNextPage.TabIndex = 120;
            this.BtNextPage.Text = "Next page";
            this.BtNextPage.UseVisualStyleBackColor = true;
            this.BtNextPage.Click += new System.EventHandler(this.BtNextPage_Click);
            // 
            // BtReversePage
            // 
            this.BtReversePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtReversePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtReversePage.Location = new System.Drawing.Point(709, 14);
            this.BtReversePage.Name = "BtReversePage";
            this.BtReversePage.Size = new System.Drawing.Size(123, 35);
            this.BtReversePage.TabIndex = 119;
            this.BtReversePage.Text = "Reverse page";
            this.BtReversePage.UseVisualStyleBackColor = true;
            this.BtReversePage.Click += new System.EventHandler(this.BtReversePage_Click);
            // 
            // CbbDelivery
            // 
            this.CbbDelivery.Enabled = false;
            this.CbbDelivery.FormattingEnabled = true;
            this.CbbDelivery.Location = new System.Drawing.Point(550, 644);
            this.CbbDelivery.Name = "CbbDelivery";
            this.CbbDelivery.Size = new System.Drawing.Size(273, 28);
            this.CbbDelivery.TabIndex = 118;
            // 
            // TbAddress
            // 
            this.TbAddress.Location = new System.Drawing.Point(550, 571);
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.Size = new System.Drawing.Size(273, 27);
            this.TbAddress.TabIndex = 117;
            // 
            // TbPhone
            // 
            this.TbPhone.Location = new System.Drawing.Point(101, 645);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(273, 27);
            this.TbPhone.TabIndex = 116;
            // 
            // TbName
            // 
>>>>>>> fa404197f3b308806d068fa3826a8da4743f068d
            this.TbName.Location = new System.Drawing.Point(98, 571);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(273, 27);
            this.TbName.TabIndex = 115;
            // 
<<<<<<< HEAD
            // TbTotalBill
            // 
            this.TbTotalBill.Enabled = false;
            this.TbTotalBill.Location = new System.Drawing.Point(99, 504);
            this.TbTotalBill.Name = "TbTotalBill";
            this.TbTotalBill.Size = new System.Drawing.Size(175, 27);
            this.TbTotalBill.TabIndex = 110;
            // 
            // BtNextPage
            // 
            this.BtNextPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtNextPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtNextPage.Location = new System.Drawing.Point(987, 14);
            this.BtNextPage.Name = "BtNextPage";
            this.BtNextPage.Size = new System.Drawing.Size(123, 35);
            this.BtNextPage.TabIndex = 120;
            this.BtNextPage.Text = "Next page";
            this.BtNextPage.UseVisualStyleBackColor = true;
            this.BtNextPage.Click += new System.EventHandler(this.BtNextPage_Click);
            // 
            // BtReversePage
            // 
            this.BtReversePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtReversePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtReversePage.Location = new System.Drawing.Point(709, 14);
            this.BtReversePage.Name = "BtReversePage";
            this.BtReversePage.Size = new System.Drawing.Size(123, 35);
            this.BtReversePage.TabIndex = 119;
            this.BtReversePage.Text = "Reverse page";
            this.BtReversePage.UseVisualStyleBackColor = true;
            this.BtReversePage.Click += new System.EventHandler(this.BtReversePage_Click);
            // 
            // CbbDelivery
            // 
            this.CbbDelivery.FormattingEnabled = true;
            this.CbbDelivery.Location = new System.Drawing.Point(550, 644);
            this.CbbDelivery.Name = "CbbDelivery";
            this.CbbDelivery.Size = new System.Drawing.Size(273, 28);
            this.CbbDelivery.TabIndex = 118;
            // 
=======
>>>>>>> fa404197f3b308806d068fa3826a8da4743f068d
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(431, 644);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 28);
            this.label7.TabIndex = 114;
            this.label7.Text = "Delivery";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(431, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 28);
            this.label6.TabIndex = 113;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(28, 644);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 28);
            this.label5.TabIndex = 112;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 111;
            this.label4.Text = "Name";
            // 
<<<<<<< HEAD
=======
            // TbTotalBill
            // 
            this.TbTotalBill.Enabled = false;
            this.TbTotalBill.Location = new System.Drawing.Point(99, 504);
            this.TbTotalBill.Name = "TbTotalBill";
            this.TbTotalBill.Size = new System.Drawing.Size(175, 27);
            this.TbTotalBill.TabIndex = 110;
            // 
>>>>>>> fa404197f3b308806d068fa3826a8da4743f068d
            // BtRemove
            // 
            this.BtRemove.Location = new System.Drawing.Point(898, 494);
            this.BtRemove.Name = "BtRemove";
            this.BtRemove.Size = new System.Drawing.Size(113, 46);
            this.BtRemove.TabIndex = 109;
            this.BtRemove.Text = "Remove";
            this.BtRemove.UseVisualStyleBackColor = true;
            this.BtRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // NUDQuantity
            // 
            this.NUDQuantity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDQuantity.Location = new System.Drawing.Point(182, 57);
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
            this.NUDQuantity.TabIndex = 108;
            this.NUDQuantity.ThousandsSeparator = true;
            this.NUDQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 107;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 106;
            this.label2.Text = "Name and price";
            // 
            // BtAddCart
            // 
            this.BtAddCart.Location = new System.Drawing.Point(1081, 62);
            this.BtAddCart.Name = "BtAddCart";
            this.BtAddCart.Size = new System.Drawing.Size(94, 37);
            this.BtAddCart.TabIndex = 105;
            this.BtAddCart.Text = "Add cart";
            this.BtAddCart.UseVisualStyleBackColor = true;
            this.BtAddCart.Click += new System.EventHandler(this.BtAddCart_Click);
            // 
            // BtFind
            // 
            this.BtFind.Location = new System.Drawing.Point(946, 62);
            this.BtFind.Name = "BtFind";
            this.BtFind.Size = new System.Drawing.Size(94, 37);
            this.BtFind.TabIndex = 104;
            this.BtFind.Text = "Find";
            this.BtFind.UseVisualStyleBackColor = true;
            this.BtFind.Click += new System.EventHandler(this.BtFind_Click);
            // 
            // CbbSearch
            // 
            this.CbbSearch.FormattingEnabled = true;
            this.CbbSearch.Location = new System.Drawing.Point(182, 15);
            this.CbbSearch.Name = "CbbSearch";
            this.CbbSearch.Size = new System.Drawing.Size(488, 28);
            this.CbbSearch.TabIndex = 103;
            // 
<<<<<<< HEAD
            // listViewCart
            // 
            this.listViewCart.Location = new System.Drawing.Point(26, 105);
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(1145, 383);
            this.listViewCart.TabIndex = 102;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            this.listViewCart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
=======
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(26, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1145, 383);
            this.listView1.TabIndex = 102;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
>>>>>>> fa404197f3b308806d068fa3826a8da4743f068d
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Total bill";
            // 
            // BtAccept
            // 
            this.BtAccept.Enabled = false;
            this.BtAccept.Location = new System.Drawing.Point(738, 494);
            this.BtAccept.Name = "BtAccept";
            this.BtAccept.Size = new System.Drawing.Size(113, 46);
            this.BtAccept.TabIndex = 100;
            this.BtAccept.Text = "Accept";
            this.BtAccept.UseVisualStyleBackColor = true;
            this.BtAccept.Click += new System.EventHandler(this.BtAccept_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.Location = new System.Drawing.Point(1058, 494);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(113, 46);
            this.BtCancel.TabIndex = 99;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = true;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
<<<<<<< HEAD
            // Tab
            // 
            this.Tab.Controls.Add(this.TabOrder);
            this.Tab.Controls.Add(this.TabBill);
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Location = new System.Drawing.Point(12, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1208, 719);
            this.Tab.TabIndex = 0;
=======
            // TabBill
            // 
            this.TabBill.Controls.Add(this.Dtg);
            this.TabBill.Controls.Add(this.button1);
            this.TabBill.Controls.Add(this.textBox2);
            this.TabBill.Controls.Add(this.DTPToDate);
            this.TabBill.Controls.Add(this.textBox1);
            this.TabBill.Controls.Add(this.DTPFormDate);
            this.TabBill.Location = new System.Drawing.Point(4, 29);
            this.TabBill.Name = "TabBill";
            this.TabBill.Padding = new System.Windows.Forms.Padding(3);
            this.TabBill.Size = new System.Drawing.Size(1200, 686);
            this.TabBill.TabIndex = 1;
            this.TabBill.Text = "Bill";
            this.TabBill.UseVisualStyleBackColor = true;
            // 
            // Dtg
            // 
            this.Dtg.BackgroundColor = System.Drawing.Color.White;
            this.Dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg.Location = new System.Drawing.Point(6, 47);
            this.Dtg.Name = "Dtg";
            this.Dtg.ReadOnly = true;
            this.Dtg.RowHeadersWidth = 51;
            this.Dtg.RowTemplate.Height = 29;
            this.Dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg.Size = new System.Drawing.Size(1188, 581);
            this.Dtg.TabIndex = 129;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1028, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 27);
            this.button1.TabIndex = 111;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(609, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 127;
            this.textBox2.Text = "To date";
            // 
            // DTPToDate
            // 
            this.DTPToDate.Location = new System.Drawing.Point(754, 14);
            this.DTPToDate.Name = "DTPToDate";
            this.DTPToDate.Size = new System.Drawing.Size(250, 27);
            this.DTPToDate.TabIndex = 125;
            this.DTPToDate.Value = new System.DateTime(2023, 1, 10, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 126;
            this.textBox1.Text = "Form date";
            // 
            // DTPFormDate
            // 
            this.DTPFormDate.Location = new System.Drawing.Point(321, 14);
            this.DTPFormDate.Name = "DTPFormDate";
            this.DTPFormDate.Size = new System.Drawing.Size(250, 27);
            this.DTPFormDate.TabIndex = 124;
            this.DTPFormDate.Value = new System.DateTime(2023, 1, 10, 0, 0, 0, 0);
>>>>>>> fa404197f3b308806d068fa3826a8da4743f068d
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 743);
            this.Controls.Add(this.Tab);
            this.Name = "FormOrder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormOrder_Load);
<<<<<<< HEAD
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabBill.ResumeLayout(false);
            this.TabBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg)).EndInit();
            this.TabOrder.ResumeLayout(false);
            this.TabOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).EndInit();
            this.Tab.ResumeLayout(false);
=======
            this.Tab.ResumeLayout(false);
            this.TabOrder.ResumeLayout(false);
            this.TabOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).EndInit();
            this.TabBill.ResumeLayout(false);
            this.TabBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg)).EndInit();
>>>>>>> fa404197f3b308806d068fa3826a8da4743f068d
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private TabPage tabPage1;
        private TextBox TbFindOrderID;
        private Button BtFindOrderId;
        private ListView listViewOrderDetail;
        private TabPage TabBill;
        private TextBox TbPageBill;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button BtNextPageBill;
        private Button BtReversePageBill;
        private DataGridView Dtg;
        private Button FindOrder;
        private DateTimePicker DTPToDate;
        private DateTimePicker DTPFormDate;
=======
        private TabControl Tab;
>>>>>>> fa404197f3b308806d068fa3826a8da4743f068d
        private TabPage TabOrder;
        private TextBox TbCurrentPage;
        private TextBox TbAddress;
        private TextBox TbPhone;
        private TextBox TbName;
        private TextBox TbTotalBill;
        private Button BtNextPage;
        private Button BtReversePage;
        private ComboBox CbbDelivery;
<<<<<<< HEAD
=======
        private TextBox TbAddress;
        private TextBox TbPhone;
        private TextBox TbName;
>>>>>>> fa404197f3b308806d068fa3826a8da4743f068d
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
<<<<<<< HEAD
=======
        private TextBox TbTotalBill;
>>>>>>> fa404197f3b308806d068fa3826a8da4743f068d
        private Button BtRemove;
        private NumericUpDown NUDQuantity;
        private Label label3;
        private Label label2;
        private Button BtAddCart;
        private Button BtFind;
        private ComboBox CbbSearch;
<<<<<<< HEAD
        private ListView listViewCart;
        private Label label1;
        private Button BtAccept;
        private Button BtCancel;
        private TabControl Tab;
=======
        private ListView listView1;
        private Label label1;
        private Button BtAccept;
        private Button BtCancel;
        private TabPage TabBill;
        private TextBox textBox2;
        private DateTimePicker DTPToDate;
        private TextBox textBox1;
        private DateTimePicker DTPFormDate;
        private Button button1;
        private DataGridView Dtg;
>>>>>>> fa404197f3b308806d068fa3826a8da4743f068d
    }
}