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

        public Form Run()
        {
            RegisterServices();

            RegisterViews();

            return GetView<CustomerTableForm>();
        }

        private void RegisterServices()
        {
            _services = new List<IService>
            {
                new DialogService()
            };
        }

        private void RegisterViews()
        {
            _views = new List<IView>
            {
                new CustomerTableForm(new CustomerTableController(this, GetService<IDialogService>()))
            };
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
