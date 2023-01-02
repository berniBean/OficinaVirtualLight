using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public abstract class obtenerInformes
    {
        public abstract ListaInformeAvance AvanceAdmin(int emision);
        public abstract ListaInformeAvance AvanceMultaSup(int emision, int supervisor);
        public abstract ListaInformeAvance AvancesReq(int emision, int supervisor);
    }
}
