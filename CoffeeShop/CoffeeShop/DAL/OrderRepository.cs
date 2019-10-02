using System;
using System.Data;
using System.Data.SqlClient;
using CoffeeShop.Model;

namespace CoffeeShop.DAL
{
    public class OrderRepository
    {
        private string connectionString = @"Data Source = KMHASAN; Initial Catalog =CoffeeShop; Integrated Security = True";

        public bool AddOrder(Order order)
        {
            
            bool isAdded = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"INSERT INTO Orders VALUES('" + order.ItemId + "','" + order.CustomerId + "'," + order.Quantity + "," + order.TotalPrice + ")";
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

                string queryString = @" SELECT o.Id,c.Name As Customer,i.Name As Item,Quantity,i.Price AS Price,TotalPrice FROM Orders AS o
	                                    LEFT JOIN Items AS i ON i.Id=o.ItemId
	                                    LEFT JOIN Customers AS c ON c.Id=o.CustomerId";

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

        public DataTable GetAllItem()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"SELECT Id,Name FROM Items";
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

        public DataTable GetAllCustomer()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"SELECT Id,Name FROM Customers";
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

        public double GetItemPriceByItemId(int id)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"SELECT Price FROM Items WHERE Id="+id+" ";
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

            return Convert.ToDouble(dataTable.Rows[0][0]);
        }

    }
}
