using GymRegistration.DAL;
using GymRegistration.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GlobalLibrary;

namespace GymRegistration.Forms
{
    public partial class Dashboard : Form
    {
        UniMetods uniMetods;
        public Dashboard()
        {
            InitializeComponent();
            uniMetods = new UniMetods();
        }

        // Opening Registration Form
        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.FormClosed += new FormClosedEventHandler(FillDashboardList);
            customerForm.ShowDialog();
        }

        // Opening Payment Form
        private void BtnPayment_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.FormClosed += new FormClosedEventHandler(FillDashboardList);
            paymentForm.ShowDialog();
        }

        // Opening Package Form
        private void BtnPackage_Click(object sender, EventArgs e)
        {
            PackageForm packageForm = new PackageForm();
            packageForm.FormClosed += new FormClosedEventHandler(FillPackageCbx);
            packageForm.ShowDialog();
        }

        // Opening Continuity Customers Form
        private void BtnContinuity_Click(object sender, EventArgs e)
        {
            ContinuityForm ContinuityForm = new ContinuityForm();
            ContinuityForm.FormClosed += new FormClosedEventHandler(FillDashboardList);
            ContinuityForm.ShowDialog();
        }

        // Opening Bar Menu Form for Order
        private void BtnMenuOrder_Click(object sender, EventArgs e)
        {
            MenuOrderForm menuOrderForm = new MenuOrderForm();
            menuOrderForm.FormClosed += new FormClosedEventHandler(FillDashboardList);
            menuOrderForm.ShowDialog();
        }

        // Opening  Menu Items 
        private void BtnMenuItem_Click(object sender, EventArgs e)
        {
            MenuItemForm menuItemForm = new MenuItemForm();
            menuItemForm.FormClosed += new FormClosedEventHandler(FillDashboardList);
            menuItemForm.ShowDialog();
        }

        // Loading ...
        private void Dashboard_Load(object sender, EventArgs e)
        {
            FillDashboardList();
            FillPackageCbx();
            FormClosing += new FormClosingEventHandler(uniMetods.dash_Closing);
        }

        // Fill Dashboard list 
        public void FillDashboardList()
        {
            using (GymDbContext _contex = new GymDbContext())
            {
                dgvDashboard.Rows.Clear();
                List<Payment> payments = _contex.Payments.Include("Customer").Include("Package").ToList();
                foreach (Payment item in payments)
                {
                    if (item.Status == true)
                    {
                        dgvDashboard.Rows.Add(
                        item.CustomerId,
                        item.Customer.Firstname,
                        item.Customer.Lastname,
                        item.Package.Name,
                        item.Price.ToString("#.00") + " Azn",
                        item.CreatedAt.AddMonths(1),
                        item.PackageEntryQuantity,
                        item.Customer.Balance.ToString("#.00") + " Azn");
                        if (item.CreatedAt.AddMonths(1) < DateTime.Now || item.PackageEntryQuantity == 0)
                        {
                            dgvDashboard.Rows[dgvDashboard.Rows.Count - 1].DefaultCellStyle.BackColor = Color.IndianRed;
                        }
                    }
                }
            }
        }

        public void FillDashboardList(object sender, EventArgs e)
        {
            using (GymDbContext _contex = new GymDbContext())
            {
                dgvDashboard.Rows.Clear();
                List<Payment> payments = _contex.Payments.Include("Customer").Include("Package").ToList();
                foreach (Payment item in payments)
                {
                    if (item.Status == true)
                    {
                        dgvDashboard.Rows.Add(
                        item.CustomerId,
                        item.Customer.Firstname,
                        item.Customer.Lastname,
                        item.Package.Name,
                        item.Price.ToString("#.00") + " Azn",
                        item.CreatedAt.AddMonths(1),
                        item.PackageEntryQuantity,
                        item.Customer.Balance.ToString("#.00") + " Azn");
                        if (item.CreatedAt.AddMonths(1) < DateTime.Now || item.PackageEntryQuantity == 0)
                        {
                            dgvDashboard.Rows[dgvDashboard.Rows.Count - 1].DefaultCellStyle.BackColor = Color.IndianRed;
                        }
                    }
                }
            }
        }

        public void FillPackageCbx(object sender, EventArgs e)
        {
            using (GymDbContext _context = new GymDbContext())
            {
                cbxPackage.Items.Clear();
                List<Package> packages = _context.Packages.ToList();
                foreach (Package item in packages)
                {
                    if (item.Status == true)
                    {
                        cbxPackage.Items.Add(item.Name);
                    }
                }
            }
        }
        public void FillPackageCbx()
        {
            using (GymDbContext _context = new GymDbContext())
            {
                List<Package> packages = _context.Packages.ToList();
                foreach (Package item in packages)
                {
                    if (item.Status == true)
                    {
                        cbxPackage.Items.Add(item.Name);
                    }
                }
            }
        }

        // Opening Reporting Form for look Customers's all payments
        private void DgvDashboard_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedId = (int)dgvDashboard.Rows[e.RowIndex].Cells[0].Value;
            ReportingForm reportingForm = new ReportingForm(selectedId);
            reportingForm.FormClosed += new FormClosedEventHandler(FillDashboardList);
            reportingForm.ShowDialog();
        }

        // When text changed, take searched list
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

            string Search = txtSearch.Text.Trim().ToLower();
            if (Search == "" && cbxPackage.SelectedIndex >= 0)
            {
                FillPackageList();
            }
            else if (Search != "" && cbxPackage.SelectedIndex >= 0)
            {
                FillPackageList();

            }
            else if (Search != "")
            {
                FillSearchedList(Search);
            }
            else { FillDashboardList(); }

        }

        // Fill dashboard list searched text
        public void FillSearchedList(string Searchtext)
        {
            using (GymDbContext _contex = new GymDbContext())
            {
                dgvDashboard.Rows.Clear();
                List<Payment> payments = _contex.Payments.Include("Customer").Include("Package").ToList();

                foreach (Payment item in payments)
                {
                    if (item.Customer.Firstname.ToLower().Contains(Searchtext))
                    {
                        if (item.Status == true)
                        {
                            dgvDashboard.Rows.Add(
                              item.Customer.Id,
                              item.Customer.Firstname,
                              item.Customer.Lastname,
                              item.Package.Name,
                              item.Price.ToString("#.00") + " Azn",
                              item.CreatedAt.AddMonths(1),
                              item.PackageEntryQuantity,
                              item.Customer.Balance.ToString("#.00") + " Azn");
                            if (item.CreatedAt.AddMonths(1) < DateTime.Now || item.PackageEntryQuantity == 0)
                            {
                                dgvDashboard.Rows[dgvDashboard.Rows.Count - 1].DefaultCellStyle.BackColor = Color.IndianRed;
                            }
                        }
                    }
                }
            }
        }

        // Fill searchedlist at package
        public void FillPackageList()
        {
            using (GymDbContext _contex = new GymDbContext())
            {
                if (cbxPackage.SelectedIndex >= 0)
                {
                    dgvDashboard.Rows.Clear();
                    List<Payment> payments = _contex.Payments.Include("Customer").Include("Package").ToList();
                    List<Package> packages = _contex.Packages.Where(p => p.Status == true).ToList();
                    Package package = new Package();
                    foreach (Package item in packages)
                    {
                        if (item.Name == cbxPackage.SelectedItem.ToString())
                        {
                            package = item;
                        }
                    }
                    string Search = txtSearch.Text.Trim().ToLower();
                    foreach (Payment item in payments)
                    {
                        if (package.Name == item.Package.Name && item.Customer.Firstname.ToLower().Contains(Search))
                        {
                            if (item.Status == true)
                            {
                                dgvDashboard.Rows.Add(
                                  item.Customer.Id,
                                  item.Customer.Firstname,
                                  item.Customer.Lastname,
                                  item.Package.Name,
                                  item.Price.ToString("#.00") + " Azn",
                                  item.CreatedAt.AddMonths(1),
                                  item.PackageEntryQuantity,
                                  item.Customer.Balance.ToString("#.00") + " Azn");
                                if (item.CreatedAt.AddMonths(1) < DateTime.Now || item.PackageEntryQuantity == 0)
                                {
                                    dgvDashboard.Rows[dgvDashboard.Rows.Count - 1].DefaultCellStyle.BackColor = Color.IndianRed;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void CbxPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPackageList();
        }

        private void BtnAllShow_Click(object sender, EventArgs e)
        {
            FillDashboardList();
            cbxPackage.SelectedIndex = -1;
            txtSearch.Text = "";
        }
    }
}
