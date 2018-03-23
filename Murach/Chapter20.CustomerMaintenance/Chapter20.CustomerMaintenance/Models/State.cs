namespace Chapter20.CustomerMaintenance.Models
{
    public sealed class State : IState
    {
        public string StateCode { get; set; }
        public string StateName { get; set; }
    }
}
