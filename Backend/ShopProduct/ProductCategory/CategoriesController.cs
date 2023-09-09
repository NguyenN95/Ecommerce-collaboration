using Ecommerce.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.ShopProduct.ProductCategory;

public class CategoriesController : BaseApiController
{
    [HttpGet]
    public IActionResult GetCategories()
    {
        return Ok();
    }
}