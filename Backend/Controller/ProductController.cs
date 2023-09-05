using Ecommerce.Shared;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.ProductController;

public class ProductController : BaseApiController
{
    private List<ProductModel> newProduct = new List<ProductModel>(){
         new ProductModel{
            ID = 1,
            NameProduct = "sách",
            PriceProduct = 100000,
            QuantitySold = 5,
            StatusProduct = true
        },
        new ProductModel{
            ID = 2,
            NameProduct = "vở",
            PriceProduct = 200000,
            QuantitySold = 1,
            StatusProduct = true
        }
    };
    // private readonly ILogger<WeatherForecastController> _logger;

    // public WeatherForecastController(ILogger<WeatherForecastController> logger)
    // {
    //     _logger = logger;
    // }

    [HttpGet]
    public ActionResult<List<ProductModel>> ShowProduct()
    {
        return newProduct;        
    }
}
