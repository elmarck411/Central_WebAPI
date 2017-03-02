using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Central_WebAPI.Models
{
    public class ListaAjust
    {
        public int status { get; set; }
        public Ajustadores[] listaAjust { get; set; }
    }
}