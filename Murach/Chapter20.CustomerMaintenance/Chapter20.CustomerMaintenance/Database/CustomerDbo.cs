using Chapter20.CustomerMaintenance.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Chapter20.CustomerMaintenance.Database
{
    public sealed class CustomerDbo : IDbo
    {
        public Customer GetCustomer(int customerId)
        {
            var connection = new SqlConnection(Properties.Settings.Default.MMABooksConnectionString);
            var selectStatement = 
                "SELECT CustomerID, Name, Address, City, State, ZipCode "
               + "FROM Customers WHERE CustomerID = @CustomerID";
            var selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@CustomerID", customerId);

            try
            {
                connection.Open();
                var customerReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if(customerReader.Read())
                {
                    var customer = new Customer();
                    customer.CustomerId = (int)customerReader["CustomerID"];
                    customer.Name = customerReader["Name"].ToString();
                    customer.Address = customerReader["Address"].ToString();
                    customer.City = customerReader["City"].ToString();
                    customer.State = customerReader["State"].ToString();
                    customer.ZipCode = customerReader["ZipCode"].ToString();

                    return customer;
                }
                else
                {
                    return null;
                }
            }
            catch(SqlException se)
            {
                throw se;
            }
            finally
            {
                connection.Close();
            }
        }

        public int AddCustomer(Customer customer)
        {
            var connection = new SqlConnection(Properties.Settings.Default.MMABooksConnectionString);
            var insertStatement =
                "INSERT INTO Customers (Name, Address, City, State, ZipCode)" +
                "VALUES (@Name, @Address, @City, @State, @ZipCode)";
            var insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@Name", customer.Name);
            insertCommand.Parameters.AddWithValue("@Address", customer.Address);
            insertCommand.Parameters.AddWithValue("@City", customer.City);
            insertCommand.Parameters.AddWithValue("@State", customer.State);
            insertCommand.Parameters.AddWithValue("@ZipCode", customer.ZipCode);

            int customerID = -1;

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();

                var selectStatement = "SELECT IDENT_CURRENT('Customers') FROM Customers";
                var selectCommand = new SqlCommand(selectStatement, connection);
                customerID = Convert.ToInt32(selectCommand.ExecuteScalar());
            }
            catch(SqlException se)
            {
                throw se;
            }
            finally
            {
                connection.Close();
            }

            return customerID;
        }

        public bool UpdateCustomer(Customer oldCustomer, Customer newCustomer)
        {
            return false;
        }

        public bool DeleteCustomer(Customer customer)
        {
            return false;
        }
    }
}
