using FoodOrderingApp.Domain.Entities;

namespace FoodOrderingApp.Domain.Contracts
{
    public interface IOrderRepository
    {
        void SaveOrder(Order order);
    }
}
