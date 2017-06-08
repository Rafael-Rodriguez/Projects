using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Exercise._02.MultipleInvoices.Perspectives
{
    public partial class MultipleInvoicePerspective : Form, IMultipleInvoicePerspective
    {
        private const string SUBTOTAL_INVALIDCHARACTERS_REGEXPRESSION = @"[^0-9^+^\-^$^.]";
        public MultipleInvoicePerspectivePresenter Presenter { get;}

        public MultipleInvoicePerspective()
        {
            InitializeComponent();

            Presenter = new MultipleInvoicePerspectivePresenter(this);
            Presenter.TotalCalculated += OnTotalCalculated;
            Presenter.InvoiceCollectionUpdated += OnInvoiceCollectionUpdated;
        }

        private void OnInvoiceCollectionUpdated(object sender, InvoiceCollectionUpdateEventArgs args)
        {
            txtBoxNumInvoices.Text = String.Format("{0:d}",args.NumInvoices);
            txtBoxTotalInvoices.Text = String.Format("{0:c}", args.TotalInvoices);
            txtBoxInvoiceAverage.Text = String.Format("{0:c}", args.InvoiceAverage);
        }

        private void OnTotalCalculated(object sender, InvoiceDataEventArgs args)
        {
            txtBoxSubtotal.Text = args.Subtotal.ToString("c");
            txtBoxTotal.Text = args.Total.ToString("c");
            txtBoxDiscountPercent.Text = args.DiscountPercent.ToString("p1");
            txtBoxDiscountAmount.Text = args.DiscountAmount.ToString("c");

            txtBoxEnterSubtotal.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Presenter.Calculate(txtBoxEnterSubtotal.Text);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please enter a value in the Subtotal text box");
            }
            catch (FormatException)
            {
                MessageBox.Show($"Entered value \"{txtBoxEnterSubtotal.Text}\" is not in a correct format.  Please reenter the value in the Subtotal text box");
            }
            catch (OverflowException)
            {
                MessageBox.Show($"Entered value is outside the valid range.  Please enter a value that is between 79e-27 and 79e27");
            }

            txtBoxEnterSubtotal.Text = "";
        }

        private void txtBoxEnterSubtotal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            decimal subtotal;
            if(!Decimal.TryParse(txtBoxEnterSubtotal.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.CurrentCulture, out subtotal))
            {
                errorProvider.SetError(txtBoxEnterSubtotal, "Entered value is not in the correct format");
                e.Cancel = true;
                return;
            }

            if(subtotal < 0)
            {
                errorProvider.SetError(txtBoxEnterSubtotal, "Subtotal cannot be negative");
                e.Cancel = true;
                return;
            }

            if(subtotal > 100000000)
            {
                errorProvider.SetError(txtBoxEnterSubtotal, "Subtotal is greater than maximum value allowed");
                e.Cancel = true;
                return;
            }

            errorProvider.SetError(txtBoxEnterSubtotal, "");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            this.Close();
        }

        private void btnClearTotals_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxEnterSubtotal_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(SUBTOTAL_INVALIDCHARACTERS_REGEXPRESSION);
            MatchCollection matches = regex.Matches(txtBoxEnterSubtotal.Text);
            if(matches.Count > 0)
            {
                MessageBox.Show("Invalid characters in subtotal");
                txtBoxEnterSubtotal.Text = "";
            }
        }

        private void txtBoxEnterSubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Regex.IsMatch(e.KeyChar.ToString(), SUBTOTAL_INVALIDCHARACTERS_REGEXPRESSION))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
