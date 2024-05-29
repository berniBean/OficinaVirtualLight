using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.Cache
{
    public static class CUserLoggin
    {
        public static int idUser { get; set; }
        public static string nombreSup { get; set; }
        public static string zonaSupervisor { get; set; }
        public static int idEmision { get; set; }
        public static int Ejercicio { get; set; }
        public static string nombreEmision { get; set; }
        public static DateTime fechaEmisionMulta { get; set; }
        public static int totalMultasEmitido { get; set; }
        public static string nombreEmisionMultaRIF { get; set; }
        public static string origenMultaRIF { get; set; }
        public static string tipoMulta { get; set; }
        public static string tipoVentana { get; set; }
        public static string tipoUsuario { get; set; }
        public static string tipoDocumentoDescarga { get; set; }
        public static CEmisionActualBO DetalleEmision { get; set; }
        public static List<CdiasFeriadosBO> DiasFestivos { get; set; }

        public static ListCEmisionActual FechasEmision { get; set; }
        public static CListNotificadores Notificadores { get; set; }
        public static CListaCatObservaciones ListadoObservaciones { get; set; }


    }
}
