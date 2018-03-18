namespace Chapter20.CustomerMaintenance.Collections
{
    public interface IDatabaseObjectCollection : ICollection
    {
        DatabaseObjectType GetDbo<DatabaseObjectType>();
    }
}
