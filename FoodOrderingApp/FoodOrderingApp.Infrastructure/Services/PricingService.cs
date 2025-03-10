
using FoodOrderingApp.Domain.Contracts;

namespace FoodOrderingApp.Infrastructure.Services
{
    public class PricingService : IPricingService
    {
        public decimal CalculatePrice(string food, int quantity) => quantity * 10m;
    }
}
