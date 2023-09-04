namespace Ecommerce.Pages.Models;

public class ProductModel
{
    public int ID { get; set; }

    public string? NameProduct { get; set; }

    public int PriceProduct { get; set; }

    public int QuantitySold { get; set; }

    public bool StatusProduct { get; set; }
}
