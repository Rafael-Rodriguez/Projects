namespace Chapter20.CustomerMaintenance.Models
{
    public interface IState
    {
        string StateCode { get; set; }
        string StateName { get; set; }
    }
}
