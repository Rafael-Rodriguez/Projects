using System;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
{
    public partial class AddModifyCustomerForm : Form, IAddModifyCustomerView
    {
        public event EventHandler<CustomerEventArgs> AcceptButtonClicked;
        public event EventHandler<CustomerEventArgs> CancelButtonClicked;

        private IController<AddModifyCustomerForm> _controller;

        public AddModifyCustomerForm(IController<AddModifyCustomerForm> controller)
        {
            InitializeComponent();

            Controller = controller;
        }

        public IController<AddModifyCustomerForm> Controller
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

        DialogResult IAddModifyCustomerView.ShowDialog()
        {
            return ShowDialog();
        }
    }
}
