using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    class CUsuarioSup
    {

        private int _idUsuario;
        public int IdUsuario {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        private string _usuario;
        public string Usuario {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public CUsuarioSup() { }

        public CUsuarioSup(int  idUsuario, string Usuario) {
            _idUsuario = idUsuario;
            _usuario = Usuario;
        }
    }
}
