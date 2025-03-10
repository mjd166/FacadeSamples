using RestaurantOrderSteps;

var orderFacade = new OrderFacade(new InventoryService(),new OrderService(),new NotificationService());
orderFacade.CompleteOrder("McDonald's", "Burger", "Majid");