namespace RestaurantOrderSteps
{
    public class NotificationService
    {
        public void Send(string customer)
        {
            Console.WriteLine($"Confirmation sent to {customer}.");
        }
    }
}
