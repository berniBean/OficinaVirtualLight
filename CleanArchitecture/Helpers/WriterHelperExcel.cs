using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CleanArchitecture.Helpers
{
    public class WriterHelperExcel
    {
        public static string GetNameFile(string NombreTipo)
        {
            string nombre = "";
            var nombreCorrecto = Regex.Replace(NombreTipo, @"[^0-9A-Za-z]", "_", RegexOptions.None);
            nombre = $"Excel_{nombreCorrecto}_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".xlsx";
            return nombre;
        }

        public static void CreateDirectory(string _fileName)
        {
            try
            {
                if (!Directory.Exists(_fileName))
                    Directory.CreateDirectory(_fileName);
            }
            catch (DirectoryNotFoundException ex)
            {

                throw new Exception(ex.Message);
            }


        }

        
    }
}
