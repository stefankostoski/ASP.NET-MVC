using BurgerWebApp.DomainModels;
using BurgerWebApp.DomainModels.Enums;

namespace BurgerWebApp.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public IsDelivered IsDelivered { get; set; }
        public string Location { get; set; }
    }
}
