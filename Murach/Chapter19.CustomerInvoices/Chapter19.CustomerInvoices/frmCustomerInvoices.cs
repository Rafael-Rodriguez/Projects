using System;
using System.Data;
using System.Data.SqlClient;
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
            // TODO: This line of code loads data into the 'mMABooksDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.mMABooksDataSet.Invoices);

            // TODO: This line of code loads data into the 'mMABooksDataSet.Customers' table. You can move, or remove it, as needed.
            //this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);

            this.ActiveControl = customerIDToolStripTextBox.TextBox;
        }

        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerID = Convert.ToInt32(customerIDToolStripTextBox.Text);
                this.customersTableAdapter.FillByCustomerID(this.mMABooksDataSet.Customers, customerID);

                if(customersBindingSource.Count > 0)
                {
                    //this.invoicesTableAdapter.FillByCustomerID(mMABooksDataSet.Invoices, customerID);
                }
                else
                {
                    MessageBox.Show("No customer found with this ID");
                }
            }
            catch(SqlException se)
            {
                MessageBox.Show("Database error # " + se.Number + ": " + se.Message, se.GetType().ToString());
            }
            catch(ConstraintException)
            {
                var rowErrors = mMABooksDataSet.Tables[1].GetErrors();
                System.Diagnostics.Debug.WriteLine($"Invoice table errors count: {rowErrors.Length}");

                for(int i = 0; i < rowErrors.Length; ++i)
                {
                    System.Diagnostics.Debug.WriteLine(rowErrors[i].RowError);
                    foreach(DataColumn col in rowErrors[i].GetColumnsInError())
                    {
                        System.Diagnostics.Debug.WriteLine($"{col.ColumnName} : {rowErrors[i].GetColumnError(col)}");
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
