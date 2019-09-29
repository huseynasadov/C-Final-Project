namespace GymRegistration.Forms
{
    partial class ReportingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportingForm));
            this.lblFn = new System.Windows.Forms.Label();
            this.lblLn = new System.Windows.Forms.Label();
            this.lblBd = new System.Windows.Forms.Label();
            this.lblPh = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMenuOrder = new System.Windows.Forms.DataGridView();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblTotalProduct = new System.Windows.Forms.Label();
            this.lblProductTotal = new System.Windows.Forms.Label();
            this.lblPaymentTotal = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblPayments = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnBalance = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFn
            // 
            this.lblFn.AutoSize = true;
            this.lblFn.Location = new System.Drawing.Point(14, 31);
            this.lblFn.Name = "lblFn";
            this.lblFn.Size = new System.Drawing.Size(67, 12);
            this.lblFn.TabIndex = 0;
            this.lblFn.Text = "Firstname :";
            // 
            // lblLn
            // 
            this.lblLn.AutoSize = true;
            this.lblLn.Location = new System.Drawing.Point(173, 31);
            this.lblLn.Name = "lblLn";
            this.lblLn.Size = new System.Drawing.Size(66, 12);
            this.lblLn.TabIndex = 1;
            this.lblLn.Text = "Lastname :";
            // 
            // lblBd
            // 
            this.lblBd.AutoSize = true;
            this.lblBd.Location = new System.Drawing.Point(339, 31);
            this.lblBd.Name = "lblBd";
            this.lblBd.Size = new System.Drawing.Size(63, 12);
            this.lblBd.TabIndex = 2;
            this.lblBd.Text = "Birthdate :";
            // 
            // lblPh
            // 
            this.lblPh.AutoSize = true;
            this.lblPh.Location = new System.Drawing.Point(500, 31);
            this.lblPh.Name = "lblPh";
            this.lblPh.Size = new System.Drawing.Size(46, 12);
            this.lblPh.TabIndex = 3;
            this.lblPh.Text = "Phone :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.ForeColor = System.Drawing.Color.Crimson;
            this.lblFirstname.Location = new System.Drawing.Point(15, 56);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(0, 12);
            this.lblFirstname.TabIndex = 4;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.ForeColor = System.Drawing.Color.Crimson;
            this.lblLastname.Location = new System.Drawing.Point(173, 56);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(0, 12);
            this.lblLastname.TabIndex = 5;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.ForeColor = System.Drawing.Color.Crimson;
            this.lblBirthdate.Location = new System.Drawing.Point(337, 56);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(0, 12);
            this.lblBirthdate.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.Crimson;
            this.lblPhone.Location = new System.Drawing.Point(500, 56);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 12);
            this.lblPhone.TabIndex = 7;
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageName,
            this.PackagePrice,
            this.CreatedTime});
            this.dgvPayment.Location = new System.Drawing.Point(17, 138);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.Size = new System.Drawing.Size(445, 270);
            this.dgvPayment.TabIndex = 8;
            // 
            // PackageName
            // 
            this.PackageName.HeaderText = "Package Name";
            this.PackageName.Name = "PackageName";
            this.PackageName.ReadOnly = true;
            // 
            // PackagePrice
            // 
            this.PackagePrice.HeaderText = "Price";
            this.PackagePrice.Name = "PackagePrice";
            this.PackagePrice.ReadOnly = true;
            // 
            // CreatedTime
            // 
            this.CreatedTime.HeaderText = "Created Date";
            this.CreatedTime.Name = "CreatedTime";
            this.CreatedTime.ReadOnly = true;
            // 
            // dgvMenuOrder
            // 
            this.dgvMenuOrder.AllowUserToAddRows = false;
            this.dgvMenuOrder.AllowUserToDeleteRows = false;
            this.dgvMenuOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMenuOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdName,
            this.ProductQuantity,
            this.ProductPrice});
            this.dgvMenuOrder.Location = new System.Drawing.Point(476, 138);
            this.dgvMenuOrder.Name = "dgvMenuOrder";
            this.dgvMenuOrder.Size = new System.Drawing.Size(421, 270);
            this.dgvMenuOrder.TabIndex = 9;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "Name";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.HeaderText = "Quantity";
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Location = new System.Drawing.Point(24, 430);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(159, 12);
            this.lblTotalPayment.TabIndex = 10;
            this.lblTotalPayment.Text = "Total Package \'s payments :";
            // 
            // lblTotalProduct
            // 
            this.lblTotalProduct.AutoSize = true;
            this.lblTotalProduct.Location = new System.Drawing.Point(467, 430);
            this.lblTotalProduct.Name = "lblTotalProduct";
            this.lblTotalProduct.Size = new System.Drawing.Size(137, 12);
            this.lblTotalProduct.TabIndex = 11;
            this.lblTotalProduct.Text = "Total Menu Bar Orders :";
            // 
            // lblProductTotal
            // 
            this.lblProductTotal.AutoSize = true;
            this.lblProductTotal.ForeColor = System.Drawing.Color.Crimson;
            this.lblProductTotal.Location = new System.Drawing.Point(639, 430);
            this.lblProductTotal.Name = "lblProductTotal";
            this.lblProductTotal.Size = new System.Drawing.Size(0, 12);
            this.lblProductTotal.TabIndex = 12;
            // 
            // lblPaymentTotal
            // 
            this.lblPaymentTotal.AutoSize = true;
            this.lblPaymentTotal.ForeColor = System.Drawing.Color.Crimson;
            this.lblPaymentTotal.Location = new System.Drawing.Point(208, 430);
            this.lblPaymentTotal.Name = "lblPaymentTotal";
            this.lblPaymentTotal.Size = new System.Drawing.Size(0, 12);
            this.lblPaymentTotal.TabIndex = 13;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(608, 111);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(100, 12);
            this.lblProducts.TabIndex = 14;
            this.lblProducts.Text = "Menu Bar Orders";
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Location = new System.Drawing.Point(173, 111);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(122, 12);
            this.lblPayments.TabIndex = 15;
            this.lblPayments.Text = "Package \'s payments";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(661, 30);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(57, 12);
            this.lblB.TabIndex = 16;
            this.lblB.Text = "Balance :";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.ForeColor = System.Drawing.Color.Crimson;
            this.lblBalance.Location = new System.Drawing.Point(661, 56);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 12);
            this.lblBalance.TabIndex = 17;
            // 
            // btnBalance
            // 
            this.btnBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnBalance.Location = new System.Drawing.Point(740, 18);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(31, 32);
            this.btnBalance.TabIndex = 18;
            this.btnBalance.Text = "+";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.BtnBalance_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtBalance.Location = new System.Drawing.Point(740, 29);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(54, 20);
            this.txtBalance.TabIndex = 19;
            this.txtBalance.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Location = new System.Drawing.Point(803, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 18);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(852, 29);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(42, 18);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "-";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ReportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 459);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblPayments);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblPaymentTotal);
            this.Controls.Add(this.lblProductTotal);
            this.Controls.Add(this.lblTotalProduct);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.dgvMenuOrder);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblPh);
            this.Controls.Add(this.lblBd);
            this.Controls.Add(this.lblLn);
            this.Controls.Add(this.lblFn);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporting Form";
            this.Load += new System.EventHandler(this.ReportingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFn;
        private System.Windows.Forms.Label lblLn;
        private System.Windows.Forms.Label lblBd;
        private System.Windows.Forms.Label lblPh;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackagePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedTime;
        private System.Windows.Forms.DataGridView dgvMenuOrder;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblTotalProduct;
        private System.Windows.Forms.Label lblProductTotal;
        private System.Windows.Forms.Label lblPaymentTotal;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.Button btnCancel;
    }
}