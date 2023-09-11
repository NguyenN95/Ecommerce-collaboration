namespace Ecommerce.Pages.ProductsPage;

#nullable disable

public class Product
{
    public int ID { get; set; }

    public string Name { get; set; }

    public string Img { get; set; }

    public double Price { get; set; }

    public int QuantitySold { get; set; }

    public bool Status { get; set; }
}
