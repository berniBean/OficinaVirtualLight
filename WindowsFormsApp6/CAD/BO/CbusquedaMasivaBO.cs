using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    class CbusquedaMasivaBO
    {


        private DataTable _lista;
        public DataTable Lista
        {
            get{ return _lista; }
            set { _lista = value; }
        }

        public CbusquedaMasivaBO() { }

        public CbusquedaMasivaBO(DataTable lista)
        {
            _lista = lista;
        }


    }
}
