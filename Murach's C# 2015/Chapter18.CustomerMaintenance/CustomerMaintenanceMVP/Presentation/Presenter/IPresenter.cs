using CustomerMaintenanceMVP.Presentation.View;

namespace CustomerMaintenanceMVP.Presentation.Presenter
{
    public interface IPresenter<T> where T : IView
    {
        T View { get; set; }

        void OnLoad();
    }
}
