using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Central_WebAPI.Models
{
    public class ListRepSin
    {
        public int status { get; set; }
        public RepSiniestro[] listaSiniestros { get; set; }
    }
}