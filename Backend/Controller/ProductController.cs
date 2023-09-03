using Ecommerce.Shared;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.ProductController;

public class ProductController : BaseApiController
{
    private ProductModel newProduct = new ProductModel(){
        ID = 1,
        NameProduct = "sách",
        NumberProduct = 10,
        NumberSale = 5,
        StatusProduct = true
    };

    // private readonly ILogger<WeatherForecastController> _logger;

    // public WeatherForecastController(ILogger<WeatherForecastController> logger)
    // {
    //     _logger = logger;
    // }

    [HttpGet]
    public ActionResult<ProductModel> ShowProduct()
    {
        return newProduct;        
    }
}
