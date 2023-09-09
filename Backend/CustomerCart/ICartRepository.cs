namespace Ecommerce.CustomerCart;

public interface ICartRepository
{
    Task<ShoppingCart?> GetCartAsync(string cartId);
    Task<ShoppingCart?> UpdateCartAsync(ShoppingCart? cart);
    Task DeleteCartAsync(string cartId);
}