using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Central_WebAPI.Models
{
    public class RepSiniestro
    {


        //Número de reporte
        private string _numeroReporte;
        public string NumeroReporte{
            get {
                return _numeroReporte;
            }
            set {
                _numeroReporte = value;
            }
        }

        //Dirección de ubicación del siniestro, calle y número
        private string _direccion;
        public string Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }

        //Colonia de la ubicación del siniestro.
        private string _colonia;
        public string Colonia
        {
            get
            {
                return _colonia;
            }
            set
            {
                _colonia = value;
            }
        }

        //Entre cuáles calles sucedió el siniestro
        private string _entreCalles;
        public string EntreCalles
        {
            get
            {
                return _entreCalles;
            }
            set
            {
                _entreCalles = value;
            }
        }

        //Nombre completo del conductor
        private string _nombreConductor;
        public string NombreConductor
        {
            get
            {
                return _nombreConductor;
            }
            set
            {
                _nombreConductor = value;
            }
        }

        //Descripción del vehículo asegurado
        private string _vehiculoAseg;
        public string VehiculoAseg
        {
            get
            {
                return _vehiculoAseg;
            }
            set
            {
                _vehiculoAseg = value;
            }
        }
        //Numero de serie del vehiculo asegurado
        private string _serieVAseg;
        public string SerieVAseg
        {
            get
            {
                return _serieVAseg;
            }
            set
            {
                _serieVAseg = value;
            }
        }

        //Numero de poliza del asegurado
        private string _numeroPoliza;
        public string NumeroPoliza
        {
            get
            {
                return _numeroPoliza;
            }
            set
            {
                _numeroPoliza = value;
            }
        }

        //Estatus de la poliza del asegurado
        private string _estatusPoliza;
        public string EstatusPoliza
        {
            get
            {
                return _estatusPoliza;
            }
            set
            {
                _estatusPoliza = value;
            }
        }

        //Descripcion del vehiculo tercero
        private string _vehicTercero;
        public string VehicTercero
        {
            get
            {
                return _vehicTercero;
            }
            set
            {
                _vehicTercero = value;
            }
        }

        //Causa del siniestro
        private string _causaSiniestro;
        public string CausaSiniestro
        {
            get
            {
                return _causaSiniestro;
            }
            set
            {
                _causaSiniestro = value;
            }
        }

        //Descripción del siniestro
        private string _descSiniestro;
        public string DescSiniestro
        {
            get
            {
                return _descSiniestro;
            }
            set
            {
                _descSiniestro = value;
            }
        }

        public RepSiniestro(
            string numeroReporte,
            string direccion,
            string colonia,
            string entreCalles,
            string nombreConductor,
            string vehiculoAseg,
            string serieVAseg,
             string numeroPoliza, 
             string estatusPoliza, 
             string vehicTercero, 
             string causaSiniestro, 
             string descSiniestro
            )
        {
               _numeroReporte  = numeroReporte;
               _direccion = direccion;
               _colonia  = colonia;
               _entreCalles = entreCalles;
               _nombreConductor  = nombreConductor;
               _vehiculoAseg  = vehiculoAseg;
               _serieVAseg = serieVAseg;
               _numeroPoliza  = numeroPoliza;
               _estatusPoliza  = estatusPoliza;
               _vehicTercero = vehicTercero;
               _causaSiniestro = causaSiniestro;
               _descSiniestro  = descSiniestro;
        }
    }
}