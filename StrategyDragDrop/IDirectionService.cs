using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IDirectionService
    {
         void fileDirection(string[] dir);
         string TypeFile();
    }
}
