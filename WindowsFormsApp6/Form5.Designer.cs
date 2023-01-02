namespace WindowsFormsApp6
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.cBusquedaMultasBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.DgbusquedaMultasRIF = new System.Windows.Forms.DataGridView();
            this.emisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numReqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._emisionMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrlMultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._numSAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._diligencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._notificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._honorarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ejecucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgReqRIF = new System.Windows.Forms.DataGridView();
            this.ordenaPorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emisionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numReqDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCtrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.diligenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCitatorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNotificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBusquedaRIFBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBusquedaMultasBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgbusquedaMultasRIF)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgReqRIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBusquedaRIFBOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.cBusquedaMultasBOBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cBusquedaMultasBOBindingSource, "_emision", true));
            this.bindingNavigator1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cBusquedaMultasBOBindingSource, "_emision", true));
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripTextBusqueda});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1234, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // cBusquedaMultasBOBindingSource
            // 
            this.cBusquedaMultasBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CBusquedaMultasBO);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBusqueda
            // 
            this.toolStripTextBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBusqueda.Name = "toolStripTextBusqueda";
            this.toolStripTextBusqueda.Size = new System.Drawing.Size(200, 25);
            this.toolStripTextBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBusqueda_KeyDown);
            this.toolStripTextBusqueda.Click += new System.EventHandler(this.toolStripTextBusqueda_Click);
            // 
            // DgbusquedaMultasRIF
            // 
            this.DgbusquedaMultasRIF.AllowUserToAddRows = false;
            this.DgbusquedaMultasRIF.AllowUserToDeleteRows = false;
            this.DgbusquedaMultasRIF.AutoGenerateColumns = false;
            this.DgbusquedaMultasRIF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbusquedaMultasRIF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emisionDataGridViewTextBoxColumn,
            this.numReqDataGridViewTextBoxColumn,
            this._zona,
            this.municipioDataGridViewTextBoxColumn,
            this._emisionMulta,
            this.tipoMultaDataGridViewTextBoxColumn,
            this.ctrlMultaDataGridViewTextBoxColumn,
            this.fechaEmision,
            this.rFCDataGridViewTextBoxColumn,
            this._numSAT,
            this.razonSocialDataGridViewTextBoxColumn,
            this._diligencia,
            this._notificacion,
            this._fechaPago,
            this._importe,
            this._honorarios,
            this._vencimiento,
            this._ejecucion});
            this.DgbusquedaMultasRIF.DataSource = this.cBusquedaMultasBOBindingSource;
            this.DgbusquedaMultasRIF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgbusquedaMultasRIF.Location = new System.Drawing.Point(3, 16);
            this.DgbusquedaMultasRIF.Name = "DgbusquedaMultasRIF";
            this.DgbusquedaMultasRIF.ReadOnly = true;
            this.DgbusquedaMultasRIF.Size = new System.Drawing.Size(1228, 263);
            this.DgbusquedaMultasRIF.TabIndex = 1;
            this.DgbusquedaMultasRIF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgbusquedaMultasRIF_CellContentClick);
            this.DgbusquedaMultasRIF.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgbusquedaMultasRIF_CellFormatting);
            // 
            // emisionDataGridViewTextBoxColumn
            // 
            this.emisionDataGridViewTextBoxColumn.DataPropertyName = "_emision";
            this.emisionDataGridViewTextBoxColumn.HeaderText = "Emisión del requerimiento";
            this.emisionDataGridViewTextBoxColumn.Name = "emisionDataGridViewTextBoxColumn";
            this.emisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numReqDataGridViewTextBoxColumn
            // 
            this.numReqDataGridViewTextBoxColumn.DataPropertyName = "_numReq";
            this.numReqDataGridViewTextBoxColumn.HeaderText = "Número de requerimiento";
            this.numReqDataGridViewTextBoxColumn.Name = "numReqDataGridViewTextBoxColumn";
            this.numReqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _zona
            // 
            this._zona.DataPropertyName = "_zona";
            this._zona.HeaderText = "Zona";
            this._zona.Name = "_zona";
            this._zona.ReadOnly = true;
            // 
            // municipioDataGridViewTextBoxColumn
            // 
            this.municipioDataGridViewTextBoxColumn.DataPropertyName = "_municipio";
            this.municipioDataGridViewTextBoxColumn.HeaderText = "Municipio";
            this.municipioDataGridViewTextBoxColumn.Name = "municipioDataGridViewTextBoxColumn";
            this.municipioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _emisionMulta
            // 
            this._emisionMulta.DataPropertyName = "_emisionMulta";
            this._emisionMulta.HeaderText = "Emision de la multa";
            this._emisionMulta.Name = "_emisionMulta";
            this._emisionMulta.ReadOnly = true;
            // 
            // tipoMultaDataGridViewTextBoxColumn
            // 
            this.tipoMultaDataGridViewTextBoxColumn.DataPropertyName = "_tipoMulta";
            this.tipoMultaDataGridViewTextBoxColumn.HeaderText = "Tipo multa";
            this.tipoMultaDataGridViewTextBoxColumn.Name = "tipoMultaDataGridViewTextBoxColumn";
            this.tipoMultaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ctrlMultaDataGridViewTextBoxColumn
            // 
            this.ctrlMultaDataGridViewTextBoxColumn.DataPropertyName = "_CtrlMulta";
            this.ctrlMultaDataGridViewTextBoxColumn.HeaderText = "Número de multa";
            this.ctrlMultaDataGridViewTextBoxColumn.Name = "ctrlMultaDataGridViewTextBoxColumn";
            this.ctrlMultaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEmision
            // 
            this.fechaEmision.DataPropertyName = "_FechaEmision";
            this.fechaEmision.HeaderText = "Fecha de emisión de la multa";
            this.fechaEmision.Name = "fechaEmision";
            this.fechaEmision.ReadOnly = true;
            // 
            // rFCDataGridViewTextBoxColumn
            // 
            this.rFCDataGridViewTextBoxColumn.DataPropertyName = "_RFC";
            this.rFCDataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn.Name = "rFCDataGridViewTextBoxColumn";
            this.rFCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _numSAT
            // 
            this._numSAT.DataPropertyName = "_numSAT";
            this._numSAT.HeaderText = "Número de control";
            this._numSAT.Name = "_numSAT";
            this._numSAT.ReadOnly = true;
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "_RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "Razón social";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            this.razonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _diligencia
            // 
            this._diligencia.DataPropertyName = "_diligencia";
            this._diligencia.HeaderText = "Diligencia";
            this._diligencia.Name = "_diligencia";
            this._diligencia.ReadOnly = true;
            // 
            // _notificacion
            // 
            this._notificacion.DataPropertyName = "_notificacion";
            this._notificacion.HeaderText = "F. Notificación";
            this._notificacion.Name = "_notificacion";
            this._notificacion.ReadOnly = true;
            // 
            // _fechaPago
            // 
            this._fechaPago.DataPropertyName = "_fechaPago";
            this._fechaPago.HeaderText = "F. pago";
            this._fechaPago.Name = "_fechaPago";
            this._fechaPago.ReadOnly = true;
            // 
            // _importe
            // 
            this._importe.DataPropertyName = "_importe";
            this._importe.HeaderText = "Importe";
            this._importe.Name = "_importe";
            this._importe.ReadOnly = true;
            // 
            // _honorarios
            // 
            this._honorarios.DataPropertyName = "_honorarios";
            this._honorarios.HeaderText = "Honorarios";
            this._honorarios.Name = "_honorarios";
            this._honorarios.ReadOnly = true;
            // 
            // _vencimiento
            // 
            this._vencimiento.DataPropertyName = "_vencimiento";
            this._vencimiento.HeaderText = "Vencimiento";
            this._vencimiento.Name = "_vencimiento";
            this._vencimiento.ReadOnly = true;
            // 
            // _ejecucion
            // 
            this._ejecucion.DataPropertyName = "_ejecucion";
            this._ejecucion.HeaderText = "Ejecución";
            this._ejecucion.Name = "_ejecucion";
            this._ejecucion.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgbusquedaMultasRIF);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1234, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgReqRIF);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1234, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requerimientos";
            // 
            // DgReqRIF
            // 
            this.DgReqRIF.AllowUserToAddRows = false;
            this.DgReqRIF.AllowUserToDeleteRows = false;
            this.DgReqRIF.AutoGenerateColumns = false;
            this.DgReqRIF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgReqRIF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordenaPorDataGridViewTextBoxColumn,
            this.emisionDataGridViewTextBoxColumn1,
            this.numReqDataGridViewTextBoxColumn1,
            this.numCtrlDataGridViewTextBoxColumn,
            this.zonaDataGridViewTextBoxColumn,
            this.municipioDataGridViewTextBoxColumn1,
            this.rFCDataGridViewTextBoxColumn1,
            this.razonSocialDataGridViewTextBoxColumn1,
            this.diligenciaDataGridViewTextBoxColumn,
            this.fechaCitatorioDataGridViewTextBoxColumn,
            this.fechaNotificacionDataGridViewTextBoxColumn});
            this.DgReqRIF.DataSource = this.cBusquedaRIFBOBindingSource;
            this.DgReqRIF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgReqRIF.Location = new System.Drawing.Point(3, 16);
            this.DgReqRIF.Name = "DgReqRIF";
            this.DgReqRIF.ReadOnly = true;
            this.DgReqRIF.Size = new System.Drawing.Size(1228, 106);
            this.DgReqRIF.TabIndex = 0;
            this.DgReqRIF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgReqRIF_CellContentClick);
            this.DgReqRIF.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgReqRIF_CellContentDoubleClick);
            // 
            // ordenaPorDataGridViewTextBoxColumn
            // 
            this.ordenaPorDataGridViewTextBoxColumn.DataPropertyName = "_ordenaPor";
            this.ordenaPorDataGridViewTextBoxColumn.HeaderText = "Edición";
            this.ordenaPorDataGridViewTextBoxColumn.Name = "ordenaPorDataGridViewTextBoxColumn";
            this.ordenaPorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emisionDataGridViewTextBoxColumn1
            // 
            this.emisionDataGridViewTextBoxColumn1.DataPropertyName = "_emision";
            this.emisionDataGridViewTextBoxColumn1.HeaderText = "Número de emisión";
            this.emisionDataGridViewTextBoxColumn1.Name = "emisionDataGridViewTextBoxColumn1";
            this.emisionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numReqDataGridViewTextBoxColumn1
            // 
            this.numReqDataGridViewTextBoxColumn1.DataPropertyName = "_numReq";
            this.numReqDataGridViewTextBoxColumn1.HeaderText = "Número de requerimiento";
            this.numReqDataGridViewTextBoxColumn1.Name = "numReqDataGridViewTextBoxColumn1";
            this.numReqDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numCtrlDataGridViewTextBoxColumn
            // 
            this.numCtrlDataGridViewTextBoxColumn.DataPropertyName = "_numCtrl";
            this.numCtrlDataGridViewTextBoxColumn.HeaderText = "Número de control";
            this.numCtrlDataGridViewTextBoxColumn.Name = "numCtrlDataGridViewTextBoxColumn";
            this.numCtrlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zonaDataGridViewTextBoxColumn
            // 
            this.zonaDataGridViewTextBoxColumn.DataPropertyName = "_zona";
            this.zonaDataGridViewTextBoxColumn.HeaderText = "Zona";
            this.zonaDataGridViewTextBoxColumn.Name = "zonaDataGridViewTextBoxColumn";
            this.zonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // municipioDataGridViewTextBoxColumn1
            // 
            this.municipioDataGridViewTextBoxColumn1.DataPropertyName = "_municipio";
            this.municipioDataGridViewTextBoxColumn1.HeaderText = "Municipio";
            this.municipioDataGridViewTextBoxColumn1.Name = "municipioDataGridViewTextBoxColumn1";
            this.municipioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rFCDataGridViewTextBoxColumn1
            // 
            this.rFCDataGridViewTextBoxColumn1.DataPropertyName = "_RFC";
            this.rFCDataGridViewTextBoxColumn1.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn1.Name = "rFCDataGridViewTextBoxColumn1";
            this.rFCDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // razonSocialDataGridViewTextBoxColumn1
            // 
            this.razonSocialDataGridViewTextBoxColumn1.DataPropertyName = "_RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn1.HeaderText = "Razón social";
            this.razonSocialDataGridViewTextBoxColumn1.Name = "razonSocialDataGridViewTextBoxColumn1";
            this.razonSocialDataGridViewTextBoxColumn1.ReadOnly = true;
            this.razonSocialDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.razonSocialDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // diligenciaDataGridViewTextBoxColumn
            // 
            this.diligenciaDataGridViewTextBoxColumn.DataPropertyName = "_Diligencia";
            this.diligenciaDataGridViewTextBoxColumn.HeaderText = "Diligencia";
            this.diligenciaDataGridViewTextBoxColumn.Name = "diligenciaDataGridViewTextBoxColumn";
            this.diligenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCitatorioDataGridViewTextBoxColumn
            // 
            this.fechaCitatorioDataGridViewTextBoxColumn.DataPropertyName = "_FechaCitatorio";
            this.fechaCitatorioDataGridViewTextBoxColumn.HeaderText = "Citatorio";
            this.fechaCitatorioDataGridViewTextBoxColumn.Name = "fechaCitatorioDataGridViewTextBoxColumn";
            this.fechaCitatorioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNotificacionDataGridViewTextBoxColumn
            // 
            this.fechaNotificacionDataGridViewTextBoxColumn.DataPropertyName = "_FechaNotificacion";
            this.fechaNotificacionDataGridViewTextBoxColumn.HeaderText = "Notificiacion";
            this.fechaNotificacionDataGridViewTextBoxColumn.Name = "fechaNotificacionDataGridViewTextBoxColumn";
            this.fechaNotificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cBusquedaRIFBOBindingSource
            // 
            this.cBusquedaRIFBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CBusquedaRIFBO);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1250, 700);
            this.MinimumSize = new System.Drawing.Size(1250, 312);
            this.Name = "Form5";
            this.Text = "Búsqueda general";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBusquedaMultasBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgbusquedaMultasRIF)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgReqRIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBusquedaRIFBOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBusqueda;
        private System.Windows.Forms.BindingSource cBusquedaMultasBOBindingSource;
        private System.Windows.Forms.DataGridView DgbusquedaMultasRIF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgReqRIF;
        private System.Windows.Forms.BindingSource cBusquedaRIFBOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenaPorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emisionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numReqDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCtrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn razonSocialDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diligenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitatorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNotificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numReqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _emisionMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctrlMultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numSAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _diligencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn _notificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn _importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn _honorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn _vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ejecucion;
    }
}