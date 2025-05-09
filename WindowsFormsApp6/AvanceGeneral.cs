using CleanArchitecture.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;
using WindowsFormsApp6.Helper;
using WindowsFormsApp6.structs;

namespace WindowsFormsApp6
{
    public partial class AvanceGeneral : Form
    {
        obtenerTableroSup tableroAvance;

        private int _emision;
        private int _tipo;
        private string _nombreEmision;
        private List<CTableroAdminBO> _datosQuery;
        public AvanceGeneral(int emision,string nombreEmision, int tipoS)
        {
            _emision = emision;
            _tipo = tipoS;
            _nombreEmision = nombreEmision;
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
                _datosQuery = tableroAvance.GetListadoCompleto(_emision, CUserLoggin.zonaSupervisor).Result;                
                dataGridView1.DataSource =  QueryListRequerimientos(_datosQuery);
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            if (_tipo == 2)
            {
                _datosQuery = tableroAvance.GetListadoCompleto(_emision, CUserLoggin.zonaSupervisor).Result;
                dataGridView1.DataSource = QueryListRequerimientos(_datosQuery); 
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


        private List<CTableroAdminBO> QueryListRequerimientos(List<CTableroAdminBO> datos)
        {
            var gato = (from item in datos
                        group item by new { item._zona, OHE = item._ohe } into grupo
                        select new CTableroAdminBO
                        {
                            _zona = grupo.Key._zona,
                            _ohe = grupo.Key.OHE,
                            _total = grupo.Count(),
                            _localizado = grupo.Count(d => d._diligencia.Equals("LOCALIZADO")),
                            _noLocalizado = grupo.Count(d => d._diligencia.Equals("NO LOCALIZADO")),
                            _noTrabajado = grupo.Count(d => d._diligencia.Equals("NO TRABAJADO")),
                            _pendientes = grupo.Count(d => d._estatus.Equals("pendiente")),
                            _porcentajeFalla = StaticPercentage.PercentageProgress(grupo.Count(d => d._diligencia.Equals("NO LOCALIZADO")), grupo.Count()),
                            _pndPDF = grupo.Count(d => d._pdf.Equals("pendiente")),

                        }).ToList();


            return gato;

        }


        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            var raton = (from item in _datosQuery
                         group item by new {item._emision} into grupo
                        select new ExcelDataDto
                        {
                            Total = grupo.Count(),
                            Localizado =  grupo.Count(d => d._diligencia.Equals("LOCALIZADO")),
                            NoLocalizado = grupo.Count(d => d._diligencia.Equals("NO LOCALIZADO")),
                            NoTrabajado = grupo.Count(d => d._diligencia.Equals("NO TRABAJADO")),
                            PorcentajeFalla = StaticPercentage.PercentageProgress(grupo.Count(d => d._diligencia.Equals("NO LOCALIZADO")), grupo.Count()),
                            PendientePdf = grupo.Count(d => d._pdf.Equals("pendiente")),
                            Fisicas = grupo.Count(d=>d._tipoc.Equals("F")),
                            Morales = grupo.Count(d => d._tipoc.Equals("M"))

                        }).ToList();


            ExcelDataDto datos = new ExcelDataDto();
            datos.Name = WriterHelperExcel.GetNameFile( _nombreEmision);
            datos.LblEmision = _nombreEmision;
            foreach (var item in raton)
            {
                datos.Total = item.Total;
                datos.Localizado = item.Localizado;
                datos.NoLocalizado = item.NoLocalizado;
                datos.NoTrabajado = item.NoTrabajado;
                datos.PorcentajeFalla = item.PorcentajeFalla;
                datos.PendientePdf = item.PendientePdf;
                datos.Fisicas = item.Fisicas;
                datos.Morales = item.Morales;
            }
            
            ToExcelTableroAsync excel = new ToExcelTableroAsync(lblStatus, datos, "InformePlus");
            await  excel.WriterAsync(_datosQuery);

        }
    }
}
