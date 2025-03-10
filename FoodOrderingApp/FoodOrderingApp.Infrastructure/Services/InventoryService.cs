
using FoodOrderingApp.Domain.Contracts;

namespace FoodOrderingApp.Infrastructure.Services
{
    public class InventoryService : IInventoryService
    {
        public bool CheckAvailability(string restaurant, string food) => true;
    }
}
