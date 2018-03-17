namespace Chapter20.CustomerMaintenance.Views
{
    public interface IView
    {
        IController<IView> Controller { get; set; }
    }
}
