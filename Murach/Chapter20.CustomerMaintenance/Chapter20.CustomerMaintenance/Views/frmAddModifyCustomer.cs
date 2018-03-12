using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
{
    public partial class frmAddModifyCustomer : Form
    {
        public frmAddModifyCustomer()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
