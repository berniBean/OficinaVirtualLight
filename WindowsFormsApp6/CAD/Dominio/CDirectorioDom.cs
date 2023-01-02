using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.CAD.Dominio
{
    public class CDirectorioDom
    {
        DirectorioBO obDir = new DirectorioBO();
        DirectorioDAL GetDir;
        public CDirectorioDom()
        {
            GetDir = new DirectorioDAL(obDir);
        }

        public void GuardarCambios()
        {

                GetDir.UpdateDirectorio(obDir);
            
        }

        //public List<IDirCelular> ListadoCelular(string nombre)
        //{
        //    GetDir.GetCelular();
        //}

        public List<IDirectorio> ListadoDirectorio(string nombre)
        {

            GetDir.GetDirectorio(FiltrarOficinas(nombre));
            return obDir.Directorios.ToList();
        }

        public List<IOficinaHacienda> ListadoOficinas()
        {
            GetDir.GetOfinas();
            return obDir.Oficinas.ToList();
        }

        private int FiltrarOficinas(string nombre)
        {
            obDir.LimpiarDirectorio();
            int clave = 0;
            var res = obDir.Oficinas.Where(O => O.OHE.Contains(nombre)).ToList();
            
            foreach (var item in res)
            {

                clave = item.IdClaveOHE;
            }
            return clave;
        }
    }
}
