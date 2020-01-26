using CustomerMaintenanceMVP.Presentation.View;

namespace CustomerMaintenanceMVP.Presentation.Presenter
{
    public interface IPresenter<T> where T : ICustomerMaintenanceView
    {
        T View { get; set; }

        void OnLoad();
    }
}
