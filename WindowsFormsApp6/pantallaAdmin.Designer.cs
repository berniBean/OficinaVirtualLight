namespace WindowsFormsApp6
{
    partial class pantallaAdmin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._idEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._referenciaNumercia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._anho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._detalleEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avance = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Listado = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ListPdf = new System.Windows.Forms.DataGridViewLinkColumn();
            this.fechaEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejercicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaNumerciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emitidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enviadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noGeneradosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmisionMultaRIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origenMultaRIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobradosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalImporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.honorariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTableroAdminBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tspProgreso = new System.Windows.Forms.ToolStripProgressBar();
            this.dataSetRIF = new WindowsFormsApp6.DataSetRIF();
            this.listadoRIFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catableroJefeRCOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cListaTableroAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTableroAdminBOBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoRIFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catableroJefeRCOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListaTableroAdminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.888889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._idEmision,
            this._referenciaNumercia,
            this._anho,
            this._detalleEmision,
            this.Avance,
            this.Listado,
            this.ListPdf,
            this.fechaEmisionDataGridViewTextBoxColumn,
            this.ejercicioDataGridViewTextBoxColumn,
            this.emisionDataGridViewTextBoxColumn,
            this.detalleEmisionDataGridViewTextBoxColumn,
            this.idEmisionDataGridViewTextBoxColumn,
            this.anhoDataGridViewTextBoxColumn,
            this.referenciaNumerciaDataGridViewTextBoxColumn,
            this.extpDataGridViewTextBoxColumn,
            this.incpDataGridViewTextBoxColumn,
            this.emitidoDataGridViewTextBoxColumn,
            this.enviadosDataGridViewTextBoxColumn,
            this.pendienteDataGridViewTextBoxColumn,
            this.noGeneradosDataGridViewTextBoxColumn,
            this.avanceDataGridViewTextBoxColumn,
            this.nombreEmisionMultaRIFDataGridViewTextBoxColumn,
            this.origenMultaRIFDataGridViewTextBoxColumn,
            this.vencidosDataGridViewTextBoxColumn,
            this.cobradosDataGridViewTextBoxColumn,
            this.totalImporteDataGridViewTextBoxColumn,
            this.honorariosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cTableroAdminBOBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(794, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // _idEmision
            // 
            this._idEmision.DataPropertyName = "_idEmision";
            this._idEmision.HeaderText = "Emisión";
            this._idEmision.Name = "_idEmision";
            this._idEmision.ReadOnly = true;
            this._idEmision.Visible = false;
            // 
            // _referenciaNumercia
            // 
            this._referenciaNumercia.DataPropertyName = "_referenciaNumercia";
            this._referenciaNumercia.HeaderText = "Referencia numérica";
            this._referenciaNumercia.Name = "_referenciaNumercia";
            this._referenciaNumercia.ReadOnly = true;
            this._referenciaNumercia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._referenciaNumercia.Visible = false;
            // 
            // _anho
            // 
            this._anho.DataPropertyName = "_anho";
            this._anho.HeaderText = "Año";
            this._anho.Name = "_anho";
            this._anho.ReadOnly = true;
            this._anho.Visible = false;
            // 
            // _detalleEmision
            // 
            this._detalleEmision.DataPropertyName = "_detalleEmision";
            this._detalleEmision.HeaderText = "Detalle de la Emisión";
            this._detalleEmision.Name = "_detalleEmision";
            this._detalleEmision.ReadOnly = true;
            this._detalleEmision.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Avance
            // 
            this.Avance.DataPropertyName = "_idEmision";
            this.Avance.HeaderText = "Avance General";
            this.Avance.Name = "Avance";
            this.Avance.ReadOnly = true;
            this.Avance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Avance.Text = "Ver";
            // 
            // Listado
            // 
            this.Listado.DataPropertyName = "_idEmision";
            this.Listado.HeaderText = "Listado Emisión";
            this.Listado.Name = "Listado";
            this.Listado.ReadOnly = true;
            this.Listado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Listado.Text = "Ver";
            // 
            // ListPdf
            // 
            this.ListPdf.DataPropertyName = "_idEmision";
            this.ListPdf.HeaderText = "Concentrado Oficios";
            this.ListPdf.Name = "ListPdf";
            this.ListPdf.ReadOnly = true;
            this.ListPdf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ListPdf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            this.fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "_fechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.HeaderText = "_fechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            this.fechaEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaEmisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // ejercicioDataGridViewTextBoxColumn
            // 
            this.ejercicioDataGridViewTextBoxColumn.DataPropertyName = "_ejercicio";
            this.ejercicioDataGridViewTextBoxColumn.HeaderText = "_ejercicio";
            this.ejercicioDataGridViewTextBoxColumn.Name = "ejercicioDataGridViewTextBoxColumn";
            this.ejercicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.ejercicioDataGridViewTextBoxColumn.Visible = false;
            // 
            // emisionDataGridViewTextBoxColumn
            // 
            this.emisionDataGridViewTextBoxColumn.DataPropertyName = "_emision";
            this.emisionDataGridViewTextBoxColumn.HeaderText = "_emision";
            this.emisionDataGridViewTextBoxColumn.Name = "emisionDataGridViewTextBoxColumn";
            this.emisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.emisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // detalleEmisionDataGridViewTextBoxColumn
            // 
            this.detalleEmisionDataGridViewTextBoxColumn.DataPropertyName = "_detalleEmision";
            this.detalleEmisionDataGridViewTextBoxColumn.HeaderText = "_detalleEmision";
            this.detalleEmisionDataGridViewTextBoxColumn.Name = "detalleEmisionDataGridViewTextBoxColumn";
            this.detalleEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.detalleEmisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // idEmisionDataGridViewTextBoxColumn
            // 
            this.idEmisionDataGridViewTextBoxColumn.DataPropertyName = "_idEmision";
            this.idEmisionDataGridViewTextBoxColumn.HeaderText = "_idEmision";
            this.idEmisionDataGridViewTextBoxColumn.Name = "idEmisionDataGridViewTextBoxColumn";
            this.idEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // anhoDataGridViewTextBoxColumn
            // 
            this.anhoDataGridViewTextBoxColumn.DataPropertyName = "_anho";
            this.anhoDataGridViewTextBoxColumn.HeaderText = "_anho";
            this.anhoDataGridViewTextBoxColumn.Name = "anhoDataGridViewTextBoxColumn";
            this.anhoDataGridViewTextBoxColumn.ReadOnly = true;
            this.anhoDataGridViewTextBoxColumn.Visible = false;
            // 
            // referenciaNumerciaDataGridViewTextBoxColumn
            // 
            this.referenciaNumerciaDataGridViewTextBoxColumn.DataPropertyName = "_referenciaNumercia";
            this.referenciaNumerciaDataGridViewTextBoxColumn.HeaderText = "_referenciaNumercia";
            this.referenciaNumerciaDataGridViewTextBoxColumn.Name = "referenciaNumerciaDataGridViewTextBoxColumn";
            this.referenciaNumerciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.referenciaNumerciaDataGridViewTextBoxColumn.Visible = false;
            // 
            // extpDataGridViewTextBoxColumn
            // 
            this.extpDataGridViewTextBoxColumn.DataPropertyName = "_extp";
            this.extpDataGridViewTextBoxColumn.HeaderText = "_extp";
            this.extpDataGridViewTextBoxColumn.Name = "extpDataGridViewTextBoxColumn";
            this.extpDataGridViewTextBoxColumn.ReadOnly = true;
            this.extpDataGridViewTextBoxColumn.Visible = false;
            // 
            // incpDataGridViewTextBoxColumn
            // 
            this.incpDataGridViewTextBoxColumn.DataPropertyName = "_incp";
            this.incpDataGridViewTextBoxColumn.HeaderText = "_incp";
            this.incpDataGridViewTextBoxColumn.Name = "incpDataGridViewTextBoxColumn";
            this.incpDataGridViewTextBoxColumn.ReadOnly = true;
            this.incpDataGridViewTextBoxColumn.Visible = false;
            // 
            // emitidoDataGridViewTextBoxColumn
            // 
            this.emitidoDataGridViewTextBoxColumn.DataPropertyName = "_emitido";
            this.emitidoDataGridViewTextBoxColumn.HeaderText = "_emitido";
            this.emitidoDataGridViewTextBoxColumn.Name = "emitidoDataGridViewTextBoxColumn";
            this.emitidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.emitidoDataGridViewTextBoxColumn.Visible = false;
            // 
            // enviadosDataGridViewTextBoxColumn
            // 
            this.enviadosDataGridViewTextBoxColumn.DataPropertyName = "_enviados";
            this.enviadosDataGridViewTextBoxColumn.HeaderText = "_enviados";
            this.enviadosDataGridViewTextBoxColumn.Name = "enviadosDataGridViewTextBoxColumn";
            this.enviadosDataGridViewTextBoxColumn.ReadOnly = true;
            this.enviadosDataGridViewTextBoxColumn.Visible = false;
            // 
            // pendienteDataGridViewTextBoxColumn
            // 
            this.pendienteDataGridViewTextBoxColumn.DataPropertyName = "_pendiente";
            this.pendienteDataGridViewTextBoxColumn.HeaderText = "_pendiente";
            this.pendienteDataGridViewTextBoxColumn.Name = "pendienteDataGridViewTextBoxColumn";
            this.pendienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.pendienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // noGeneradosDataGridViewTextBoxColumn
            // 
            this.noGeneradosDataGridViewTextBoxColumn.DataPropertyName = "_noGenerados";
            this.noGeneradosDataGridViewTextBoxColumn.HeaderText = "_noGenerados";
            this.noGeneradosDataGridViewTextBoxColumn.Name = "noGeneradosDataGridViewTextBoxColumn";
            this.noGeneradosDataGridViewTextBoxColumn.ReadOnly = true;
            this.noGeneradosDataGridViewTextBoxColumn.Visible = false;
            // 
            // avanceDataGridViewTextBoxColumn
            // 
            this.avanceDataGridViewTextBoxColumn.DataPropertyName = "_avance";
            this.avanceDataGridViewTextBoxColumn.HeaderText = "_avance";
            this.avanceDataGridViewTextBoxColumn.Name = "avanceDataGridViewTextBoxColumn";
            this.avanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.avanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreEmisionMultaRIFDataGridViewTextBoxColumn
            // 
            this.nombreEmisionMultaRIFDataGridViewTextBoxColumn.DataPropertyName = "_nombreEmisionMultaRIF";
            this.nombreEmisionMultaRIFDataGridViewTextBoxColumn.HeaderText = "_nombreEmisionMultaRIF";
            this.nombreEmisionMultaRIFDataGridViewTextBoxColumn.Name = "nombreEmisionMultaRIFDataGridViewTextBoxColumn";
            this.nombreEmisionMultaRIFDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreEmisionMultaRIFDataGridViewTextBoxColumn.Visible = false;
            // 
            // origenMultaRIFDataGridViewTextBoxColumn
            // 
            this.origenMultaRIFDataGridViewTextBoxColumn.DataPropertyName = "_origenMultaRIF";
            this.origenMultaRIFDataGridViewTextBoxColumn.HeaderText = "_origenMultaRIF";
            this.origenMultaRIFDataGridViewTextBoxColumn.Name = "origenMultaRIFDataGridViewTextBoxColumn";
            this.origenMultaRIFDataGridViewTextBoxColumn.ReadOnly = true;
            this.origenMultaRIFDataGridViewTextBoxColumn.Visible = false;
            // 
            // vencidosDataGridViewTextBoxColumn
            // 
            this.vencidosDataGridViewTextBoxColumn.DataPropertyName = "_vencidos";
            this.vencidosDataGridViewTextBoxColumn.HeaderText = "_vencidos";
            this.vencidosDataGridViewTextBoxColumn.Name = "vencidosDataGridViewTextBoxColumn";
            this.vencidosDataGridViewTextBoxColumn.ReadOnly = true;
            this.vencidosDataGridViewTextBoxColumn.Visible = false;
            // 
            // cobradosDataGridViewTextBoxColumn
            // 
            this.cobradosDataGridViewTextBoxColumn.DataPropertyName = "_cobrados";
            this.cobradosDataGridViewTextBoxColumn.HeaderText = "_cobrados";
            this.cobradosDataGridViewTextBoxColumn.Name = "cobradosDataGridViewTextBoxColumn";
            this.cobradosDataGridViewTextBoxColumn.ReadOnly = true;
            this.cobradosDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalImporteDataGridViewTextBoxColumn
            // 
            this.totalImporteDataGridViewTextBoxColumn.DataPropertyName = "_totalImporte";
            this.totalImporteDataGridViewTextBoxColumn.HeaderText = "_totalImporte";
            this.totalImporteDataGridViewTextBoxColumn.Name = "totalImporteDataGridViewTextBoxColumn";
            this.totalImporteDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalImporteDataGridViewTextBoxColumn.Visible = false;
            // 
            // honorariosDataGridViewTextBoxColumn
            // 
            this.honorariosDataGridViewTextBoxColumn.DataPropertyName = "_honorarios";
            this.honorariosDataGridViewTextBoxColumn.HeaderText = "_honorarios";
            this.honorariosDataGridViewTextBoxColumn.Name = "honorariosDataGridViewTextBoxColumn";
            this.honorariosDataGridViewTextBoxColumn.ReadOnly = true;
            this.honorariosDataGridViewTextBoxColumn.Visible = false;
            // 
            // cTableroAdminBOBindingSource
            // 
            this.cTableroAdminBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CTableroAdminBO);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEjercicio);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 34);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona el año";
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.DataSource = this.cTableroAdminBOBindingSource;
            this.cmbEjercicio.DisplayMember = "_anho";
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(120, 9);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(121, 21);
            this.cmbEjercicio.TabIndex = 0;
            this.cmbEjercicio.Leave += new System.EventHandler(this.cmbEjercicio_Leave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspProgreso});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tspProgreso
            // 
            this.tspProgreso.Name = "tspProgreso";
            this.tspProgreso.Size = new System.Drawing.Size(100, 16);
            // 
            // dataSetRIF
            // 
            this.dataSetRIF.DataSetName = "DataSetRIF";
            this.dataSetRIF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listadoRIFBindingSource
            // 
            this.listadoRIFBindingSource.DataMember = "ListadoRIF";
            this.listadoRIFBindingSource.DataSource = this.dataSetRIF;
            // 
            // catableroJefeRCOBindingSource
            // 
            this.catableroJefeRCOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CatableroJefeRCO);
            // 
            // cListaTableroAdminBindingSource
            // 
            this.cListaTableroAdminBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CListaTableroAdmin);
            // 
            // pantallaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "pantallaAdmin";
            this.Text = "pantallaAdmin";
            this.Load += new System.EventHandler(this.pantallaAdmin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTableroAdminBOBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoRIFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catableroJefeRCOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListaTableroAdminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cListaTableroAdminBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.BindingSource catableroJefeRCOBindingSource;
        private DataSetRIF dataSetRIF;
        private System.Windows.Forms.BindingSource listadoRIFBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cTableroAdminBOBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEjercicio;
        private System.Windows.Forms.ToolStripProgressBar tspProgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn _idEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn _referenciaNumercia;
        private System.Windows.Forms.DataGridViewTextBoxColumn _anho;
        private System.Windows.Forms.DataGridViewTextBoxColumn _detalleEmision;
        private System.Windows.Forms.DataGridViewLinkColumn Avance;
        private System.Windows.Forms.DataGridViewLinkColumn Listado;
        private System.Windows.Forms.DataGridViewLinkColumn ListPdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejercicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaNumerciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emitidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enviadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noGeneradosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmisionMultaRIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origenMultaRIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobradosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalImporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn honorariosDataGridViewTextBoxColumn;
    }
}