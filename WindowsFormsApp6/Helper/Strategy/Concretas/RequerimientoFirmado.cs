using System;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.Helper.Strategy.Concretas
{
    public class RequerimientoFirmado : UrlSetter, IPDFSwitch
    {


        public CListaURL listaUrl { set; get; }

        public RequerimientoFirmado(int tipo) : base(tipo)
        {
        }

        public string SelectPDF(string type)
        {
            //ftp://10.1.110.35/PLUS/REQ/67/REQFirma/
            listaUrl = obURLR.listaURI();
            

            var ruta = listaUrl[0]._URL.ToString();

            return ruta;
        }
    }
}
