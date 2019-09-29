namespace GymRegistration.Forms
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnPackage = new System.Windows.Forms.Button();
            this.btnContinuity = new System.Windows.Forms.Button();
            this.btnMenuOrder = new System.Windows.Forms.Button();
            this.btnMenuItem = new System.Windows.Forms.Button();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.dgvDashboard = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbxPackage = new System.Windows.Forms.ComboBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.btnAllShow = new System.Windows.Forms.Button();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCustomer.Location = new System.Drawing.Point(0, 1);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(191, 104);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Registration";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPayment.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPayment.Location = new System.Drawing.Point(191, 1);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(191, 104);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // btnPackage
            // 
            this.btnPackage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPackage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPackage.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackage.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPackage.Location = new System.Drawing.Point(382, 1);
            this.btnPackage.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(191, 104);
            this.btnPackage.TabIndex = 2;
            this.btnPackage.Text = "Package";
            this.btnPackage.UseVisualStyleBackColor = false;
            this.btnPackage.Click += new System.EventHandler(this.BtnPackage_Click);
            // 
            // btnContinuity
            // 
            this.btnContinuity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContinuity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnContinuity.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnContinuity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnContinuity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnContinuity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuity.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnContinuity.Location = new System.Drawing.Point(573, 1);
            this.btnContinuity.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnContinuity.Name = "btnContinuity";
            this.btnContinuity.Size = new System.Drawing.Size(191, 104);
            this.btnContinuity.TabIndex = 3;
            this.btnContinuity.Text = "Continuity";
            this.btnContinuity.UseVisualStyleBackColor = false;
            this.btnContinuity.Click += new System.EventHandler(this.BtnContinuity_Click);
            // 
            // btnMenuOrder
            // 
            this.btnMenuOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenuOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenuOrder.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMenuOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMenuOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMenuOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuOrder.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMenuOrder.Location = new System.Drawing.Point(764, 1);
            this.btnMenuOrder.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnMenuOrder.Name = "btnMenuOrder";
            this.btnMenuOrder.Size = new System.Drawing.Size(191, 104);
            this.btnMenuOrder.TabIndex = 4;
            this.btnMenuOrder.Text = "Bar Menu";
            this.btnMenuOrder.UseVisualStyleBackColor = false;
            this.btnMenuOrder.Click += new System.EventHandler(this.BtnMenuOrder_Click);
            // 
            // btnMenuItem
            // 
            this.btnMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenuItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMenuItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMenuItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMenuItem.Location = new System.Drawing.Point(955, 1);
            this.btnMenuItem.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnMenuItem.Name = "btnMenuItem";
            this.btnMenuItem.Size = new System.Drawing.Size(191, 104);
            this.btnMenuItem.TabIndex = 5;
            this.btnMenuItem.Text = "Product";
            this.btnMenuItem.UseVisualStyleBackColor = false;
            this.btnMenuItem.Click += new System.EventHandler(this.BtnMenuItem_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDashboard.BackColor = System.Drawing.Color.AliceBlue;
            this.panelDashboard.Controls.Add(this.btnCustomer);
            this.panelDashboard.Controls.Add(this.btnMenuItem);
            this.panelDashboard.Controls.Add(this.btnMenuOrder);
            this.panelDashboard.Controls.Add(this.btnPayment);
            this.panelDashboard.Controls.Add(this.btnContinuity);
            this.panelDashboard.Controls.Add(this.btnPackage);
            this.panelDashboard.Location = new System.Drawing.Point(28, 10);
            this.panelDashboard.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1163, 105);
            this.panelDashboard.TabIndex = 6;
            // 
            // dgvDashboard
            // 
            this.dgvDashboard.AllowUserToAddRows = false;
            this.dgvDashboard.AllowUserToDeleteRows = false;
            this.dgvDashboard.AllowUserToResizeRows = false;
            this.dgvDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDashboard.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDashboard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDashboard.ColumnHeadersHeight = 30;
            this.dgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Firstname,
            this.Lastname,
            this.Package,
            this.PackagePrice,
            this.EndTime,
            this.EntryQuantity,
            this.Balance});
            this.dgvDashboard.GridColor = System.Drawing.Color.DimGray;
            this.dgvDashboard.Location = new System.Drawing.Point(28, 164);
            this.dgvDashboard.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.dgvDashboard.Name = "dgvDashboard";
            this.dgvDashboard.Size = new System.Drawing.Size(1146, 448);
            this.dgvDashboard.TabIndex = 7;
            this.dgvDashboard.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDashboard_RowHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // Package
            // 
            this.Package.HeaderText = "Package";
            this.Package.Name = "Package";
            this.Package.ReadOnly = true;
            // 
            // PackagePrice
            // 
            this.PackagePrice.HeaderText = "Package Price";
            this.PackagePrice.Name = "PackagePrice";
            this.PackagePrice.ReadOnly = true;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End Time";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            // 
            // EntryQuantity
            // 
            this.EntryQuantity.HeaderText = "Entry Quantity";
            this.EntryQuantity.Name = "EntryQuantity";
            this.EntryQuantity.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(105, 128);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(249, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(49, 132);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(45, 12);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search";
            // 
            // cbxPackage
            // 
            this.cbxPackage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPackage.FormattingEnabled = true;
            this.cbxPackage.ItemHeight = 12;
            this.cbxPackage.Location = new System.Drawing.Point(518, 128);
            this.cbxPackage.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.cbxPackage.Name = "cbxPackage";
            this.cbxPackage.Size = new System.Drawing.Size(137, 20);
            this.cbxPackage.TabIndex = 10;
            this.cbxPackage.SelectedIndexChanged += new System.EventHandler(this.CbxPackage_SelectedIndexChanged);
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(455, 132);
            this.lblPackage.Margin = new System.Windows.Forms.Padding(0);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(53, 12);
            this.lblPackage.TabIndex = 11;
            this.lblPackage.Text = "Package";
            // 
            // btnAllShow
            // 
            this.btnAllShow.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAllShow.Location = new System.Drawing.Point(665, 128);
            this.btnAllShow.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnAllShow.Name = "btnAllShow";
            this.btnAllShow.Size = new System.Drawing.Size(70, 20);
            this.btnAllShow.TabIndex = 12;
            this.btnAllShow.Text = "All show";
            this.btnAllShow.UseVisualStyleBackColor = true;
            this.btnAllShow.Click += new System.EventHandler(this.BtnAllShow_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1198, 622);
            this.Controls.Add(this.btnAllShow);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.cbxPackage);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDashboard);
            this.Controls.Add(this.panelDashboard);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " GYM Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnPackage;
        private System.Windows.Forms.Button btnContinuity;
        private System.Windows.Forms.Button btnMenuOrder;
        private System.Windows.Forms.Button btnMenuItem;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.DataGridView dgvDashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackagePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbxPackage;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Button btnAllShow;
    }
}