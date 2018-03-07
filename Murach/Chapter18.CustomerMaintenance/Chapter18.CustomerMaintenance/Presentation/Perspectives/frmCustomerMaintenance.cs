using System;
using System.Data;
using System.Data.SqlClient;
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
            if (customersBindingSource.Count > 0)
            {
                if (IsValidData())
                {
                    try
                    {
                        customersBindingSource.EndEdit();
                        tableAdapterManager.UpdateAll(this.mMABooksDataSet);
                    }
                    catch(ArgumentException ae)
                    {
                        MessageBox.Show(ae.Message, "Argument Exception");
                        customersBindingSource.CancelEdit();
                    }
                    catch (DBConcurrencyException)
                    {
                        MessageBox.Show("Someone has modified the customer database.  The application will update the table now.  Please resubmit.");
                        this.customersTableAdapter.Fill(mMABooksDataSet.Customers);
                    }
                    catch (DataException de)
                    {
                        MessageBox.Show(de.Message, de.GetType().ToString());
                        customersBindingSource.CancelEdit();
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show($"Database error # {se.Number} : {se.Message}", se.GetType().ToString());
                    }
                }
            }
            else
            {
                try
                {
                    tableAdapterManager.UpdateAll(mMABooksDataSet);
                }
                catch(DBConcurrencyException)
                {
                    MessageBox.Show("A concurrency error occurred.  Some rows were not updated.", "Concurrency Exception");
                    customersTableAdapter.Fill(mMABooksDataSet.Customers);
                }
                catch(SqlException se)
                {
                    MessageBox.Show($"Database error # {se.Number} : {se.Message}", se.GetType().ToString());
                }
            }
        }

        private bool IsValidData()
        {
            return
                IsPresent(nameTextBox, "Name") &&
                IsPresent(addressTextBox, "Address") &&
                IsPresent(cityTextBox, "City") &&
                IsPresent(stateNameComboBox, "State") &&
                IsPresent(zipCodeTextBox, "Zip Code");
        }

        private bool IsPresent(ComboBox comboBox, string name)
        {
            if(comboBox.SelectedIndex == -1)
            {
                MessageBox.Show($"{name} is a required field.", "Entry Error");
                comboBox.Focus();
                return false;
            }

            return true;
        }

        private bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show($"{name} is a required field", "Entry error");
                textBox.Focus();
                return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.statesDataSet.States);
            stateNameComboBox.SelectedIndex = -1;
            
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

                if(customersBindingSource.Count == 0)
                {
                    MessageBox.Show("No customer found with this ID.  Please try again.", "Customer Not Found");
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Customer ID must be an integer.", "Entry error");
            }
            catch (SqlException se)
            {
                MessageBox.Show($"Database error # {se.Number} : {se.Message}", se.GetType().ToString());
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
                MessageBox.Show($"Database error # {se.Number} : {se.Message}", se.GetType().ToString());
            }
        }
    }
}
