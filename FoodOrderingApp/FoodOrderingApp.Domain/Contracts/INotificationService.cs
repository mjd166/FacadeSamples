namespace FoodOrderingApp.Domain.Contracts
{
    public interface INotificationService
    {
        void SendConfirmation(string userId);
    }
}
