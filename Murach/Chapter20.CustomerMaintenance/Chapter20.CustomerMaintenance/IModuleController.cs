using Chapter20.CustomerMaintenance.Services;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance
{
    public interface IModuleController
    {
        Form Run();

        FormType GetView<FormType>();

        ServiceType GetService<ServiceType>();

        CollectionType GetCollection<CollectionType>();
    }
}
