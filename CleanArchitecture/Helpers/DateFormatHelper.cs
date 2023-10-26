using System;

namespace CleanArchitecture.Helpers
{
    public static class DateFormatHelper
    {
        public static string FechaLetra(DateTime? fechaCorta)
        {
            if (fechaCorta.ToString() == "01/01/0001 12:00:00 a. m.")
                return null;

            var item = Convert.ToDateTime(fechaCorta).ToString(@"dd \de MMMM \de  yyyy");
            return item;
        }

        public static string FechaCorta(DateTime? fecha)
        {

            if (fecha.ToString() == "01/01/0001 12:00:00 a. m.")
                return null;

            var item = Convert.ToDateTime(fecha).ToString("MM/dd/yyyy");
            return item;
        }

        public static string FechaCortaInterop(DateTime? fecha)
        {

            if (fecha.ToString() == "01/01/0001 12:00:00 a. m.")
                return null;

            var item = Convert.ToDateTime(fecha).ToString("dd/MM/yyyy");
            return item;
        }
    }
}
