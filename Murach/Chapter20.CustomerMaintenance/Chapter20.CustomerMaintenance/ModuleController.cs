using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Chapter20.CustomerMaintenance.Services;
using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Presentation.Controllers;

namespace Chapter20.CustomerMaintenance
{
    public class ModuleController : IModuleController
    {
        private List<IView> _views;
        private List<IService> _services;
        private List<ICollection> _collections;

        public Form Run()
        {
            RegisterServices();

            RegisterCollections();

            RegisterViews();

            return GetView<CustomerMaintenanceForm>();
        }

        public TFormType GetView<TFormType>()
        {
            return _views.OfType<TFormType>().Single();
        }

        public TServiceType GetService<TServiceType>()
        {
            return _services.OfType<TServiceType>().Single();
        }

        public TCollectionType GetCollection<TCollectionType>()
        {
            return _collections.OfType<TCollectionType>().Single();
        }

        private void RegisterServices()
        {
            _services = new List<IService>
            {
                new ProgramFlowManager(this),
                new DialogService()
            };
        }

        private void RegisterCollections()
        {
            _collections = new List<ICollection>
            {
                new DatabaseObjectCollection()
            };
        }

        private void RegisterViews()
        {
            _views = new List<IView>
            {
                new CustomerMaintenanceForm(new CustomerMaintenanceController(this, GetService<IDialogService>())),
                new AddCustomerForm(new AddCustomerController(this, GetService<IDialogService>())),
                new ModifyCustomerForm(new ModifyCustomerController(this, GetService<IDialogService>())),
                new DeleteCustomerForm(new DeleteCustomerController(this, GetService<IDialogService>()))
            };
        }

                
    }

}
