using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Central_WebAPI.Models
{
    public class Ajustadores
    {
        private string _nombreAjustador;
        private int _idAjustador;
        public Ajustadores(int idAjustador, string nombreAjustador)
        {
            _idAjustador = idAjustador;
            _nombreAjustador = nombreAjustador;
        }
        
        public int Id {
            get
            {
                return _idAjustador;
            }



        }
        public string Nombre {
            get
            {
                return _nombreAjustador;

            }
        }
    }
}