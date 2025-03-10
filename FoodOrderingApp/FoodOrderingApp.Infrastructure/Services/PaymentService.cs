
using FoodOrderingApp.Domain.Contracts;

namespace FoodOrderingApp.Infrastructure.Services
{
    public class PaymentService : IPaymentService
    {
        public bool ProcessPayment(string userId, decimal amount) => amount > 0;
    }
}
