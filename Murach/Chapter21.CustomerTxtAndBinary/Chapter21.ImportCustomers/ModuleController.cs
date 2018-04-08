using Chapter21.CustomerTxtAndBinary.Components;
using Chapter21.CustomerTxtAndBinary.Presentation.Controllers;
using Chapter21.CustomerTxtAndBinary.Presentation.Views;
using Chapter21.CustomerTxtAndBinary.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chapter21.CustomerTxtAndBinary
{
    public class ModuleController : IModuleController
    {
        private List<IView> _views;
        private List<IService> _services;
        private List<ICustomerTableReader> _customerTableReaders;

        public Form Run()
        {
            RegisterServices();

            RegisterTableReaders();

            RegisterViews();

            return GetView<ImportCustomersForm>();
        }

        private void RegisterServices()
        {
            _services = new List<IService>
            {
                new DialogService(),
            };
        }

        private void RegisterTableReaders()
        {
            _customerTableReaders = new List<ICustomerTableReader>()
            {
                new CustomerTableReader()
            };
        }

        private void RegisterViews()
        {
            _views = new List<IView>
            {
                new ImportCustomersForm(new ImportCustomersController(this, GetService<DialogService>(),GetCustomerTableReader<CustomerTableReader>()))
            };
        }

        public TCustomerTableReaderType GetCustomerTableReader<TCustomerTableReaderType>()
        {
            return _customerTableReaders.OfType<TCustomerTableReaderType>().Single();
        }

        public TServiceType GetService<TServiceType>()
        {
            return _services.OfType<TServiceType>().Single();
        }

        public TFormType GetView<TFormType>()
        {
            return _views.OfType<TFormType>().Single();
        }
    }
}
