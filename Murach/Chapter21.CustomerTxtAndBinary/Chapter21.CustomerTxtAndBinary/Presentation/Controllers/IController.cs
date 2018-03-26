using Chapter21.CustomerTxtAndBinary.Presentation.Views;

namespace Chapter21.CustomerTxtAndBinary.Presentation.Controllers
{
    public interface IController<T> where T : IView
    {
        T View { get; set; }
    }
}
