using System;
using System.Data;
using System.Windows.Forms;
using CoffeeShop.BLL;
using CoffeeShop.Model;

namespace CoffeeShopWindowsFormsApp
{
    public partial class OrderUi : Form
    {
        
        OrderManager _orderManager=new OrderManager();
        Order _order=new Order();

        public OrderUi()
        {
            InitializeComponent();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (IsCustomerAndOrderComboBoxEmpty())
            {
                MessageBox.Show(@"Please, Add Customer and Item first !");
                return;
            }
            if (quantityNumericUpDown.Text=="0")
            {
                MessageBox.Show(@"Item quantity can not be zero !");
                quantityNumericUpDown.Focus();
                return;
            }

            
            _order.Quantity = Convert.ToInt32(quantityNumericUpDown.Text);
            _order.ItemId = Convert.ToInt32(itemComboBox.SelectedValue);
            _order.CustomerId = Convert.ToInt32(customerNameComboBox.SelectedValue);

            
            if (_orderManager.AddOrder(_order))
            {
               showDataGridView.DataSource= _orderManager.Display();

               showTotalPriceTextBox.Text = _order.TotalPrice.ToString();

                MessageBox.Show(@"Saved successfully");

            }
            else
            {
                MessageBox.Show(@"Save failed");
               
            }


        }

        private void OrderUi_Load(object sender, EventArgs e)
        {

            #region Display all order

            DataTable dataTable = new DataTable();

            dataTable = _orderManager.Display();

            if (dataTable.Rows.Count > 0)
            {
                showDataGridView.DataSource = _orderManager.Display();

            }

            #endregion

            //make combobox not editable
            customerNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            itemComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //load customer name and item name to combobox
            customerNameComboBox.DataSource = _orderManager.GetAllCustomer();
            itemComboBox.DataSource = _orderManager.GetAllItem();

        }

        private bool IsCustomerAndOrderComboBoxEmpty()
        {
            bool isEmpty = false;

            DataTable customerDataTable = new DataTable();
            DataTable itemDataTable = new DataTable();

            customerDataTable = _orderManager.GetAllCustomer();

            itemDataTable= _orderManager.GetAllItem();

            if (customerDataTable.Rows.Count == 0 || itemDataTable.Rows.Count == 0)
            {
                isEmpty = true;
            }

            return isEmpty;
        }
    }
}
