using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BLL;
using WindowsFormsApp6.structs;

namespace WindowsFormsApp6
{
    public partial class Form4 : Form
    {
        DataTable dt = new DataTable();



        public delegate void BusquedaDelegado(IEnumerable<busquedaMasivaDO> ReturnLstBusqueda);
        public event BusquedaDelegado ejecutar;

        public delegate Task SetRequerimiento(string diligencia);        
        public event SetRequerimiento setDiligencia;

        public delegate void SetTipoMulta(string tipoM);
        public event SetTipoMulta setTipoM;

        public delegate Task DescargarDelegado();
        public event DescargarDelegado ejecutarDescarga;


        public int _tipo;

        public delegate Task SetFecha(DateTime fecha);
        public event SetFecha setFechaReq;

        private CCCBusquedaMasivaBLL bd = new CCCBusquedaMasivaBLL();
        List<busquedaMasivaDO> resultado = new List<busquedaMasivaDO>();
        //private CbusquedaMasivaBO obListaMasiva = new CbusquedaMasivaBO();
        //private ListBusquedaMasiva listMasiva;
        public string tipoVentana { get; set; }
        public string tipoMulta { get; set; }
        

        public Form4()
        {


            InitializeComponent();
            //BusquedaMasivaDelegada = new BusquedaDelegado(busquedaMasiva);
            dt.Columns.Add("Numero control SAT", typeof(string));
            //dt.Rows.Add();
            dataGridBusqueda.DataSource = dt;

            radioButton3.Visible = false;



        }







        //funcion de copiado y pegado
        public void copiar_portapapeles(DataGridView dataGrid)
        {
            DataObject objeto_datos = dataGrid.GetClipboardContent();

            Clipboard.SetDataObject(objeto_datos);
        }



        public void pegar_portapapeles(DataGridView dataGrid)
        {

            string texto_copiado = Clipboard.GetText();
            string[] lineas = texto_copiado.Split('\n');
            int ultima = lineas.Count() - 1;
            crearFilas(lineas, dataGrid, ultima);
            dataGridBusqueda.DataSource = dt;

            dataGridBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 

        }

        private void crearFilas(string[] lineas, DataGridView dataGrid, int ultima)
        {

            dt.Clear();
            int i;
            for (i = 0; i < ultima; i++)
            {
                dt.Rows.Add(lineas[i]);
            }

           
        }

        private void itemsBusqueda()
        {
            int celda = 0;



            foreach (DataGridViewRow row in dataGridBusqueda.Rows)
            {

                try
                {
                    string valor;

                    valor = row.Cells[0].Value.ToString().Replace("\r\n", "").Replace("\n", "").Replace("\r", "");




                    if (valor != null && tipoVentana == "Multas" || tipoMulta == "Multas")
                    {
                        //bd.CrearListaBusquedaMasiva(valor);
                        resultado.Add(new busquedaMasivaDO() { numMulta = Convert.ToInt32( valor) });

                    }
                    if (valor != null && tipoVentana == "Requerimientos" || tipoMulta == "Requerimientos")
                    {
                        resultado.Add(new busquedaMasivaDO() { numCtrl = valor });
                    }


                    //valor = row.Cells[2].Value.ToString();
                    celda++;

                }
                catch (NullReferenceException ex)
                {


                }
            }
            celda = 0;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {


            itemsBusqueda();


            if (_tipo == 1)
            {
                ejecutar(ReturnLstBusqueda());
                setDiligencia(EstablecerComo());                

            }
            else if (_tipo == 2)
            {
                setTipoM(EstablecerTipoMulta());                
                ejecutar(ReturnLstBusqueda());
                setDiligencia(EstablecerComo());


            }
            else if (_tipo == 3)
            {


                if (tipoMulta == "MPLUS_" || tipoMulta == "MRIF_") 
                {
                    setTipoM(EstablecerTipoMulta());
                    ejecutar(ReturnLstBusqueda());
                }
                else
                {
                    ejecutar(ReturnLstBusqueda());
                }

                

                //ejecutarDescarga();
            }

            
            



        }
        private void btnDescargar_Click(object sender, EventArgs e)
        {
            itemsBusqueda();

            if (_tipo == 1)
            {
                ejecutar(ReturnLstBusqueda());

            }
            else if (_tipo == 2)
            {
                setTipoM(EstablecerTipoMulta());
                ejecutar(ReturnLstBusqueda());



            }
            else if (_tipo == 3)
            {


                if (tipoMulta == "Multas" )
                {
                    setTipoM(EstablecerTipoMulta());
                    ejecutar(ReturnLstBusqueda());
                    setDiligencia(EstablecerComo());
                    ejecutarDescarga();
                }
                else
                {
                    setTipoM(EstablecerTipoMulta());
                    ejecutar(ReturnLstBusqueda());
                    ejecutarDescarga();
                }



                //ejecutarDescarga();
            }



        }

        private IEnumerable<busquedaMasivaDO> ReturnLstBusqueda()
        {           
            return resultado.Distinct();
        }

        private DateTime SetFechasRequerimientos(DateTime valor)
        {
           
           

            return valor;

        }


        private string EstablecerTipoMulta()
        {
            string resultado="";

                foreach (RadioButton rdo in groupBoxPLUS.Controls.OfType<RadioButton>())
                {
                    if (rdo.Checked)
                    {
                        resultado = rdo.Text;
                    }
                }
            

            return resultado;
        }

        private string EstablecerComo()
        {
            
            string resultado="";
            foreach (RadioButton rdo in gbSet.Controls.OfType<RadioButton>() )
            {
                if (rdo.Checked)
                {
                     
                    resultado = rdo.Text;
                    break;
                    
                }  
            }

            return resultado;


        }

        private void ClearSelection(DataGridView dataGrid)
        {

            foreach (DataGridViewCell cell in dataGrid.SelectedCells)
            {
                try
                {
                    dataGrid.Rows.RemoveAt(cell.RowIndex);
                }
                catch (InvalidOperationException ex)
                {

                    
                } 
                
            }

        }


        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                copiar_portapapeles(dataGridBusqueda);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
                pegar_portapapeles(dataGridBusqueda);

            }

            if (e.KeyValue == 46 )
            { //suprimir

                ClearSelection(dataGridBusqueda);
                e.Handled = true;

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (tipoVentana == "Requerimientos")
            {
                gbMulta.Visible = false;
                //groupBoxPLUS.Visible = false;
                _tipo = 1;
            }
                
            if (tipoVentana == "Multas")
            {

                radioButton3.Visible = true;
                if (tipoMulta == "MRIF_")
                {
                    gbMulta.Visible = true;
                   // groupBoxPLUS.Visible = false;
                    
                }

                if(tipoMulta == "MPLUS_")
                {
                    gbMulta.Visible = false;
                    groupBoxPLUS.Visible = true;
                }
                _tipo = 2;
            }
            
            if(tipoVentana == "Super")
            {
                gbSet.Visible = false;
                btnDescargar.Visible = true;
                groupBoxPLUS.Visible = true;
                if (tipoVentana == "Multas" || tipoVentana == "Super")
                {
                    radioButton3.Visible = true;
                    if (tipoMulta == "MRIF_")
                    {
                        gbMulta.Visible = true;
                        groupBoxPLUS.Visible = false;

                    }

                    if (tipoMulta == "MPLUS_")
                    {
                        gbMulta.Visible = false;
                        groupBoxPLUS.Visible = true;
                    }
                    
                }
                _tipo = 3;
            }
        }


    }
}
