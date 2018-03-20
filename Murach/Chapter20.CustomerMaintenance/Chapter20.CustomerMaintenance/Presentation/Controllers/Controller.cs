﻿using Chapter20.CustomerMaintenance.Presentation.Views;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public abstract class Controller<T> : IController<T> where T : IView
    {
        private T _view;

        protected Controller(IModuleController moduleController)
        {
            ModuleController = moduleController;
        }

        protected IModuleController ModuleController { get; }

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