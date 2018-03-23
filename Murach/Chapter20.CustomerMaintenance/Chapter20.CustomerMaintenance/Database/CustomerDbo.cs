using Chapter20.CustomerMaintenance.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Chapter20.CustomerMaintenance.Database
{
    public sealed class CustomerDbo : ICustomerDbo
    {
        public ICustomer GetCustomer(int customerId)
        {
            var connection = new SqlConnection(Properties.Settings.Default.MMABooksConnectionString);
            const string selectStatement = "SELECT CustomerID, Name, Address, City, State, ZipCode "
                                           + "FROM Customers WHERE CustomerID = @CustomerID";
            var selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@CustomerID", customerId);

            try
            {
                connection.Open();
                var customerReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if(customerReader.Read())
                {
                    var customer = new Customer
                    {
                        CustomerId = (int) customerReader["CustomerID"],
                        Name = customerReader["Name"].ToString(),
                        Address = customerReader["Address"].ToString(),
                        City = customerReader["City"].ToString(),
                        State = customerReader["State"].ToString(),
                        ZipCode = customerReader["ZipCode"].ToString()
                    };

                    return customer;
                }
                else
                {
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public int AddCustomer(ICustomer customer)
        {
            var connection = new SqlConnection(Properties.Settings.Default.MMABooksConnectionString);
            const string insertStatement = "INSERT INTO Customers (Name, Address, City, State, ZipCode)" +
                                           "VALUES (@Name, @Address, @City, @State, @ZipCode)";
            var insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@Name", customer.Name);
            insertCommand.Parameters.AddWithValue("@Address", customer.Address);
            insertCommand.Parameters.AddWithValue("@City", customer.City);
            insertCommand.Parameters.AddWithValue("@State", customer.State);
            insertCommand.Parameters.AddWithValue("@ZipCode", customer.ZipCode);

            int customerId;

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();

                const string selectStatement = "SELECT IDENT_CURRENT('Customers') FROM Customers";
                var selectCommand = new SqlCommand(selectStatement, connection);
                customerId = Convert.ToInt32(selectCommand.ExecuteScalar());
            }
            finally
            {
                connection.Close();
            }

            return customerId;
        }

        public bool UpdateCustomer(ICustomer oldCustomer, ICustomer newCustomer)
        {
            return false;
        }

        public bool DeleteCustomer(ICustomer customer)
        {
            return false;
        }
    }
}
