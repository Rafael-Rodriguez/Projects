using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CustomerMaintenanceMVP.Models;

namespace CustomerMaintenanceMVP.Database
{
    public class CustomerDataAccessObject : ICustomerDataAccessObject
    {
        public IList<Customer> GetCustomers()
        {
            var connection = new SqlConnection(Properties.Settings.Default.CustomerDataSet);

            const string selectStatement = "SELECT CustomerID, Name, Address, City, State, ZipCode " +
                                           "FROM Customers";

            var selectCommand = new SqlCommand(selectStatement, connection);

            var customers = new List<Customer>();

            try
            {
                connection.Open();

                using (var customerReader = selectCommand.ExecuteReader())
                {
                    if (customerReader.HasRows)
                    {
                        while (customerReader.Read())
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

                            customers.Add(customer);
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }

            return customers;
        }
    }
}
