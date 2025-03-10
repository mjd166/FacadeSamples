namespace FoodOrderingApp.Domain.Contracts
{
    public interface IAuthenticationService
    {
        bool Authenticate(string userId);
    }
}
