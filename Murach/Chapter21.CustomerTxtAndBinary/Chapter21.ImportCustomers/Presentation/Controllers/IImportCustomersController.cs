using Chapter21.CustomerTxtAndBinary.Presentation.Views;

namespace Chapter21.CustomerTxtAndBinary.Presentation.Controllers
{
    public interface IImportCustomerController<T> : IController<T> where T : IView
    {
        void OnImportCustomersClicked();
    }
}
