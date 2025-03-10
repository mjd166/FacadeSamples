namespace FoodOrderingApp.Domain.Entities
{
    public class Order
    {
        public string UserId { get; set; }
        public string Food { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
