using Chapter20.CustomerMaintenance.Controller;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
{
    public partial class frmAddModifyCustomer : AbstractView
    {
        public frmAddModifyCustomer(IController controller) : base(controller)
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
