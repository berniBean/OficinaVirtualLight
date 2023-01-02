using CleanArchitecture.Helpers;
using System;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BLL;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;



namespace WindowsFormsApp6
{
    public partial class Form5 : Form
    {

        private ListaCBusquedaRIF listRIF;
        obtenerBusqueda obBusqueda;

        private CCCBusquedaMultasBLL bdMultas = new CCCBusquedaMultasBLL();
        private CBusquedaMultasBO obListMultasRIF = new CBusquedaMultasBO();
        private ListaCBusquedaMultas listMultasRIF;
        obtenerBusquedaMultas obBuscarMultas;

        obtenerURL obUrl;
        obtenerURL obURLR;
        private CListaURL listaUrl;
        private int _tipo;

        public Form5()
        {
            InitializeComponent();
            
        }

        public Form5(int tipo)
        {
            InitializeComponent();
            _tipo = tipo;
            if(tipo==1)
            {
                obBusqueda = factoryBusqueda.maker(factoryBusqueda.RIF);
                obBuscarMultas = factoryBuscarMultas.maker(factoryBuscarMultas.RIF);
                obURLR= factoryURL.maker(factoryURL.RIF);
                obUrl = factoryURL.maker(factoryURL.MRIF);
            }
            else if (tipo == 2)
            {
                obBusqueda = factoryBusqueda.maker(factoryBusqueda.PLUS);
                obBuscarMultas = factoryBuscarMultas.maker(factoryBuscarMultas.PLUS);
                obURLR = factoryURL.maker(factoryURL.PLUS);
                obUrl = factoryURL.maker(factoryURL.MPLUS);
            }

        }


        private void toolStripTextBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyValue == 13)//enter
            {
                
                if (!string.IsNullOrEmpty(toolStripTextBusqueda.Text))
                {

                        BusquedaRIF(toolStripTextBusqueda.Text);
                        BusquedaMultas(toolStripTextBusqueda.Text);
                    


                }
                else
                {
                    BusquedaRIF(toolStripTextBusqueda.Text);
                    BusquedaMultas(toolStripTextBusqueda.Text);
                }

                
            }
            DgReqRIF.AutoResizeColumns();
            DgReqRIF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DgbusquedaMultasRIF.AutoResizeColumns();
            DgbusquedaMultasRIF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void BusquedaMultas(string datoBusqueda)
        {
            if (string.IsNullOrEmpty(datoBusqueda))
            {
                DgbusquedaMultasRIF.Rows.Clear();
                DgbusquedaMultasRIF.Refresh();
            }
            else
            {
                listMultasRIF = obBuscarMultas.busquedaMultas(datoBusqueda);//bdMultas.GetListaBusquedaMultasRIF(datoBusqueda);
                if (listMultasRIF.Count.Equals(0))
                {
                    cBusquedaMultasBOBindingSource.DataSource = listMultasRIF;
                    DgbusquedaMultasRIF.DataSource = cBusquedaMultasBOBindingSource;
                    return;
                }
                cBusquedaMultasBOBindingSource.DataSource = listMultasRIF;
                DgbusquedaMultasRIF.DataSource = cBusquedaMultasBOBindingSource;
                
            }
        }

        private void BusquedaRIF(string datoBusqueda)
        {
            if (string.IsNullOrEmpty(datoBusqueda))
            {
                DgReqRIF.Rows.Clear();
                DgReqRIF.Refresh();
            }
            else
            {
                listRIF = obBusqueda.ListaBusqueda(datoBusqueda);//bdRIF.GetListaBusquedaRIF(datoBusqueda);
                if (listRIF.Count.Equals(0))
                {
                    MessageBox.Show("No se encontraron coincidencias");
                    cBusquedaRIFBOBindingSource.DataSource = listRIF;
                    DgReqRIF.DataSource = cBusquedaRIFBOBindingSource;
                    return;
                }
                cBusquedaRIFBOBindingSource.DataSource = listRIF;
                DgReqRIF.DataSource = cBusquedaRIFBOBindingSource;
            }

        }


        private void DgbusquedaMultasRIF_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if(this.DgbusquedaMultasRIF.Columns[e.ColumnIndex].Name== "fechaEmision")
                e.CellStyle.Format = "dd \"de\" MMMM \"de\" yyyy";
        }

        private void toolStripTextBusqueda_Click(object sender, EventArgs e)
        {
            toolStripTextBusqueda.SelectAll();
        }

        private void DgbusquedaMultasRIF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listaUrl = obUrl.listaURI();
            string uri = listaUrl[0]._URL.ToString();
            string numReq = DgbusquedaMultasRIF.CurrentRow.Cells[6].Value.ToString();
            string RFC = DgbusquedaMultasRIF.CurrentRow.Cells[8].Value.ToString();
            string idSAT = DgbusquedaMultasRIF.CurrentRow.Cells[9].Value.ToString();
            string rs = DgbusquedaMultasRIF.CurrentRow.Cells[10].Value.ToString();
            string diligencia =  DgbusquedaMultasRIF.CurrentRow.Cells[11].Value.ToString();
            string Citatorio = DateFormatHelper.FechaCorta( Convert.ToDateTime( DgbusquedaMultasRIF.CurrentRow.Cells[12].Value.ToString()));
            string Notificacion = DateFormatHelper.FechaCorta(Convert.ToDateTime(  DgbusquedaMultasRIF.CurrentRow.Cells[13].Value.ToString()));
            string ohe = DgbusquedaMultasRIF.CurrentRow.Cells[3].Value.ToString(); ;
            string emision = DgbusquedaMultasRIF.CurrentRow.Cells[4].Value.ToString();
            int tipo = 1;
            pdfGestor vistaPDf = new pdfGestor(tipo, numReq, RFC, rs, idSAT, diligencia,Citatorio,Notificacion, uri, emision, ohe);
            vistaPDf.ShowDialog();
        }

        private void DgReqRIF_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgReqRIF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listaUrl = obURLR.listaURI();
            string uri = listaUrl[0]._URL.ToString();
            string numReq = DgReqRIF.CurrentRow.Cells[2].Value.ToString();
            string RFC = DgReqRIF.CurrentRow.Cells[6].Value.ToString();
            string idSAT = DgReqRIF.CurrentRow.Cells[3].Value.ToString();
            string rs = DgReqRIF.CurrentRow.Cells[7].Value.ToString();
            string diligencia = DgReqRIF.CurrentRow.Cells[8].Value.ToString();
            string Citatorio = DateFormatHelper.FechaCorta(Convert.ToDateTime( DgReqRIF.CurrentRow.Cells[9].Value.ToString()));
            string Notificacion = DateFormatHelper.FechaCorta(Convert.ToDateTime( DgReqRIF.CurrentRow.Cells[10].Value.ToString()));
            string ohe = DgReqRIF.CurrentRow.Cells[5].Value.ToString(); ;
            string emision = DgReqRIF.CurrentRow.Cells[0].Value.ToString();
            int tipo = 1;
            pdfGestor vistaPDf = new pdfGestor(tipo, numReq, RFC, rs, idSAT, diligencia,Citatorio,Notificacion, uri, emision, ohe);
            vistaPDf.ShowDialog();
        }
    }
}
