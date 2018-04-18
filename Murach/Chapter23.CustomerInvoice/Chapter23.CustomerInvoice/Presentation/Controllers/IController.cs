namespace Chapter23.CustomerInvoice
{
    public interface IController<T> where T: IView
    {
        T View { get; set; }

        void OnLoad();
    }
}