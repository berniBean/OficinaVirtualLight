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
        public abstract Task<ListaInformeAvance> AvanceAdmin(int emision);
        public abstract Task<ListaInformeAvance> AvanceMultaSup(int emision, int supervisor);
        public abstract Task<ListaInformeAvance> AvancesReq(int emision, int supervisor);
    }
}
