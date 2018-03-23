﻿using Chapter20.CustomerMaintenance.Models;
using System;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public interface ICustomerMaintenanceView : IView
    {
        void FillWithCustomerInfo(ICustomer customer);

        void RegrabCustomerInfoFromDb();
    }
}
