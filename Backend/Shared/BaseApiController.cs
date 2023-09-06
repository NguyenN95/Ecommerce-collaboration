using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Shared;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseApiController : ControllerBase
{
    private readonly ILogger? logger;

    protected BaseApiController(ILogger? logger = null)
    {
        this.logger = logger;
    }
}