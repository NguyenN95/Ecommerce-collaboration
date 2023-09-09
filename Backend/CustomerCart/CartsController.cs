using Ecommerce.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.CustomerCart;

public class CartsController : BaseApiController
{
    private readonly ICartRepository cartRepository;

    public CartsController(ICartRepository cartRepository)
    {
        this.cartRepository = cartRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetCartById(string id)
    {
        var cart = await cartRepository.GetCartAsync(id);
        return Ok(cart ?? new ShoppingCart(id));
    }

    [HttpPost]
    public async Task<IActionResult> UpdateCart(ShoppingCart cart)
    {
        var updatedCart = await cartRepository.UpdateCartAsync(cart);
        return Ok(updatedCart);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteCartById(string id)
    {
        await cartRepository.DeleteCartAsync(id);
        return Ok();
    }
}