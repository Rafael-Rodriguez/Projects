﻿using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Services;
using System;
using System.Windows.Forms;
using Chapter20.CustomerMaintenance.Properties;
using Chapter20.CustomerMaintenance.Models;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public sealed class CustomerMaintenanceController : Controller<CustomerMaintenanceForm>
    {
        public CustomerMaintenanceController(IModuleController moduleController, IDialogService dialogService)
            : base(moduleController, dialogService) { }

        public void OnDeleteButtonClicked(ICustomer customer)
        {
            throw new NotImplementedException();
        }

        public void OnModifyButtonClicked(ICustomer customer)
        {
            if (customer == null)
            {
                DialogService.ShowMessageBox(
                    Resources.NoCustomerInformationErrorMessage,
                    Resources.NoCustomerInformationTitle, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);

                View.SetFocusOnCustomerIdTextBox();
                return;
            }

            var programFlowManager = ModuleController.GetService<IProgramFlowManager>();

            programFlowManager.ModifyExistingCustomer(customer);
        }

        public void OnAddButtonClicked()
        {
            var programFlowManager = ModuleController.GetService<IProgramFlowManager>();

            programFlowManager.AddNewCustomer();
        }

        public void OnGetCustomerButtonClicked(string customerIdText)
        {
            if(!IsValidCustomerId(customerIdText))
            {
                DialogService.ShowMessageBox(
                    Resources.InvalidCustomerIDErrorMessage, 
                    Resources.InvalidEntryTitle);

                View.SetFocusOnCustomerIdTextBox();
                return;
            }

            GetCustomerInfo(customerIdText);
        }

        public void GetCustomerInfo(string text)
        {
            var customerId = ParseCustomerId(text);

            var customer = GetCustomerDbo().GetCustomer(customerId);

            if (customer != null)
            {
                try
                {
                    View.FillWithCustomerInfo(customer);
                }
                catch (ArgumentNullException)
                {
                    DialogService.ShowMessageBox(
                        Resources.InvalidCustomerIDErrorMessage, 
                        Resources.InvalidCustomerIDTitle);

                    View.SetFocusOnCustomerIdTextBox();
                }
            }
            else
            {
                View.ClearControls();
            }
        }

        private static bool IsValidCustomerId(string text)
        {
            int resultingNumber;
            if (text != null && int.TryParse(text, out resultingNumber))
            {
                return true;
            }

            return false;
        }
        
        private int ParseCustomerId(string text)
        {
            if(!IsValidCustomerId(text))
            {
                return -1;
            }

            return int.Parse(text);
        }

        private CustomerDbo GetCustomerDbo()
        {
            return ModuleController.GetCollection<IDatabaseObjectCollection>().GetDbo<CustomerDbo>();
        }

        protected override void Dispose(bool disposing)
        {    
        }
    }
}
