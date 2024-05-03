using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Helper
{
    public static class CadenaTextoHelper
    {
        public static string NormalizarTexto(string texto)
        {
            // Utiliza LINQ para convertir las letras acentuadas a letras sin acento
            string textoSinAcentos = new string(texto
                .Select(c => char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.NonSpacingMark ? default(char) : c)
                .ToArray())
                .Normalize(System.Text.NormalizationForm.FormC);

            // Reemplaza los espacios en blanco por guiones bajos
            string textoNormalizado = textoSinAcentos.Replace(' ', '_');

            return textoNormalizado;
        }
    }
}
