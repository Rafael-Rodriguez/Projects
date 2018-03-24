using Chapter20.CustomerMaintenance.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public interface IDeleteCustomerView : IView
    {
        ICustomer Customer { get; set; }

        IList<string> States { get; }

        DialogResult ShowDialog(ICustomer customer);

        void SetDialogResult(DialogResult result);

        void FillStateComboBox(string[] states);
    }
}
