namespace Chapter23.CustomerInvoice.Database
{
    public interface IDatabaseObjectCollection
    {
        TDatabaseObjectType GetDbo<TDatabaseObjectType>();
    }
}
