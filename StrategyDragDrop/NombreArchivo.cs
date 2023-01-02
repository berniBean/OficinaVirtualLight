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
    public class NombreArchivo : IDataFileService
    {
        private FileInfo direction { get; set; }

        public List<ChocoPdfs> dataFile(string ruta)
        {

            direction = new FileInfo(ruta);


            ChocoPdfs chocho = new ChocoPdfs(direction.Name, direction.FullName);
            ChocolateBoiler.getInstance().addPdf(chocho);

            return ChocolateBoiler.getInstance().readPdf();
        }

        public List<ChocoPdfs> deleteFile()
        {
            return ChocolateBoiler.getInstance().clearPdf();
        }
    }
}
