using DragDrop;
using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IDataFileService
    {
         List<ChocoPdfs> dataFile(string ruta);
         List<ChocoPdfs> deleteFile();

    }
}
