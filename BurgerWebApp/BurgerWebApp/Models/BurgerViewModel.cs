using BurgerWebApp.DomainModels.Enums;

namespace BurgerWebApp.Models
{
    public class BurgerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public IsVegan IsVegan { get; set; }
        public IsVegetarian IsVegetarian { get; set; }
        public HasFries HasFries { get; set; }
    }
}
