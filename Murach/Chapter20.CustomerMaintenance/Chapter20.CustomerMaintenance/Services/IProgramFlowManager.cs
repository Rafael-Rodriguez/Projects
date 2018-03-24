using Chapter20.CustomerMaintenance.Models;
using Chapter20.CustomerMaintenance.Presentation.Views;

namespace Chapter20.CustomerMaintenance.Services
{
    public interface IProgramFlowManager : IService
    {
        void AddNewCustomer();
        void ModifyExistingCustomer(ICustomer customer);
        void DeleteExistingCustomer(ICustomer customer);
    }
}
