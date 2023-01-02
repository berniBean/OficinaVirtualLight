using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.CAD.BLL
{
    class CUsuarioSupBLL
    {
        CUsuarioSupDAL bd = new CUsuarioSupDAL();

        public bool LoginUser(string usuario, string pass) {
            return bd.IndentificaUsuario(usuario, pass);
        }

    }
}
