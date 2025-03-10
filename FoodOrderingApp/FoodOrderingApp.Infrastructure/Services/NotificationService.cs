
using FoodOrderingApp.Domain.Contracts;

namespace FoodOrderingApp.Infrastructure.Services
{
    public class NotificationService : INotificationService
    {
        public void SendConfirmation(string userId)
        {
            Console.WriteLine($"Order confirmation sent to user {userId}");
        }
    }
}
