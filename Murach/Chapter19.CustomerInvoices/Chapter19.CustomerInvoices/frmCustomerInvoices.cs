using System;
using System.Windows.Forms;

namespace Chapter19.CustomerInvoices
{
    public partial class frmCustomerInvoices : Form
    {
        public frmCustomerInvoices()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = customerIDToolStripTextBox.TextBox;
        }

        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillByCustomerID(this.mMABooksDataSet.Customers, ((int)(System.Convert.ChangeType(customerIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
