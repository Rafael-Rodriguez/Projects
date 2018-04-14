namespace Chapter23.CustomerInvoice
{
    partial class Form
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
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInvoiceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInvoiceDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInvoiceTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCustomer,
            this.columnHeaderInvoiceID,
            this.columnHeaderInvoiceDate,
            this.columnHeaderInvoiceTotal});
            this.listView.Location = new System.Drawing.Point(13, 13);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(518, 339);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCustomer
            // 
            this.columnHeaderCustomer.Text = "Customer";
            this.columnHeaderCustomer.Width = 200;
            // 
            // columnHeaderInvoiceID
            // 
            this.columnHeaderInvoiceID.Text = "Invoice #";
            // 
            // columnHeaderInvoiceDate
            // 
            this.columnHeaderInvoiceDate.Text = "InvoiceDate";
            this.columnHeaderInvoiceDate.Width = 120;
            // 
            // columnHeaderInvoiceTotal
            // 
            this.columnHeaderInvoiceTotal.Text = "Invoice Total";
            this.columnHeaderInvoiceTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderInvoiceTotal.Width = 135;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 364);
            this.Controls.Add(this.listView);
            this.Name = "Form";
            this.Text = "Customer Invoices by Invoice Total";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeaderCustomer;
        private System.Windows.Forms.ColumnHeader columnHeaderInvoiceID;
        private System.Windows.Forms.ColumnHeader columnHeaderInvoiceDate;
        private System.Windows.Forms.ColumnHeader columnHeaderInvoiceTotal;
    }
}

