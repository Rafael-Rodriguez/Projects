using System.Text;

namespace Chapter21.CustomerTxtAndBinary.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public static Customer FromItemArray(object[] itemArray)
        {
            var customer = new Customer()
            {
                CustomerID = (int)itemArray[0],
                Name = ((string)itemArray[1]).TrimEnd(),
                Address = ((string)itemArray[2]).TrimEnd(),
                City = ((string)itemArray[3]).TrimEnd(),
                State = ((string)itemArray[4]).TrimEnd(),
                ZipCode = ((string)itemArray[5]).TrimEnd()
            };

            return customer;
        }

        public override string ToString()
        {
            var output = string.Format("| {0,10} | {1,25} | {2,30} | {3,25} | {4,5} | {5,10} |", CustomerID, Name, Address, City, State, ZipCode);

            return output;
        }
    }
}
