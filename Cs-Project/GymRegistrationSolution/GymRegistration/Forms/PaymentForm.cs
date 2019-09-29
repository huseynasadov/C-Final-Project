using GlobalLibrary;
using GymRegistration.DAL;
using GymRegistration.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuItem = GymRegistration.Models.MenuItem;

namespace GymRegistration.Forms
{
    public partial class PaymentForm : Form
    {
        private readonly GymDbContext _context;
        UniMetods uniMetods;
        Payment SelectPayment;
        Customer SelectedCustomer;
        Package SelectedPackage;
        // Constructor ...
        public PaymentForm()
        {
            InitializeComponent();
            _context = new GymDbContext();
            uniMetods = new UniMetods();
            SelectPayment = new Payment();
            SelectedCustomer = new Customer();
            SelectedPackage = new Package();
        }

        // Loading ...
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            FillPaymentList();
            FillCustomerListCbx();
            FillPackageListCbx();
        }

        // Payment Created When clicked Save Button 
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if ((cbxCustomer.SelectedIndex >= 0) || (cbxPackage.SelectedIndex >= 0) || !string.IsNullOrEmpty(txtPrice.Text.Trim()) || !string.IsNullOrEmpty(txtCreatedDate.Text.Trim()))
            {
                if (ValidatePayment())
                {
                    Payment payment = new Payment();
                    SaveUpdate(payment);
                    List<Payment> payments = _context.Payments.Include("Customer").ToList();
                    foreach (Payment item in payments)
                    {
                        if (item.Status == true)
                        {
                            if (item.CustomerId == payment.CustomerId &&
                                item.CreatedAt.AddMonths(1) > DateTime.Now && item.PackageEntryQuantity > 0)
                            {
                                MessageBox.Show("Customer 's have a active Package");
                                payment = null;
                                return;
                            }
                        }
                    }
                    if (payment != null)
                    {
                        _context.Payments.Add(payment);
                        _context.SaveChanges();
                        FillPaymentList();
                    }

                }
            }
            else { MessageBox.Show("Please, Fill all fields"); }
        }

        // Updated selected Payment 
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if ((cbxCustomer.SelectedIndex >= 0) || (cbxPackage.SelectedIndex >= 0) || !string.IsNullOrEmpty(txtPrice.Text.Trim()) || !string.IsNullOrEmpty(txtCreatedDate.Text.Trim()))
            {
                if (ValidatePayment())
                {

                    SaveUpdate(SelectPayment);
                    _context.SaveChanges();
                    FillPaymentList();
                }
            }
            else { MessageBox.Show("Please, Fill all fields"); }
        }

        // Metod for Save and Update 
        public void SaveUpdate(Payment payment)
        {
            string[] custarr = cbxCustomer.SelectedItem.ToString().Split('-');
            string selectedFname = custarr[1].Trim();
            string selectedLname = custarr[0].Trim();
            SelectedCustomer = _context.Customers.FirstOrDefault(c => c.Firstname == selectedFname && c.Lastname == selectedLname);
            payment.Customer = SelectedCustomer;
            payment.CustomerId = SelectedCustomer.Id;
            payment.Package = SelectedPackage;
            payment.PackageId = SelectedPackage.Id;
            payment.Price = double.Parse(txtPrice.Text.Trim());
            payment.CreatedAt = DateTime.Parse(txtCreatedDate.Text.Trim());
            payment.PackageEntryQuantity = payment.Package.EntryQuantity;
            payment.Status = true;
        }

        // Delete selected Payment 
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (SelectPayment != null)
            {
                if (!uniMetods.DeleteUser())
                {
                    Reset();
                    return;
                }
                SelectPayment.Status = false;
                _context.SaveChanges();
                FillPaymentList();
            }
        }

        // Selected Payment for Update or Delete 
        private void DgvPayment_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedId = (int)dgvPayment.Rows[e.RowIndex].Cells[0].Value;
            SelectPayment = _context.Payments.Find(selectedId);
            cbxCustomer.SelectedItem = SelectPayment.Customer.Lastname + " - " + SelectPayment.Customer.Firstname;
            cbxPackage.SelectedItem = SelectPayment.Package.Name + " | " + SelectPayment.Package.Price.ToString("#.00") + " Azn";
            txtCreatedDate.Text = SelectPayment.CreatedAt.ToString();
            txtPrice.Text = SelectPayment.Price.ToString("#.00");
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        // Fill Payment List ...
        public void FillPaymentList()
        {
            dgvPayment.Rows.Clear();
            List<Payment> payments = _context.Payments.Include("Customer").Include("Package").ToList();
            foreach (Payment item in payments)
            {
                if (item.Status == true)
                {
                    dgvPayment.Rows.Add(
                        item.Id,
                        item.Customer.Firstname + " " + item.Customer.Lastname,
                        item.Package.Name,
                        item.Price.ToString("#.00") + " Azn",
                        item.CreatedAt.ToShortDateString(),
                        item.PackageEntryQuantity);
                    if (item.CreatedAt.AddMonths(1) < DateTime.Now || item.PackageEntryQuantity == 0)
                    {
                        dgvPayment.Rows[dgvPayment.Rows.Count - 1].DefaultCellStyle.BackColor = Color.IndianRed;
                    }
                }
            }
            Reset();
        }

        // Fill Customer Combobox
        public void FillCustomerListCbx()
        {
            List<Customer> customers = _context.Customers.ToList();
            foreach (Customer item in customers)
            {
                if (item.Status == true)
                {
                    cbxCustomer.Items.Add(item.Lastname + " - " + item.Firstname);
                }
            }
        }

        // Fill Package Combobox
        public void FillPackageListCbx()
        {
            List<Package> packages = _context.Packages.ToList();
            foreach (Package item in packages)
            {
                if (item.Status == true)
                {
                    cbxPackage.Items.Add(item.Name + " | " + item.Price.ToString("#.00") + " Azn");
                }
            }
        }

        // Reset ...
        public void Reset()
        {
            cbxCustomer.SelectedIndex = -1;
            cbxPackage.SelectedIndex = -1;
            txtCreatedDate.Text = "";
            txtPrice.Text = "";
            SelectPayment = null;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        // Validation Payment
        public bool ValidatePayment()
        {
            if (cbxCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("Please, choose Customer");
                return false;
            }

            if (cbxPackage.SelectedIndex < 0)
            {
                MessageBox.Show("Please, choose Product");
                return false;
            }
            double Price;
            bool isdouble = double.TryParse(txtPrice.Text.Trim(), out Price);
            if (!string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                if (!isdouble)
                {
                    MessageBox.Show("Please, Fill Correctly Payment's Price");
                    return false;
                }
                if (Price > SelectedPackage.Price)
                {
                    MessageBox.Show("Price must be less Package Price");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Please, Fill Payment's Price");
                return false;
            }

            DateTime dateTime;
            bool isDate = DateTime.TryParse(txtCreatedDate.Text.Trim(), out dateTime);
            if (!string.IsNullOrEmpty(txtCreatedDate.Text.Trim()))
            {
                if (!isDate)
                {
                    MessageBox.Show("Please, Fill Correctly Created Date");
                    return false;
                }
                if (DateTime.Compare(dateTime.AddHours(1),DateTime.Now) < 0)
                {
                    MessageBox.Show("Started date must be after or now time");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please, Fill Payment's Created date");
                return false;
            }
            return true;
        }

        private void CbxPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPackage.SelectedItem != null)
            {
                string[] prodarr = cbxPackage.SelectedItem.ToString().Split('|');
                string selectedPro = prodarr[0].Trim();
                SelectedPackage = _context.Packages.FirstOrDefault(m => m.Name == selectedPro);
                txtPrice.Text = SelectedPackage.Price.ToString();
                txtCreatedDate.Text = DateTime.Now.ToString();
            }
        }
    }
}
