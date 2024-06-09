using Microsoft.AspNetCore.Mvc;
using NetworkInfoApi.Services;

namespace NetworkInfoApi.Controllers
{
    [Route("/networkinfo")]
    [ApiController]
    public class NetworkInterfaceController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var results = NetworkInterfaceService.GetNetworkInfo();
            if (results.Count > 0)
                return Ok(results);
            return NotFound();
        }
    }
}