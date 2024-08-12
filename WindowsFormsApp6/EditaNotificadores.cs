using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6
{
    public partial class EditaNotificadores : Form
    {
        private int DatoID;
        obtenerOHE obOHE;
        private ListCoheActiva ListOHE;
        private List<CNotificadoresBO> listNotificador;

        private CNotificadoresDAL CatalogoNotificadores = new CNotificadoresDAL();
        private List<CNotificadoresBO> NuevosNotificadores = new List<CNotificadoresBO>();


        public EditaNotificadores()
        {
            InitializeComponent();

            obOHE = factoryOHE.maker(factoryOHE.PLUS);
        }

        private void EditaNotificadores_Load(object sender, System.EventArgs e)
        {
            DatoID = CUserLoggin.idUser;
            CargarOficinasHacienda();
            CargarNotificadores();

            DGNotificadores.AutoResizeColumns();
            DGNotificadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }



        

        private void CargarOficinasHacienda()
        {
            try
            {
                ListOHE = obOHE.ListadoNotificadoresOHE(Convert.ToString(DatoID));
                listCoheActivaBindingSource.DataSource = ListOHE;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        




        private void cmbOHE_Leave(object sender, EventArgs e)
        {
            CargarNotificadores();
            DGNotificadores.AutoResizeColumns();
            DGNotificadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cmbOHE_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                CargarNotificadores();
                DGNotificadores.AutoResizeColumns();
                DGNotificadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                
            }
        }


        private void CargarNotificadores()
        {
            try
            {
                listNotificador = CUserLoggin.Notificadores.Where(x => x.Ohe.Equals(cmbOHE.Text) && !string.IsNullOrWhiteSpace(x.NombreNotificador)).ToList();

                DGNotificadores.DataSource = listNotificador;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

            var oficina = ListOHE.FirstOrDefault(x => x.OHE.Equals(cmbOHE.Text));            
            Guid g = Guid.NewGuid();
            var Notificador = new CNotificadoresBO();
            Notificador.IdNotificador = g.ToString();
            Notificador.IdClaveOHE = oficina.IdclaveOHE;
            Notificador.ClaveNotificador = txtClaveNot.Text;
            Notificador.NombreNotificador = txtNombre.Text;
            Notificador.Status = true;

            CatalogoNotificadores.NuevoNotificador(Notificador);

            RecargaNotificadores();

            txtClaveNot.Clear();
            txtNombre.Clear();
            CargarNotificadores();

        }

        private void DGNotificadores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var colIndex = DGNotificadores.CurrentCell.ColumnIndex;
            var colName = DGNotificadores.Columns[colIndex].Name;

            if(colName == "Edit")
            {
                var Id = DGNotificadores.CurrentRow.Cells[0].Value.ToString();

                var Notificador = new CNotificadoresBO();
                Notificador.IdNotificador = Id;
                //Notificador.ClaveNotificador = DGNotificadores.CurrentRow.Cells[2].Value.ToString();
                Notificador.NombreNotificador = DGNotificadores.CurrentRow.Cells[3].Value.ToString();

                CatalogoNotificadores.EditaNotificador(Notificador);

                MessageBox.Show("Registro guardado");
            }

            if(colName == "Delete")
            {
                var Id = DGNotificadores.CurrentRow.Cells[0].Value.ToString();
                var Nombre = DGNotificadores.CurrentRow.Cells[3].Value.ToString();
                var Notificador = new CNotificadoresBO();
                Notificador.IdNotificador = Id;
                Notificador.Status = false;

                var Dr = MessageBox.Show($"Desea eliminar el registro de: {Nombre} ","ELiMINAR REGISTRO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (Dr == DialogResult.Yes)
                {
                    CatalogoNotificadores.EliminarNotificador(Notificador);
                }


                RecargaNotificadores();

                CargarNotificadores();
            }
        }


        private void RecargaNotificadores()
        {
            var listado = CatalogoNotificadores.GetListadoNotificadores();
            CUserLoggin.Notificadores = listado;
        }

        private void lblNombramiento_Click(object sender, EventArgs e)
        {

        }
    }
}
