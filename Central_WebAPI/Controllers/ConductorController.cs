using Central_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Central_WebAPI.Controllers
{
    public class ConductorController : ApiController
    {
        // GET: api/Conductor
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Conductor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Conductor
        [ResponseType (typeof(Conductor))]
        public IHttpActionResult Post(Conductor conductor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return CreatedAtRoute("api/Conductor/1", new { Nombre = conductor.Nombre, NumLicencia = conductor.NumLicencia, TipoLicencia = conductor.TipoLicencia } , conductor);
        }
    }
}
