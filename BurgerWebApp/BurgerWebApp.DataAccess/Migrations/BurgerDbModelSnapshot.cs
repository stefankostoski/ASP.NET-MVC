﻿// <auto-generated />
using BurgerWebApp.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgerWebApp.DataAccess.Migrations
{
    [DbContext(typeof(BurgerDb))]
    partial class BurgerDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BurgerWebApp.DomainModel.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BurgerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("PricePerItem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BurgerId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails", (string)null);
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.Burger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("HasFries")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsVegan")
                        .HasColumnType("int");

                    b.Property<int>("IsVegetarian")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Burger", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasFries = 2,
                            Image = "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Big-Mac-1:product-header-desktop",
                            IsVegan = 2,
                            IsVegetarian = 1,
                            Name = "Big Mac",
                            Price = 230m
                        },
                        new
                        {
                            Id = 2,
                            HasFries = 2,
                            Image = "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Quarter-Pounder-with-Cheese-1:product-header-desktop",
                            IsVegan = 2,
                            IsVegetarian = 1,
                            Name = "Quarter Pounder with Cheese",
                            Price = 200m
                        },
                        new
                        {
                            Id = 3,
                            HasFries = 2,
                            Image = "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Quarter-Pounder-with-Cheese-1:product-header-desktop",
                            IsVegan = 2,
                            IsVegetarian = 1,
                            Name = "Quarter Pounder with Cheese",
                            Price = 200m
                        },
                        new
                        {
                            Id = 4,
                            HasFries = 1,
                            Image = "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Quarter-Pounder-with-Cheese-1:product-header-desktop",
                            IsVegan = 2,
                            IsVegetarian = 1,
                            Name = "McDouble",
                            Price = 210m
                        },
                        new
                        {
                            Id = 5,
                            HasFries = 2,
                            Image = "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Double-Cheeseburger-1:product-header-desktop",
                            IsVegan = 1,
                            IsVegetarian = 1,
                            Name = "Double Cheeseburger",
                            Price = 300m
                        },
                        new
                        {
                            Id = 6,
                            HasFries = 1,
                            Image = "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-qpc-deluxe-burger:product-header-desktop",
                            IsVegan = 2,
                            IsVegetarian = 1,
                            Name = "Quarter Pounder with Cheese Deluxe",
                            Price = 300m
                        },
                        new
                        {
                            Id = 7,
                            HasFries = 1,
                            Image = "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Hamburger:product-header-desktop",
                            IsVegan = 2,
                            IsVegetarian = 2,
                            Name = "Hamburger",
                            Price = 350m
                        });
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDelivered")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Order", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Ilindenska bb.",
                            FullName = "Stefan Kostoski",
                            IsDelivered = 1,
                            Location = "Karposh"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Uluca i broj",
                            FullName = "Risto Panchevski",
                            IsDelivered = 1,
                            Location = "Karposh"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Partizanska bb.",
                            FullName = "Radmila Sokolovska",
                            IsDelivered = 1,
                            Location = "Centar"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Tetovska Ulica bb.",
                            FullName = "Marko Markoski",
                            IsDelivered = 1,
                            Location = "Aerodrom"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Zelezara bb.",
                            FullName = "Mirko Mirkoski",
                            IsDelivered = 1,
                            Location = "Zelezara"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Ilindenska bb.",
                            FullName = "Trpe Trpeski",
                            IsDelivered = 1,
                            Location = "Vodno"
                        });
                });

            modelBuilder.Entity("BurgerWebApp.DomainModel.OrderDetails", b =>
                {
                    b.HasOne("BurgerWebApp.DomainModels.Burger", "Burger")
                        .WithMany()
                        .HasForeignKey("BurgerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerWebApp.DomainModels.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Burger");

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
