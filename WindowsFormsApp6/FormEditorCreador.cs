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
            RequerimientosControl requerimientosControl = new RequerimientosControl();
            tabCrear.Alignment = TabAlignment.Right;
            tabContainer.Controls.Add(requerimientosControl);           
            requerimientosControl.Dock = DockStyle.Fill;
        }
    }
}
