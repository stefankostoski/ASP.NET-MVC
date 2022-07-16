namespace BurgerWebApp.Models
{
    public class OrderDetailsViewModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BurgerId { get; set; }
        public decimal PricePerItem { get; set; }
        public int Quantity { get; set; }
    }
}
