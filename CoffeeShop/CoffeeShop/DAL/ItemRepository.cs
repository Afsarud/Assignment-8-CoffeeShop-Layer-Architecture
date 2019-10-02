using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CoffeeShop.Model;

namespace CoffeeShop.DAL
{
    public class ItemRepository
    {
        private string connectionString = @"Data Source = KMHASAN; Initial Catalog =CoffeeShop; Integrated Security = True";

        
        public bool UniqueItemName(Item item)
        {
            bool isUnique = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"SELECT * FROM Items WHERE Name='" + item.Name + "' AND Id !="+item.Id+" ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                DataTable dataTable = new DataTable();

                //open connection
                sqlConnection.Open();

                sqlDataAdapter.Fill(dataTable);

                //close connection
                sqlConnection.Close();

                if (dataTable.Rows.Count > 0)
                {
                    isUnique = true;
                }

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);

            }

            return isUnique;
        }

        public bool AddItem(Item item)
        {
       
            bool isAdded = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"INSERT INTO Items VALUES('" + item.Name + "'," + item.Price + ")";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                //close connection
                sqlConnection.Close();

                if (isExecuted > 0)
                {
                    isAdded = true;
                }

            }
            catch (Exception exception)
            {
               // MessageBox.Show(exception.Message);
            }

            return isAdded;
        }

        public DataTable Display()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string queryString = @"SELECT * FROM Items;";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                
                //open connection
                sqlConnection.Open();

                sqlDataAdapter.Fill(dataTable);

                //close connection
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }
            return dataTable;
        }

        public bool UpdateItem(Item item)
        {
            bool isUpdated = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"UPDATE Items SET Name='" + item.Name + "',Price=" + item.Price+ " WHERE Id=" + item.Id + "";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                //close connection
                sqlConnection.Close();

                if (isExecuted > 0)
                {
                    isUpdated = true;
                }
                
            }
            catch (Exception exception)
            {
               // MessageBox.Show(exception.Message);
            }

            return isUpdated;
        }

        public bool DeleteItem(Item item)
        {
            bool isDeleted = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"DELETE FROM Items WHERE Id=" + item.Id + "";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                //close connection
                sqlConnection.Close();

                if (isExecuted > 0)
                {
                    isDeleted = true;
                }

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }

            return isDeleted;
        }

        public DataTable SearchItemByName(Item item)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"SELECT * FROM Items WHERE Name='" + item.Name + "' ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                
                //open connection
                sqlConnection.Open();

                sqlDataAdapter.Fill(dataTable);

                //close connection
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
               // MessageBox.Show(exception.Message);
            }
            return dataTable;
        }

    }
}
