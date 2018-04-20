using Chapter23.CustomerInvoice.Presentation.Views;

namespace Chapter23.CustomerInvoice.Presentation.Controllers
{
    public interface IController<T> where T: IView
    {
        T View { get; set; }

        void OnLoad();
    }
}