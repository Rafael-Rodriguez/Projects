using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
{
    public partial class frmAddModifyCustomer : Form, IView
    {
        public frmAddModifyCustomer(IModuleController controller)
        {
            Controller = controller;

            InitializeComponent();
        }

        public IModuleController Controller { get; }

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        
    }
}
