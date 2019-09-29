namespace GymRegistration.Forms
{
    partial class ContinuityForm
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbxContinuityCustomer = new System.Windows.Forms.ComboBox();
            this.dgvContinuity = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepEnddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContinuity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(30, 36);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(59, 12);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer";
            // 
            // cbxContinuityCustomer
            // 
            this.cbxContinuityCustomer.FormattingEnabled = true;
            this.cbxContinuityCustomer.Location = new System.Drawing.Point(34, 60);
            this.cbxContinuityCustomer.Name = "cbxContinuityCustomer";
            this.cbxContinuityCustomer.Size = new System.Drawing.Size(240, 20);
            this.cbxContinuityCustomer.TabIndex = 1;
            // 
            // dgvContinuity
            // 
            this.dgvContinuity.AllowUserToAddRows = false;
            this.dgvContinuity.AllowUserToDeleteRows = false;
            this.dgvContinuity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContinuity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContinuity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContinuity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.RepCustomer,
            this.RepQuantity,
            this.RepEnddate});
            this.dgvContinuity.Location = new System.Drawing.Point(302, 11);
            this.dgvContinuity.Name = "dgvContinuity";
            this.dgvContinuity.Size = new System.Drawing.Size(406, 393);
            this.dgvContinuity.TabIndex = 2;
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // RepCustomer
            // 
            this.RepCustomer.HeaderText = "Customer";
            this.RepCustomer.Name = "RepCustomer";
            this.RepCustomer.ReadOnly = true;
            // 
            // RepQuantity
            // 
            this.RepQuantity.HeaderText = "Entry Quantity";
            this.RepQuantity.Name = "RepQuantity";
            this.RepQuantity.ReadOnly = true;
            // 
            // RepEnddate
            // 
            this.RepEnddate.HeaderText = "Deadline";
            this.RepEnddate.Name = "RepEnddate";
            this.RepEnddate.ReadOnly = true;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.LightGreen;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCheck.Location = new System.Drawing.Point(34, 109);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(240, 72);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Enter...";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // ContinuityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 415);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dgvContinuity);
            this.Controls.Add(this.cbxContinuityCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ContinuityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Continuity Form";
            this.Load += new System.EventHandler(this.ContinuityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContinuity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbxContinuityCustomer;
        private System.Windows.Forms.DataGridView dgvContinuity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepEnddate;
        private System.Windows.Forms.Button btnCheck;
    }
}