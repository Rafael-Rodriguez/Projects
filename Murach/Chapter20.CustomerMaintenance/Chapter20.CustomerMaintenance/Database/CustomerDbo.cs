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
            var connection = new SqlConnection(Properties.Settings.Default.MMABooksConnectionString);
            const string updateStatement = "UPDATE Customers SET " +
                "Name = @NewName, " +
                "Address = @NewAddress, " +
                "City = @NewCity, " +
                "State = @NewState, " +
                "ZipCode = @NewZipCode " +
                "WHERE CustomerID = @CustomerID " +
                "AND Name = @OldName " +
                "AND Address = @OldAddress " +
                "AND City = @OldCity " +
                "AND State = @OldState " +
                "AND ZipCode = @OldZipCode";
            var updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewName", newCustomer.Name);
            updateCommand.Parameters.AddWithValue("@NewAddress", newCustomer.Address);
            updateCommand.Parameters.AddWithValue("@NewCity", newCustomer.City);
            updateCommand.Parameters.AddWithValue("@NewState", newCustomer.State);
            updateCommand.Parameters.AddWithValue("@NewZipCode", newCustomer.ZipCode);
            updateCommand.Parameters.AddWithValue("@CustomerID", oldCustomer.CustomerId);
            updateCommand.Parameters.AddWithValue("@OldName", oldCustomer.Name);
            updateCommand.Parameters.AddWithValue("@OldAddress", oldCustomer.Address);
            updateCommand.Parameters.AddWithValue("@OldCity", oldCustomer.City);
            updateCommand.Parameters.AddWithValue("@OldState", oldCustomer.State);
            updateCommand.Parameters.AddWithValue("@OldZipCode", oldCustomer.ZipCode);

            try
            {
                connection.Open();

                var count = updateCommand.ExecuteNonQuery();
                if(count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                connection.Close();
            }

        }

        public bool DeleteCustomer(ICustomer customer)
        {
            return false;
        }
    }
}
