using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class CTableroAdminBO
    {
        //tableroJEFEPLUS
        public int _idEmision { get; set; }
        public string _referenciaNumercia { get; set; }
        public int _anho { get; set; }
        public string _detalleEmision { get; set; }
        public string _observaciones { get; set; }
        public string _notasObservaciones { get; set; }
        public string _malCapturado { get; set; }
        public string _nombreNotificador { get; set; }

        public int _totalEmision { get; set; }

        //Avance Emision General
        public string _zona { get; set; }
        public string _ohe { get; set; }
        public string _municipio { get; set; }
        public int _numReq { get; set; }
        public string _rfc { get; set; }
        public string _tipoc { get; set; }
        public string _numCtrl { get; set; }
        public string _rs { get; set; }
        public string _diligencia { get; set; }
        public DateTime _fechaNotificacion { get; set; }
        public DateTime _fechaCitatorio { get; set; }
        public string _estatus { get; set; }
        public string _pdf { get; set; }
        public int _total { get; set; }
        public int _pendientes { get; set; }
        public int _localizado { get; set; }
        public int _noLocalizado { get; set; }
        public float _porcentajeFalla { get; set; }
        public int _pndPDF { get; set; }

        public DateTime _fechaEmision { get; set; }
        public int _ejercicio { get; set; }
        public int _emision { get; set; }
        
        
        
        
        public string _tipoM { get; set; }

        public int _extp { get; set; }
        public int _incp { get; set; }
        public int _emitido { get; set; }
        public int _enviados { get; set; }
        public int _pendiente { get; set; }
        public int _noGenerados { get; set; }
        public int _noTrabajado { get; set; }
        public float _avance { get; set; }
        public string _nombreEmisionMultaRIF { get; set; }
        public string _origenMultaRIF { get; set; }

        public int _vencidos { get; set; }
        public int _cobrados { get; set; }

        public float _totalImporte { get; set; }
        public float _honorarios { get; set; }

        public CTableroAdminBO() { }

        
        //tablero administador
        public CTableroAdminBO(int IdEmision, string ReferenciaNumerica, int Ahno,string DetalleEmision) 
        {
            _idEmision = IdEmision;
            _referenciaNumercia = ReferenciaNumerica;
            _anho = Ahno;
            _detalleEmision = DetalleEmision;
        }
        //multas plus
        public CTableroAdminBO(int IdEmision, string ReferenciaNumerica, DateTime fechaEmision, int Ahno, string DetalleEmision)
        {
            _idEmision = IdEmision;
            _referenciaNumercia = ReferenciaNumerica;
            _fechaEmision = fechaEmision;
            _anho = Ahno;            
            _detalleEmision = DetalleEmision;
        }
        public CTableroAdminBO( int Ahno)
        {
            _anho = Ahno;
        }
        //Avance Emision General
        public CTableroAdminBO(string Zona, string Ohe,  int Total, int Pendientes,int Localizado, int NoLocalizado,int NoTrabajado, float Porcentaje, int PndPDF)
        {
            _zona = Zona;
            _ohe = Ohe;
            _total = Total;
            _pendientes = Pendientes;
            _localizado = Localizado;
            _noLocalizado = NoLocalizado;
            _noTrabajado = NoTrabajado;
            _porcentajeFalla = Porcentaje;
            _pndPDF = PndPDF;
         }


        //Listado Requerimientos Completo
        public CTableroAdminBO(string Zona, string Ohe,string municipio, int NumReq, string RFC,string TipoC, string NumCtrl, string Rs,  string Diligencia, DateTime Notificacion, DateTime Citatorio, string Estatus, string PDF,string malCapturado ,string observaciones, string notas, string notificador) 
        {
            _zona = Zona;
            _ohe = Ohe;
            _municipio = municipio;
            _numReq = NumReq;
            _rfc = RFC;
            _tipoc = TipoC;
            _numCtrl = NumCtrl;
            _rs = Rs;
            _diligencia = Diligencia;
            _fechaNotificacion = Notificacion;
            _fechaCitatorio = Citatorio;
            _estatus = Estatus;
            _pdf = PDF;
            _malCapturado = malCapturado;
            _observaciones = observaciones;
            _notasObservaciones = notas;
            _nombreNotificador = notificador;
        }

        //RIF
        public CTableroAdminBO(string Zona, string Ohe, string municipio, int NumReq, string RFC, string NumCtrl, string Rs, string Diligencia, DateTime Notificacion, DateTime Citatorio, string Estatus, string PDF)
        {
            _zona = Zona;
            _ohe = Ohe;
            _municipio = municipio;
            _numReq = NumReq;
            _rfc = RFC;            
            _numCtrl = NumCtrl;
            _rs = Rs;
            _diligencia = Diligencia;
            _fechaNotificacion = Notificacion;
            _fechaCitatorio = Citatorio;
            _estatus = Estatus;
            _pdf = PDF;
        }


        //tablero multasRIF supervisor
        public CTableroAdminBO(int Ejercicio, int Emision, DateTime FechaEmision, int Extp, int Incp, int Emitido, int Enviado, int Pendiente, int Vencidos, int Cobrados, float TotalImporte,float Honorarios, string NombreMultaRIF, string OrigenMultaRIF, int PndPDF)
        {
            _ejercicio = Ejercicio;
            _emision = Emision;
            _fechaEmision = FechaEmision;
            _extp = Extp;
            _incp = Incp;
            _emitido = Emitido;
            _enviados = Enviado;
            _pendiente = Pendiente;
            _vencidos = Vencidos;
            _cobrados = Cobrados;
            _totalImporte = TotalImporte;
            _honorarios = Honorarios;
            _nombreEmisionMultaRIF = NombreMultaRIF;
            _origenMultaRIF = OrigenMultaRIF;
            _pndPDF = PndPDF;
        }

        public CTableroAdminBO( string zona, string ohe, int Emitido, int Extp, int Incp, int Pendiente, 
                                int localizado, int noLocalizado, int noTrabajado, int PDF,
                                int Vencidos, int Cobrados, float Honorarios, int total )
        {
            
            _zona = zona;
            _ohe = ohe;
            _emitido = Emitido;
            _extp = Extp;
            _incp = Incp;
            _pendientes = Pendiente;          
            _localizado = localizado;
            _noLocalizado = noLocalizado;
            _noTrabajado = noTrabajado;
            _pndPDF = PDF;
            _vencidos = Vencidos;
            _cobrados = Cobrados;            
            _honorarios = Honorarios;
            _total = total;
            
            
        }


    }
}
