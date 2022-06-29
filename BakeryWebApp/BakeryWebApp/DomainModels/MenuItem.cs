namespace BakeryWebApp.DomainModels
{
    public class MenuItem
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public Product Product { get; set; }
        public Size Size { get; set; }
        public decimal Price { get; set; }

        public MenuItem()
        {

        }
        public MenuItem(int id, Category category, Product product, Size size, decimal price)
        {
            Id = id;
            Category = category;
            Product = product;
            Size = size;
            Price = price;
        }
    }
}
