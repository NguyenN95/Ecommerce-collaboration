using Ecommerce.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Products;

public class ProductsController : BaseApiController
{
    private readonly List<Product> newProduct = new(){
         new Product{
            ID = 1,
            NameProduct = "sách",
            PriceProduct = 100000,
            QuantitySold = 5,
            StatusProduct = true
        },
        new Product{
            ID = 2,
            NameProduct = "vở",
            PriceProduct = 200000,
            QuantitySold = 1,
            StatusProduct = true
        }
    };

    [HttpGet]
    public IActionResult ShowProduct()
    {
        return Ok(newProduct);
    }
}
