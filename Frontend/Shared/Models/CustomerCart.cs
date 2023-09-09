namespace Ecommerce.Shared.Models;

#nullable disable

public class CustomerCart
{
    public string Id { get; set; }
    public List<CustomerCartItem> Items { get; set; } = new();
}