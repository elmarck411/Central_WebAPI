using Central_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Central_WebAPI.Controllers
{
    public class AjustadorController : ApiController
    {
        // GET: api/Ajustador
        public IEnumerable<Ajustadores> Get()
        {
            ListaAjust ajustadores = new ListaAjust();
            ajustadores.listaAjust = new Ajustadores[25];

            for (int i = 0; i < ajustadores.listaAjust.Count(); i++)
            {
                ajustadores.listaAjust[i] = new Ajustadores(15,"Adrian");
            }
            return ajustadores.listaAjust;
        }

        // GET: api/Ajustador/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Ajustador
        [HttpPost]
        public HttpResponseMessage PostAjustadores(Ajustadores ajustador)
        {
            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }

        // PUT: api/Ajustador/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Ajustador/5
        public void Delete(int id)
        {
        }
    }
}
