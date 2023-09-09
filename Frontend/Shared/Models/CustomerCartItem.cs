namespace Ecommerce.Shared.Models;

public class CustomerCartItem
{
    public int ProductId { get; set; }
    public required string ProductName { get; set; }
    public string? ImageUrl { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}