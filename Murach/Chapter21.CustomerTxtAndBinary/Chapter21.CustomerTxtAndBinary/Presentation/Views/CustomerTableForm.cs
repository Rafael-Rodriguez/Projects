using Chapter21.CustomerTxtAndBinary.Presentation.Controllers;
using System;
using System.Data;
using System.Windows.Forms;

namespace Chapter21.CustomerTxtAndBinary.Presentation.Views
{
    public partial class CustomerTableForm : Form, ICustomerTableView
    {
        private ICustomerTableController<ICustomerTableView> _controller;
        public CustomerTableForm(ICustomerTableController<ICustomerTableView> controller)
        {
            InitializeComponent();

            _controller = controller;
        }

        public ICustomerTableController<ICustomerTableView> Controller
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.OnSaveAsClicked(mMABooksDataSet.Customers.Cast<DataRow>());
        }
    }
}
