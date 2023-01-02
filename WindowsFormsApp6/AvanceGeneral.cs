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
    public partial class AvanceGeneral : Form
    {
        obtenerTableroSup tableroAvance;

        private int _emision;
        private int _tipo;
        public AvanceGeneral(int emision,string nombreEmision, int tipoS)
        {
            _emision = emision;
            _tipo = tipoS;
            InitializeComponent();

            if (tipoS==1|| tipoS == 3)
            {
                tableroAvance = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
            }

            if (tipoS == 2|| tipoS == 4)
            {
                tableroAvance = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
            }

            cargarTableroAvance();
            
        }

        private void cargarTableroAvance()
        {
            if (_tipo == 1) 
            {
                dataGridView1.DataSource = tableroAvance.GetVanceEmision(_emision, CUserLoggin.idUser);
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            if (_tipo == 2)
            {
                dataGridView1.DataSource = tableroAvance.GetVanceEmision(_emision, CUserLoggin.idUser);
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            if (_tipo == 3)
            {
                dataGridView1.DataSource = tableroAvance.GetAvanceMultasAdmin(_emision, CUserLoggin.idUser);
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            if (_tipo == 4)
            {
                dataGridView1.DataSource = tableroAvance.GetAvanceMultasAdmin(_emision, CUserLoggin.idUser);
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }


        }
    }
}
