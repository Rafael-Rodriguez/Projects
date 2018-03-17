using System;

namespace Chapter20.CustomerMaintenance.Views
{
    public interface IController<T> : IDisposable where T : IView
    {
        T View { get; set; }
    }
}
