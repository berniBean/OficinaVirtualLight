using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace WindowsFormsApp6.Helper
{
    public static class CadenaTextoHelper
    {

        public static string QuitarDespuesDelEspacio(string texto)
        {
            int indiceEspacio = texto.IndexOf(' ');

            if (indiceEspacio != -1)
            {
                return texto.Substring(0, indiceEspacio);
            }

            return texto; // Devuelve el texto original si no hay espacio
        }

        public static string QuitarAcentosYReemplazarEspacios(string texto)
        {
            // Quitar acentos
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            Regex regex = new Regex(@"\p{Mn}");
            string textoSinAcentos = regex.Replace(textoNormalizado, "");

            // Reemplazar espacios en blanco con guión bajo
            return textoSinAcentos.Replace(" ", "_");
        }

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
