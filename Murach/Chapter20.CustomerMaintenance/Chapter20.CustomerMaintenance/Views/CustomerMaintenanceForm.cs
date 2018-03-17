using System;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
{
    public partial class CustomerMaintenanceForm : Form, IView
    {
        public event EventHandler<CustomerEventArgs> AddButtonClicked;
        public event EventHandler<CustomerEventArgs> ModifyButtonClicked;
        public event EventHandler<CustomerEventArgs> DeleteButtonClicked; 

        private IController<IView> _controller;
          
        public CustomerMaintenanceForm()
        {
            InitializeComponent();
        }

        public IController<IView> Controller {
            get { return _controller; }
            set
            {
                _controller = value;
                _controller.View = this;
            }
        }

        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddModifyCustomerForm();
            DialogResult result = addCustomerForm.ShowDialog();

            var handler = AddButtonClicked;
            handler?.Invoke(this, new CustomerEventArgs());
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var handler = ModifyButtonClicked;
            handler?.Invoke(this, new CustomerEventArgs());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var handler = DeleteButtonClicked;
            handler?.Invoke(this, new CustomerEventArgs());
        }
    }
}
