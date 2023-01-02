
namespace WindowsFormsApp6
{
    partial class PantallaAdminMultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.cTableroAdminBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detalleEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this._listado = new System.Windows.Forms.DataGridViewLinkColumn();
            this._concentrado = new System.Windows.Forms.DataGridViewLinkColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTableroAdminBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmbEjercicio);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 428);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 1;
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.DataSource = this.cTableroAdminBOBindingSource;
            this.cmbEjercicio.DisplayMember = "_anho";
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(113, 16);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(121, 21);
            this.cmbEjercicio.TabIndex = 1;
            this.cmbEjercicio.Leave += new System.EventHandler(this.cmbEjercicio_Leave);
            // 
            // cTableroAdminBOBindingSource
            // 
            this.cTableroAdminBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CTableroAdminBO);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona el año:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalleEmisionDataGridViewTextBoxColumn,
            this.idEmisionDataGridViewTextBoxColumn,
            this._listado,
            this._concentrado});
            this.dataGridView1.DataSource = this.cTableroAdminBOBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // detalleEmisionDataGridViewTextBoxColumn
            // 
            this.detalleEmisionDataGridViewTextBoxColumn.DataPropertyName = "_detalleEmision";
            this.detalleEmisionDataGridViewTextBoxColumn.HeaderText = "Detalle de la emisión";
            this.detalleEmisionDataGridViewTextBoxColumn.Name = "detalleEmisionDataGridViewTextBoxColumn";
            this.detalleEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEmisionDataGridViewTextBoxColumn
            // 
            this.idEmisionDataGridViewTextBoxColumn.DataPropertyName = "_idEmision";
            this.idEmisionDataGridViewTextBoxColumn.HeaderText = "Avance General";
            this.idEmisionDataGridViewTextBoxColumn.Name = "idEmisionDataGridViewTextBoxColumn";
            this.idEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmisionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idEmisionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // _listado
            // 
            this._listado.DataPropertyName = "_idEmision";
            this._listado.HeaderText = "Listado Emisión";
            this._listado.Name = "_listado";
            this._listado.ReadOnly = true;
            this._listado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._listado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // _concentrado
            // 
            this._concentrado.DataPropertyName = "_idEmision";
            this._concentrado.HeaderText = "Concentrado Oficios";
            this._concentrado.Name = "_concentrado";
            this._concentrado.ReadOnly = true;
            this._concentrado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._concentrado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PantallaAdminMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "PantallaAdminMultas";
            this.Text = "PantallaAdminMultas";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTableroAdminBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbEjercicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cTableroAdminBOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn idEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn _listado;
        private System.Windows.Forms.DataGridViewLinkColumn _concentrado;
    }
}