using GymRegistration.DAL;
using GymRegistration.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GymRegistration.Forms
{
    public partial class ContinuityForm : Form
    {
        private readonly GymDbContext _context;
        public ContinuityForm()
        {
            InitializeComponent();
            _context = new GymDbContext();
        }

        // Loading ...
        private void ContinuityForm_Load(object sender, EventArgs e)
        {
            FillContinuityList();
            FillCustomerCbx();
        }

        // Fill all Customers Continuity list DGV
        public void FillContinuityList()
        {
            dgvContinuity.Rows.Clear();
            List<Payment> payments = _context.Payments.Include("Package").Include("Customer").ToList();
            foreach (Payment item in payments)
            {
                if (item.Status == true)
                {
                    dgvContinuity.Rows.Add(
                                       item.CustomerId,
                                       item.Customer.Firstname + " " + item.Customer.Lastname,
                                       item.PackageEntryQuantity,
                                       item.CreatedAt.AddMonths(1));
                    if (item.CreatedAt.AddMonths(1) < DateTime.Now || item.PackageEntryQuantity == 0)
                    {
                        dgvContinuity.Rows[dgvContinuity.Rows.Count - 1].DefaultCellStyle.BackColor = Color.IndianRed;
                    }
                }
            }
            Reset();
        }

        // Fill Customers name in combobox
        public void FillCustomerCbx()
        {
            List<Customer> customers = _context.Customers.ToList();
            foreach (Customer item in customers)
            {
                if (item.Status == true)
                {
                    cbxContinuityCustomer.Items.Add(item.Lastname + " - " + item.Firstname);
                }
            }
            
        }

        // Reset ... 
        public void Reset()
        {
            cbxContinuityCustomer.SelectedIndex = -1;
        }

        // Entry Qunatity falsed on Click Enter
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (cbxContinuityCustomer.SelectedIndex >=0)
            {
                List<Payment> payments = _context.Payments.Include("Customer").Include("Package").ToList();
                string[] arrCust = cbxContinuityCustomer.SelectedItem.ToString().Split('-');
                string CustFname = arrCust[1].Trim();
                string CustLname = arrCust[0].Trim();
                foreach (Payment item in payments)
                {
                    if (item.Status == true)
                    {
                        if ((item.Customer.Firstname == CustFname) && (item.Customer.Lastname == CustLname))
                        {
                            if (item.PackageEntryQuantity - 1 == 0)
                            {
                                MessageBox.Show($"Today is {item.Customer.Firstname.ToUpper()} {item.Customer.Lastname.ToUpper()} 's Last day ");
                            }

                            if (item.PackageEntryQuantity - 1 < 0)
                            {
                                MessageBox.Show("Entry Quantity ended. Please, buy new package");
                                return;
                            }
                            item.PackageEntryQuantity -= 1;
                        }
                    }
                }
                _context.SaveChanges();
                FillContinuityList();
            }
        }
    }
}
