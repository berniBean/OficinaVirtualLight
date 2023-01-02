using CleanArchitecture.Concretas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.structs
{
    public class CargarFechasOficios
    {
        private ListFechaOficios _listFechas;
        private FechaOficiosDAL _oficiosDAL;
        private fechaOficios _fechaOficios;
        private BindingSource _fechasBs;

        public CargarFechasOficios(BindingSource FechasBs)
        {
            _fechasBs = FechasBs;
            _listFechas = new ListFechaOficios();
            _oficiosDAL = new FechaOficiosDAL();
        }

        public BindingSource FechasBs { get => _fechasBs; set => _fechasBs = value; }

        public async Task<ListFechaOficios> GetFechasOficios(string _emision)
        {
            
             _listFechas= await _oficiosDAL.GetFechaOficios(_emision);
            return _listFechas;
        }

        public void SetFechaOficio(fechaOficios ob)
        {
            
            if (_listFechas[0].ModificadoOficio)
                _oficiosDAL.ModificaFechasOficios(ob);
        }



        public void SetFechaRetro(fechaOficios ob)
        {
            if (_listFechas[0].ModificadoRetro)
                _oficiosDAL.ModificaFechaRetro(ob);
        }

    }
}
