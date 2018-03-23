using Chapter20.CustomerMaintenance.Models;
using System.Collections.Generic;

namespace Chapter20.CustomerMaintenance.Database
{
    public interface IStatesDbo : IDbo
    {
        IList<State> GetStates();
    }
}
