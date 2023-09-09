namespace Ecommerce.CustomerCart;

public class ShoppingCart
{
    public ShoppingCart()
    {
        // TODO: use random generator or id of user
        Id = "AAA";
    }
    public ShoppingCart(string id)
    {
        Id = id;
    }
    public string Id { get; set; }
    public List<ShoppingCartItem> Items { get; set; } = new();
}