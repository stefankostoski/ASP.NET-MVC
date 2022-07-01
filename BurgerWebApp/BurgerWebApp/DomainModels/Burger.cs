using BurgerWebApp.DomainModels.Enums;

namespace BurgerWebApp.DomainModels
{
    public class Burger
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public decimal Price { get; set; }
        public string Image { get; set; }
        public IsVegan IsVegan { get; set; }
        public IsVegetarian IsVegetarian { get; set; }
        public HasFries HasFries { get; set; }
        public Burger()
        {

        }
        public Burger(int id, string name, decimal price, string image, IsVegan isVegan, IsVegetarian isVegetarian, HasFries hasFries)
        {
            Id = id;
            Name = name;
            Price = price;
            Image = image;
            IsVegan = isVegan;
            IsVegetarian = isVegetarian;
            HasFries = hasFries;
        }
    }
}
