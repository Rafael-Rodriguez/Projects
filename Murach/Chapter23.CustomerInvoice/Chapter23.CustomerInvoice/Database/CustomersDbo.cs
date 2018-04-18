using Chapter23.CustomerInvoice.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Chapter23.CustomerInvoice.Database
{
    public sealed class CustomersDbo : ICustomersDbo
    {
        public IList<Customer> GetCustomers()
        {
            var connection = new SqlConnection(Properties.Settings.Default.MMABooksConnectionString);
            const string selectStatement = "SELECT CustomerID, Name, Address, City, State, ZipCode" +
                                            "FROM Customers";
            var selectCommand = new SqlCommand(selectStatement, connection);

            List<Customer> customers = new List<Customer>();

            try
            {
                connection.Open();
                using (var customerReader = selectCommand.ExecuteReader())
                {
                    if(customerReader.HasRows)
                    {
                        while(customerReader.Read())
                        {
                            var customer = new Customer
                            {
                                CustomerId = (int)customerReader["CustomerID"],
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
