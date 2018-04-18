using System;

namespace Chapter23.CustomerInvoice
{
    public partial class CustomerInvoicesView : System.Windows.Forms.Form, IView
    {
        private IController<IView> _controller;

        public CustomerInvoicesView(IController<IView> controller)
        {
            InitializeComponent();

            Controller = controller;
        }

        public IController<IView> Controller
        {
            get
            {
                return _controller;
            }
            set
            {
                _controller = value;
                _controller.View = this;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Controller.OnLoad();
        }
    }
}
