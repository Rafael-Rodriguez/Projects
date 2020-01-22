namespace CustomerMaintenanceMVP.Database
{
    public interface IDatabaseObjectCollection
    {
        void CreateDataAccessObjects();

        TDatabaseObjectType GetDataAccessObject<TDatabaseObjectType>();
    }
}
