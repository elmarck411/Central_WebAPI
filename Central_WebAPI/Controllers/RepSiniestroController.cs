using Central_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Central_WebAPI.Controllers
{
    public class RepSiniestroController : ApiController
    {
        // GET: api/RepSiniestro
        public IEnumerable<RepSiniestro> Get()
        {
            ListRepSin repSin = new ListRepSin();
            repSin.listaSiniestros = new  RepSiniestro[2];
            repSin.listaSiniestros[0] = new RepSiniestro(
                    "00045024-2016",
                    "AV DE LA LUZ",
                    "VILLA MARIA",
                    "VILLA JARDIN Y ANILLO PERIFERICO NORTE",
                    "FRANCISCO ALEJANDRO MONSIVAS REYES",
                    "NISSAN NP300 ESTACAS D/H ED. ESPECIAL",
                    "3N6DD25T4EK091727",
                    "AUCO-0000050-000080",
                    "VIGENTE / PAGADA",
                    "INTERNATIONAL AUTOBUS",
                    "Colisión",
                    "Choque por alcance");
            repSin.listaSiniestros[1] = new RepSiniestro(
                     "44444444-2016",
                     "AV MEXICO 215",
                     "VILLA ",
                     "CORAL Y DALIAS",
                     "JOSE JUAN RAMIREZ MENDOZA",
                     "JETTA D/H ED. ESPECIAL",
                     "5D53A65S6A5",
                     "JET-0006798-000080",
                     "VIGENTE / PAGADA",
                     "CHEVY MONZA",
                     "Colisión",
                     "Choque por alcance");
            return repSin.listaSiniestros;
        }

        // GET: api/RepSiniestro/5
        public RepSiniestro Get(int id)
        {
            return new RepSiniestro(
                    "UNELE-2016",
                    "AV DE LA LUZ",
                    "VILLA MARIA",
                    "VILLA JARDIN Y ANILLO PERIFERICO NORTE",
                    "FRANCISCO ALEJANDRO MONSIVAS REYES",
                    "NISSAN NP300 ESTACAS D/H ED. ESPECIAL",
                    "3N6DD25T4EK091727",
                    "AUCO-0000050-000080",
                    "VIGENTE / PAGADA",
                    "INTERNATIONAL AUTOBUS",
                    "Colisión",
                    "Choque por alcance");
        }

        // POST: api/RepSiniestro
        public void Post([FromBody]string value)
        {
        }

        /*
        // PUT: api/RepSiniestro/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RepSiniestro/5
        public void Delete(int id)
        {
        }*/ 
    }
}
