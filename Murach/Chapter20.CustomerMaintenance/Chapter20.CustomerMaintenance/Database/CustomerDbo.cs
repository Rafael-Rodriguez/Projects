using Chapter20.CustomerMaintenance.Models;

namespace Chapter20.CustomerMaintenance.Database
{
    public class CustomerDbo : IDbo
    {
        public Customer GetCustomer(int customerId)
        {
            return null;
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
