namespace Ecommerce.Pages.Products;

public class ProductModel
{
    public int ID { get; set; }

    public string Name { get; set; }

    public int Price { get; set; }

    public int QuantitySold { get; set; }

    public bool Status { get; set; }
}