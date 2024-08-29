namespace WindowsFormsApp6
{
    partial class ListadoRequeridos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoRequeridos));
            this.requeridos = new System.Windows.Forms.DataGridView();
            this.dataGridZona = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridOHE = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridNumReq = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridNumCtrl = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridRFC = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridTipoC = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridRS = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridDiligencia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridFC = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridFN = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridEstatus = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridPDF = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this._nombreNotificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridMalCapturado = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridObvservaciones = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this._notasObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cListaTableroAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OheLabel = new System.Windows.Forms.ToolStripLabel();
            this.OheSelect = new System.Windows.Forms.ToolStripComboBox();
            this.Down_SelectedBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.tsbFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsExcel = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgreso = new System.Windows.Forms.ToolStripProgressBar();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CalendarioFechas = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.requeridos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListaTableroAdminBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // requeridos
            // 
            this.requeridos.AllowUserToAddRows = false;
            this.requeridos.AllowUserToDeleteRows = false;
            this.requeridos.AutoGenerateColumns = false;
            this.requeridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requeridos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridZona,
            this.dataGridOHE,
            this.dataGridNumReq,
            this.dataGridNumCtrl,
            this.dataGridRFC,
            this.dataGridTipoC,
            this.dataGridRS,
            this.dataGridDiligencia,
            this.dataGridFC,
            this.dataGridFN,
            this.dataGridEstatus,
            this.dataGridPDF,
            this._nombreNotificador,
            this.dataGridMalCapturado,
            this.dataGridObvservaciones,
            this._notasObservaciones});
            this.requeridos.DataSource = this.cListaTableroAdminBindingSource;
            this.requeridos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requeridos.Location = new System.Drawing.Point(3, 47);
            this.requeridos.Name = "requeridos";
            this.requeridos.Size = new System.Drawing.Size(1577, 566);
            this.requeridos.TabIndex = 0;
            this.requeridos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requeridos_CellClick);
            this.requeridos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requeridos_CellContentClick);
            this.requeridos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requeridos_CellContentDoubleClick);
            this.requeridos.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.requeridos_CellValidated);
            this.requeridos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.requeridos_CellValidating);
            this.requeridos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.requeridos_CellValueChanged);
            this.requeridos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.requeridos_DataBindingComplete);
            this.requeridos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.requeridos_EditingControlShowing);
            this.requeridos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.requeridos_KeyDown);
            // 
            // dataGridZona
            // 
            this.dataGridZona.DataPropertyName = "_zona";
            this.dataGridZona.FilteringEnabled = false;
            this.dataGridZona.HeaderText = "Zona";
            this.dataGridZona.Name = "dataGridZona";
            this.dataGridZona.ReadOnly = true;
            this.dataGridZona.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridOHE
            // 
            this.dataGridOHE.DataPropertyName = "_ohe";
            this.dataGridOHE.FilteringEnabled = false;
            this.dataGridOHE.HeaderText = "OHE";
            this.dataGridOHE.Name = "dataGridOHE";
            this.dataGridOHE.ReadOnly = true;
            this.dataGridOHE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridNumReq
            // 
            this.dataGridNumReq.DataPropertyName = "_numReq";
            this.dataGridNumReq.FilteringEnabled = false;
            this.dataGridNumReq.HeaderText = "Numero Requerimiento";
            this.dataGridNumReq.Name = "dataGridNumReq";
            this.dataGridNumReq.ReadOnly = true;
            this.dataGridNumReq.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridNumCtrl
            // 
            this.dataGridNumCtrl.DataPropertyName = "_numCtrl";
            this.dataGridNumCtrl.FilteringEnabled = false;
            this.dataGridNumCtrl.HeaderText = "Numero de control";
            this.dataGridNumCtrl.Name = "dataGridNumCtrl";
            this.dataGridNumCtrl.ReadOnly = true;
            this.dataGridNumCtrl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridRFC
            // 
            this.dataGridRFC.DataPropertyName = "_rfc";
            this.dataGridRFC.FilteringEnabled = false;
            this.dataGridRFC.HeaderText = "RFC";
            this.dataGridRFC.Name = "dataGridRFC";
            this.dataGridRFC.ReadOnly = true;
            this.dataGridRFC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridTipoC
            // 
            this.dataGridTipoC.DataPropertyName = "_tipoc";
            this.dataGridTipoC.FilteringEnabled = false;
            this.dataGridTipoC.HeaderText = "Tipo contribuyente";
            this.dataGridTipoC.Name = "dataGridTipoC";
            this.dataGridTipoC.ReadOnly = true;
            this.dataGridTipoC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridRS
            // 
            this.dataGridRS.DataPropertyName = "_rs";
            this.dataGridRS.HeaderText = "Razon Social";
            this.dataGridRS.Name = "dataGridRS";
            this.dataGridRS.ReadOnly = true;
            this.dataGridRS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridDiligencia
            // 
            this.dataGridDiligencia.DataPropertyName = "_diligencia";
            this.dataGridDiligencia.HeaderText = "Diligencia";
            this.dataGridDiligencia.Items.AddRange(new object[] {
            "LOCALIZADO",
            "NO LOCALIZADO",
            "NO TRABAJADO"});
            this.dataGridDiligencia.Name = "dataGridDiligencia";
            this.dataGridDiligencia.ReadOnly = true;
            this.dataGridDiligencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDiligencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridFC
            // 
            this.dataGridFC.DataPropertyName = "_fechaCitatorio";
            this.dataGridFC.FilteringEnabled = false;
            this.dataGridFC.HeaderText = "Fecha citatorio";
            this.dataGridFC.Name = "dataGridFC";
            this.dataGridFC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridFN
            // 
            this.dataGridFN.DataPropertyName = "_fechaNotificacion";
            this.dataGridFN.FilteringEnabled = false;
            this.dataGridFN.HeaderText = "Fecha Notificacion";
            this.dataGridFN.Name = "dataGridFN";
            this.dataGridFN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridEstatus
            // 
            this.dataGridEstatus.DataPropertyName = "_estatus";
            this.dataGridEstatus.FilteringEnabled = false;
            this.dataGridEstatus.HeaderText = "Estatus";
            this.dataGridEstatus.Name = "dataGridEstatus";
            this.dataGridEstatus.ReadOnly = true;
            this.dataGridEstatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridPDF
            // 
            this.dataGridPDF.DataPropertyName = "_pdf";
            this.dataGridPDF.FilteringEnabled = false;
            this.dataGridPDF.HeaderText = "PDF";
            this.dataGridPDF.Name = "dataGridPDF";
            this.dataGridPDF.ReadOnly = true;
            this.dataGridPDF.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // _nombreNotificador
            // 
            this._nombreNotificador.DataPropertyName = "_nombreNotificador";
            this._nombreNotificador.HeaderText = "Notificador";
            this._nombreNotificador.Name = "_nombreNotificador";
            this._nombreNotificador.ReadOnly = true;
            // 
            // dataGridMalCapturado
            // 
            this.dataGridMalCapturado.DataPropertyName = "_malCapturado";
            this.dataGridMalCapturado.FilteringEnabled = false;
            this.dataGridMalCapturado.HeaderText = "Mal caputurado";
            this.dataGridMalCapturado.Name = "dataGridMalCapturado";
            this.dataGridMalCapturado.ReadOnly = true;
            this.dataGridMalCapturado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridObvservaciones
            // 
            this.dataGridObvservaciones.DataPropertyName = "_observaciones";
            this.dataGridObvservaciones.FilteringEnabled = false;
            this.dataGridObvservaciones.HeaderText = "Observaciones";
            this.dataGridObvservaciones.Name = "dataGridObvservaciones";
            this.dataGridObvservaciones.ReadOnly = true;
            this.dataGridObvservaciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // _notasObservaciones
            // 
            this._notasObservaciones.DataPropertyName = "_notasObservaciones";
            this._notasObservaciones.HeaderText = "Notas";
            this._notasObservaciones.Name = "_notasObservaciones";
            this._notasObservaciones.ReadOnly = true;
            // 
            // cListaTableroAdminBindingSource
            // 
            this.cListaTableroAdminBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CListaTableroAdmin);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.requeridos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CalendarioFechas, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1583, 656);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OheLabel,
            this.OheSelect,
            this.Down_SelectedBtn,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tbBusqueda,
            this.tsbFiltrar,
            this.toolStripButton1,
            this.tsExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1583, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OheLabel
            // 
            this.OheLabel.Name = "OheLabel";
            this.OheLabel.Size = new System.Drawing.Size(48, 22);
            this.OheLabel.Text = "Oficina:";
            // 
            // OheSelect
            // 
            this.OheSelect.Name = "OheSelect";
            this.OheSelect.Size = new System.Drawing.Size(121, 25);
            this.OheSelect.Leave += new System.EventHandler(this.OheSelect_Leave);
            this.OheSelect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OheSelect_KeyUp);
            // 
            // Down_SelectedBtn
            // 
            this.Down_SelectedBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Down_SelectedBtn.Image = global::WindowsFormsApp6.Properties.Resources.down;
            this.Down_SelectedBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Down_SelectedBtn.Name = "Down_SelectedBtn";
            this.Down_SelectedBtn.Size = new System.Drawing.Size(23, 22);
            this.Down_SelectedBtn.Text = "toolStripButton2";
            this.Down_SelectedBtn.Click += new System.EventHandler(this.Down_SelectedBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(62, 22);
            this.toolStripLabel1.Text = "Busqueda:";
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbBusqueda.HideSelection = false;
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(300, 25);
            this.tbBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBusqueda_KeyDown);
            // 
            // tsbFiltrar
            // 
            this.tsbFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbFiltrar.Image = global::WindowsFormsApp6.Properties.Resources.filtrar;
            this.tsbFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiltrar.Name = "tsbFiltrar";
            this.tsbFiltrar.Size = new System.Drawing.Size(41, 22);
            this.tsbFiltrar.Text = "Filtrar";
            this.tsbFiltrar.Click += new System.EventHandler(this.tsbFiltrar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(99, 22);
            this.toolStripButton1.Text = "Descarga Masiva";
            this.toolStripButton1.ToolTipText = "Descarga masiva";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsExcel
            // 
            this.tsExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsExcel.Image")));
            this.tsExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExcel.Name = "tsExcel";
            this.tsExcel.Size = new System.Drawing.Size(44, 22);
            this.tsExcel.Text = "EXCEL";
            this.tsExcel.Click += new System.EventHandler(this.tsExcel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgreso,
            this.FilterStatusLabel,
            this.ShowAllLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1583, 20);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgreso
            // 
            this.tsProgreso.Name = "tsProgreso";
            this.tsProgreso.Size = new System.Drawing.Size(100, 14);
            this.tsProgreso.Click += new System.EventHandler(this.tsProgreso_Click);
            // 
            // FilterStatusLabel
            // 
            this.FilterStatusLabel.Name = "FilterStatusLabel";
            this.FilterStatusLabel.Size = new System.Drawing.Size(0, 15);
            this.FilterStatusLabel.Visible = false;
            // 
            // ShowAllLabel
            // 
            this.ShowAllLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllLabel.IsLink = true;
            this.ShowAllLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ShowAllLabel.Name = "ShowAllLabel";
            this.ShowAllLabel.Size = new System.Drawing.Size(53, 15);
            this.ShowAllLabel.Text = "Show &All";
            this.ShowAllLabel.Click += new System.EventHandler(this.ShowAllLabel_Click);
            // 
            // CalendarioFechas
            // 
            this.CalendarioFechas.Location = new System.Drawing.Point(9, 645);
            this.CalendarioFechas.Name = "CalendarioFechas";
            this.CalendarioFechas.TabIndex = 3;
            this.CalendarioFechas.Visible = false;
            // 
            // ListadoRequeridos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 656);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListadoRequeridos";
            this.Text = "ListadoRequeridos";
            this.Load += new System.EventHandler(this.ListadoRequeridos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requeridos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListaTableroAdminBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView requeridos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tbBusqueda;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FilterStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowAllLabel;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dgZona;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dgOHE;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dgNumReq;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dgRFC;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dgNumCtrl;
        private System.Windows.Forms.DataGridViewLinkColumn dgRs;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dgDiligencia;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dgFC;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dgFN;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dgEstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaNumerciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noLocalizadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeFallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejercicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emitidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enviadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noGeneradosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTrabajadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmisionMultaRIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origenMultaRIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobradosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalImporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn honorariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton tsbFiltrar;
        private System.Windows.Forms.ToolStripProgressBar tsProgreso;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource cListaTableroAdminBindingSource;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn zonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numReqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCtrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diligenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitatorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNotificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataX;
        private System.Windows.Forms.ToolStripButton tsExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn _observaciones;
        private System.Windows.Forms.ToolStripLabel OheLabel;
        private System.Windows.Forms.ToolStripComboBox OheSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MonthCalendar CalendarioFechas;
        private System.Windows.Forms.ToolStripButton Down_SelectedBtn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridZona;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridOHE;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridNumReq;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridNumCtrl;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridRFC;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridTipoC;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridRS;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridDiligencia;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridFC;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridFN;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridEstatus;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nombreNotificador;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridMalCapturado;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridObvservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn _notasObservaciones;
    }
}