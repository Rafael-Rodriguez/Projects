using Chapter20.CustomerMaintenance.Models;
using System;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public interface ICustomerMaintenanceView : IView
    {
        void SetFocusOnCustomerIdTextBox();

        void FillWithCustomerInfo(ICustomer customer);

        void RegrabCustomerInfoFromDb();

        void ClearControls();
    }
}
