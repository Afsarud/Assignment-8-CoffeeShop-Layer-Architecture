using System;
using System.Data;
using System.Windows.Forms;
using CoffeeShop.BLL;
using CoffeeShop.Model;

namespace CoffeeShop
{
    public partial class ItemUi : Form
    {
        private readonly ItemManager _itemManager=new ItemManager();

       Item _item=new Item();

       public ItemUi()
        {
            InitializeComponent();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            searchNameTextBox.Clear();


            _item.Name = nameTextBox.Text;

            if (String.IsNullOrEmpty(_item.Name))
            {
                MessageBox.Show(@"Enter item name");
                nameTextBox.Focus();
                return;
            }

            if ( String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show(@"Enter item price");
                priceTextBox.Focus();
                return;
            }


            if (_itemManager.UniqueItemName(_item))
            {
                MessageBox.Show(@"Item name already exits");
                return;
            }


            _item.Price = Convert.ToDouble(priceTextBox.Text);

            //call method
            bool isAdded= _itemManager.AddItem(_item);

            if (isAdded)
            {
               showDataGridView.DataSource= _itemManager.Display();
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
            //call method for clear all textbox 
            ClearAllInputField();
            searchNameTextBox.Clear();

            DataTable dataTable=new DataTable();

            //call display method
            dataTable=_itemManager.Display();

            if (dataTable.Rows.Count > 0)
            {
                showDataGridView.DataSource = _itemManager.Display();
            }
            else
            {
                MessageBox.Show(@"No data found");
            }
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            _item.Name = nameTextBox.Text;

            if (String.IsNullOrEmpty(_item.Name))
            {
                MessageBox.Show(@"Enter item name");
                nameTextBox.Focus();
                return;
            }


            if (_itemManager.UniqueItemName(_item))
            {
                MessageBox.Show(@"Item name already exits");
                nameTextBox.Focus();
                return;
            }
            if (priceTextBox.Text == "")
            {
                MessageBox.Show(@"Enter item price");
                priceTextBox.Focus();
                return;
            }

            _item.Price = Convert.ToDouble(priceTextBox.Text);

          
            if (_itemManager.UpdateItem(_item))
            {
                showDataGridView.DataSource = _itemManager.Display();
                MessageBox.Show(@"Updated Successfully");
                ClearAllInputField();
            }
            else
            {
                MessageBox.Show(@"Update failed");
            }

            addButton.Enabled = true;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (_itemManager.DeleteItem(_item))
            {
                showDataGridView.DataSource = _itemManager.Display();
                MessageBox.Show(@"Deleted Successfully");
                ClearAllInputField();
            }
            else
            {
                MessageBox.Show(@"Delete failed");
            }

            addButton.Enabled = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _item.Name = searchNameTextBox.Text;
            if (String.IsNullOrEmpty(_item.Name))
            {
                MessageBox.Show(@"Enter item name");
                searchNameTextBox.Focus();
                return;
            }

            
            DataTable dataTable=new DataTable();
            //call a method
            dataTable = _itemManager.SearchItemByName(_item);

            if (dataTable.Rows.Count>0)
            {
                showDataGridView.DataSource = dataTable;
                MessageBox.Show(@"Data found");
                ClearAllInputField();
            }
            else
            {
                MessageBox.Show(@"Data not found");
            }
           
        }

        
        private void ItemUi_Load(object sender, EventArgs e)
        {

            updateButton.Enabled = false;
            deleteButton.Enabled = false;

            #region Display all item

            DataTable dataTable = new DataTable();

            dataTable = _itemManager.Display();

            if (dataTable.Rows.Count > 0)
            {
                showDataGridView.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show(@"No data found");
            }

            #endregion

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

                _item.Id = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                priceTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();

            }
        }
        private void ClearAllInputField()
        {
            nameTextBox.Clear();
            priceTextBox.Clear();
        }
    }
}
