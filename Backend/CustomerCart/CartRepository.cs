namespace Ecommerce.CustomerCart;

public class CartRepository : ICartRepository
{
    // TODO: Implement Redis
    private ShoppingCart? mockShoppingCart = new();

    public CartRepository()
    {
        mockShoppingCart.Items.Add(new ShoppingCartItem
        {
            ProductId = 1,
            ImageUrl = "images/product-1.jpg",
            ProductName = "Colorful Stylish Shirt",
            Price = 150,
            Quantity = 10
        });
        mockShoppingCart.Items.Add(new ShoppingCartItem
        {
            ProductId = 2,
            ImageUrl = "images/product-2.jpg",
            ProductName = "Colorful Stylish Pants",
            Price = 200,
            Quantity = 5
        });
    }

    public Task DeleteCartAsync(string cartId)
    {
        if (mockShoppingCart != null)
        {
            mockShoppingCart = null;
        }
        return Task.CompletedTask;
    }

    public Task<ShoppingCart?> GetCartAsync(string cartId)
    {
        return Task.FromResult(mockShoppingCart);
    }

    public Task<ShoppingCart?> UpdateCartAsync(ShoppingCart? cart)
    {
        mockShoppingCart = cart;
        return Task.FromResult(mockShoppingCart);
    }
}