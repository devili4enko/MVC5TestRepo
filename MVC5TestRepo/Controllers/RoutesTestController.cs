using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC5TestRepo.Controllers
{
    public class RoutesTestController : ApiController
    {
        [Route("api/test")]
        public IHttpActionResult Get()
        {
            return Ok();
        }

        [Route("api/test/{id}")]
        public IHttpActionResult Get(int id)
        {
            return Ok(id);
        }

        [Route("api/test")]
        [HttpPost]
        public IHttpActionResult Get([FromBody]string id)
        {
            return Ok(id);
        }
    }
}