using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter10.PaymentApplication
{
    public partial class frmPayment : Form
    {
        private const string DEFAULT_CARD_NUMBER = "XXXX-XXXX-XXXX-XXXX";

        public frmPayment()
        {
            InitializeComponent();

            this.Shown += OnFormShown;
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            _lstCreditCardTypes.SelectedIndex = 0;
            _cboExpirationMonth.SelectedIndex = 0;
            _cboExpirationYear.SelectedIndex = 0;
            _txtCardNumber.Text = DEFAULT_CARD_NUMBER;
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnTextBoxCardNumberMouseDown(object sender, MouseEventArgs e)
        {
            if(_txtCardNumber.Text.Equals(DEFAULT_CARD_NUMBER))
            {
                _txtCardNumber.Text = "";
            }
        }

        private void OnLeaveFocus(object sender, EventArgs e)
        {
            if(_txtCardNumber.Text.Equals(""))
            {
                _txtCardNumber.Text = DEFAULT_CARD_NUMBER;
            }
        }

        private void EnableCreditCardControls(bool enable)
        {
            _lstCreditCardTypes.Enabled = enable;
            _txtCardNumber.Enabled = enable;
            _cboExpirationMonth.Enabled = _cboExpirationYear.Enabled = enable;
            _lblCardNumber.Enabled = enable;
            _lblCreditCardType.Enabled = enable;
            _lblExpirationDate.Enabled = enable;
        }

        private void OnCreditCardCheckedChanged(object sender, EventArgs e)
        {
            if(_rdoCreditCard.Checked)
            {
                EnableCreditCardControls(true);
            }
        }

        private void OnBillCustomerCheckedChanged(object sender, EventArgs e)
        {
            if(_rdoBillCustomer.Checked)
            {
                EnableCreditCardControls(false);
            }
        }

        private void OnCreditCardNumberKeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode != Keys.D0 &&
                e.KeyCode != Keys.D1 &&
                e.KeyCode != Keys.D2 &&
                e.KeyCode != Keys.D3 &&
                e.KeyCode != Keys.D4 &&
                e.KeyCode != Keys.D5 &&
                e.KeyCode != Keys.D6 &&
                e.KeyCode != Keys.D7 &&
                e.KeyCode != Keys.D8 &&
                e.KeyCode != Keys.D9 &&
                e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            InitializeCreditCardTypes();
            InitializeExpirationMonthAndYear();
        }

        private void InitializeExpirationMonthAndYear()
        {
            string[] months =
                        {
                "Select a month...",
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            _cboExpirationMonth.Items.AddRange(months);
            _cboExpirationMonth.SelectedIndex = 0;

            int year = DateTime.Today.Year;
            int endYear = year + 8;
            _cboExpirationYear.Items.Add("Select a year...");
            while (year < endYear)
            {
                _cboExpirationYear.Items.Add(year);
                year++;
            }
            _cboExpirationYear.SelectedIndex = 0;
        }

        private void InitializeCreditCardTypes()
        {
            _lstCreditCardTypes.Items.Add("Visa");
            _lstCreditCardTypes.Items.Add("Mastercard");
            _lstCreditCardTypes.Items.Add("American Express");
            _lstCreditCardTypes.SelectedIndex = 0;
        }

        private void _btnOK_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            string msg = null;
            if(_rdoCreditCard.Checked == true)
            {
                msg += "Charge to credit card." + "\n\n";
                msg += "Card type: " + _lblCreditCardType.Text + "\n";
                msg += "Card number: " + _txtCardNumber.Text + "\n";
                msg += "Expiration date: " + _cboExpirationMonth.Text + "/" + _cboExpirationYear.Text + "\n";
            }
            else
            {
                msg += "Send bill to customer." + "\n\n";
            }

            bool isDefaultBilling = _chkDefaultBilling.Checked;
            msg += "Default billing: " + isDefaultBilling;

            Tag = msg;
            DialogResult = DialogResult.OK;
        }

        private bool IsValidData()
        {
            if(_rdoCreditCard.Checked)
            {
                if(_lstCreditCardTypes.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a credit card type.", "Entry Error");
                    _lstCreditCardTypes.Focus();
                    return false;
                }

                if(_txtCardNumber.Text == "")
                {
                    MessageBox.Show("You must enter a credit card number.", "Entry Error");
                    _txtCardNumber.Focus();
                    return false;
                }

                if(_cboExpirationMonth.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a month.", "Entry Error");
                    _cboExpirationMonth.Focus();
                    return false;
                }

                if(_cboExpirationYear.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a year.", "Entry Error");
                    _cboExpirationYear.Focus();
                    return false;
                }
            }

            return true;
        }
    }
}
