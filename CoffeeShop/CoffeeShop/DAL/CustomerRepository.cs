using System;
using System.Data;
using System.Data.SqlClient;
using CoffeeShop.Model;
namespace CoffeeShop.DAL
{
    public class CustomerRepository
    {
        private string connectionString = @"Data Source = KMHASAN; Initial Catalog =CoffeeShop; Integrated Security = True";
        public bool CheckUniqueCustomerName(Customer customer)
        {
            bool isUniqueName = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"SELECT * FROM Customers WHERE Name='" + customer.Name + "' AND Id != "+customer.Id+" ";
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
                    isUniqueName = true;
                }

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);

            }

            return isUniqueName;
        }

        public bool AddCustomer(Customer customer)
        {
            bool isAdded = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"INSERT INTO Customers VALUES('" + customer.Name + "','" + customer.Contact + "','" + customer.Address + "')";
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
                //MessageBox.Show(exception.Message);
            }

            return isAdded;
        }

        public DataTable Display()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"SELECT * FROM Customers";
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

        public bool UpdateCustomer(Customer customer)
        {
            bool isUpdated = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"UPDATE Customers SET Name='" + customer.Name + "',Contact='" + customer.Contact + "',Address='" + customer.Address + "' WHERE Id=" + customer.Id + "";
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
                //MessageBox.Show(exception.Message);
            }

            return isUpdated;
        }

        public bool DeleteCustomer(int id)
        {
            bool isDeleted = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"DELETE FROM Customers WHERE Id=" + id + "";
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

        public DataTable SearchCustomerByName(Customer customer)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryString = @"SELECT * FROM Customers WHERE Name='" + customer.Name + "'  ";
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

        
    }
}
