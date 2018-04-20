namespace Chapter23.CustomerInvoice.Database
{
    public interface IDatabaseAccessObjectCollection
    {
        TDatabaseObjectType GetDataAccessObject<TDatabaseObjectType>();
    }
}
