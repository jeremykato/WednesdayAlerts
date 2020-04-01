using Microsoft.AspNetCore.Mvc;
using WednesdayAlerts.Features.Builders;
using WednesdayAlerts.Models;

namespace WednesdayAlerts.Controllers
{
    [Route("[controller]")]
    public class WednesdayController : ControllerBase
    {
        private readonly IWednesdayStatusBuilder _wednesdayBuilder;

        public WednesdayController(IWednesdayStatusBuilder wednesdayBuilder)
        {
            _wednesdayBuilder = wednesdayBuilder;
        }

        [HttpGet]
        public ActionResult<WednesdayStatus> Get()
        {
            return Ok(_wednesdayBuilder.BuildWednesdayStatus());
        }
    }
}
