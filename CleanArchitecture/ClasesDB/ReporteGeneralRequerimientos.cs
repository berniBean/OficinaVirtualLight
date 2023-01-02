using System;

namespace CleanArchitecture.ClasesDB
{
    public class ReporteGeneralRequerimientos
    {
        public string Zona { get; set; }
        public string Ohe { get; set; }
        public int  NumReq { get; set; }
        public string RFC { get; set; }
        public string NumCtrl { get; set; }
        public string RazonSocial { get; set; }
        public string Diligencia { get; set; }
        public DateTime Notificacion { get; set; }
        public DateTime Citatorio { get; set; }
        public string Observaciones { get; set; }
        public string MalCaputurado { get; set; }
    }
}
