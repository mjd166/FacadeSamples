
using FoodOrderingApp.Domain.Contracts;
using FoodOrderingApp.Domain.Entities;

namespace OrderingApp.Application.Services
{
    public class OrderFacade
    {
        private readonly IAuthenticationService _authService;
        private readonly IInventoryService _inventoryService;
        private readonly IPricingService _pricingService;
        private readonly IPaymentService _paymentService;
        private readonly IOrderRepository _orderRepository;
        private readonly INotificationService _notificationService;

        public OrderFacade(IAuthenticationService authService, IInventoryService inventoryService, IPricingService pricingService, IPaymentService paymentService, IOrderRepository orderRepository, INotificationService notificationService)
        {
            _authService = authService;
            _inventoryService = inventoryService;
            _pricingService = pricingService;
            _paymentService = paymentService;
            _orderRepository = orderRepository;
            _notificationService = notificationService;
        }

        public void PlaceOrder(string userId,string restaurant,string food,int quantity)
        {
            if (!_authService.Authenticate(userId))
                throw new Exception("Authentication Failed.");
            if (!_inventoryService.CheckAvailability(restaurant, food))
                throw new Exception("Food not availabile");
            var price= _pricingService.CalculatePrice(food, quantity);
            if (!_paymentService.ProcessPayment(userId, price))
                throw new Exception("Payment Failed");

            var order = new Order
            {
                 Food = food,
                 Quantity = quantity,
                 TotalPrice = price,
                 UserId=userId,
            };

            _orderRepository.SaveOrder(order);
            _notificationService.SendConfirmation(userId);

        }
    }
}
