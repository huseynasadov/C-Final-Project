using GlobalLibrary;
using GymRegistration.DAL;
using GymRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GymRegistration.Forms
{
    public partial class CustomerForm : Form
    {
        GymDbContext _context;
        UniMetods uniMetods;
        Customer SelectedCustomer;
        string Fname, Lname, Bdate, Phone, Blnc;
        // Constructor ...
        public CustomerForm()
        {
            InitializeComponent();
            _context = new GymDbContext();
            uniMetods = new UniMetods();
            SelectedCustomer = new Customer();
        }

        // Loading ...
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            FillCustomerList();
        }

        // Customer Created When clicked Save Button
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Fname = txtFname.Text.Trim();
            Lname = txtLname.Text.Trim();
            Bdate = txtBirthdate.Text.Trim();
            Phone = txtPhone.Text.Trim();
            Blnc = txtBalance.Text.Trim();
            if (!string.IsNullOrEmpty(Fname) || !string.IsNullOrEmpty(Lname) || !string.IsNullOrEmpty(Bdate) || !string.IsNullOrEmpty(Phone) || !string.IsNullOrEmpty(Blnc))
            {
                if (ValidatePayment())
                {
                    Customer customer = new Customer();
                    customer.Firstname = uniMetods.FirstCharToUpper(Fname);
                    customer.Lastname = uniMetods.FirstCharToUpper(Lname);
                    customer.Birthdate = DateTime.Parse(Bdate);
                    customer.Phone = uniMetods.FirstCharToUpper(Phone);
                    customer.Balance = double.Parse(Blnc);
                    customer.Status = true;
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                    FillCustomerList();
                }
            }
            else { MessageBox.Show("Please, Fill all fields"); }
        }

        // Updated selected Customer
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedCustomer != null)
            {
                Fname = txtFname.Text.Trim();
                Lname = txtLname.Text.Trim();
                Bdate = txtBirthdate.Text.Trim();
                Phone = txtPhone.Text.Trim();
                Blnc = txtBalance.Text.Trim();
                if (!string.IsNullOrEmpty(Fname) || !string.IsNullOrEmpty(Lname) || !string.IsNullOrEmpty(Bdate) || !string.IsNullOrEmpty(Phone) || !string.IsNullOrEmpty(Blnc))
                {
                    if (ValidatePayment())
                    {
                        SelectedCustomer.Firstname = uniMetods.FirstCharToUpper(Fname);
                        SelectedCustomer.Lastname = uniMetods.FirstCharToUpper(Lname);
                        SelectedCustomer.Birthdate = DateTime.Parse(Bdate);
                        SelectedCustomer.Phone = uniMetods.FirstCharToUpper(Phone);
                        SelectedCustomer.Balance = double.Parse(Blnc);
                        SelectedCustomer.Status = true;
                        _context.SaveChanges();
                        FillCustomerList();
                    }
                }
                else { MessageBox.Show("Please, Fill all fields"); }
            }
        }

        // Delete selected Product
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedCustomer != null)
            {
                if (!uniMetods.DeleteUser())
                {
                    Reset();
                    return;
                }
                    SelectedCustomer.Status = false;
                    _context.SaveChanges();
                    FillCustomerList();
            }
        }

        // Selected Customer for Update or Delete
        private void DgvCustomer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedId = (int)dgvCustomer.Rows[e.RowIndex].Cells[0].Value;
            SelectedCustomer = _context.Customers.Find(selectedId);
            txtFname.Text = SelectedCustomer.Firstname;
            txtLname.Text = SelectedCustomer.Lastname;
            txtBirthdate.Text = SelectedCustomer.Birthdate.ToShortDateString();
            txtPhone.Text = SelectedCustomer.Phone;
            txtBalance.Text = SelectedCustomer.Balance.ToString();
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        // Fill Customer List ...
        public void FillCustomerList()
        {
            dgvCustomer.Rows.Clear();
            List<Customer> menuItems = _context.Customers.ToList();
            foreach (Customer item in menuItems)
            {
                if (item.Status == true)
                {
                    dgvCustomer.Rows.Add(item.Id, item.Firstname, item.Lastname, item.Birthdate.ToShortDateString(), item.Phone, item.Balance + " Azn");
                }
            }
            Reset();
        }

        // Reset
        public void Reset()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtBirthdate.Text = "";
            txtPhone.Text = "";
            txtBalance.Text = "";
            SelectedCustomer = null;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        // Validation Payment
        public bool ValidatePayment()
        {
            string Fname = txtFname.Text.Trim();
            string Lname = txtLname.Text.Trim();
            string Bdate = txtBirthdate.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            string Balance = txtBalance.Text.Trim();
            if (string.IsNullOrEmpty(Fname))
            {
                MessageBox.Show("Please, Fill Customer's Firstname");
                return false;
            }
            if (Fname.Length < 2 || Fname.Length > 50)
            {
                MessageBox.Show("Customer's firstname must be min 2 , max 50 character");
                return false;
            }


            if (string.IsNullOrEmpty(Lname))
            {
                MessageBox.Show("Please, Fill Customer's Lastname");
                return false;
            }
            if (Lname.Length < 2 || Lname.Length > 50)
            {
                MessageBox.Show("Customer's Lastname must be min 2 , max 50 character");
                return false;
            }


            DateTime dateTime;
            bool isDate = DateTime.TryParse(Bdate, out dateTime);
            if (string.IsNullOrEmpty(Bdate))
            {
                MessageBox.Show("Please, Fill Customer's Birthdate");
                return false;
            }
            if (!isDate)
            {
                MessageBox.Show("Please, Fill Correctly Birthdate. For example : 'yyyy.MM.dd'");
                return false;
            }


            if (string.IsNullOrEmpty(Phone))
            {
                MessageBox.Show("Please, Fill Customer's Phone number");
                return false;
            }
            if (!IsPhoneNumber(Phone))
            {
                MessageBox.Show("Please, fill correctly Phone number . For example : '+99450XXXXXXX'");
                return false;
            }


            double balance;
            bool isdouble = double.TryParse(Balance, out balance);
            if (string.IsNullOrEmpty(Balance))
            {
                MessageBox.Show("Please, Fill Customer's Balance");
                return false;
            }
            if (!isdouble)
            {
                MessageBox.Show("Please, Fill Correctly Customer's Balance");
                return false;
            }


            return true;
        }

        // Valitation phone number
        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{12})$").Success;
        }
    }
}
