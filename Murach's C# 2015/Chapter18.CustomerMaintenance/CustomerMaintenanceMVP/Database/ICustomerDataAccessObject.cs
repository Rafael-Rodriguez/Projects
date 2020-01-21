using System.Collections.Generic;
using CustomerMaintenanceMVP.Models;

namespace CustomerMaintenanceMVP.Database
{
    public interface ICustomerDataAccessObject : IDataAccessObject
    {
        IList<Customer> GetCustomers();
    }
}
