using System;
using System.Windows.Forms;

namespace Exercise._02.MultipleInvoices.Perspectives
{
    public partial class MultipleInvoicePerspective : Form, IMultipleInvoicePerspective
    {
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearTotals_Click(object sender, EventArgs e)
        {

        }
    }
}
