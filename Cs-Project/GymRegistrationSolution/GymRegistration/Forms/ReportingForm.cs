using GymRegistration.DAL;
using GymRegistration.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GymRegistration.Forms
{
    public partial class ReportingForm : Form
    {
        int customerId;
        private readonly GymDbContext _context;
        List<Payment> payments;
        List<MenuOrder> menuOrders;
        public ReportingForm(int cId)
        {
            InitializeComponent();
            customerId = cId;
            _context = new GymDbContext();
            payments = _context.Payments.Include("Customer").Include("Package").Where(p => p.CustomerId == customerId).ToList();
            menuOrders = _context.MenuOrders.Include("Customer").Include("MenuItem").Where(p => p.CustomerId == customerId).ToList();
        }

        private void ReportingForm_Load(object sender, EventArgs e)
        {
            FillPaymentsList();
            FillProductsList();
            FillCustomerinfo();
        }

        // Fill Package's Payments List
        public void FillPaymentsList()
        {
            foreach (Payment item in payments)
            {
                dgvPayment.Rows.Add(item.Package.Name, item.Price.ToString("#.00") + " Azn", item.CreatedAt);
                if (item.CreatedAt.AddMonths(1) < DateTime.Now || item.Status == false || item.PackageEntryQuantity <= 0)
                {
                    dgvPayment.Rows[dgvPayment.Rows.Count - 1].DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
        }

        // Fill Products List
        public void FillProductsList()
        {
            foreach (MenuOrder item in menuOrders)
            {
                dgvMenuOrder.Rows.Add(item.MenuItem.Name, item.Quantity, item.MenuItem.Price.ToString("#.00") + " Azn");

            }
        }

        // Fill Customer Info
        public void FillCustomerinfo()
        {
            double totalPay = 0;
            double totalPro = 0;
            Customer customer = payments[0].Customer;
            lblFirstname.Text = customer.Firstname;
            lblLastname.Text = customer.Lastname;
            lblBirthdate.Text = customer.Birthdate.ToShortDateString();
            lblPhone.Text = customer.Phone;
            lblBalance.Text = customer.Balance.ToString("#.00") + " Azn";
            foreach (Payment item in payments)
            {
                totalPay += item.Price;
            }
            foreach (MenuOrder item in menuOrders)
            {
                totalPro += item.MenuItem.Price;
            }
            lblPaymentTotal.Text = totalPay.ToString("#.00") + " Azn";
            lblProductTotal.Text = totalPro.ToString("#.00") + " Azn";
        }

        private void BtnBalance_Click(object sender, EventArgs e)
        {
            txtBalance.Visible = true;
            btnBalance.Visible = false;
            btnAdd.Visible = true;
            btnCancel.Visible = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = _context.Customers.FirstOrDefault(c => c.Id == customerId);
            double balance;
            bool isdouble = double.TryParse(txtBalance.Text.Trim(), out balance);
            if (!isdouble)
            {
                MessageBox.Show("Please, entered correctly Balance");
                return;
            }
            customer.Balance += double.Parse(txtBalance.Text.Trim());
            _context.SaveChanges();
            FillCustomerinfo();
            txtBalance.Visible = false;
            btnAdd.Visible = false;
            btnBalance.Visible = true;
            btnCancel.Visible = false;
            MessageBox.Show($"Balance {balance} (Azn) increased");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtBalance.Visible = false;
            txtBalance.Text = "";
            btnAdd.Visible = false;
            btnBalance.Visible = true;
            btnCancel.Visible = false;

        }
    }
}
