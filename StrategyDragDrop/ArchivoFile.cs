using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ArchivoFile : InfoFiles
    {

        public ArchivoFile(IDirectionService DirectionService, IDataFileService DataFileService) : base(DirectionService, DataFileService)
        {
            DirectionService = new Archivo();
            DataFileService = new NombreArchivo();
            
        }
    }
}
