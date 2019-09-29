using GymRegistration.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MenuItem = GymRegistration.Models.MenuItem;
using GlobalLibrary;

namespace GymRegistration.Forms
{
    public partial class MenuItemForm : Form
    {
        private readonly GymDbContext _context;
        UniMetods uniMetods;
        MenuItem SelectedMenuItem;

        // Constructor ...
        public MenuItemForm()
        {
            InitializeComponent();
            _context = new GymDbContext();
            uniMetods = new UniMetods();
            SelectedMenuItem = new MenuItem();
        }

        // Loading ...
        private void MenuItemForm_Load(object sender, EventArgs e)
        {
            FillProductList();
        }

        // Product Created When clicked Save Button 
        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtName.Text.Trim()) || !string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                if (ValidateProduct())
                {
                    MenuItem menuItem = new MenuItem();
                    string TxtName = txtName.Text.Trim();
                    string TxtPrice = txtPrice.Text.Trim();
                    menuItem.Name = uniMetods.FirstCharToUpper(TxtName);
                    double Price = double.Parse(TxtPrice);
                    menuItem.Price = Price;
                    menuItem.Status = true;
                    _context.MenuItems.Add(menuItem);
                    _context.SaveChanges();
                    FillProductList();
                }  
            }
            else { MessageBox.Show("Please, Fill all fields"); }
        }

        // Selected Product for Update or Delete 
        private void DgvProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedId = (int)dgvProduct.Rows[e.RowIndex].Cells[0].Value;
            SelectedMenuItem = _context.MenuItems.Find(selectedId);
            txtName.Text = SelectedMenuItem.Name;
            txtPrice.Text = SelectedMenuItem.Price.ToString("#.00");
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            
        }

        // Updated selected MenuItem 
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedMenuItem != null)
            {
                string TxtName = txtName.Text.Trim();
                string TxtPrice = txtPrice.Text.Trim();
                if (!string.IsNullOrEmpty(TxtName) || !string.IsNullOrEmpty(TxtPrice))
                {
                    if (ValidateProduct())
                    {
                        SelectedMenuItem.Name = uniMetods.FirstCharToUpper(TxtName);
                        double Price;
                        bool isDouble = double.TryParse(uniMetods.FirstCharToUpper(TxtPrice), out Price);
                        if (!isDouble)
                        {
                            MessageBox.Show("Please, entered Price");
                            return;
                        }
                        SelectedMenuItem.Price = Price;
                        _context.SaveChanges();
                        FillProductList();
                    } 
                }
                else { MessageBox.Show("Please, Fill all fields"); }
            }
        }

        // Delete selected Product 
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedMenuItem != null)
            {
                if (!uniMetods.DeleteUser())
                {
                    Reset();
                    return;
                }
                SelectedMenuItem.Status = false;
                _context.SaveChanges();
                FillProductList();
            }
        }

        // Fill Product List ...
        public void FillProductList()
        {
            dgvProduct.Rows.Clear();
            List<MenuItem> menuItems = _context.MenuItems.ToList();
            foreach (MenuItem item in menuItems)
            {
                if (item.Status == true)
                {
                    dgvProduct.Rows.Add(item.Id, item.Name, item.Price.ToString("#.00") + " Azn");
                }
            }
            Reset();
        }

        // Reset ...
        public void Reset()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            SelectedMenuItem = null;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        // Validation Products
        public bool ValidateProduct()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                if (txtName.Text.Length < 2 || txtName.Text.Length > 50)
                {
                    MessageBox.Show("Product Name must be min 2 and max 50 character ");
                    return false;
                }
                MessageBox.Show("Please, choose Product Name");
                return false;
            }

            double Price;
            bool isdouble = double.TryParse(txtPrice.Text.Trim(), out Price);
            if (!string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                if (!isdouble)
                {
                    MessageBox.Show("Please, Fill Correctly Product Price");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Please, Fill Product Price");
                return false;
            }

            return true;
        }
    }
}
