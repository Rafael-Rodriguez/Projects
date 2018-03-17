using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
{
    public partial class AddModifyCustomerForm : Form, IView
    {
        private IController<IView> _controller;

        public AddModifyCustomerForm()
        {
            InitializeComponent();
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
        }

        
    }
}
