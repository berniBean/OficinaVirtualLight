using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class CInformeAvance
    {
        public string _referenciaNumerica { get; set; }
        public DateTime _fechaImpresion { get; set; }
        public string _nomEmision { get; set; }
        public string _zona { get; set; }
        public int _preparados { get; set; }

        public int _cobrados { get; set; }
        public int _vencidos { get; set; }

        public int _extp { get; set; }
        public int _incp { get; set; }
        public float _totalImporte { get; set; }
        public float _honorarios { get; set; }

        public string _origenMultaRIF { get; set; }

        private string _ohe;
        public string Ohe
        {
            get { return _ohe; }
            set { _ohe = value; }
        }

        private int _totalReq;
        public int TotalReq
        {
            get { return _totalReq; }
            set { _totalReq = value; }
        }

        private int _pendientes;
        public int Pendientes
        {
            get { return _pendientes; }
            set { _pendientes = value; }
        }

        private int _requeridos;
        public int Requeridos
        {
            get { return _requeridos; }
            set { _requeridos = value; }
        }

        private int _localizado;
        public int Localizado
        {
            get { return _localizado; }
            set { _localizado = value; }
        }

        private int _noLocalizado;
        public int NoLocalizado
        {
            get { return _noLocalizado; }
            set { _noLocalizado = value; }
        }

        private int _noTrabajado;
        public int noTrabajado
        {
            get { return _noTrabajado; }
            set { _noTrabajado = value; }
        }
        public int _pndPdf { get; set; }
        public CInformeAvance() { }

        public CInformeAvance(string ohe, int totalReq) {
            _ohe = ohe; _totalReq = totalReq;
        }

        public CInformeAvance(  string ohe, int totalReq, int pendientes, int requeridos, 
                             int localizado,int noLoclizado, int noTrabajado) {
            _ohe = ohe; _totalReq = totalReq; _pendientes = pendientes;
            _requeridos = requeridos; _localizado = localizado; _noLocalizado = noLoclizado; _noTrabajado= noTrabajado;
        }

        public CInformeAvance(string ReferenciaNumerica, DateTime FechaImpreion, string NombreEmision,string Zona,string ohe, int totalReq, int pendientes, int requeridos,
                     int localizado, int noLoclizado, int noTrabajado, int Preparados)
        {
            _referenciaNumerica = ReferenciaNumerica; _fechaImpresion = FechaImpreion; _nomEmision = NombreEmision; _zona = Zona; _ohe = ohe; _totalReq = totalReq; _pendientes = pendientes;
            _requeridos = requeridos; _localizado = localizado; _noLocalizado = noLoclizado; _noTrabajado= noTrabajado; 
            _preparados = Preparados;
        }

        //avance multasRIF
        public CInformeAvance( string Zona, string ohe,int Extp,int Incp,  int totalReq, int Pendiente,
             int localizado, int noLoclizado,int noTrabajado, int Vencidos,int Cobrados, float TotalImporte, float Honorarios, int pndPDF)
        {
            _zona = Zona; _ohe = ohe; _extp = Extp; _incp = Incp; _totalReq = totalReq; _pendientes = Pendiente; _localizado = localizado; _noLocalizado = noLoclizado; _noTrabajado = noTrabajado;
            _vencidos = Vencidos; _cobrados = Cobrados; _totalImporte = TotalImporte; _honorarios = Honorarios; _pndPdf = pndPDF;


        }


    }
}
