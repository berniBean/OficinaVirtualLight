using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CarpetasFiles : InfoFiles
    {
        public CarpetasFiles(IDirectionService DirectionService, IDataFileService DataFileService) : base(DirectionService, DataFileService)
        {
            DirectionService = new Archivo();
            DataFileService = new NombreArchivos();
            
        }
    }
}
