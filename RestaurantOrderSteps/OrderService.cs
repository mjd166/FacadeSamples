namespace RestaurantOrderSteps
{
    public class OrderService
    {
        public void PlaceOrder(string restaurant, string food)
        {
            Console.WriteLine($"Order placed for {food} from {restaurant}.");
        }
    }
}
