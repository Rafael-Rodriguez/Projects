namespace CustomerMaintenanceMVP.Database
{
    public interface IDatabaseObjectCollection
    {
        TDatabaseObjectType GetDataAccessObjects<TDatabaseObjectType>();
    }
}
