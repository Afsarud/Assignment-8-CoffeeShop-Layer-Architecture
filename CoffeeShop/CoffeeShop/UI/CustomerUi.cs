using CoffeeShop.BLL;
using CoffeeShop.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class CustomerUi : Form
    {
        private readonly CustomerManager _customerManager=new CustomerManager();

        Customer _customer=new Customer();
        public CustomerUi()
        {
            InitializeComponent();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _customer.Name = customerNameTextBox.Text;
            _customer.Contact = contactNoTextBox.Text;
            _customer.Address = addressTextBox.Text;

            if (String.IsNullOrEmpty(_customer.Name))
            {
                MessageBox.Show(@"Enter customer name");
                customerNameTextBox.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(_customer.Contact))
            {
                MessageBox.Show(@"Enter customer contact number");
                contactNoTextBox.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(_customer.Address))
            {
                MessageBox.Show(@"Enter customer address");
                addressTextBox.Focus();
                return;
            }
            else if (_customerManager.CheckUniqueCustomerName(_customer))
            {
                MessageBox.Show(@"Customer name already exist");
                customerNameTextBox.Focus();
                return;
            }

            bool isAdded = _customerManager.AddCustomer(_customer);


            if (isAdded)
            {
                showDataGridView.DataSource = _customerManager.Display();
                MessageBox.Show(@"Saved Successfully");
            }
            else
            {
                MessageBox.Show(@"Save failed");
            }

            ClearAllInputField();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            searchNameTextBox.Clear();
            ClearAllInputField();

            DataTable dataTable=new DataTable();

            dataTable = _customerManager.Display();

            if (dataTable.Rows.Count>0)
            {
                showDataGridView.DataSource = _customerManager.Display();
            }
            else
            {
                MessageBox.Show(@"No data found");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            _customer.Name = customerNameTextBox.Text;
            _customer.Contact = contactNoTextBox.Text;
            _customer.Address = addressTextBox.Text;

            if (String.IsNullOrEmpty(_customer.Name))
            {
                MessageBox.Show(@"Enter customer name");
                customerNameTextBox.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(_customer.Contact))
            {
                MessageBox.Show(@"Enter customer contact number");
                contactNoTextBox.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(_customer.Address))
            {
                MessageBox.Show(@"Enter customer address");
                addressTextBox.Focus();
                return;
            }
            else if (_customerManager.CheckUniqueCustomerName(_customer))
            {
                MessageBox.Show(@"Customer name already exist");
                customerNameTextBox.Focus();
                return;
            }

            if (_customerManager.UpdateCustomer(_customer))
            {
                showDataGridView.DataSource = _customerManager.Display();
                MessageBox.Show(@"Updated successfully");
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
                addButton.Enabled = true;
            }
            else
            {
                MessageBox.Show(@"Update failed");
            }

            ClearAllInputField();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            if (_customerManager.DeleteCustomer(_customer.Id))
            {
                showDataGridView.DataSource = _customerManager.Display();
                MessageBox.Show(@"Deleted successfully");
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
                addButton.Enabled = true;
            }
            else
            {
                MessageBox.Show(@"Delete failed");
            }
            ClearAllInputField();
           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _customer.Name = searchNameTextBox.Text;
            if (String.IsNullOrEmpty(_customer.Name))
            {
                MessageBox.Show(@"Enter customer name");
                searchNameTextBox.Focus();
                return;
            }

          
            DataTable dataTable=new DataTable();

            dataTable = _customerManager.SearchCustomerByName(_customer);
            if (dataTable.Rows.Count>0)
            {
                showDataGridView.DataSource = dataTable;
                MessageBox.Show(@"Data found");
            }
            else
            {
                MessageBox.Show(@"No data found");
            }
            ClearAllInputField();
        }

        private void ClearAllInputField()
        {
            customerNameTextBox.Clear();
            contactNoTextBox.Clear();
            addressTextBox.Clear();
        }

        private void CustomerUi_Load(object sender, EventArgs e)
        {


            DataTable dataTable = new DataTable();

            dataTable = _customerManager.Display();
            if (dataTable.Rows.Count > 0)
            {
                showDataGridView.DataSource = dataTable;
            }


            addButton.Enabled = true;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void showDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            searchNameTextBox.Clear();
            if (showDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                addButton.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;

                showDataGridView.CurrentRow.Selected = true;
                _customer.Id = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                customerNameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                contactNoTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Contact"].FormattedValue.ToString();
                addressTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();

            }
        }
    }
}
