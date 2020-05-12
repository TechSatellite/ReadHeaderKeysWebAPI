using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadHeaderWebAPI.Controllers
{
    public class SampleController : ApiController
    {
        [HttpGet]
        [HeaderFilter]
        public IHttpActionResult GetData()
        {
            return Ok("hi");
        }
    }
}
