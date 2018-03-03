namespace Chapter18.CustomerMaintenance
{
    partial class frmCustomerMaintenance
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label zipCodeLabel;
            System.Windows.Forms.Label stateNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerMaintenance));
            this.mMABooksDataSet = new Chapter18.CustomerMaintenance.MMABooksDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new Chapter18.CustomerMaintenance.MMABooksDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Chapter18.CustomerMaintenance.MMABooksDataSetTableAdapters.TableAdapterManager();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.statesDataSet = new Chapter18.CustomerMaintenance.StatesDataSet();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesTableAdapter = new Chapter18.CustomerMaintenance.StatesDataSetTableAdapters.StatesTableAdapter();
            this.tableAdapterManager1 = new Chapter18.CustomerMaintenance.StatesDataSetTableAdapters.TableAdapterManager();
            this.stateNameComboBox = new System.Windows.Forms.ComboBox();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.customerIdToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.customerIdToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByCustomerIdToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByZipCodeToolStrip = new System.Windows.Forms.ToolStrip();
            this.zipCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.zipCodeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByZipCodeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByStateToolStrip = new System.Windows.Forms.ToolStrip();
            this.stateToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fillByStateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stateToolStripTextBox = new System.Windows.Forms.ToolStripComboBox();
            customerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            stateNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillByZipCodeToolStrip.SuspendLayout();
            this.fillByStateToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(6, 125);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 156);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(6, 189);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(6, 220);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(315, 256);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(53, 13);
            zipCodeLabel.TabIndex = 11;
            zipCodeLabel.Text = "Zip Code:";
            // 
            // stateNameLabel
            // 
            stateNameLabel.AutoSize = true;
            stateNameLabel.Location = new System.Drawing.Point(8, 256);
            stateNameLabel.Name = "stateNameLabel";
            stateNameLabel.Size = new System.Drawing.Size(35, 13);
            stateNameLabel.TabIndex = 9;
            stateNameLabel.Text = "State:";
            // 
            // mMABooksDataSet
            // 
            this.mMABooksDataSet.DataSetName = "MMABooksDataSet";
            this.mMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.mMABooksDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Chapter18.CustomerMaintenance.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customersBindingNavigatorSaveItem});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(521, 25);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customersBindingNavigatorSaveItem.Text = "Save Data";
            this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(80, 122);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.ReadOnly = true;
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(80, 153);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(415, 20);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.WordWrap = false;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(80, 186);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(415, 20);
            this.addressTextBox.TabIndex = 6;
            this.addressTextBox.WordWrap = false;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(80, 217);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(415, 20);
            this.cityTextBox.TabIndex = 8;
            this.cityTextBox.WordWrap = false;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(374, 254);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(121, 20);
            this.zipCodeTextBox.TabIndex = 12;
            // 
            // statesDataSet
            // 
            this.statesDataSet.DataSetName = "StatesDataSet";
            this.statesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.statesDataSet;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Chapter18.CustomerMaintenance.StatesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stateNameComboBox
            // 
            this.stateNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customersBindingSource, "State", true));
            this.stateNameComboBox.DataSource = this.statesBindingSource;
            this.stateNameComboBox.DisplayMember = "StateName";
            this.stateNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateNameComboBox.FormattingEnabled = true;
            this.stateNameComboBox.Location = new System.Drawing.Point(80, 253);
            this.stateNameComboBox.Name = "stateNameComboBox";
            this.stateNameComboBox.Size = new System.Drawing.Size(201, 21);
            this.stateNameComboBox.TabIndex = 10;
            this.stateNameComboBox.ValueMember = "StateCode";
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIdToolStripLabel,
            this.customerIdToolStripTextBox,
            this.fillByCustomerIdToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(521, 25);
            this.fillByToolStrip.TabIndex = 13;
            this.fillByToolStrip.Text = "fillByCustomerIDToolStrip";
            // 
            // customerIdToolStripLabel
            // 
            this.customerIdToolStripLabel.Name = "customerIdToolStripLabel";
            this.customerIdToolStripLabel.Size = new System.Drawing.Size(73, 22);
            this.customerIdToolStripLabel.Text = "CustomerID:";
            // 
            // customerIdToolStripTextBox
            // 
            this.customerIdToolStripTextBox.Name = "customerIdToolStripTextBox";
            this.customerIdToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByCustomerIdToolStripButton
            // 
            this.fillByCustomerIdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByCustomerIdToolStripButton.Name = "fillByCustomerIdToolStripButton";
            this.fillByCustomerIdToolStripButton.Size = new System.Drawing.Size(102, 22);
            this.fillByCustomerIdToolStripButton.Text = "FillByCustomerID";
            this.fillByCustomerIdToolStripButton.Click += new System.EventHandler(this.fillByCustomerIDToolStripButton_Click);
            // 
            // fillByZipCodeToolStrip
            // 
            this.fillByZipCodeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zipCodeToolStripLabel,
            this.zipCodeToolStripTextBox,
            this.fillByZipCodeToolStripButton});
            this.fillByZipCodeToolStrip.Location = new System.Drawing.Point(0, 50);
            this.fillByZipCodeToolStrip.Name = "fillByZipCodeToolStrip";
            this.fillByZipCodeToolStrip.Size = new System.Drawing.Size(521, 25);
            this.fillByZipCodeToolStrip.TabIndex = 14;
            this.fillByZipCodeToolStrip.Text = "fillByZipCodeToolStrip";
            // 
            // zipCodeToolStripLabel
            // 
            this.zipCodeToolStripLabel.Name = "zipCodeToolStripLabel";
            this.zipCodeToolStripLabel.Size = new System.Drawing.Size(55, 22);
            this.zipCodeToolStripLabel.Text = "ZipCode:";
            // 
            // zipCodeToolStripTextBox
            // 
            this.zipCodeToolStripTextBox.Name = "zipCodeToolStripTextBox";
            this.zipCodeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByZipCodeToolStripButton
            // 
            this.fillByZipCodeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByZipCodeToolStripButton.Name = "fillByZipCodeToolStripButton";
            this.fillByZipCodeToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.fillByZipCodeToolStripButton.Text = "FillByZipCode";
            this.fillByZipCodeToolStripButton.Click += new System.EventHandler(this.fillByZipCodeToolStripButton_Click);
            // 
            // fillByStateToolStrip
            // 
            this.fillByStateToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stateToolStripLabel,
            this.stateToolStripTextBox,
            this.fillByStateToolStripButton});
            this.fillByStateToolStrip.Location = new System.Drawing.Point(0, 75);
            this.fillByStateToolStrip.Name = "fillByStateToolStrip";
            this.fillByStateToolStrip.Size = new System.Drawing.Size(521, 25);
            this.fillByStateToolStrip.TabIndex = 15;
            this.fillByStateToolStrip.Text = "fillByStateToolStrip";
            // 
            // stateToolStripLabel
            // 
            this.stateToolStripLabel.Name = "stateToolStripLabel";
            this.stateToolStripLabel.Size = new System.Drawing.Size(36, 22);
            this.stateToolStripLabel.Text = "State:";
            // 
            // fillByStateToolStripButton
            // 
            this.fillByStateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByStateToolStripButton.Name = "fillByStateToolStripButton";
            this.fillByStateToolStripButton.Size = new System.Drawing.Size(65, 22);
            this.fillByStateToolStripButton.Text = "FillByState";
            this.fillByStateToolStripButton.Click += new System.EventHandler(this.fillByStateToolStripButton_Click);
            // 
            // stateToolStripTextBox
            // 
            this.stateToolStripTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateToolStripTextBox.Name = "stateToolStripTextBox";
            this.stateToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // frmCustomerMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 299);
            this.Controls.Add(this.fillByStateToolStrip);
            this.Controls.Add(this.fillByZipCodeToolStrip);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(stateNameLabel);
            this.Controls.Add(this.stateNameComboBox);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.customersBindingNavigator);
            this.Name = "frmCustomerMaintenance";
            this.Text = "Customer Maintenance";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillByZipCodeToolStrip.ResumeLayout(false);
            this.fillByZipCodeToolStrip.PerformLayout();
            this.fillByStateToolStrip.ResumeLayout(false);
            this.fillByStateToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MMABooksDataSet mMABooksDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private MMABooksDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private MMABooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private StatesDataSet statesDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private StatesDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private StatesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox stateNameComboBox;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel customerIdToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox customerIdToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByCustomerIdToolStripButton;
        private System.Windows.Forms.ToolStrip fillByZipCodeToolStrip;
        private System.Windows.Forms.ToolStripLabel zipCodeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox zipCodeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByZipCodeToolStripButton;
        private System.Windows.Forms.ToolStrip fillByStateToolStrip;
        private System.Windows.Forms.ToolStripLabel stateToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillByStateToolStripButton;
        private System.Windows.Forms.ToolStripComboBox stateToolStripTextBox;
    }
}

