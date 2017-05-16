using System;
using System.Windows.Forms;

namespace Exercise._02.MultipleInvoices.Perspectives
{
    public partial class MultipleInvoicePerspective : Form
    {
        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        public MultipleInvoicePerspective()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var subTotal = Convert.ToDecimal(txtBoxEnterSubtotal.Text);
            var discountPercent = 0m;

            if (subTotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (subTotal >= 250)
            {
                discountPercent = .15m;
            }
            else if (subTotal >= 100)
            {
                discountPercent = .1m;
            }

            var discountAmount = subTotal * discountPercent;
            var invoiceTotal = subTotal - discountAmount;

            txtBoxSubtotal.Text = subTotal.ToString("c");
            txtBoxDiscountPercent.Text = discountPercent.ToString("p1");
            txtBoxDiscountAmount.Text = discountAmount.ToString("c");
            txtBoxTotal.Text = invoiceTotal.ToString("c");

            numberOfInvoices++;
            totalOfInvoices += invoiceTotal;
            invoiceAverage = totalOfInvoices / numberOfInvoices;

            txtBoxNumInvoices.Text = numberOfInvoices.ToString();
            txtBoxTotalInvoices.Text = totalOfInvoices.ToString("c");
            txtBoxInvoiceAverage.Text = invoiceAverage.ToString("c");

            txtBoxEnterSubtotal.Focus();



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
