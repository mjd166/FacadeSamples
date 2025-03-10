using FoodOrderingApp.Domain.Contracts;
using FoodOrderingApp.Domain.Entities;
namespace FoodOrderingApp.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void SaveOrder(Order order)
        {
            Console.WriteLine($"Order saved for {order.UserId}: {order.Quantity}x {order.Food} - ${order.TotalPrice}");

        }
    }
}
