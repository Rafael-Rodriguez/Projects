using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter10.PaymentApplication
{
    public partial class frmCustomer : Form
    {
        private bool _isDataSaved = false;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            _cboCustomerNames.Items.Add("Select a customer...");
            _cboCustomerNames.Items.Add("Mike Smith");
            _cboCustomerNames.Items.Add("Nancy Jones");
            _cboCustomerNames.SelectedIndex = 0;

            _isDataSaved = true;
        }

        private void _btnSelectPayment_Click(object sender, EventArgs e)
        {
            if(_cboCustomerNames.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form paymentForm = new frmPayment();
            DialogResult result = paymentForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                _txtPayment.Text = (string)paymentForm.Tag;
            }
        }

        private void _txtPayment_TextChanged(object sender, EventArgs e)
        {
            _isDataSaved = false;
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            _cboCustomerNames.SelectedIndex = 0;
            _txtPayment.Text = "";
            _isDataSaved = true;
            _cboCustomerNames.Focus();
        }

        private bool IsValidData()
        {
            if(_cboCustomerNames.SelectedIndex == 0)
            {
                MessageBox.Show("You must select a customer.", "Entry Error");
                _cboCustomerNames.Focus();
                return false;
            }

            if(_txtPayment.Text == "")
            {
                MessageBox.Show("You must enter a payment.", "Entry Error");
                return false;
            }

            return true;
        }

        private void _btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_isDataSaved == false)
            {
                string message = "This form contains unsaved data.\n\n" + "Do you want to save it?";

                DialogResult result = MessageBox.Show(message, "Customer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    if(IsValidData())
                    {
                        SaveData();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }

                if(result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
