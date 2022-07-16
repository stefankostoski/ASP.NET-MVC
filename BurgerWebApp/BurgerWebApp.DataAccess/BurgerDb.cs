using BurgerWebApp.DomainModel;
using BurgerWebApp.DomainModels;
using BurgerWebApp.DomainModels.Enums;
using BurgerWebApp.Helpers;
using Microsoft.EntityFrameworkCore;

namespace BurgerWebApp.Storage
{
    public class BurgerDb : DbContext
    {
        public BurgerDb(DbContextOptions<BurgerDb> options) : base(options)
        {
        }

        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Burger>(x => x.ToTable("Burger"));
            /*.Property(x => x.ImageUrl).HasColumnName("URL").HasColumnType("nvarchar(100)")*/
            builder.Entity<OrderDetails>(x => x.ToTable("OrderDetails"));
            builder.Entity<Order>(x => x.ToTable("Order"));



            builder.Entity<Burger>().HasData(
                    new Burger(CommonHelper.GetRandomId(), "Big Mac", 230, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Big-Mac-1:product-header-desktop", IsVegan.No, IsVegetarian.Yes, HasFries.No)
                    {
                        Id = 1
                    },
                    new Burger(CommonHelper.GetRandomId(), "Quarter Pounder with Cheese", 200, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Quarter-Pounder-with-Cheese-1:product-header-desktop", IsVegan.No, IsVegetarian.Yes, HasFries.No)
                    {
                        Id = 2
                    },
                    new Burger(CommonHelper.GetRandomId(), "Quarter Pounder with Cheese", 200, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Quarter-Pounder-with-Cheese-1:product-header-desktop", IsVegan.No, IsVegetarian.Yes, HasFries.No)
                    {
                        Id = 3
                    },
                    new Burger(CommonHelper.GetRandomId(), "McDouble", 210, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Quarter-Pounder-with-Cheese-1:product-header-desktop", IsVegan.No, IsVegetarian.Yes, HasFries.Yes)
                    {
                        Id = 4
                    },
                    new Burger(CommonHelper.GetRandomId(), "Double Cheeseburger", 300, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Double-Cheeseburger-1:product-header-desktop", IsVegan.Yes, IsVegetarian.Yes, HasFries.No)
                    {
                        Id = 5
                    },
                    new Burger(CommonHelper.GetRandomId(), "Quarter Pounder with Cheese Deluxe", 300, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-qpc-deluxe-burger:product-header-desktop", IsVegan.No, IsVegetarian.Yes, HasFries.Yes)
                    {
                        Id = 6
                    },
                    new Burger(CommonHelper.GetRandomId(), "Hamburger", 350, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Hamburger:product-header-desktop", IsVegan.No, IsVegetarian.No, HasFries.Yes)
                    {
                        Id = 7
                    }
                );


            //builder.Entity<Order>().HasData(
            //      new Order(CommonHelper.GetRandomId(), "Stefan Kostoski", "Ilindenska bb.", IsDelivered.Yes, "Karposh")
            //      {
            //          Id = 1
            //      },
            //     new Order(CommonHelper.GetRandomId(), "Risto Panchevski", "Uluca i broj", IsDelivered.Yes, "Karposh")
            //     {
            //         Id = 2
            //     },
            //      new Order(CommonHelper.GetRandomId(), "Radmila Sokolovska", "Partizanska bb.", IsDelivered.Yes, "Centar")
            //      {
            //          Id = 3
            //      },
            //      new Order(CommonHelper.GetRandomId(), "Marko Markoski", "Tetovska Ulica bb.", IsDelivered.Yes, "Aerodrom")
            //      {
            //          Id = 4
            //      },
            //      new Order(CommonHelper.GetRandomId(), "Mirko Mirkoski", "Zelezara bb.", IsDelivered.Yes, "Zelezara")
            //      {
            //          Id = 5
            //      },
            //      new Order(CommonHelper.GetRandomId(), "Trpe Trpeski", "Ilindenska bb.", IsDelivered.Yes, "Vodno")
            //      {
            //          Id = 6
            //      }
            //  );


            //builder.Entity<OrderDetails>().HasData(
            //     new OrderDetails(CommonHelper.GetRandomId(), Orders[1].Id, Burgers[0].Id, Burgers[0].Price, 4)
            //     {
            //         Id = 1
            //     },
            //    new OrderDetails(CommonHelper.GetRandomId(), Orders[1].Id, Burgers[1].Id, Burgers[1].Price, 2)
            //    {
            //        Id = 2
            //    },
            //    new OrderDetails(CommonHelper.GetRandomId(), Orders[2].Id, Burgers[2].Id, Burgers[2].Price, 1)
            //    {
            //        Id = 3
            //    },
            //    new OrderDetails(CommonHelper.GetRandomId(), Orders[4].Id, Burgers[3].Id, Burgers[3].Price, 5)
            //    {
            //        Id = 4
            //    },
            //    new OrderDetails(CommonHelper.GetRandomId(), Orders[3].Id, Burgers[4].Id, Burgers[4].Price, 3)
            //    {
            //        Id = 5
            //    }
            // );
        }
    }
}