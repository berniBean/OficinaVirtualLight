using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6
{
    public partial class AvanceGeneralMultasAdmin : Form
    {
        obtenerTableroSup tableroAvance;

        private int _emision;
        public AvanceGeneralMultasAdmin(int emision, int tipoS)
        {
            _emision = emision;
            InitializeComponent();

            if (tipoS == 1)
            {
                tableroAvance = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
            }

            if (tipoS == 2)
            {
                tableroAvance = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
            }

            //this.dgMultasPendiente.Columns["_totalImporte"].DefaultCellStyle.Format = "C";
            //this.dgMultasPendiente.Columns["_honorarios"].DefaultCellStyle.Format = "C";
            //this.dgTablaMultasRIF.Columns["Importe"].DefaultCellStyle.Format = "C";
            //this.dgTablaMultasRIF.Columns["Honorarios"].DefaultCellStyle.Format = "C";


            cargarTableroAvance();

            this.dataGridView1.Columns[12].DefaultCellStyle.Format = "C";
            this.dataGridView1.Columns[13].DefaultCellStyle.Format = "C";
        }

        private async void cargarTableroAvance()
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cTableroAdminBOBindingSource.DataSource = await tableroAvance.GetAvanceMultasAdmin(_emision, CUserLoggin.idUser);

        }
    }
}
