namespace Chapter23.CustomerInvoice.Models
{
    public sealed class Customer : ICustomer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int CustomerId { get; set; }
    }
}
