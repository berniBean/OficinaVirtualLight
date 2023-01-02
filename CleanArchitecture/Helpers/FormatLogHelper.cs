using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanArchitecture.Helpers
{
    public class FormatLogHelper
    {
        public static string TipoActa(string Citatorio, string Notificacion, string CitatorioNotificacion)
        {
            string resultado = "";

            if(String.IsNullOrEmpty(Citatorio) && String.IsNullOrEmpty(Notificacion) && String.IsNullOrEmpty(CitatorioNotificacion))
            {
                resultado = "";
            }else if(Citatorio != Convert.ToString(0))
            {
                resultado = "Citatorio";
            }else if (Notificacion != Convert.ToString(0))
            {
                resultado = "Acta de notificación";
            }else if (CitatorioNotificacion != Convert.ToString(0))
            {
                resultado = "Citatorio y Notificación";
            }            
               
            

            return resultado;
        }

        public static string CutNumberOb(string Observacion)
        {
            string resultado = "";
            if (string.IsNullOrEmpty(Observacion))
                return null;

            resultado = Regex.Replace(Observacion, @"[\d-]", string.Empty);
            return resultado;
        }
    }
}
