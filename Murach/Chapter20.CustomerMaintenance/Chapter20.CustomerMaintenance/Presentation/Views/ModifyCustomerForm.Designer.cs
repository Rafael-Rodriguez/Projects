namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    partial class ModifyCustomerForm
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
            this.comboBoxStates = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtBoxZip = new System.Windows.Forms.TextBox();
            this.lblCityStateZip = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxStates
            // 
            this.comboBoxStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStates.FormattingEnabled = true;
            this.comboBoxStates.Location = new System.Drawing.Point(363, 77);
            this.comboBoxStates.Name = "comboBoxStates";
            this.comboBoxStates.Size = new System.Drawing.Size(83, 21);
            this.comboBoxStates.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(438, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(31, 134);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(99, 23);
            this.btnAccept.TabIndex = 18;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtBoxZip
            // 
            this.txtBoxZip.Location = new System.Drawing.Point(452, 77);
            this.txtBoxZip.Name = "txtBoxZip";
            this.txtBoxZip.Size = new System.Drawing.Size(85, 20);
            this.txtBoxZip.TabIndex = 17;
            // 
            // lblCityStateZip
            // 
            this.lblCityStateZip.AutoSize = true;
            this.lblCityStateZip.Location = new System.Drawing.Point(28, 80);
            this.lblCityStateZip.Name = "lblCityStateZip";
            this.lblCityStateZip.Size = new System.Drawing.Size(79, 13);
            this.lblCityStateZip.TabIndex = 14;
            this.lblCityStateZip.Text = "City, State, Zip:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(28, 51);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name:";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(113, 77);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(243, 20);
            this.txtBoxCity.TabIndex = 15;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(113, 51);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(424, 20);
            this.txtBoxAddress.TabIndex = 13;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(113, 25);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(424, 20);
            this.txtBoxName.TabIndex = 11;
            // 
            // ModifyCustomerForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(583, 169);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxStates);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtBoxZip);
            this.Controls.Add(this.lblCityStateZip);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxName);
            this.Name = "ModifyCustomerForm";
            this.Text = "Modify Customer";
            this.Load += new System.EventHandler(this.ModifyCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStates;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtBoxZip;
        private System.Windows.Forms.Label lblCityStateZip;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxName;
    }
}