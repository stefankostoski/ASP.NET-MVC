using BurgerWebApp.DomainModels;
using BurgerWebApp.DomainModels.Enums;
using BurgerWebApp.Helpers;

namespace BurgerWebApp.Storage
{
    public static class BurgerDb
    {
        public static List<Burger> Burgers = new List<Burger>
        {
            new Burger(CommonHelper.GetRandomId(), "Big Mac", 230, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Big-Mac-1:product-header-desktop",IsVegan.No,IsVegetarian.Yes,HasFries.No),
            new Burger(CommonHelper.GetRandomId(), "Quarter Pounder with Cheese", 200, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Quarter-Pounder-with-Cheese-1:product-header-desktop", IsVegan.No,IsVegetarian.Yes,HasFries.No),
            new Burger(CommonHelper.GetRandomId(), "McDouble", 210, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Quarter-Pounder-with-Cheese-1:product-header-desktop", IsVegan.No,IsVegetarian.Yes,HasFries.Yes),
            new Burger(CommonHelper.GetRandomId(), "Double Cheeseburger", 300, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Double-Cheeseburger-1:product-header-desktop",IsVegan.Yes,IsVegetarian.Yes,HasFries.No),
            new Burger(CommonHelper.GetRandomId(), "Quarter Pounder with Cheese Deluxe", 300, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-qpc-deluxe-burger:product-header-desktop", IsVegan.No,IsVegetarian.Yes,HasFries.Yes),
            new Burger(CommonHelper.GetRandomId(), "Hamburger", 350, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Hamburger:product-header-desktop", IsVegan.No,IsVegetarian.No,HasFries.Yes),
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order(CommonHelper.GetRandomId(),"Stefan Kostoski", "Ilindenska bb.", IsDelivered.Yes, "Karposh"),
            new Order(CommonHelper.GetRandomId(),"Risto Panchevski", "Uluca i broj", IsDelivered.Yes, "Karposh"),
            new Order(CommonHelper.GetRandomId(),"Radmila Sokolovska", "Partizanska bb.", IsDelivered.Yes, "Centar"),
            new Order(CommonHelper.GetRandomId(),"Marko Markoski", "Tetovska Ulica bb.", IsDelivered.Yes, "Aerodrom"),
            new Order(CommonHelper.GetRandomId(),"Mirko Mirkoski", "Zelezara bb.", IsDelivered.Yes, "Zelezara"),
            new Order(CommonHelper.GetRandomId(),"Trpe Trpeski", "Ilindenska bb.", IsDelivered.Yes, "Vodno")
        };

    }
}
