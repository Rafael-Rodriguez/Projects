using System.Windows.Forms;

namespace CustomerMaintenanceMVP
{
    public interface IModuleController
    {
        TDatabaseObjectCollectionType GetCollection<TDatabaseObjectCollectionType>();

        TViewType GetView<TViewType>();

        Form Run();
    }
}