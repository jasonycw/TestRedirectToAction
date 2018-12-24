using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestApi.Model;

namespace TestApi.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class TestController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() 
            => RedirectToAction("Get", "Values", new { version = "1.0" });

        [HttpGet("redirect")]
        public ActionResult<IEnumerable<string>> Redirect([FromQuery]Query q) 
            => RedirectToAction("Test", "Values", new { version = "1.0", id = q.Id });
    }
}
