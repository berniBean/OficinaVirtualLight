using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class CBusquedaRIFBO
    {
        public int _ordenaPor { get; set; }
        public string _emision { get; set; }
        public int _numReq { get; set; }
        public string _numCtrl { get; set; }
        public string _zona { get; set; }
        public string _municipio { get; set; }
        public string _RFC { get; set; }
        public string _RazonSocial { get; set; }
        public string _Diligencia { get; set; }
        public DateTime _FechaCitatorio { get; set; }
        public DateTime _FechaNotificacion { get; set; }


        public CBusquedaRIFBO() { }


        public CBusquedaRIFBO(int ordenad,string emision, int numReq, string numCtrl,string zona, string municipio, string RFC, string RazonSocial, string diligencia, DateTime citatorio, DateTime notificacion)
        {
            _ordenaPor = ordenad;
            _emision = emision;
            _numReq = numReq;
            _numCtrl = numCtrl;
            _zona = zona;
            _municipio = municipio;
            _RFC = RFC;
            _RazonSocial = RazonSocial;
            _Diligencia = diligencia;
            _FechaCitatorio = citatorio;
            _FechaNotificacion = notificacion;

        }





    }



}
