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

namespace GymRegistration.Forms
{
    public partial class PackageForm : Form
    {
        private readonly GymDbContext _context;
        UniMetods uniMetods;
        Package SelectPackage;
        // Constructor ...
        public PackageForm()
        {
            InitializeComponent();
            _context = new GymDbContext();
            uniMetods = new UniMetods();
            SelectPackage = new Package();
        }

        // Loading ...
        private void PackageForm_Load(object sender, EventArgs e)
        {
            FillPackageList();
        }

        // Package Created When clicked Save Button
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string PackName = txtPackName.Text.Trim();
            string PackQuantity = txtPackQuantity.Text.Trim();
            string PackPrice = txtPackPrice.Text.Trim();
            if (!string.IsNullOrEmpty(PackName) ||
                !string.IsNullOrEmpty(PackQuantity) ||
                !string.IsNullOrEmpty(PackPrice))
            {
                if (ValidatePackage())
                {
                    Package package = new Package();
                    package.Name = uniMetods.FirstCharToUpper(PackName);
                    package.EntryQuantity =byte.Parse(uniMetods.FirstCharToUpper(PackQuantity));
                    package.Price =double.Parse(uniMetods.FirstCharToUpper(PackPrice));
                    package.Status = true;
                    _context.Packages.Add(package);
                    _context.SaveChanges();
                    FillPackageList();
                }
            }
            else { MessageBox.Show("Please, Fill all fields"); }
        }

        // Validate Package inputs
        public bool ValidatePackage()
        {
            if (string.IsNullOrEmpty(txtPackName.Text.Trim()))
            {
                MessageBox.Show("Please, Enter Package Name");
                return false;
            }

            byte Quantity;
            bool isByte = Byte.TryParse(txtPackQuantity.Text.Trim(),out Quantity);
            if (!string.IsNullOrEmpty(txtPackQuantity.Text.Trim()))
            {
                if (!isByte)
                {
                    MessageBox.Show("Please, Fill Correctly Package Entry Quantity");
                    return false;
                }
            }
            else {
                MessageBox.Show("Please, Fill Package Entry Quantity");
                return false;
            }

            double Price;
            bool isdouble = double.TryParse(txtPackPrice.Text.Trim(), out Price);
            if (!string.IsNullOrEmpty(txtPackPrice.Text.Trim()))
            {
                if (!isdouble)
                {
                    MessageBox.Show("Please, Fill Correctly Package Price");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please, Fill Package Price");
                return false;
            }
            return true;
        }

        // Updated selected Package
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (SelectPackage != null)
            {
                string PackName = txtPackName.Text.Trim();
                string PackQuantity = txtPackQuantity.Text.Trim();
                string PackPrice = txtPackPrice.Text.Trim();
                if (!string.IsNullOrEmpty(PackName) ||
                !string.IsNullOrEmpty(PackQuantity) ||
                !string.IsNullOrEmpty(PackPrice))
                {
                    if (ValidatePackage())
                    {
                        SelectPackage.Name = uniMetods.FirstCharToUpper(PackName);
                        SelectPackage.EntryQuantity =byte.Parse(uniMetods.FirstCharToUpper(PackQuantity));
                        SelectPackage.Price =double.Parse(uniMetods.FirstCharToUpper(PackPrice));
                        _context.SaveChanges();
                        FillPackageList();
                    }
                }
                else { MessageBox.Show("Please, Fill all fields"); }
            }
        }

        // Delete selected Package
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (SelectPackage != null)
            {
                if (!uniMetods.DeleteUser())
                {
                    Reset();
                    return;
                }
                SelectPackage.Status = false;
                _context.SaveChanges();
                FillPackageList();
            }
        }

        // Selected Package for Update or Delete
        private void DgvPackage_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedId = (int)dgvPackage.Rows[e.RowIndex].Cells[0].Value;
            SelectPackage = _context.Packages.Find(selectedId);
            txtPackName.Text = SelectPackage.Name;
            txtPackQuantity.Text = SelectPackage.EntryQuantity.ToString();
            txtPackPrice.Text = SelectPackage.Price.ToString();
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        // Fill Package List ...
        public void  FillPackageList()
        {
            dgvPackage.Rows.Clear();
            List<Package> packages = _context.Packages.ToList();
            foreach (Package item in packages)
            {
                if (item.Status == true)
                {
                    dgvPackage.Rows.Add(item.Id, item.Name,item.EntryQuantity,item.Price.ToString("#.00") + " Azn");
                }
            }
            Reset();
        }

        // Reset ...
        public void Reset()
        {
            txtPackName.Text = "";
            txtPackPrice.Text = "";
            txtPackQuantity.Text = "";
            SelectPackage = null;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

    }
}
