using System.Windows.Forms;

namespace Chapter23.CustomerInvoice
{
    public interface IModuleController
    {
        Form Run();

        FormType GetView<FormType>();

        CollectionType GetCollection<CollectionType>();
    }
}
