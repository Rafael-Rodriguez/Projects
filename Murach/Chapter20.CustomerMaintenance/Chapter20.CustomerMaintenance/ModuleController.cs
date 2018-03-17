using Chapter20.CustomerMaintenance.Views;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;
using Chapter20.CustomerMaintenance.Services;

namespace Chapter20.CustomerMaintenance
{
    public class ModuleController : IModuleController
    {
        private List<IView> _views;
        private List<IService> _services;

        public Form Run()
        {
            RegisterServices();

            RegisterViews();

            return GetView<CustomerMaintenanceForm>();
        }

        public FormType GetView<FormType>()
        {
            return _views.OfType<FormType>().Single();
        }

        public ServiceType GetService<ServiceType>()
        {
            return _services.OfType<ServiceType>().Single();
        }

        private void RegisterServices()
        {
            _services = new List<IService>
            {
                new ProgramFlowManager(this)
            };
        }

        private void RegisterViews()
        {
            _views = new List<IView>
            {
                {new CustomerMaintenanceForm(new CustomerMaintenanceController(this))},
                {new AddModifyCustomerForm(new AddModifyCustomerController(this))}
            };
        }

                
    }

}
