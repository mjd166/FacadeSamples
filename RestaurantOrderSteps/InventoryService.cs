namespace RestaurantOrderSteps
{
    public class InventoryService
    {
        public bool CheckAvailability(string restaurant,string food)
        {
            Console.WriteLine($"Checking availability for {food} in {restaurant}...");
            return true;
        }
    }
    public class OrderFacade
    {
        private readonly InventoryService inventoryService;
        private readonly OrderService orderService;
        private readonly NotificationService notificationService;

        public OrderFacade(InventoryService inventoryService, OrderService orderService, NotificationService notificationService)
        {
            this.inventoryService = inventoryService;
            this.orderService = orderService;
            this.notificationService = notificationService;
        }
        public void CompleteOrder(string restaurant,string food,string customer)
        {
            if (inventoryService.CheckAvailability(restaurant, food))
            {
                orderService.PlaceOrder(food, customer);
                notificationService.Send(customer);
            }
            else
            {
                Console.WriteLine("Food not available.");
            }
        }
    }
}
