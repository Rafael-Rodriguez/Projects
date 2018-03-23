using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Services;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public abstract class Controller<T> : IController<T> where T : IView
    {
        private T _view;

        protected Controller(IModuleController moduleController, IDialogService dialogService)
        {
            ModuleController = moduleController;

            DialogService = dialogService;
        }

        protected IModuleController ModuleController { get; }

        protected IDialogService DialogService { get; }

        public T View
        {
            get { return _view; }
            set
            {
                OnBeforeViewSet();
                _view = value;
                OnViewSet();
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected abstract void Dispose(bool disposing);

        protected virtual void OnBeforeViewSet() { }

        protected virtual void OnViewSet() { }
    }
}
