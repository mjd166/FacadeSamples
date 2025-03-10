namespace OrderingApp.API.Controllers
{
    public class PlaceOrderRequest
    {
        public string UserId { get; set; }
        public string Restaurant { get; set; }
        public string Food { get; set; }
        public int Quantity { get; set; }
    }
}
