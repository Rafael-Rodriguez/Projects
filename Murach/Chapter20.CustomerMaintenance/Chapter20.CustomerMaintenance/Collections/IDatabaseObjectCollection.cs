namespace Chapter20.CustomerMaintenance.Collections
{
    public interface IDatabaseObjectCollection : ICollection
    {
        TDatabaseObjectType GetDbo<TDatabaseObjectType>();
    }
}
