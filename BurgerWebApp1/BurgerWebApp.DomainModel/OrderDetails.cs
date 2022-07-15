namespace BurgerWebApp.DomainModels
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BurgerId { get; set; }
        public decimal PricePerItem { get; set; }
        public int Quantity { get; set; }
        public OrderDetails()
        {

        }
        public OrderDetails(int id,int orderId , int burgerId, decimal priceperitem, int quantity)
        {
            Id = id;
            OrderId = orderId;
            BurgerId = burgerId;
            PricePerItem = priceperitem;
            Quantity = quantity;
        }
    }
}
