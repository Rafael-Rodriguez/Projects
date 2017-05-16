using System;
using System.Windows.Forms;

namespace Exercise._02.MultipleInvoices.Perspectives
{
    public partial class frmMultipleInvoices : Form
    {
        public frmMultipleInvoices()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var subTotal = Convert.ToDecimal(txtBoxSubtotal.Text);
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

            txtBoxDiscountPercent.Text = discountPercent.ToString("p1");
            txtBoxDiscountAmount.Text = discountAmount.ToString("c");
            txtBoxTotal.Text = invoiceTotal.ToString("c");

            txtBoxSubtotal.Focus();



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
