﻿namespace ConnectToAPI.FormInventories
{
    partial class FormInventory
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
            this.CbbInventoryFilter = new System.Windows.Forms.ComboBox();
            this.TbCurrentPage = new System.Windows.Forms.TextBox();
            this.BtNextPage = new System.Windows.Forms.Button();
            this.BtReversePage = new System.Windows.Forms.Button();
            this.CbAllResult = new System.Windows.Forms.CheckBox();
            this.CbbWareHouse = new System.Windows.Forms.ComboBox();
            this.CbbProduct = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbQuatity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtRemove = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.CbbPage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtFind = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // CbbInventoryFilter
            // 
            this.CbbInventoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbInventoryFilter.FormattingEnabled = true;
            this.CbbInventoryFilter.Location = new System.Drawing.Point(921, 333);
            this.CbbInventoryFilter.Name = "CbbInventoryFilter";
            this.CbbInventoryFilter.Size = new System.Drawing.Size(198, 28);
            this.CbbInventoryFilter.TabIndex = 100;
            this.CbbInventoryFilter.SelectedValueChanged += new System.EventHandler(this.CbbInventoryFilter_SelectedValueChanged);
            // 
            // TbCurrentPage
            // 
            this.TbCurrentPage.Enabled = false;
            this.TbCurrentPage.Location = new System.Drawing.Point(481, 631);
            this.TbCurrentPage.Name = "TbCurrentPage";
            this.TbCurrentPage.Size = new System.Drawing.Size(125, 27);
            this.TbCurrentPage.TabIndex = 99;
            // 
            // BtNextPage
            // 
            this.BtNextPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtNextPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtNextPage.Location = new System.Drawing.Point(778, 623);
            this.BtNextPage.Name = "BtNextPage";
            this.BtNextPage.Size = new System.Drawing.Size(123, 35);
            this.BtNextPage.TabIndex = 98;
            this.BtNextPage.Text = "Next page";
            this.BtNextPage.UseVisualStyleBackColor = true;
            this.BtNextPage.Click += new System.EventHandler(this.BtNextPage_Click);
            // 
            // BtReversePage
            // 
            this.BtReversePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtReversePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtReversePage.Location = new System.Drawing.Point(146, 623);
            this.BtReversePage.Name = "BtReversePage";
            this.BtReversePage.Size = new System.Drawing.Size(123, 35);
            this.BtReversePage.TabIndex = 97;
            this.BtReversePage.Text = "Reverse page";
            this.BtReversePage.UseVisualStyleBackColor = true;
            this.BtReversePage.Click += new System.EventHandler(this.BtReversePage_Click);
            // 
            // CbAllResult
            // 
            this.CbAllResult.AutoSize = true;
            this.CbAllResult.Location = new System.Drawing.Point(1005, 114);
            this.CbAllResult.Name = "CbAllResult";
            this.CbAllResult.Size = new System.Drawing.Size(49, 24);
            this.CbAllResult.TabIndex = 96;
            this.CbAllResult.Text = "All";
            this.CbAllResult.UseVisualStyleBackColor = true;
            this.CbAllResult.Click += new System.EventHandler(this.CbAllResult_CheckedChanged);
            // 
            // CbbWareHouse
            // 
            this.CbbWareHouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbbWareHouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbbWareHouse.FormattingEnabled = true;
            this.CbbWareHouse.Location = new System.Drawing.Point(223, 112);
            this.CbbWareHouse.Name = "CbbWareHouse";
            this.CbbWareHouse.Size = new System.Drawing.Size(151, 28);
            this.CbbWareHouse.TabIndex = 95;
            // 
            // CbbProduct
            // 
            this.CbbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbbProduct.FormattingEnabled = true;
            this.CbbProduct.Location = new System.Drawing.Point(21, 112);
            this.CbbProduct.Name = "CbbProduct";
            this.CbbProduct.Size = new System.Drawing.Size(151, 28);
            this.CbbProduct.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.TbQuatity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(250, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 63);
            this.panel1.TabIndex = 92;
            // 
            // TbQuatity
            // 
            this.TbQuatity.Location = new System.Drawing.Point(185, 19);
            this.TbQuatity.Name = "TbQuatity";
            this.TbQuatity.ReadOnly = true;
            this.TbQuatity.Size = new System.Drawing.Size(290, 27);
            this.TbQuatity.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(84, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Quatity";
            // 
            // Dtg
            // 
            this.Dtg.BackgroundColor = System.Drawing.Color.White;
            this.Dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg.Location = new System.Drawing.Point(145, 236);
            this.Dtg.Name = "Dtg";
            this.Dtg.ReadOnly = true;
            this.Dtg.RowHeadersWidth = 51;
            this.Dtg.RowTemplate.Height = 29;
            this.Dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg.Size = new System.Drawing.Size(755, 375);
            this.Dtg.TabIndex = 89;
            this.Dtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_CellClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(405, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 38);
            this.label1.TabIndex = 86;
            this.label1.Text = "PAGE INVENTORY";
            // 
            // BtRemove
            // 
            this.BtRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtRemove.Location = new System.Drawing.Point(777, 681);
            this.BtRemove.Name = "BtRemove";
            this.BtRemove.Size = new System.Drawing.Size(123, 53);
            this.BtRemove.TabIndex = 88;
            this.BtRemove.Text = "Delete";
            this.BtRemove.UseVisualStyleBackColor = false;
            this.BtRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtAdd.Location = new System.Drawing.Point(145, 681);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(123, 53);
            this.BtAdd.TabIndex = 87;
            this.BtAdd.Text = "Add";
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // CbbPage
            // 
            this.CbbPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbPage.FormattingEnabled = true;
            this.CbbPage.Location = new System.Drawing.Point(931, 236);
            this.CbbPage.Name = "CbbPage";
            this.CbbPage.Size = new System.Drawing.Size(151, 28);
            this.CbbPage.TabIndex = 93;
            this.CbbPage.SelectedValueChanged += new System.EventHandler(this.CbbPage_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(128, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 91;
            this.label3.Text = "Search name";
            // 
            // BtFind
            // 
            this.BtFind.Location = new System.Drawing.Point(832, 113);
            this.BtFind.Name = "BtFind";
            this.BtFind.Size = new System.Drawing.Size(94, 27);
            this.BtFind.TabIndex = 90;
            this.BtFind.Text = "Find";
            this.BtFind.UseVisualStyleBackColor = true;
            this.BtFind.Click += new System.EventHandler(this.BtFind_Click);
            // 
            // BtUpdate
            // 
            this.BtUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtUpdate.Enabled = false;
            this.BtUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtUpdate.Location = new System.Drawing.Point(481, 681);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(123, 53);
            this.BtUpdate.TabIndex = 101;
            this.BtUpdate.Text = "Update";
            this.BtUpdate.UseVisualStyleBackColor = false;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(579, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 103;
            this.label6.Text = "Search";
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(464, 112);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(358, 27);
            this.TbId.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 117;
            this.label4.Text = "Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(253, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 116;
            this.label5.Text = "Warehouse";
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 743);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.CbbInventoryFilter);
            this.Controls.Add(this.TbCurrentPage);
            this.Controls.Add(this.BtNextPage);
            this.Controls.Add(this.BtReversePage);
            this.Controls.Add(this.CbAllResult);
            this.Controls.Add(this.CbbWareHouse);
            this.Controls.Add(this.CbbProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dtg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtRemove);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.CbbPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtFind);
            this.Name = "FormInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FromInventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CbbInventoryFilter;
        private TextBox TbCurrentPage;
        private Button BtNextPage;
        private Button BtReversePage;
        private CheckBox CbAllResult;
        private ComboBox CbbWareHouse;
        private ComboBox CbbProduct;
        private Panel panel1;
        private TextBox TbQuatity;
        private Label label2;
        private DataGridView Dtg;
        private Label label1;
        private Button BtRemove;
        private Button BtAdd;
        private ComboBox CbbPage;
        private Label label3;
        private Button BtFind;
        private Button BtUpdate;
        private Label label6;
        private TextBox TbId;
        private Label label4;
        private Label label5;
    }
}