using Chapter20.CustomerMaintenance.Presentation.Views;

namespace Chapter20.CustomerMaintenance.Services
{
    public interface IProgramFlowManager : IService
    {
        void AddNewCustomer();
        void ModifyExistingCustomer(CustomerEventArgs customerEventArgs);
    }
}
