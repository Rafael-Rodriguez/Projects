namespace CustomerMaintenanceMVP.Models
{
    public interface ICustomer
    {
        string Name { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
        int CustomerId { get; set; }
    }
}
