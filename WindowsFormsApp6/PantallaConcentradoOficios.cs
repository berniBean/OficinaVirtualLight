using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6
{
    public partial class PantallaConcentradoOficios : Form
    {
        private obtenerOficiosSQL obtenerOficiosConcentradoSQL;
        private int _emision;
        private string _nombreEmision;
        private int _idSup;
        private ListCOficios oficiosConcentrado;
        public PantallaConcentradoOficios(int idSup,int emision, string nombreEmision,int tipoS)
        {
            InitializeComponent();
            _emision = emision;
            _nombreEmision = nombreEmision;
            _idSup = idSup;
            if (tipoS == 1)
            {
                obtenerOficiosConcentradoSQL = OficiosFactory.maker(OficiosFactory.RIF);
            }

            if (tipoS == 2)
            {
                obtenerOficiosConcentradoSQL = OficiosFactory.maker(OficiosFactory.PLUS);
            }

            cargarTableroOficiosConcentrado().Wait();
        }

        private async Task cargarTableroOficiosConcentrado()
        {
            oficiosConcentrado = await obtenerOficiosConcentradoSQL.listadoConcentradoOficioSql(_nombreEmision,_emision, _idSup);
            cOficiosBOBindingSource.DataSource = oficiosConcentrado;

            dgOficiosConcentrado.AutoResizeColumns();
            dgOficiosConcentrado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
