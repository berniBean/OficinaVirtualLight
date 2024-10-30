using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.Helper.Strategy.Concretas
{
    public class RequerimientoEscaneado : UrlSetter, IPDFSwitch
    {

        public CListaURL listaUrl { set; get; }
        public ListPdfSql listadoPDFDB { set; get; }

        public RequerimientoEscaneado(int tipo) : base(tipo)
        {
        }

        public string SelectPDF(string type)
        {
            listaUrl = obURLR.listaURI();

            var ruta = listaUrl[0]._URL.ToString();

            return ruta;
        }
    }
}
