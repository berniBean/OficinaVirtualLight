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
    public abstract class InfoFiles
    {
        public string[] dir { get; set; }
        private IDirectionService _directionService;
        private IDataFileService _dataFileService;


        public IDataFileService DataFileService
        {
            set { _dataFileService = value; }
        }
        public InfoFiles()
        {

        }
        public InfoFiles(IDirectionService DirectionService, IDataFileService DataFileService)
        {
            _directionService = DirectionService;
            _dataFileService = DataFileService;
            
        }

        public void performDirection()
        {
            _directionService.fileDirection(dir);
            
        }

        public string performTypeFile()
        {
            return _directionService.TypeFile();
        }

        public List<ChocoPdfs> performNameFiles()
        {
            return _dataFileService.dataFile(string.Join(" ", dir));
            
        }

        public List<ChocoPdfs> PerformClearList()
        {
           return  _dataFileService.deleteFile();
        }


    }
}
