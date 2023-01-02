namespace WindowsFormsApp6
{
    partial class PantallaMultasPendientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cListaTableroAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgTableroMultas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ejercicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this._origenMultaRIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nombreEmisionMultaRIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._extp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._incp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emitidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._pndPDF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enviadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._vencidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._cobrados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._totalImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._honorarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cListaTableroAdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTableroMultas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cListaTableroAdminBindingSource
            // 
            this.cListaTableroAdminBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CListaTableroAdmin);
            // 
            // dgTableroMultas
            // 
            this.dgTableroMultas.AllowUserToAddRows = false;
            this.dgTableroMultas.AllowUserToDeleteRows = false;
            this.dgTableroMultas.AutoGenerateColumns = false;
            this.dgTableroMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTableroMultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ejercicioDataGridViewTextBoxColumn,
            this.emisionDataGridViewTextBoxColumn,
            this._origenMultaRIF,
            this._nombreEmisionMultaRIF,
            this.fechaEmisionDataGridViewTextBoxColumn,
            this._extp,
            this._incp,
            this.emitidoDataGridViewTextBoxColumn,
            this._pndPDF,
            this.pendienteDataGridViewTextBoxColumn,
            this.enviadosDataGridViewTextBoxColumn,
            this._vencidos,
            this._cobrados,
            this._totalImporte,
            this._honorarios});
            this.dgTableroMultas.DataSource = this.cListaTableroAdminBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTableroMultas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgTableroMultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTableroMultas.Location = new System.Drawing.Point(0, 0);
            this.dgTableroMultas.Name = "dgTableroMultas";
            this.dgTableroMultas.ReadOnly = true;
            this.dgTableroMultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTableroMultas.Size = new System.Drawing.Size(1064, 410);
            this.dgTableroMultas.TabIndex = 1;
            this.dgTableroMultas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTableroMultas_CellClick);
            this.dgTableroMultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTableroMultas_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1070, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
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
            this.splitContainer1.Panel2.Controls.Add(this.dgTableroMultas);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 444);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.TabIndex = 2;
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.DataSource = this.cListaTableroAdminBindingSource;
            this.cmbEjercicio.DisplayMember = "_anho";
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(110, 3);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(121, 21);
            this.cmbEjercicio.TabIndex = 1;
            this.cmbEjercicio.Leave += new System.EventHandler(this.cmbEjercicio_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona el año:";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1070, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1070, 450);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // ejercicioDataGridViewTextBoxColumn
            // 
            this.ejercicioDataGridViewTextBoxColumn.DataPropertyName = "_ejercicio";
            this.ejercicioDataGridViewTextBoxColumn.HeaderText = "EJERCICIO";
            this.ejercicioDataGridViewTextBoxColumn.Name = "ejercicioDataGridViewTextBoxColumn";
            this.ejercicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emisionDataGridViewTextBoxColumn
            // 
            this.emisionDataGridViewTextBoxColumn.DataPropertyName = "_emision";
            this.emisionDataGridViewTextBoxColumn.HeaderText = "EMISION";
            this.emisionDataGridViewTextBoxColumn.Name = "emisionDataGridViewTextBoxColumn";
            this.emisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.emisionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.emisionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // _origenMultaRIF
            // 
            this._origenMultaRIF.DataPropertyName = "_origenMultaRIF";
            this._origenMultaRIF.HeaderText = "Disco/OficioSAT";
            this._origenMultaRIF.Name = "_origenMultaRIF";
            this._origenMultaRIF.ReadOnly = true;
            // 
            // _nombreEmisionMultaRIF
            // 
            this._nombreEmisionMultaRIF.DataPropertyName = "_nombreEmisionMultaRIF";
            this._nombreEmisionMultaRIF.HeaderText = "Nombre Emision";
            this._nombreEmisionMultaRIF.Name = "_nombreEmisionMultaRIF";
            this._nombreEmisionMultaRIF.ReadOnly = true;
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            this.fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "_fechaEmision";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.fechaEmisionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaEmisionDataGridViewTextBoxColumn.HeaderText = "FECHA DE EMISION";
            this.fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            this.fechaEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _extp
            // 
            this._extp.DataPropertyName = "_extp";
            this._extp.HeaderText = "Extemporaneos";
            this._extp.Name = "_extp";
            this._extp.ReadOnly = true;
            // 
            // _incp
            // 
            this._incp.DataPropertyName = "_incp";
            this._incp.HeaderText = "Incumplidos";
            this._incp.Name = "_incp";
            this._incp.ReadOnly = true;
            // 
            // emitidoDataGridViewTextBoxColumn
            // 
            this.emitidoDataGridViewTextBoxColumn.DataPropertyName = "_emitido";
            this.emitidoDataGridViewTextBoxColumn.HeaderText = "TOTAL EMITIDO";
            this.emitidoDataGridViewTextBoxColumn.Name = "emitidoDataGridViewTextBoxColumn";
            this.emitidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _pndPDF
            // 
            this._pndPDF.DataPropertyName = "_pndPDF";
            this._pndPDF.HeaderText = "Pendientes PDF";
            this._pndPDF.Name = "_pndPDF";
            this._pndPDF.ReadOnly = true;
            // 
            // pendienteDataGridViewTextBoxColumn
            // 
            this.pendienteDataGridViewTextBoxColumn.DataPropertyName = "_pendiente";
            this.pendienteDataGridViewTextBoxColumn.HeaderText = "PENDIENTES";
            this.pendienteDataGridViewTextBoxColumn.Name = "pendienteDataGridViewTextBoxColumn";
            this.pendienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enviadosDataGridViewTextBoxColumn
            // 
            this.enviadosDataGridViewTextBoxColumn.DataPropertyName = "_enviados";
            this.enviadosDataGridViewTextBoxColumn.HeaderText = "Enviados Ejecución";
            this.enviadosDataGridViewTextBoxColumn.Name = "enviadosDataGridViewTextBoxColumn";
            this.enviadosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _vencidos
            // 
            this._vencidos.DataPropertyName = "_vencidos";
            this._vencidos.HeaderText = "Vencidos";
            this._vencidos.Name = "_vencidos";
            this._vencidos.ReadOnly = true;
            // 
            // _cobrados
            // 
            this._cobrados.DataPropertyName = "_cobrados";
            this._cobrados.HeaderText = "Cobrados";
            this._cobrados.Name = "_cobrados";
            this._cobrados.ReadOnly = true;
            // 
            // _totalImporte
            // 
            this._totalImporte.DataPropertyName = "_totalImporte";
            this._totalImporte.HeaderText = "Recaudado";
            this._totalImporte.Name = "_totalImporte";
            this._totalImporte.ReadOnly = true;
            // 
            // _honorarios
            // 
            this._honorarios.DataPropertyName = "_honorarios";
            this._honorarios.HeaderText = "Honorarios";
            this._honorarios.Name = "_honorarios";
            this._honorarios.ReadOnly = true;
            // 
            // PantallaMultasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "PantallaMultasPendientes";
            this.Text = "PantallaMultasPendientes";
            this.Load += new System.EventHandler(this.PantallaMultasPendientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cListaTableroAdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTableroMultas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cListaTableroAdminBindingSource;
        private System.Windows.Forms.DataGridView dgTableroMultas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbEjercicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejercicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn emisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _origenMultaRIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nombreEmisionMultaRIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _extp;
        private System.Windows.Forms.DataGridViewTextBoxColumn _incp;
        private System.Windows.Forms.DataGridViewTextBoxColumn emitidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _pndPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enviadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _vencidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn _cobrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn _totalImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn _honorarios;
    }
}