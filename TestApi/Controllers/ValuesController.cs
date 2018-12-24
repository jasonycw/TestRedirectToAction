using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestApi.Model;

namespace TestApi.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ValuesController : ControllerBase
    {
        // GET api/values/test?id=123
        [HttpGet("test")]
        public ActionResult<IEnumerable<string>> Test([FromQuery]Query q) => Ok(q);

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() => new string[] { "value1", "value2" };

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id) => "value";

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
