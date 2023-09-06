using Ecommerce.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Products;

public class ProductsController : BaseApiController
{
    private readonly List<Product> newProduct = new(){
         new Product{
            ID = 1,
            Name = "sách",
            Price = 100000,
            QuantitySold = 5,
            Status = true
        },
        new Product{
            ID = 2,
            Name = "vở",
            Price = 200000,
            QuantitySold = 1,
            Status = true
        }
    };

    [HttpGet]
    public IActionResult ShowProduct()
    {
        return Ok(newProduct);
    }
}
