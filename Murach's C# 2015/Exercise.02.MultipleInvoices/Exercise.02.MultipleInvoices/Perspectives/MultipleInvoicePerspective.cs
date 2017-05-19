using System;
using System.Windows.Forms;

namespace Exercise._02.MultipleInvoices.Perspectives
{
    public partial class MultipleInvoicePerspective : Form, IMultipleInvoicePerspective
    {
        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        public MultipleInvoicePerspectivePresenter Presenter { get;}

        public MultipleInvoicePerspective()
        {
            InitializeComponent();

            Presenter = new MultipleInvoicePerspectivePresenter(this);
            Presenter.TotalCalculated += OnTotalCalculated;
        }

        private void OnTotalCalculated(object sender, InvoiceDataEventArgs args)
        {
            txtBoxTotal.Text = args.Total.ToString("c");
            txtBoxDiscountPercent.Text = args.DiscountPercent.ToString("p1");
            txtBoxDiscountAmount.Text = args.DiscountAmount.ToString("c");

            txtBoxEnterSubtotal.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var subtotal = Convert.ToDecimal(txtBoxEnterSubtotal.Text);

            Presenter.Calculate(subtotal);

            
            var discountPercent = 0m;

            if (subtotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (subtotal >= 250)
            {
                discountPercent = .15m;
            }
            else if (subtotal >= 100)
            {
                discountPercent = .1m;
            }

            var discountAmount = subtotal * discountPercent;
            var invoiceTotal = subtotal - discountAmount;

            txtBoxSubtotal.Text = subtotal.ToString("c");
            txtBoxDiscountPercent.Text = discountPercent.ToString("p1");
            txtBoxDiscountAmount.Text = discountAmount.ToString("c");
            txtBoxTotal.Text = invoiceTotal.ToString("c");

            numberOfInvoices++;
            totalOfInvoices += invoiceTotal;
            invoiceAverage = totalOfInvoices / numberOfInvoices;

            txtBoxNumInvoices.Text = numberOfInvoices.ToString();
            txtBoxTotalInvoices.Text = totalOfInvoices.ToString("c");
            txtBoxInvoiceAverage.Text = invoiceAverage.ToString("c");

            



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
