namespace ConnectToAPI.FormWarehouses
{
    partial class FormWarehouse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.CbbFilter = new System.Windows.Forms.ComboBox();
            this.Dtg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TbCurrentPage = new System.Windows.Forms.TextBox();
            this.BtNextPage = new System.Windows.Forms.Button();
            this.BtReversePage = new System.Windows.Forms.Button();
            this.BtRemove = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.CbAllResult = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtFind = new System.Windows.Forms.Button();
            this.TbFind = new System.Windows.Forms.TextBox();
            this.FormWarehousePage = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TbName);
            this.panel1.Location = new System.Drawing.Point(215, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 63);
            this.panel1.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            // 
            // TbName
            // 
            this.TbName.Enabled = false;
            this.TbName.Location = new System.Drawing.Point(188, 16);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(290, 27);
            this.TbName.TabIndex = 10;
            // 
            // CbbFilter
            // 
            this.CbbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbFilter.FormattingEnabled = true;
            this.CbbFilter.Items.AddRange(new object[] {
            "Ngày tăng dần",
            "Ngày giảm dần"});
            this.CbbFilter.Location = new System.Drawing.Point(903, 263);
            this.CbbFilter.Name = "CbbFilter";
            this.CbbFilter.Size = new System.Drawing.Size(151, 28);
            this.CbbFilter.TabIndex = 89;
            this.CbbFilter.SelectedIndexChanged += new System.EventHandler(this.CbbFilter_SelectedIndexChanged);
            // 
            // Dtg
            // 
            this.Dtg.BackgroundColor = System.Drawing.Color.White;
            this.Dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg.Location = new System.Drawing.Point(110, 263);
            this.Dtg.Name = "Dtg";
            this.Dtg.ReadOnly = true;
            this.Dtg.RowHeadersWidth = 51;
            this.Dtg.RowTemplate.Height = 29;
            this.Dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg.Size = new System.Drawing.Size(755, 361);
            this.Dtg.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(380, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 38);
            this.label1.TabIndex = 81;
            this.label1.Text = "PAGE WAREHOUSE";
            // 
            // TbCurrentPage
            // 
            this.TbCurrentPage.Enabled = false;
            this.TbCurrentPage.Location = new System.Drawing.Point(445, 644);
            this.TbCurrentPage.Name = "TbCurrentPage";
            this.TbCurrentPage.Size = new System.Drawing.Size(125, 27);
            this.TbCurrentPage.TabIndex = 101;
            // 
            // BtNextPage
            // 
            this.BtNextPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtNextPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtNextPage.Location = new System.Drawing.Point(742, 636);
            this.BtNextPage.Name = "BtNextPage";
            this.BtNextPage.Size = new System.Drawing.Size(123, 35);
            this.BtNextPage.TabIndex = 100;
            this.BtNextPage.Text = "Next page";
            this.BtNextPage.UseVisualStyleBackColor = true;
            this.BtNextPage.Click += new System.EventHandler(this.BtNextPage_Click);
            // 
            // BtReversePage
            // 
            this.BtReversePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtReversePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtReversePage.Location = new System.Drawing.Point(110, 636);
            this.BtReversePage.Name = "BtReversePage";
            this.BtReversePage.Size = new System.Drawing.Size(123, 35);
            this.BtReversePage.TabIndex = 99;
            this.BtReversePage.Text = "Reverse page";
            this.BtReversePage.UseVisualStyleBackColor = true;
            this.BtReversePage.Click += new System.EventHandler(this.BtReversePage_Click);
            // 
            // BtRemove
            // 
            this.BtRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtRemove.Enabled = false;
            this.BtRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtRemove.Location = new System.Drawing.Point(742, 683);
            this.BtRemove.Name = "BtRemove";
            this.BtRemove.Size = new System.Drawing.Size(123, 53);
            this.BtRemove.TabIndex = 98;
            this.BtRemove.Text = "Delete";
            this.BtRemove.UseVisualStyleBackColor = false;
            this.BtRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // BtUpdate
            // 
            this.BtUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtUpdate.Enabled = false;
            this.BtUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtUpdate.Location = new System.Drawing.Point(445, 681);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(123, 53);
            this.BtUpdate.TabIndex = 97;
            this.BtUpdate.Text = "Update";
            this.BtUpdate.UseVisualStyleBackColor = false;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtAdd.Location = new System.Drawing.Point(110, 681);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(123, 53);
            this.BtAdd.TabIndex = 96;
            this.BtAdd.Text = "Add";
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(642, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 28);
            this.label6.TabIndex = 108;
            this.label6.Text = "Search ID";
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(526, 91);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(358, 27);
            this.TbId.TabIndex = 107;
            // 
            // CbAllResult
            // 
            this.CbAllResult.AutoSize = true;
            this.CbAllResult.Location = new System.Drawing.Point(1054, 91);
            this.CbAllResult.Name = "CbAllResult";
            this.CbAllResult.Size = new System.Drawing.Size(49, 24);
            this.CbAllResult.TabIndex = 106;
            this.CbAllResult.Text = "All";
            this.CbAllResult.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(195, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 28);
            this.label3.TabIndex = 105;
            this.label3.Text = "Search Name";
            // 
            // BtFind
            // 
            this.BtFind.Location = new System.Drawing.Point(890, 90);
            this.BtFind.Name = "BtFind";
            this.BtFind.Size = new System.Drawing.Size(94, 27);
            this.BtFind.TabIndex = 104;
            this.BtFind.Text = "Find";
            this.BtFind.UseVisualStyleBackColor = true;
            this.BtFind.Click += new System.EventHandler(this.BtFind_Click);
            // 
            // TbFind
            // 
            this.TbFind.Location = new System.Drawing.Point(79, 91);
            this.TbFind.Name = "TbFind";
            this.TbFind.Size = new System.Drawing.Size(358, 27);
            this.TbFind.TabIndex = 103;
            // 
            // FormWarehousePage
            // 
            this.FormWarehousePage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormWarehousePage.FormattingEnabled = true;
            this.FormWarehousePage.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.FormWarehousePage.Location = new System.Drawing.Point(903, 328);
            this.FormWarehousePage.Name = "FormWarehousePage";
            this.FormWarehousePage.Size = new System.Drawing.Size(151, 28);
            this.FormWarehousePage.TabIndex = 109;
            this.FormWarehousePage.SelectedValueChanged += new System.EventHandler(this.FormWarehousePage_SelectedValueChanged);
            // 
            // FormWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 743);
            this.Controls.Add(this.FormWarehousePage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.CbAllResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtFind);
            this.Controls.Add(this.TbFind);
            this.Controls.Add(this.TbCurrentPage);
            this.Controls.Add(this.BtNextPage);
            this.Controls.Add(this.BtReversePage);
            this.Controls.Add(this.BtRemove);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CbbFilter);
            this.Controls.Add(this.Dtg);
            this.Controls.Add(this.label1);
            this.Name = "FormWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormWarehouse";
            this.Load += new System.EventHandler(this.FormWareHouse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TextBox TbName;
        private ComboBox CbbFilter;
        private DataGridView Dtg;
        private Label label1;
        private TextBox TbCurrentPage;
        private Button BtNextPage;
        private Button BtReversePage;
        private Button BtRemove;
        private Button BtUpdate;
        private Button BtAdd;
        private Label label6;
        private TextBox TbId;
        private CheckBox CbAllResult;
        private Label label3;
        private Button BtFind;
        private TextBox TbFind;
        private ComboBox FormWarehousePage;
    }
}