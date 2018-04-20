using System.Collections.Generic;
using Chapter23.CustomerInvoice.Database;
using Chapter23.CustomerInvoice.Models;
using Chapter23.CustomerInvoice.Presentation.Views;

namespace Chapter23.CustomerInvoice.Presentation.Controllers
{
    public class CustomerInvoicesController : IController<IView>
    {
        public CustomerInvoicesController(IModuleController _moduleController)
        {
            ModuleController = _moduleController;
        }

        public IModuleController ModuleController { get; set; }

        public IView View { get; set; }

        public void OnLoad()
        {
            var customers = GetCustomers();
            var invoices = GetInvoices();


        }

        private IEnumerable<Invoice> GetInvoices()
        {
            return GetInvoicesDataAccessObject().GetInvoices();
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return GetCustomersDataAccessObject().GetCustomers();
        }

        private ICustomersDataAccessObject GetCustomersDataAccessObject()
        {
            return ModuleController.GetCollection<IDatabaseAccessObjectCollection>().GetDataAccessObject<ICustomersDataAccessObject>();
        }

        private IInvoicesDataAccessObject GetInvoicesDataAccessObject()
        {
            return ModuleController.GetCollection<IDatabaseAccessObjectCollection>().GetDataAccessObject<IInvoicesDataAccessObject>();
        }
    }
}
