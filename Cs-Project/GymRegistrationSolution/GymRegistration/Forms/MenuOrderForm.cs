
using GymRegistration.DAL;
using GymRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MenuItem = GymRegistration.Models.MenuItem;
using GlobalLibrary;

namespace GymRegistration.Forms
{
    public partial class MenuOrderForm : Form
    {
        private readonly GymDbContext _context;
        MenuOrder SelectedOrder;
        List<MenuOrder> menuOrders;
        UniMetods uniMetods;
        Customer selectedCustomer;
        MenuItem SelectedmenuItem;
        double totalSum;
        // Constructor ...
        public MenuOrderForm()
        {
            InitializeComponent();
            _context = new GymDbContext();
            SelectedOrder = new MenuOrder();
            menuOrders = new List<MenuOrder>();
            selectedCustomer = new Customer();
            SelectedmenuItem = new MenuItem();
            uniMetods = new UniMetods();
        }

        // Loading ...
        private void MenuOrderForm_Load(object sender, EventArgs e)
        {
            FillCustomerListCbx();
            FillProductListCbx();
        }

        // Menu Created When clicked Save Button
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if ((cbxCustomer.SelectedIndex >= 0) || (cbxProduct.SelectedIndex >= 0) || (numQuantity.Value > 0))
            {
                if (ValidateOrder())
                {
                    MenuOrder menuOrder = new MenuOrder();
                    string[] custarr = cbxCustomer.SelectedItem.ToString().Split('-');
                    string selectedFname = custarr[1].Trim();
                    string selectedLname = custarr[0].Trim();

                    selectedCustomer = _context.Customers.FirstOrDefault(c => c.Firstname == selectedFname && c.Lastname == selectedLname);
                    menuOrder.Customer = selectedCustomer;
                    menuOrder.CustomerId = selectedCustomer.Id;

                    string[] prodarr = cbxProduct.SelectedItem.ToString().Split('|');
                    string selectedPro = prodarr[0].Trim();
                    SelectedmenuItem = _context.MenuItems.FirstOrDefault(m => m.Name == selectedPro);
                    menuOrder.MenuItem = SelectedmenuItem;
                    menuOrder.MenuItemId = SelectedmenuItem.Id;

                    menuOrder.Quantity = (int)numQuantity.Value;
                    menuOrder.Status = true;
                    cbxCustomer.Enabled = false;
                    btnOrdered.Enabled = true;
                    menuOrders.Add(menuOrder);
                    FillOrderList();
                }
            }
            else { MessageBox.Show("Please, fill all fields "); }
        }

        // Validation Ordered
        public bool ValidateOrder()
        {
            if (cbxCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("Please, choose Customer");
                return false;
            }
            if (cbxProduct.SelectedIndex < 0)
            {
                MessageBox.Show("Please, choose Product");
                return false;
            }
            if (numQuantity.Value < 1)
            {
                MessageBox.Show("Please, enterd quantity");
                return false;
            }
            return true;
        }

