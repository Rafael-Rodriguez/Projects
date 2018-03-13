using Chapter20.CustomerMaintenance.Controller;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
{
    public abstract class AbstractView : Form, IView
    {
        protected internal IController Controller {get; private set;}

        public AbstractView(IController controller)
        {
            Controller = controller;
        }
    }
}
