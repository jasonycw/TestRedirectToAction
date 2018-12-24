using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TestApi.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class TestController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() => RedirectToAction("Get", "Values");
    }
}
