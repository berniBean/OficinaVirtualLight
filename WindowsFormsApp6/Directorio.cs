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
using WindowsFormsApp6.CAD.Dominio;

namespace WindowsFormsApp6
{

    public partial class Directorio : Form
    {
        
        private readonly CDirectorioDom Odirdom = new CDirectorioDom();
        public Directorio()
        {
            InitializeComponent();
        }

        private void Directorio_Load(object sender, EventArgs e)
        {
            MostrarOficinas();
            MostrarDireccion();
            
        }

        private void MostrarCelular()
        {

        }
        private void MostrarOficinas()
        {
            oficinaHaciendaBOBindingSource.DataSource= Odirdom.ListadoOficinas();
        }

        private void MostrarDireccion()
        {
           
            
            bsDireccion.DataSource = Odirdom.ListadoDirectorio(cbOficina.Text);

        }

        private void cbOficina_Leave(object sender, EventArgs e)
        {
            MostrarDireccion();
        }
        private void cbOficina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                MostrarDireccion();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Odirdom.GuardarCambios();
            MessageBox.Show("Cambios guardados");
        }


    }
}
