namespace Chapter10.PaymentApplication
{
    partial class frmCustomer
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this._cboCustomerNames = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this._txtPayment = new System.Windows.Forms.TextBox();
            this._btnSelectPayment = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(22, 20);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "&Customer Name:";
            // 
            // _cboCustomerNames
            // 
            this._cboCustomerNames.FormattingEnabled = true;
            this._cboCustomerNames.Location = new System.Drawing.Point(150, 20);
            this._cboCustomerNames.Name = "_cboCustomerNames";
            this._cboCustomerNames.Size = new System.Drawing.Size(231, 21);
            this._cboCustomerNames.TabIndex = 1;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(22, 71);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(90, 13);
            this.lblPaymentMethod.TabIndex = 2;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // _txtPayment
            // 
            this._txtPayment.Location = new System.Drawing.Point(25, 96);
            this._txtPayment.Multiline = true;
            this._txtPayment.Name = "_txtPayment";
            this._txtPayment.ReadOnly = true;
            this._txtPayment.Size = new System.Drawing.Size(226, 100);
            this._txtPayment.TabIndex = 3;
            this._txtPayment.TabStop = false;
            this._txtPayment.TextChanged += new System.EventHandler(this._txtPayment_TextChanged);
            // 
            // _btnSelectPayment
            // 
            this._btnSelectPayment.Location = new System.Drawing.Point(279, 96);
            this._btnSelectPayment.Name = "_btnSelectPayment";
            this._btnSelectPayment.Size = new System.Drawing.Size(102, 23);
            this._btnSelectPayment.TabIndex = 2;
            this._btnSelectPayment.Text = "Select Payment";
            this._btnSelectPayment.UseVisualStyleBackColor = true;
            this._btnSelectPayment.Click += new System.EventHandler(this._btnSelectPayment_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(207, 217);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 3;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnExit
            // 
            this._btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnExit.Location = new System.Drawing.Point(306, 217);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 4;
            this._btnExit.Text = "Exit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this._btnExit_Click);
            // 
            // frmCustomer
            // 
            this.AcceptButton = this._btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnExit;
            this.ClientSize = new System.Drawing.Size(409, 262);
            this.ControlBox = false;
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnSelectPayment);
            this.Controls.Add(this._txtPayment);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this._cboCustomerNames);
            this.Controls.Add(this.lblCustomerName);
            this.MaximizeBox = false;
            this.Name = "frmCustomer";
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox _cboCustomerNames;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.TextBox _txtPayment;
        private System.Windows.Forms.Button _btnSelectPayment;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnExit;
    }
}