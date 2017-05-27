namespace Exercise._02.MultipleInvoices.Perspectives
{
    partial class MultipleInvoicePerspective
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBoxEnterSubtotal = new System.Windows.Forms.TextBox();
            this.txtBoxDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtBoxDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNumInvoices = new System.Windows.Forms.Label();
            this.lblTotalInvoices = new System.Windows.Forms.Label();
            this.lblInvoiceAverage = new System.Windows.Forms.Label();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.txtBoxNumInvoices = new System.Windows.Forms.TextBox();
            this.txtBoxTotalInvoices = new System.Windows.Forms.TextBox();
            this.txtBoxInvoiceAverage = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter &Subtotal";
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Location = new System.Drawing.Point(29, 135);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(116, 17);
            this.lblDiscountPercent.TabIndex = 100;
            this.lblDiscountPercent.Text = "Discount Percent";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Location = new System.Drawing.Point(29, 174);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(115, 17);
            this.lblDiscountAmount.TabIndex = 100;
            this.lblDiscountAmount.Text = "Discount Amount";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(29, 210);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 17);
            this.lblTotal.TabIndex = 100;
            this.lblTotal.Text = "Total";
            // 
            // txtBoxEnterSubtotal
            // 
            this.txtBoxEnterSubtotal.Location = new System.Drawing.Point(198, 60);
            this.txtBoxEnterSubtotal.Name = "txtBoxEnterSubtotal";
            this.txtBoxEnterSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtBoxEnterSubtotal.TabIndex = 1;
            this.txtBoxEnterSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxEnterSubtotal.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxEnterSubtotal_Validating);
            // 
            // txtBoxDiscountPercent
            // 
            this.txtBoxDiscountPercent.Location = new System.Drawing.Point(198, 132);
            this.txtBoxDiscountPercent.Name = "txtBoxDiscountPercent";
            this.txtBoxDiscountPercent.ReadOnly = true;
            this.txtBoxDiscountPercent.Size = new System.Drawing.Size(100, 22);
            this.txtBoxDiscountPercent.TabIndex = 100;
            this.txtBoxDiscountPercent.TabStop = false;
            this.txtBoxDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxDiscountAmount
            // 
            this.txtBoxDiscountAmount.Location = new System.Drawing.Point(198, 170);
            this.txtBoxDiscountAmount.Name = "txtBoxDiscountAmount";
            this.txtBoxDiscountAmount.ReadOnly = true;
            this.txtBoxDiscountAmount.Size = new System.Drawing.Size(100, 22);
            this.txtBoxDiscountAmount.TabIndex = 100;
            this.txtBoxDiscountAmount.TabStop = false;
            this.txtBoxDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(198, 207);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.Size = new System.Drawing.Size(100, 22);
            this.txtBoxTotal.TabIndex = 100;
            this.txtBoxTotal.TabStop = false;
            this.txtBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(210, 292);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 29);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(493, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNumInvoices
            // 
            this.lblNumInvoices.AutoSize = true;
            this.lblNumInvoices.Location = new System.Drawing.Point(349, 97);
            this.lblNumInvoices.Name = "lblNumInvoices";
            this.lblNumInvoices.Size = new System.Drawing.Size(129, 17);
            this.lblNumInvoices.TabIndex = 101;
            this.lblNumInvoices.Text = "Number of invoices";
            // 
            // lblTotalInvoices
            // 
            this.lblTotalInvoices.AutoSize = true;
            this.lblTotalInvoices.Location = new System.Drawing.Point(349, 134);
            this.lblTotalInvoices.Name = "lblTotalInvoices";
            this.lblTotalInvoices.Size = new System.Drawing.Size(111, 17);
            this.lblTotalInvoices.TabIndex = 101;
            this.lblTotalInvoices.Text = "Total of invoices";
            // 
            // lblInvoiceAverage
            // 
            this.lblInvoiceAverage.AutoSize = true;
            this.lblInvoiceAverage.Location = new System.Drawing.Point(349, 174);
            this.lblInvoiceAverage.Name = "lblInvoiceAverage";
            this.lblInvoiceAverage.Size = new System.Drawing.Size(108, 17);
            this.lblInvoiceAverage.TabIndex = 101;
            this.lblInvoiceAverage.Text = "Invoice average";
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Location = new System.Drawing.Point(352, 292);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(108, 29);
            this.btnClearTotals.TabIndex = 3;
            this.btnClearTotals.Text = "C&lear Totals";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.btnClearTotals_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "Subtotal";
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.Location = new System.Drawing.Point(198, 95);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.ReadOnly = true;
            this.txtBoxSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSubtotal.TabIndex = 100;
            this.txtBoxSubtotal.TabStop = false;
            this.txtBoxSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxNumInvoices
            // 
            this.txtBoxNumInvoices.Location = new System.Drawing.Point(504, 91);
            this.txtBoxNumInvoices.Name = "txtBoxNumInvoices";
            this.txtBoxNumInvoices.ReadOnly = true;
            this.txtBoxNumInvoices.Size = new System.Drawing.Size(100, 22);
            this.txtBoxNumInvoices.TabIndex = 103;
            this.txtBoxNumInvoices.TabStop = false;
            // 
            // txtBoxTotalInvoices
            // 
            this.txtBoxTotalInvoices.Location = new System.Drawing.Point(504, 134);
            this.txtBoxTotalInvoices.Name = "txtBoxTotalInvoices";
            this.txtBoxTotalInvoices.ReadOnly = true;
            this.txtBoxTotalInvoices.Size = new System.Drawing.Size(100, 22);
            this.txtBoxTotalInvoices.TabIndex = 103;
            this.txtBoxTotalInvoices.TabStop = false;
            // 
            // txtBoxInvoiceAverage
            // 
            this.txtBoxInvoiceAverage.Location = new System.Drawing.Point(504, 174);
            this.txtBoxInvoiceAverage.Name = "txtBoxInvoiceAverage";
            this.txtBoxInvoiceAverage.ReadOnly = true;
            this.txtBoxInvoiceAverage.Size = new System.Drawing.Size(100, 22);
            this.txtBoxInvoiceAverage.TabIndex = 103;
            this.txtBoxInvoiceAverage.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MultipleInvoicePerspective
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(644, 368);
            this.Controls.Add(this.txtBoxInvoiceAverage);
            this.Controls.Add(this.txtBoxTotalInvoices);
            this.Controls.Add(this.txtBoxNumInvoices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInvoiceAverage);
            this.Controls.Add(this.lblTotalInvoices);
            this.Controls.Add(this.lblNumInvoices);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.txtBoxDiscountAmount);
            this.Controls.Add(this.txtBoxSubtotal);
            this.Controls.Add(this.txtBoxDiscountPercent);
            this.Controls.Add(this.txtBoxEnterSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultipleInvoicePerspective";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBoxEnterSubtotal;
        private System.Windows.Forms.TextBox txtBoxDiscountPercent;
        private System.Windows.Forms.TextBox txtBoxDiscountAmount;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNumInvoices;
        private System.Windows.Forms.Label lblTotalInvoices;
        private System.Windows.Forms.Label lblInvoiceAverage;
        private System.Windows.Forms.Button btnClearTotals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.TextBox txtBoxNumInvoices;
        private System.Windows.Forms.TextBox txtBoxTotalInvoices;
        private System.Windows.Forms.TextBox txtBoxInvoiceAverage;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}