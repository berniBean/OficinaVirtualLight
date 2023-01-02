using DragDrop;
using Singleton;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class NombreArchivos :  IDataFileService
    {
        
        
        public DirectoryInfo direction { get; set; }      

        public List<ChocoPdfs> dataFile(string ruta)
        {
            direction = new DirectoryInfo(ruta);
            foreach (var fi in direction.GetFiles())
            {
                ChocoPdfs choco = new ChocoPdfs(fi.Name, fi.FullName); 
                ChocolateBoiler.getInstance().addPdf(choco);
            }

            return ChocolateBoiler.getInstance().readPdf();
        }

        public List<ChocoPdfs> deleteFile()
        {
            return ChocolateBoiler.getInstance().clearPdf();
        }
    }
}
