using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Helper
{
    public static class CadenaTextoHelper
    {
        public static string NormalizarTexto(string texto)
        {

            // Normaliza el texto para separar los caracteres base de los diacríticos
            string textoFormD = texto.Normalize(NormalizationForm.FormD);

            // Filtra los caracteres eliminando los diacríticos
            StringBuilder sb = new StringBuilder();
            foreach (char c in textoFormD)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            // Normaliza de nuevo para garantizar la composición adecuada de caracteres
            string textoSinAcentos = sb.ToString().Normalize(NormalizationForm.FormC);

            // Reemplaza los espacios en blanco por guiones bajos
            string textoNormalizado = textoSinAcentos.Replace(' ', '_');

            return textoNormalizado;
            //// Utiliza LINQ para convertir las letras acentuadas a letras sin acento
            //string textoSinAcentos = new string(texto
            //    .Select(c => char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.NonSpacingMark ? default(char) : c)
            //    .ToArray())
            //    .Normalize(System.Text.NormalizationForm.FormC);

            //// Reemplaza los espacios en blanco por guiones bajos
            //string textoNormalizado = textoSinAcentos.Replace(' ', '_');

            //return textoNormalizado;
        }
    }
}
