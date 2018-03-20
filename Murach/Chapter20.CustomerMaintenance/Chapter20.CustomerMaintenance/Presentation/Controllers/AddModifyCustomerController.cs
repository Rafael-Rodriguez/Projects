﻿using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Presentation.Views;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public sealed class AddModifyCustomerController : Controller<AddModifyCustomerForm>
    {
        public AddModifyCustomerController(IModuleController moduleController)
            :base(moduleController) { }

        public void OnLoad()
        {
            //var states = GetStatesDbo().GetStates();
            //View.FillStateComboBox(states);
        }

        public void OnAcceptButtonClicked(CustomerEventArgs eventArgs)
        {

        }

        public void OnCancelButtonClicked()
        {

        }

        protected override void Dispose(bool disposing)
        {
            
        }

        private StatesDbo GetStatesDbo()
        {
            return ModuleController.GetCollection<IDatabaseObjectCollection>().GetDbo<StatesDbo>();
        }
    }
}
