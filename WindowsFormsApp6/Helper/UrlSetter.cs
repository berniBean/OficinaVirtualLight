
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.Helper
{
    public class UrlSetter
    {
        public obtenerURL obUrl { get; }
        public obtenerURL obURLR { get; }
        private CListaURL listaUrl;

        public UrlSetter(int tipo)
        {
            if (tipo == 1)
            {
                obURLR = factoryURL.maker(factoryURL.RIF);
                obUrl = factoryURL.maker(factoryURL.MRIF);
            }
            else if (tipo == 2)
            {
                obURLR = factoryURL.maker(factoryURL.PLUS);
                obUrl = factoryURL.maker(factoryURL.MPLUS);
            }
        }
    }
}
