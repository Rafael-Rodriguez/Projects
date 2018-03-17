using System;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
{
    public partial class AddModifyCustomerForm : Form, IView
    {
        public event EventHandler<CustomerEventArgs> AcceptButtonClicked;
        public event EventHandler<CustomerEventArgs> CancelButtonClicked;

        private IController<IView> _controller;

        public AddModifyCustomerForm(IController<IView> controller)
        {
            InitializeComponent();

            Controller = controller;
        }

        public IController<IView> Controller
        {
            get { return _controller; }
            set
            {
                _controller = value;
                _controller.View = this;
            }
        }

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;

            var handler = AcceptButtonClicked;
            handler?.Invoke(this, new CustomerEventArgs());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var handler = CancelButtonClicked;
            handler?.Invoke(this, new CustomerEventArgs());
        }
    }
}
