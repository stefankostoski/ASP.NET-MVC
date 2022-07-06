namespace BurgerWebApp.DomainModels
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int BurgerId { get; set; }
        public int Quantity { get; set; }
        public OrderDetails()
        {

        }
        public OrderDetails(int id, int burgerId, int quantity)
        {
            Id = id;
            BurgerId = burgerId;
            Quantity = quantity;
        }
    }
}
