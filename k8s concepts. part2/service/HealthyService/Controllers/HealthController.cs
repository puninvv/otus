using System.Threading.Tasks;
using HealthyService.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthyService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public async Task<HealthStatus> GetStatus()
        {
            return new HealthStatus()
            {
                Status = Status.OK,
            };
        }
    }
}
