using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class FormEditorCreador : Form
    {
        public FormEditorCreador()
        {
            InitializeComponent();
        }

        private void FormEditorCreador_Load(object sender, EventArgs e)
        {
            
            tabCrear.Alignment = TabAlignment.Right;
            RequerimientosControl requerimientosControl = new RequerimientosControl();
            EliminaRequerimientoControl1 eliminaRequerimiento = new EliminaRequerimientoControl1(); 
            tabContainer.Controls.Add(requerimientosControl);
            TabDelete.Controls.Add(eliminaRequerimiento);
            requerimientosControl.Dock = DockStyle.Fill;
            eliminaRequerimiento.Dock = DockStyle.Fill;
            
        }
    }
}
