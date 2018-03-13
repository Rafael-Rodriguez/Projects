using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
{
    public abstract class AbstractView : Form, IView
    {
        protected internal IDomainController Controller {get; private set;}

        public AbstractView(IDomainController controller)
        {
            Controller = controller;
        }
    }
}
