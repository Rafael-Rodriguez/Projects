namespace Chapter10.PaymentApplication
{
    partial class frmPayment
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
            this.grpBilling = new System.Windows.Forms.GroupBox();
            this._rdoBillCustomer = new System.Windows.Forms.RadioButton();
            this._rdoCreditCard = new System.Windows.Forms.RadioButton();
            this._lblCreditCardType = new System.Windows.Forms.Label();
            this._lstCreditCardTypes = new System.Windows.Forms.ListBox();
            this._lblCardNumber = new System.Windows.Forms.Label();
            this._txtCardNumber = new System.Windows.Forms.TextBox();
            this._lblExpirationDate = new System.Windows.Forms.Label();
            this._cboExpirationMonth = new System.Windows.Forms.ComboBox();
            this._cboExpirationYear = new System.Windows.Forms.ComboBox();
            this._chkDefaultBilling = new System.Windows.Forms.CheckBox();
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.grpBilling.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBilling
            // 
            this.grpBilling.Controls.Add(this._rdoBillCustomer);
            this.grpBilling.Controls.Add(this._rdoCreditCard);
            this.grpBilling.Location = new System.Drawing.Point(10, 11);
            this.grpBilling.Margin = new System.Windows.Forms.Padding(2);
            this.grpBilling.Name = "grpBilling";
            this.grpBilling.Padding = new System.Windows.Forms.Padding(2);
            this.grpBilling.Size = new System.Drawing.Size(390, 81);
            this.grpBilling.TabIndex = 10;
            this.grpBilling.TabStop = false;
            this.grpBilling.Text = "Billing";
            // 
            // _rdoBillCustomer
            // 
            this._rdoBillCustomer.AutoSize = true;
            this._rdoBillCustomer.Location = new System.Drawing.Point(242, 32);
            this._rdoBillCustomer.Margin = new System.Windows.Forms.Padding(2);
            this._rdoBillCustomer.Name = "_rdoBillCustomer";
            this._rdoBillCustomer.Size = new System.Drawing.Size(85, 17);
            this._rdoBillCustomer.TabIndex = 1;
            this._rdoBillCustomer.TabStop = true;
            this._rdoBillCustomer.Text = "&Bill Customer";
            this._rdoBillCustomer.UseVisualStyleBackColor = true;
            this._rdoBillCustomer.CheckedChanged += new System.EventHandler(this.OnBillCustomerCheckedChanged);
            // 
            // _rdoCreditCard
            // 
            this._rdoCreditCard.AutoSize = true;
            this._rdoCreditCard.Location = new System.Drawing.Point(34, 32);
            this._rdoCreditCard.Margin = new System.Windows.Forms.Padding(2);
            this._rdoCreditCard.Name = "_rdoCreditCard";
            this._rdoCreditCard.Size = new System.Drawing.Size(77, 17);
            this._rdoCreditCard.TabIndex = 0;
            this._rdoCreditCard.TabStop = true;
            this._rdoCreditCard.Text = "Credi&t Card";
            this._rdoCreditCard.UseVisualStyleBackColor = true;
            this._rdoCreditCard.CheckedChanged += new System.EventHandler(this.OnCreditCardCheckedChanged);
            // 
            // _lblCreditCardType
            // 
            this._lblCreditCardType.AutoSize = true;
            this._lblCreditCardType.Location = new System.Drawing.Point(8, 115);
            this._lblCreditCardType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblCreditCardType.Name = "_lblCreditCardType";
            this._lblCreditCardType.Size = new System.Drawing.Size(85, 13);
            this._lblCreditCardType.TabIndex = 0;
            this._lblCreditCardType.Text = "&Credit Card type:";
            // 
            // _lstCreditCardTypes
            // 
            this._lstCreditCardTypes.FormattingEnabled = true;
            this._lstCreditCardTypes.Location = new System.Drawing.Point(110, 115);
            this._lstCreditCardTypes.Margin = new System.Windows.Forms.Padding(2);
            this._lstCreditCardTypes.Name = "_lstCreditCardTypes";
            this._lstCreditCardTypes.Size = new System.Drawing.Size(266, 69);
            this._lstCreditCardTypes.TabIndex = 1;
            // 
            // _lblCardNumber
            // 
            this._lblCardNumber.AutoSize = true;
            this._lblCardNumber.Location = new System.Drawing.Point(8, 221);
            this._lblCardNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblCardNumber.Name = "_lblCardNumber";
            this._lblCardNumber.Size = new System.Drawing.Size(70, 13);
            this._lblCardNumber.TabIndex = 2;
            this._lblCardNumber.Text = "Car&d number:";
            // 
            // _txtCardNumber
            // 
            this._txtCardNumber.Location = new System.Drawing.Point(110, 219);
            this._txtCardNumber.Margin = new System.Windows.Forms.Padding(2);
            this._txtCardNumber.MaxLength = 16;
            this._txtCardNumber.Name = "_txtCardNumber";
            this._txtCardNumber.Size = new System.Drawing.Size(266, 20);
            this._txtCardNumber.TabIndex = 3;
            this._txtCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnCreditCardNumberKeyDown);
            this._txtCardNumber.Leave += new System.EventHandler(this.OnLeaveFocus);
            this._txtCardNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnTextBoxCardNumberMouseDown);
            // 
            // _lblExpirationDate
            // 
            this._lblExpirationDate.AutoSize = true;
            this._lblExpirationDate.Location = new System.Drawing.Point(8, 276);
            this._lblExpirationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblExpirationDate.Name = "_lblExpirationDate";
            this._lblExpirationDate.Size = new System.Drawing.Size(82, 13);
            this._lblExpirationDate.TabIndex = 4;
            this._lblExpirationDate.Text = "Exp&iration Date:";
            // 
            // _cboExpirationMonth
            // 
            this._cboExpirationMonth.FormattingEnabled = true;
            this._cboExpirationMonth.Location = new System.Drawing.Point(110, 274);
            this._cboExpirationMonth.Margin = new System.Windows.Forms.Padding(2);
            this._cboExpirationMonth.Name = "_cboExpirationMonth";
            this._cboExpirationMonth.Size = new System.Drawing.Size(112, 21);
            this._cboExpirationMonth.TabIndex = 5;
            // 
            // _cboExpirationYear
            // 
            this._cboExpirationYear.FormattingEnabled = true;
            this._cboExpirationYear.Location = new System.Drawing.Point(251, 274);
            this._cboExpirationYear.Margin = new System.Windows.Forms.Padding(2);
            this._cboExpirationYear.Name = "_cboExpirationYear";
            this._cboExpirationYear.Size = new System.Drawing.Size(112, 21);
            this._cboExpirationYear.TabIndex = 6;
            // 
            // _chkDefaultBilling
            // 
            this._chkDefaultBilling.AutoSize = true;
            this._chkDefaultBilling.Location = new System.Drawing.Point(10, 321);
            this._chkDefaultBilling.Margin = new System.Windows.Forms.Padding(2);
            this._chkDefaultBilling.Name = "_chkDefaultBilling";
            this._chkDefaultBilling.Size = new System.Drawing.Size(158, 17);
            this._chkDefaultBilling.TabIndex = 7;
            this._chkDefaultBilling.Text = "&Set as default billing method";
            this._chkDefaultBilling.UseVisualStyleBackColor = true;
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(209, 360);
            this._btnOK.Margin = new System.Windows.Forms.Padding(2);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(73, 19);
            this._btnOK.TabIndex = 8;
            this._btnOK.Text = "OK";
            this._btnOK.UseVisualStyleBackColor = true;
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(310, 360);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(70, 19);
            this._btnCancel.TabIndex = 9;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // frmPayment
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(409, 405);
            this.ControlBox = false;
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._chkDefaultBilling);
            this.Controls.Add(this._cboExpirationYear);
            this.Controls.Add(this._cboExpirationMonth);
            this.Controls.Add(this._lblExpirationDate);
            this.Controls.Add(this._txtCardNumber);
            this.Controls.Add(this._lblCardNumber);
            this.Controls.Add(this._lstCreditCardTypes);
            this.Controls.Add(this._lblCreditCardType);
            this.Controls.Add(this.grpBilling);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.grpBilling.ResumeLayout(false);
            this.grpBilling.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBilling;
        private System.Windows.Forms.RadioButton _rdoBillCustomer;
        private System.Windows.Forms.RadioButton _rdoCreditCard;
        private System.Windows.Forms.Label _lblCreditCardType;
        private System.Windows.Forms.ListBox _lstCreditCardTypes;
        private System.Windows.Forms.Label _lblCardNumber;
        private System.Windows.Forms.TextBox _txtCardNumber;
        private System.Windows.Forms.Label _lblExpirationDate;
        private System.Windows.Forms.ComboBox _cboExpirationMonth;
        private System.Windows.Forms.ComboBox _cboExpirationYear;
        private System.Windows.Forms.CheckBox _chkDefaultBilling;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
    }
}

