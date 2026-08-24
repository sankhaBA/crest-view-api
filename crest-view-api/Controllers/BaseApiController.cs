using Microsoft.AspNetCore.Mvc;

namespace crest_view_api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public abstract class BaseApiController : ControllerBase
{
}
