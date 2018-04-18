using Chapter23.CustomerInvoice.Database;
using Chapter23.CustomerInvoice.Models;
using System;
using System.Collections.Generic;

namespace Chapter23.CustomerInvoice
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

        private IList<Invoice> GetInvoices()
        {
            return GetInvoicesDbo().GetInvoices();
        }

        private IList<Customer> GetCustomers()
        {
            return GetCustomerDbo().GetCustomers();
        }

        private ICustomersDbo GetCustomerDbo()
        {
            return ModuleController.GetCollection<IDatabaseObjectCollection>().GetDbo<ICustomersDbo>();
        }

        private IInvoicesDbo GetInvoicesDbo()
        {
            return ModuleController.GetCollection<IDatabaseObjectCollection>().GetDbo<IInvoicesDbo>();
        }
    }
}
