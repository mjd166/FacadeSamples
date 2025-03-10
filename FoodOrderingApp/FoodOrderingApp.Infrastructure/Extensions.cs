using FoodOrderingApp.Domain.Contracts;
using FoodOrderingApp.Infrastructure.Repositories;
using FoodOrderingApp.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using OrderingApp.Application.Services;

namespace FoodOrderingApp.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<IPricingService, PricingService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<INotificationService, NotificationService>();

            services.AddScoped<OrderFacade>();
            return services;
        }
    }
}
