using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerWebApp.DataAccess.Migrations
{
    public partial class seedordertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "Address", "FullName", "IsDelivered", "Location" },
                values: new object[,]
                {
                    { 1, "Ilindenska bb.", "Stefan Kostoski", 1, "Karposh" },
                    { 2, "Uluca i broj", "Risto Panchevski", 1, "Karposh" },
                    { 3, "Partizanska bb.", "Radmila Sokolovska", 1, "Centar" },
                    { 4, "Tetovska Ulica bb.", "Marko Markoski", 1, "Aerodrom" },
                    { 5, "Zelezara bb.", "Mirko Mirkoski", 1, "Zelezara" },
                    { 6, "Ilindenska bb.", "Trpe Trpeski", 1, "Vodno" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
