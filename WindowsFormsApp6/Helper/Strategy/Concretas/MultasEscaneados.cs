

using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.Helper.Strategy.Concretas
{
    internal class MultasEscaneados : UrlSetter, IPDFSwitch
    {
        public CListaURL listaUrl { set; get; }
        public MultasEscaneados(int tipo) : base(tipo)
        {
        }

        public string SelectPDF(string type)
        {
            listaUrl = obUrl.listaURI();

            var ruta = listaUrl[2]._URL.ToString();

            return ruta;
        }
    }
}
