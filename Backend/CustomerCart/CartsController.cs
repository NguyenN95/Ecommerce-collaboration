using Ecommerce.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.CustomerCart;

public class CartsController : BaseApiController
{
    [HttpGet]
    public IActionResult GetCartById(string id)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult UpdateCart(ShoppingCart cart)
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeleteCartById(string id)
    {
        return Ok();
    }
}