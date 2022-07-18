using BurgerWebApp.DomainModels.Enums;

namespace BurgerWebApp.DomainModels
{
    public class Order
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public IsDelivered IsDelivered { get; set; }
        public string Location { get; set; }

        public Order()
        {

        }
        public Order(string fullName, string address, IsDelivered isdelivered, string location)
        {
            FullName = fullName;
            Address = address;
            IsDelivered = isdelivered;
            Location = location;

        }
    }
}
