namespace Ecommerce.Shared.Models;

#nullable disable

public class CustomerCartItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}