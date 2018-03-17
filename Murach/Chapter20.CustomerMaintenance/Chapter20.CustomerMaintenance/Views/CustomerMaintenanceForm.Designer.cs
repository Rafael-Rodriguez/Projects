namespace Chapter20.CustomerMaintenance.Views
{
    partial class CustomerMaintenanceForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCityStateZip = new System.Windows.Forms.Label();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.txtBoxZip = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtBoxCustomerID = new System.Windows.Forms.TextBox();
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(66, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(267, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(167, 170);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(463, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Enabled = false;
            this.txtBoxName.Location = new System.Drawing.Point(114, 61);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(424, 20);
            this.txtBoxName.TabIndex = 15;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Enabled = false;
            this.txtBoxAddress.Location = new System.Drawing.Point(114, 87);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(424, 20);
            this.txtBoxAddress.TabIndex = 16;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Enabled = false;
            this.txtBoxCity.Location = new System.Drawing.Point(114, 113);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(243, 20);
            this.txtBoxCity.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(29, 87);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Address:";
            // 
            // lblCityStateZip
            // 
            this.lblCityStateZip.AutoSize = true;
            this.lblCityStateZip.Location = new System.Drawing.Point(29, 116);
            this.lblCityStateZip.Name = "lblCityStateZip";
            this.lblCityStateZip.Size = new System.Drawing.Size(79, 13);
            this.lblCityStateZip.TabIndex = 20;
            this.lblCityStateZip.Text = "City, State, Zip:";
            // 
            // txtBoxState
            // 
            this.txtBoxState.Enabled = false;
            this.txtBoxState.Location = new System.Drawing.Point(363, 113);
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(84, 20);
            this.txtBoxState.TabIndex = 21;
            // 
            // txtBoxZip
            // 
            this.txtBoxZip.Enabled = false;
            this.txtBoxZip.Location = new System.Drawing.Point(453, 113);
            this.txtBoxZip.Name = "txtBoxZip";
            this.txtBoxZip.Size = new System.Drawing.Size(85, 20);
            this.txtBoxZip.TabIndex = 22;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(32, 13);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // txtBoxCustomerID
            // 
            this.txtBoxCustomerID.Location = new System.Drawing.Point(114, 6);
            this.txtBoxCustomerID.Name = "txtBoxCustomerID";
            this.txtBoxCustomerID.Size = new System.Drawing.Size(61, 20);
            this.txtBoxCustomerID.TabIndex = 1;
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.Location = new System.Drawing.Point(194, 5);
            this.btnGetCustomer.Name = "btnGetCustomer";
            this.btnGetCustomer.Size = new System.Drawing.Size(106, 23);
            this.btnGetCustomer.TabIndex = 2;
            this.btnGetCustomer.Text = "Get Customer";
            this.btnGetCustomer.UseVisualStyleBackColor = true;
            // 
            // CustomerMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(556, 205);
            this.ControlBox = false;
            this.Controls.Add(this.btnGetCustomer);
            this.Controls.Add(this.txtBoxCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtBoxZip);
            this.Controls.Add(this.txtBoxState);
            this.Controls.Add(this.lblCityStateZip);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerMaintenanceForm";
            this.Text = "Customer Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCityStateZip;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.TextBox txtBoxZip;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtBoxCustomerID;
        private System.Windows.Forms.Button btnGetCustomer;
    }
}

