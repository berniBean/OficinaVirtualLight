using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class CBusquedaMultasBO
    {
        public string _emision { get; set; }
        public int _emisionMulta { get; set; }
        
        public int _numReq { get; set; }
        public string _municipio { get; set; }
        public string _zona { get; set; }
        public string _tipoMulta { get; set; }
        public string _CtrlMulta { get; set; }
        public DateTime _FechaEmision { get; set; }
        public string _RFC { get; set; }
        public string _numSAT { get; set; }
        public string _RazonSocial { get; set; }
        public string _diligencia { get; set; }
        public DateTime _notificacion { get; set; }
        public DateTime _fechaPago { get; set; }
        public double _honorarios { get; set; }
        public double _importe { get; set; }
        public DateTime _vencimiento { get; set; }
        public string _ejecucion { get; set; }


        public CBusquedaMultasBO() { }


        public CBusquedaMultasBO(string emision, int numReq, string municipio,  string RFC, string RazonSocial)
        {
            _emision = emision;
            _numReq = numReq;
            _municipio = municipio;
            _RFC = RFC;
            _RazonSocial = RazonSocial;

        }


        public CBusquedaMultasBO(string emision,int emisionMulta, int numReq,  string zona, string municipio, string tipoMulta, string CtrlMulta,
                                   DateTime FechaEmision, string RFC, string numSAT, string RazonSocial, string diligencia, DateTime notificacion, 
                                   DateTime fechaPago,double honorarios, double importe, DateTime vencimiento, string ejecucion)
        {
            _emision = emision;
            _emisionMulta = emisionMulta;
            _numReq = numReq;
            _zona = zona; 
            _municipio = municipio;
            _tipoMulta = tipoMulta;
            _CtrlMulta = CtrlMulta;
            _FechaEmision = FechaEmision;
            _RFC = RFC;
            _numSAT = numSAT;
            _RazonSocial = RazonSocial;
            _diligencia = diligencia;
            _notificacion = notificacion;
            _fechaPago = fechaPago;
            _honorarios = honorarios;
            _importe = importe;
            _vencimiento = vencimiento;
            _ejecucion = ejecucion;

        }


    }
}
