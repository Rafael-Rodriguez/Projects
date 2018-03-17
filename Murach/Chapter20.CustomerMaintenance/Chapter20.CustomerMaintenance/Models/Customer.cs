namespace Chapter20.CustomerMaintenance.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public State State { get; set; }
        public string ZipCode { get; set; }
        public int CustomerID { get; set; }
    }
}
