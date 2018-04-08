using System.Windows.Forms;

namespace Chapter21.CustomerTxtAndBinary
{
    public interface IModuleController
    {
        Form Run();

        FormType GetView<FormType>();

        ServiceType GetService<ServiceType>();
    }
}
