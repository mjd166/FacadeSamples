using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderingApp.Application.Services;

namespace OrderingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodOrderingApi : ControllerBase
    {
        private readonly OrderFacade _orderFacade;

        public FoodOrderingApi(OrderFacade orderFacade)
        {
            _orderFacade = orderFacade;
        }

        [HttpPost]
        public IActionResult PlaceOrder([FromBody] PlaceOrderRequest request)
        {
            try
            {
                _orderFacade.PlaceOrder(request.UserId, request.Restaurant, request.Food, request.Quantity);
                return Ok("Order placed successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
    }
}
