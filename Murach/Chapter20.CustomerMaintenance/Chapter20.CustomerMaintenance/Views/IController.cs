using System;

namespace Chapter20.CustomerMaintenance.Views
{
    public interface IController<T> : IDisposable where T : class
    {
        T View { get; set; }
    }
}
