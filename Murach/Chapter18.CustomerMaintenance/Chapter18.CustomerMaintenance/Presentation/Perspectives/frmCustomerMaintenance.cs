using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            catch(DBConcurrencyException)
            {
                MessageBox.Show("Someone has modified the customer database.  The application will update the table now.  Please resubmit.");
                this.customersTableAdapter.Fill(mMABooksDataSet.Customers);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                customersBindingSource.CancelEdit();
            }
            catch(SqlException se)
            {
                MessageBox.Show("Database error # " + se.Number + ": " + se.Message, se.GetType().ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.statesDataSet.States);

            // TODO: This line of code loads data into the 'mMABooksDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);

            
            stateToolStripComboBox.ComboBox.DataSource = this.statesDataSet.States;
            stateToolStripComboBox.ComboBox.DisplayMember = "StateCode";
            stateToolStripComboBox.ComboBox.ValueMember = "StateCode";

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
                var customerID = Convert.ToInt32(customerIdToolStripTextBox.Text);

                this.customersTableAdapter.FillByCustomerID(this.mMABooksDataSet.Customers, customerID);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillByZipCodeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillByZipCode(this.mMABooksDataSet.Customers, zipCodeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByStateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillByState(this.mMABooksDataSet.Customers, stateToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            this.customersBindingSource.CancelEdit();
        }

        private void toolStripButtonGetAllCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);
            }
            catch(SqlException se)
            {
                MessageBox.Show("Database error # " + se.Number + ": " + se.Message, se.GetType().ToString());
            }
        }
    }
}
