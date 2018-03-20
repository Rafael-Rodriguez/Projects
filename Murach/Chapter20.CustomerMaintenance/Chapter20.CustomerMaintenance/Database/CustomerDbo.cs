using Chapter20.CustomerMaintenance.Models;
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
            return -1;
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
