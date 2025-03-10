namespace FoodOrderingApp.Domain.Contracts
{
    public interface IPricingService
    {
        decimal CalculatePrice(string food, int quantity);
    }
}
