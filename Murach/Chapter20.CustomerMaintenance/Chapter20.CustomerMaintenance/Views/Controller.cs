using System;

namespace Chapter20.CustomerMaintenance.Views
{
    public abstract class Controller<T> : IController<T> where T : IView
    {
        private T _view;
        private readonly IModuleController _moduleController;

        public Controller(IModuleController moduleController)
        {
            _moduleController = moduleController;
        }

        protected IModuleController ModuleController
        {
            get { return _moduleController; }
        }

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
