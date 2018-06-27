using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HttpErrorResponseApi.Controllers
{
    [Route("api/server")]
    [ApiController]
    public class ServerController: ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
            => StatusCode(StatusCodes.Status502BadGateway);        
    }
}
