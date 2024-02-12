using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Helpers
{
    public static class DateValidatorHelper
    {
        public static bool ValidDate(DateTime fechaImpresion, DateTime fechaEntrega)
        {
            // Obtener la fecha ingresada en formato dd-MM-yyyy
            //Console.Write("Ingrese una fecha (dd-MM-yyyy): ");
            string inputFecha = Console.ReadLine();

            // Intentar convertir la cadena a un objeto DateTime
            if (!DateTime.TryParseExact(inputFecha, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaIngresada))
            {
                Console.WriteLine("Formato de fecha incorrecto.");
                return false;
            }

            // Verificar si la fecha ingresada está dentro del rango permitido
            if (fechaIngresada < fechaImpresion || fechaIngresada > fechaEntrega)
            {
                Console.WriteLine("La fecha debe estar entre la fecha de impresión y la fecha de entrega.");
                return false;
            }

            // Verificar si la fecha ingresada no es sábado ni domingo
            if (fechaIngresada.DayOfWeek == DayOfWeek.Saturday || fechaIngresada.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("La fecha no puede ser un sábado o domingo.");
                return false;
            }

            // La fecha ingresada cumple con todas las restricciones
            return true;
        }
    }
}
