using Chapter21.CustomerTxtAndBinary.Presentation.Controllers;
using System.Windows.Forms;

namespace Chapter21.CustomerTxtAndBinary.Presentation.Views
{
    public partial class ImportCustomersForm : Form, IImportCustomersView
    {
        private IImportCustomerController<IImportCustomersView> _controller;

        public ImportCustomersForm(IImportCustomerController<IImportCustomersView> controller)
        {
            InitializeComponent();

            Controller = controller;
        }

        public IImportCustomerController<IImportCustomersView> Controller
        {
            get { return _controller; }
            set { _controller = value;  _controller.View = this; }
        }

        public DataGridView DataGrid
        {
            get { return dataGridView; }
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void importCustomerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Controller.OnImportCustomersClicked();
        }
    }
}
