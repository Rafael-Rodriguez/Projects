using Chapter20.CustomerMaintenance.Models;

namespace Chapter20.CustomerMaintenance.Database
{
    public interface ICustomerDbo : IDbo
    {
        ICustomer GetCustomer(int customerId);

        int AddCustomer(ICustomer customer);

        bool UpdateCustomer(ICustomer oldCustomer, ICustomer newCustomer);

        bool DeleteCustomer(ICustomer customer);
    }
}
