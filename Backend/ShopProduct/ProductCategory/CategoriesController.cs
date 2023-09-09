using Ecommerce.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.ShopProduct.ProductCategory;

[Route("api/Products/[controller]")]
public class CategoriesController : BaseApiController
{
    [HttpGet]
    public IActionResult GetCategories()
    {
        return Ok();
    }
}