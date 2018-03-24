using Chapter20.CustomerMaintenance.Models;
using System;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public interface ICustomerMaintenanceView : IView
    {
        string NameTextBox { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }

        void SetFocusOnCustomerIdTextBox();

        void FillWithCustomerInfo(ICustomer customer);

        void RegrabCustomerInfoFromDb();

        void ClearControls();
    }
}
