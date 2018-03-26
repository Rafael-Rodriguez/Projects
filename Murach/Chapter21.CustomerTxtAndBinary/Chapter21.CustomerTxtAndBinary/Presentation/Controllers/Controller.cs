using Chapter21.CustomerTxtAndBinary.Presentation.Views;
using System;

namespace Chapter21.CustomerTxtAndBinary.Presentation.Controllers
{
    public class Controller<T> : IController<T> where T : IView
    {
        private T _view;
        public T View
        {
            get
            {
                return _view;
            }

            set
            {
                _view = value;
            }
        }
    }
}
