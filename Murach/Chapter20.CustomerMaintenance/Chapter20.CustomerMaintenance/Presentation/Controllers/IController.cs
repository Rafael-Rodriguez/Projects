using Chapter20.CustomerMaintenance.Presentation.Views;
using System;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public interface IController<T> : IDisposable where T : IView
    {
        T View { get; set; }
    }
}