        // Updated selected Menu Bar
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedOrder != null)
            {
                if ((cbxCustomer.SelectedIndex >= 0) && (cbxProduct.SelectedIndex >= 0) && (numQuantity.Value > 0))
                {
                    if (ValidateOrder())
                    {
                        string[] custarr = cbxCustomer.SelectedItem.ToString().Split('-');
                        string selectedFname = custarr[1].Trim();
                        string selectedLname = custarr[0].Trim();
                        selectedCustomer = _context.Customers.FirstOrDefault(c => c.Firstname == selectedFname && c.Lastname == selectedLname);
                        SelectedOrder.Customer = selectedCustomer;
                        SelectedOrder.CustomerId = selectedCustomer.Id;

                        string[] prodarr = cbxProduct.SelectedItem.ToString().Split('|');
                        string selectedPro = prodarr[0].Trim();
                        SelectedmenuItem = _context.MenuItems.FirstOrDefault(m => m.Name == selectedPro);
                        SelectedOrder.MenuItem = SelectedmenuItem;
                        SelectedOrder.MenuItemId = SelectedmenuItem.Id;

                        SelectedOrder.Quantity = (int)numQuantity.Value;

                        SelectedOrder.Status = true;
                        cbxCustomer.Enabled = false;
                        btnOrdered.Enabled = true;
                        FillOrderList();
                        Reset();

                    }
                }
                else { MessageBox.Show("Please, Fill all fields"); }
            }
        }

        // Delete selected Menu Order
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!uniMetods.DeleteUser())
            {
                Reset();
                return;
            }
            SelectedOrder.Status = false;
            FillOrderList();
        }

        // Selected Menu for Update or Delete
        private void DgvMenuOrder_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedId = (int)dgvMenuOrder.Rows[e.RowIndex].Cells[0].Value;

            foreach (var item in menuOrders)
            {
                if (item.Status == true)
                {
                    SelectedOrder = menuOrders[e.RowIndex];

                }
            }

            cbxCustomer.SelectedItem = SelectedOrder.Customer.Lastname + " - " + SelectedOrder.Customer.Firstname;
            cbxProduct.SelectedItem = SelectedOrder.MenuItem.Name + " | " + SelectedOrder.MenuItem.Price.ToString("#.00") + " Azn";
            numQuantity.Value = SelectedOrder.Quantity;

            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnOrdered.Enabled = false;
        }

        // Created new Order 
        private void BtnOrdered_Click(object sender, EventArgs e)
        {
            if (menuOrders != null)
            {
                foreach (var item in menuOrders)
                {
                    item.Status = false;
                }
                _context.MenuOrders.AddRange(menuOrders);
                _context.Customers.Find(selectedCustomer.Id).Balance -= totalSum;
                cbxCustomer.Enabled = true;
                _context.SaveChanges();
                MessageBox.Show("The Order is being Prepared");
                dgvMenuOrder.Rows.Clear();
                cbxCustomer.SelectedIndex = -1;
                lblTotalPrice.Text = "";
                Reset();
                btnOrdered.Enabled = false;
            }
        }

        // Fill Product List ...
        public void FillOrderList()
        {
            dgvMenuOrder.Rows.Clear();
            totalSum = 0;
            foreach (MenuOrder item in menuOrders)
            {
                if (item.Status == true)
                {
                    totalSum += item.MenuItem.Price * item.Quantity;
                    if (totalSum > item.Customer.Balance)
                    {
                        MessageBox.Show("There is no amount needed on the balance");
                        Reset();
                        totalSum -= item.MenuItem.Price * item.Quantity;
                        cbxCustomer.SelectedIndex = -1;
                        cbxCustomer.Enabled = true;
                        return;
                    }
                    dgvMenuOrder.Rows.Add(
                        item.CustomerId,
                        item.Customer.Firstname + " " + item.Customer.Lastname,
                        item.MenuItem.Name,
                        item.MenuItem.Price.ToString("#.00") + " Azn",
                        item.Quantity,
                        (item.MenuItem.Price * item.Quantity).ToString("#.00") + " Azn",
                        item.Customer.Balance + " Azn");

                    lblTotalPrice.Text = totalSum.ToString("#.00") + " Azn";
                }
            }
            Reset();
        }

        // Fill Customer List
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

        // Fill Product List
        public void FillProductListCbx()
        {
            List<MenuItem> products = _context.MenuItems.ToList();
            foreach (MenuItem item in products)
            {
                if (item.Status == true)
                {
                    cbxProduct.Items.Add(item.Name + " | " + item.Price.ToString("#.00") + " Azn");
                }
            }
        }

        // Reset
        public void Reset()
        {
            cbxProduct.SelectedIndex = -1;
            numQuantity.Value = 0;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

       
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Reset();
            cbxCustomer.SelectedIndex = -1;
            cbxCustomer.Enabled = true;
            dgvMenuOrder.Rows.Clear();
            lblTotalPrice.Text = "";
            btnOrdered.Enabled = false;
            menuOrders.Clear();
        }
    }
}
