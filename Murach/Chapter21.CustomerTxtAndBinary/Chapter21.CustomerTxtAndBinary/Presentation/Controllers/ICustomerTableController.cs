using Chapter21.CustomerTxtAndBinary.Presentation.Views;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Chapter21.CustomerTxtAndBinary.Presentation.Controllers
{
    public interface ICustomerTableController<T> : IController<T> where T : IView
    {
        void OnSaveAsClicked(IEnumerable<DataRow> items);
    }
}
