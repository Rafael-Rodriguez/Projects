﻿using Chapter20.CustomerMaintenance.Presentation.Controllers;
using System;
using System.Windows.Forms;
using Chapter20.CustomerMaintenance.Models;
using System.Linq;
using System.Collections.Generic;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public partial class AddCustomerForm : Form, IAddCustomerView
    {
        private AddCustomerController _controller;

        public AddCustomerForm(AddCustomerController controller)
        {
            InitializeComponent();

            Controller = controller;
        }

        public AddCustomerController Controller
        {
            get { return _controller; }
            set
            {
                _controller = value;
                _controller.View = this;
            }
        }

        public ICustomer Customer { get; set; }

        public IList<string> States
        {
            get
            {
                return comboBoxStates.Items.Cast<string>().ToList();
            }
        }

        public void FillStateComboBox(string[] states)
        {
            if(states == null)
            {
                throw new ArgumentNullException("states");
            }

            comboBoxStates.Items.AddRange(states);
        }

        public void SetDialogResult(DialogResult result)
        {
            DialogResult = result;
        }

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            Controller.OnAcceptButtonClicked(
                new NewCustomerArgs(
                    address: txtBoxAddress.Text,
                    city: txtBoxCity.Text, 
                    name: txtBoxName.Text, 
                    zipCode: txtBoxZip.Text,
                    state: comboBoxStates.Text));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controller.OnCancelButtonClicked();
        }

        private void AddModifyCustomerForm_Load(object sender, EventArgs e)
        {
            Controller.OnLoad();
        }

        DialogResult IAddCustomerView.ShowDialog()
        {
            return ShowDialog();
        }
    }
}
