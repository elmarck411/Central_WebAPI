using Central_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
        public string Post(Conductor conductor)
        {
            return "Datos de conductor de post, Nombre: " + conductor.Nombre +
                "Numero Licencia: " + conductor.NumLicencia + "Tipo de Licencia: " +
                conductor.TipoLicencia;
        }
    }
}
