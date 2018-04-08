using Chapter21.CustomerTxtAndBinary.Presentation.Controllers;
using Chapter21.CustomerTxtAndBinary.Presentation.Views;
using Chapter21.CustomerTxtAndBinary.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Chapter21.CustomerTxtAndBinary.Components;

namespace Chapter21.CustomerTxtAndBinary
{
    public class ModuleController : IModuleController
    {
        private List<IView> _views;
        private List<IService> _services;
        private List<ICustomerTableWriter> _customerTableWriters;
        private List<ICustomerTableReader> _customerTableReaders;

        public Form Run()
        {
            RegisterServices();

            RegisterTableWriters();

            RegisterTableReaders();

            RegisterViews();

            return GetView<ExportCustomersForm>();
        }

        private void RegisterServices()
        {
            _services = new List<IService>
            {
                new DialogService()
            };
        }

        private void RegisterTableWriters()
        {
            _customerTableWriters = new List<ICustomerTableWriter>()
            {
                new CustomerTableWriter()
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
                new ExportCustomersForm(new ExportCustomersController(this, GetService<DialogService>(), GetCustomerTableWriter<CustomerTableWriter>())),
                new ImportCustomersForm(new ImportCustomersController(this, GetService<DialogService>(),GetCustomerTableReader<CustomerTableReader>()))
            };
        }

        public TCustomerTableWriterType GetCustomerTableWriter<TCustomerTableWriterType>()
        {
            return _customerTableWriters.OfType<TCustomerTableWriterType>().Single();
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
