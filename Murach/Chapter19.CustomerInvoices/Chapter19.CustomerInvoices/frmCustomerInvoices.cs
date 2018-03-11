using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ActiveControl = customerIDToolStripTextBox.TextBox;
        }

        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerID = Convert.ToInt32(customerIDToolStripTextBox.Text);

                customersTableAdapter.FillByCustomerID(this.mMABooksDataSet.Customers, customerID);

                if(customersBindingSource.Count > 0)
                {
                    this.invoicesTableAdapter.FillByCustomerID(mMABooksDataSet.Invoices, customerID);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
