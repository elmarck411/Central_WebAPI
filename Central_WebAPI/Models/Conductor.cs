using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Central_WebAPI.Models
{

    public class Conductor
    {

        public Conductor(string nombre, string numLicencia, string tipoLicencia)
        {
            _nombre = nombre;
            _numLicencia = numLicencia;
            _tipoLicencia = tipoLicencia;
        }
        //Nombre completo del conductor
        private string _nombre;
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        //Numero de licencia
        private string _numLicencia;
        public string NumLicencia
        {
            get
            {
                return _numLicencia;
            }
            set
            {
                _numLicencia = value;
            }
        }

        //Tipo de licencia
        private string _tipoLicencia;
        public string TipoLicencia
        {
            get
            {
                return _tipoLicencia;
            }
            set
            {
                _tipoLicencia = value;
            }
        }



    }
}