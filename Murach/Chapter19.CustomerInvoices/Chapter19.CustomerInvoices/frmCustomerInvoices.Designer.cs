﻿namespace Chapter19.CustomerInvoices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.fillByCustomerIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.customerIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.customerIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByCustomerIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMABooksDataSet = new Chapter19.CustomerInvoices.MMABooksDataSet();
            this.customersTableAdapter = new Chapter19.CustomerInvoices.MMABooksDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Chapter19.CustomerInvoices.MMABooksDataSetTableAdapters.TableAdapterManager();
            this.invoicesTableAdapter = new Chapter19.CustomerInvoices.MMABooksDataSetTableAdapters.InvoicesTableAdapter();
            this.invoicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityStateZipLabel = new System.Windows.Forms.Label();
            this.fillByCustomerIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).BeginInit();
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
            this.nameTextBox.Size = new System.Drawing.Size(510, 20);
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
            this.addressTextBox.Size = new System.Drawing.Size(510, 20);
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
            this.fillByCustomerIDToolStrip.Size = new System.Drawing.Size(622, 25);
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
            this.fillByCustomerIDToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.fillByCustomerIDToolStripButton.Text = "Get Customer";
            this.fillByCustomerIDToolStripButton.Click += new System.EventHandler(this.fillByCustomerIDToolStripButton_Click);
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "FK_Invoices_Customers";
            this.invoicesBindingSource.DataSource = this.customersBindingSource;
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
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // invoicesDataGridView
            // 
            this.invoicesDataGridView.AllowUserToAddRows = false;
            this.invoicesDataGridView.AllowUserToDeleteRows = false;
            this.invoicesDataGridView.AutoGenerateColumns = false;
            this.invoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.invoicesDataGridView.DataSource = this.invoicesBindingSource;
            this.invoicesDataGridView.Location = new System.Drawing.Point(14, 132);
            this.invoicesDataGridView.Name = "invoicesDataGridView";
            this.invoicesDataGridView.ReadOnly = true;
            this.invoicesDataGridView.Size = new System.Drawing.Size(588, 220);
            this.invoicesDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Invoice ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "InvoiceDate";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "Invoice Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductTotal";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SalesTax";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn5.HeaderText = "Sales Tax";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Shipping";
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn6.HeaderText = "Shipping";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "InvoiceTotal";
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn7.HeaderText = "Invoice Total";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // frmCustomerInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 382);
            this.Controls.Add(this.invoicesDataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private MMABooksDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.DataGridView invoicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

