namespace GymRegistration.Forms
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.lblCust = new System.Windows.Forms.Label();
            this.lblPack = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this.cbxPackage = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCrDate = new System.Windows.Forms.Label();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(33, 30);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(59, 12);
            this.lblCust.TabIndex = 0;
            this.lblCust.Text = "Customer";
            // 
            // lblPack
            // 
            this.lblPack.AutoSize = true;
            this.lblPack.Location = new System.Drawing.Point(33, 62);
            this.lblPack.Name = "lblPack";
            this.lblPack.Size = new System.Drawing.Size(53, 12);
            this.lblPack.TabIndex = 1;
            this.lblPack.Text = "Package";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(33, 91);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 12);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price (Azn)";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(115, 23);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(229, 20);
            this.cbxCustomer.TabIndex = 4;
            // 
            // cbxPackage
            // 
            this.cbxPackage.FormattingEnabled = true;
            this.cbxPackage.Location = new System.Drawing.Point(115, 54);
            this.cbxPackage.Name = "cbxPackage";
            this.cbxPackage.Size = new System.Drawing.Size(229, 20);
            this.cbxPackage.TabIndex = 5;
            this.cbxPackage.SelectedIndexChanged += new System.EventHandler(this.CbxPackage_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(115, 85);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(44, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(115, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(230, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Pay";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(115, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(236, 199);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 35);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PayCustomer,
            this.PayPackage,
            this.PayPrice,
            this.PayCreatedDate,
            this.PayQuantity});
            this.dgvPayment.Location = new System.Drawing.Point(370, 23);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.Size = new System.Drawing.Size(549, 381);
            this.dgvPayment.TabIndex = 11;
            this.dgvPayment.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPayment_RowHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // PayCustomer
            // 
            this.PayCustomer.HeaderText = "Customer";
            this.PayCustomer.Name = "PayCustomer";
            this.PayCustomer.ReadOnly = true;
            // 
            // PayPackage
            // 
            this.PayPackage.HeaderText = "Package";
            this.PayPackage.Name = "PayPackage";
            this.PayPackage.ReadOnly = true;
            // 
            // PayPrice
            // 
            this.PayPrice.HeaderText = "Price (Azn)";
            this.PayPrice.Name = "PayPrice";
            this.PayPrice.ReadOnly = true;
            // 
            // PayCreatedDate
            // 
            this.PayCreatedDate.HeaderText = "Created Date";
            this.PayCreatedDate.Name = "PayCreatedDate";
            this.PayCreatedDate.ReadOnly = true;
            // 
            // PayQuantity
            // 
            this.PayQuantity.HeaderText = "Entry Quantity";
            this.PayQuantity.Name = "PayQuantity";
            this.PayQuantity.ReadOnly = true;
            // 
            // lblCrDate
            // 
            this.lblCrDate.AutoSize = true;
            this.lblCrDate.Location = new System.Drawing.Point(33, 123);
            this.lblCrDate.Name = "lblCrDate";
            this.lblCrDate.Size = new System.Drawing.Size(75, 12);
            this.lblCrDate.TabIndex = 3;
            this.lblCrDate.Text = "Started Date";
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Location = new System.Drawing.Point(115, 116);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Size = new System.Drawing.Size(229, 20);
            this.txtCreatedDate.TabIndex = 7;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 415);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCreatedDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cbxPackage);
            this.Controls.Add(this.cbxCustomer);
            this.Controls.Add(this.lblCrDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPack);
            this.Controls.Add(this.lblCust);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Form";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblPack;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbxCustomer;
        private System.Windows.Forms.ComboBox cbxPackage;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayQuantity;
        private System.Windows.Forms.Label lblCrDate;
        private System.Windows.Forms.TextBox txtCreatedDate;
    }
}