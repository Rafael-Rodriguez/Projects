using CustomerMaintenanceMVP.Models;

namespace CustomerMaintenanceMVP.Database
{
    public interface ICustomerRepository
    {
        void LoadAll();
        void SaveAll();
        void Save(ICustomer customer);
    }
}
