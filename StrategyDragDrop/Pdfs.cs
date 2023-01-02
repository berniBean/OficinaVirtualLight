using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragDrop
{
    public class Pdfs 
    {
        public string _name { get; set; }
        public string _direction { get; set; }

        public Pdfs(string name)
        {
            _name = name;
        }
    }
}
