using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter18.CustomerMaintenance
{
    public partial class frmCustomerMaintenance : Form
    {
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            try
            {
                this.customersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                customersBindingSource.CancelEdit();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.statesDataSet.States);
            // TODO: This line of code loads data into the 'mMABooksDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);

        }

        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            OnCustomerIDSelected();
        }

        private void customerIDToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                OnCustomerIDSelected();
            }
        }

        private void OnCustomerIDSelected()
        {
            try
            {
                var customerID = Convert.ToInt32(customerIDToolStripTextBox.Text);

                this.customersTableAdapter.FillByCustomerID(this.mMABooksDataSet.Customers, customerID);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
