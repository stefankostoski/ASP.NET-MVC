using BurgerWebApp.DomainModels;

namespace BurgerWebApp.DomainModel
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int BurgerId { get; set; }
        public Burger Burger { get; set; }
        public decimal PricePerItem { get; set; }
        public int Quantity { get; set; }
        public OrderDetails()
        {

        }
        public OrderDetails(int orderId, int burgerId, decimal priceperitem, int quantity)
        {
            OrderId = orderId;
            BurgerId = burgerId;
            PricePerItem = priceperitem;
            Quantity = quantity;
        }
    }
}
