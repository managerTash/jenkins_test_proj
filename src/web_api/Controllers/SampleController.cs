using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {

        [HttpGet("[action]")]
        public (bool, string) GetData()
        {
            return (true, "This is a test response");
        }
    }
}