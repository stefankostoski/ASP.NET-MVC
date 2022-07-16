using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerWebApp.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Burger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVegan = table.Column<int>(type: "int", nullable: false),
                    IsVegetarian = table.Column<int>(type: "int", nullable: false),
                    HasFries = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelivered = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    BurgerId = table.Column<int>(type: "int", nullable: false),
                    PricePerItem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Burger_BurgerId",
                        column: x => x.BurgerId,
                        principalTable: "Burger",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Burger",
                columns: new[] { "Id", "HasFries", "Image", "IsVegan", "IsVegetarian", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 2, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Big-Mac-1:product-header-desktop", 2, 1, "Big Mac", 230m },
                    { 2, 2, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Quarter-Pounder-with-Cheese-1:product-header-desktop", 2, 1, "Quarter Pounder with Cheese", 200m },
                    { 3, 2, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Quarter-Pounder-with-Cheese-1:product-header-desktop", 2, 1, "Quarter Pounder with Cheese", 200m },
                    { 4, 1, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Quarter-Pounder-with-Cheese-1:product-header-desktop", 2, 1, "McDouble", 210m },
                    { 5, 2, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Double-Cheeseburger-1:product-header-desktop", 1, 1, "Double Cheeseburger", 300m },
                    { 6, 1, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-qpc-deluxe-burger:product-header-desktop", 2, 1, "Quarter Pounder with Cheese Deluxe", 300m },
                    { 7, 1, "https://s7d1.scene7.com/is/image/mcdonalds/t-mcdonalds-Hamburger:product-header-desktop", 2, 2, "Hamburger", 350m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_BurgerId",
                table: "OrderDetails",
                column: "BurgerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Burger");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
