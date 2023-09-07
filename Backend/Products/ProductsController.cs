using Ecommerce.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Products;

public class ProductsController : BaseApiController
{
    private readonly List<Product> ListProduct = new(){
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
    public IActionResult ShowAll()
    {
        return Ok(ListProduct);
    }
    [HttpGet("id")]
    public IActionResult GetByID(int id)
    {
        var product = ListProduct!.FirstOrDefault(x => x.ID == id);
        return Ok(product);
    }
    [HttpPost]
    public IActionResult Create(int id, string name, int price)
    {
        Product Product = new Product{
            ID = id,
            Name = name,
            Price = price,
            QuantitySold = 0,
            Status = true, 
        };
        ListProduct.Add(Product);
        return Ok(Product);
    }
    [HttpPut("id")]
    public IActionResult Edit(int id, string name, int price, bool status)
    {
        var product = ListProduct!.FirstOrDefault(x => x.ID == id);
        if(product != null)
        {
            product.Name = name;
            product.Price = price;
            product.Status = status;
        }
        else{
            return Ok("Product does not exist");
        }
        return Ok(product);
    }
}
