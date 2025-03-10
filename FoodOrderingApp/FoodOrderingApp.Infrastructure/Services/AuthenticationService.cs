
using FoodOrderingApp.Domain.Contracts;

namespace FoodOrderingApp.Infrastructure.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public bool Authenticate(string userId) =>!string.IsNullOrEmpty(userId);
    }
}
