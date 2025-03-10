namespace FoodOrderingApp.Domain.Contracts
{
    public interface IPaymentService
    {
        bool ProcessPayment(string userId, decimal amount);
    }
}
