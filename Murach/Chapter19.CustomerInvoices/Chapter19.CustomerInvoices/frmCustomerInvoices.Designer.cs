namespace Chapter19.CustomerInvoices
{
    partial class frmCustomerInvoices
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityStateZipLabel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.fillByCustomerIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.customerIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.customerIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByCustomerIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMABooksDataSet = new Chapter19.CustomerInvoices.MMABooksDataSet();
            this.customersTableAdapter = new Chapter19.CustomerInvoices.MMABooksDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Chapter19.CustomerInvoices.MMABooksDataSetTableAdapters.TableAdapterManager();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityStateZipLabel = new System.Windows.Forms.Label();
            this.fillByCustomerIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 43);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 69);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Address:";
            // 
            // cityStateZipLabel
            // 
            cityStateZipLabel.AutoSize = true;
            cityStateZipLabel.Location = new System.Drawing.Point(12, 95);
            cityStateZipLabel.Name = "cityStateZipLabel";
            cityStateZipLabel.Size = new System.Drawing.Size(79, 13);
            cityStateZipLabel.TabIndex = 5;
            cityStateZipLabel.Text = "City, State, Zip:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.CausesValidation = false;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(92, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(621, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TabStop = false;
            // 
            // addressTextBox
            // 
            this.addressTextBox.CausesValidation = false;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Enabled = false;
            this.addressTextBox.Location = new System.Drawing.Point(92, 69);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(621, 20);
            this.addressTextBox.TabIndex = 4;
            this.addressTextBox.TabStop = false;
            // 
            // cityTextBox
            // 
            this.cityTextBox.CausesValidation = false;
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.cityTextBox.Enabled = false;
            this.cityTextBox.Location = new System.Drawing.Point(92, 95);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(265, 20);
            this.cityTextBox.TabIndex = 6;
            this.cityTextBox.TabStop = false;
            // 
            // stateTextBox
            // 
            this.stateTextBox.CausesValidation = false;
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "State", true));
            this.stateTextBox.Enabled = false;
            this.stateTextBox.Location = new System.Drawing.Point(363, 95);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(72, 20);
            this.stateTextBox.TabIndex = 7;
            this.stateTextBox.TabStop = false;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.CausesValidation = false;
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Enabled = false;
            this.zipCodeTextBox.Location = new System.Drawing.Point(441, 95);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.ReadOnly = true;
            this.zipCodeTextBox.Size = new System.Drawing.Size(72, 20);
            this.zipCodeTextBox.TabIndex = 8;
            this.zipCodeTextBox.TabStop = false;
            // 
            // fillByCustomerIDToolStrip
            // 
            this.fillByCustomerIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDToolStripLabel,
            this.customerIDToolStripTextBox,
            this.fillByCustomerIDToolStripButton});
            this.fillByCustomerIDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByCustomerIDToolStrip.Name = "fillByCustomerIDToolStrip";
            this.fillByCustomerIDToolStrip.Size = new System.Drawing.Size(744, 25);
            this.fillByCustomerIDToolStrip.TabIndex = 0;
            this.fillByCustomerIDToolStrip.Text = "fillByCustomerIDToolStrip";
            // 
            // customerIDToolStripLabel
            // 
            this.customerIDToolStripLabel.Name = "customerIDToolStripLabel";
            this.customerIDToolStripLabel.Size = new System.Drawing.Size(73, 22);
            this.customerIDToolStripLabel.Text = "CustomerID:";
            // 
            // customerIDToolStripTextBox
            // 
            this.customerIDToolStripTextBox.Name = "customerIDToolStripTextBox";
            this.customerIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByCustomerIDToolStripButton
            // 
            this.fillByCustomerIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByCustomerIDToolStripButton.Name = "fillByCustomerIDToolStripButton";
            this.fillByCustomerIDToolStripButton.Size = new System.Drawing.Size(102, 22);
            this.fillByCustomerIDToolStripButton.Text = "FillByCustomerID";
            this.fillByCustomerIDToolStripButton.Click += new System.EventHandler(this.fillByCustomerIDToolStripButton_Click);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.mMABooksDataSet;
            // 
            // mMABooksDataSet
            // 
            this.mMABooksDataSet.DataSetName = "MMABooksDataSet";
            this.mMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Chapter19.CustomerInvoices.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCustomerInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 485);
            this.Controls.Add(this.fillByCustomerIDToolStrip);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityStateZipLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Name = "frmCustomerInvoices";
            this.Text = "Customer Invoices";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fillByCustomerIDToolStrip.ResumeLayout(false);
            this.fillByCustomerIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MMABooksDataSet mMABooksDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private MMABooksDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private MMABooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.ToolStrip fillByCustomerIDToolStrip;
        private System.Windows.Forms.ToolStripLabel customerIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox customerIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByCustomerIDToolStripButton;
    }
}

