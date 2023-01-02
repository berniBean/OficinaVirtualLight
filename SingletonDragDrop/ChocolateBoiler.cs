using System.Collections.Generic;


namespace Singleton
{
    public class ChocolateBoiler
    {
        private List<ChocoPdfs> ListaPdfs { get; set; }
        private ChocoPdfs itemPdf;

        private static ChocolateBoiler uniqueInstance;
        private ChocolateBoiler()
        {
            ListaPdfs = new List<ChocoPdfs>();
            
        }

        public static ChocolateBoiler getInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new ChocolateBoiler();
            }

            return uniqueInstance;
        }

        public void addPdf(ChocoPdfs item)
        {
            itemPdf = new ChocoPdfs(item._name,item._fullName);
            if(!ListaPdfs.Contains(new ChocoPdfs { _name = itemPdf._name}))
            ListaPdfs.Add(itemPdf);
        }

        public List<ChocoPdfs> clearPdf()
        {
            ListaPdfs.Clear();
            return ListaPdfs;
        }

        public List<ChocoPdfs> readPdf()
        {
            return ListaPdfs;
        }


    }
}
