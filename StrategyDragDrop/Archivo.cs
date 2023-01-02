using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Archivo : IDirectionService
    {
        public FileInfo fileInfo { get; set; }

        public void fileDirection(string[] dir)
        {

            fileInfo = new FileInfo(string.Join(" ", dir));            
        }
        public string TypeFile()
        {
            return FileSystemInfoAttributes(fileInfo);
        }

        private string FileSystemInfoAttributes(FileSystemInfo fsi)
        {
            string entryType = "File";

            // Determine if entry is really a directory
            if ((fsi.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                entryType = "Directory";
            }
            return entryType;
        }
    }
}
