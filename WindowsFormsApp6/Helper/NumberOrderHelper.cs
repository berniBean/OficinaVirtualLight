using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Helper
{
    public static class NumberOrderHelper
    {
        public static int ObtenerNumeroAntesGuionBajo(string nombreArchivo)
        {
            int guionBajoIndex = nombreArchivo.IndexOf('_');
            if (guionBajoIndex != -1)
            {
                string numeroStr = nombreArchivo.Substring(0, guionBajoIndex);
                if (int.TryParse(numeroStr, out int numero))
                {
                    return numero;
                }
            }
            return 0; // Valor predeterminado si no se puede obtener el número
        }

        public static int ObtenerNumeroAntesGuion(string nombreArchivo)
        {
            int guionBajoIndex = nombreArchivo.IndexOf('-');
            if (guionBajoIndex != -1)
            {
                string numeroStr = nombreArchivo.Substring(0, guionBajoIndex);
                if (int.TryParse(numeroStr, out int numero))
                {
                    return numero;
                }
            }
            return 0; // Valor predeterminado si no se puede obtener el número
        }

        public static Uri ObtenerUrlSecundarias(string ftpAddress)
        {
            Uri uri = new Uri(ftpAddress);

            var newSegments = uri.Segments.Take(uri.Segments.Length - 1).ToArray();
            newSegments[newSegments.Length - 1] =
                newSegments[newSegments.Length - 1].TrimEnd('/');
            var ub = new UriBuilder(uri);
            ub.Path = string.Concat(newSegments);
            //ub.Query=string.Empty;  //maybe?
            var newUri = ub.Uri;

            return (newUri);
        }
    }
}
