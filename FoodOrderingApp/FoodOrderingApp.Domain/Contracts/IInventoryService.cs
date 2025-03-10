namespace FoodOrderingApp.Domain.Contracts
{
    public interface IInventoryService
    {
        bool CheckAvailability(string restaurant, string food);
    }
}
