namespace WindowsFormsApp6
{
    partial class Form1
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
            System.Windows.Forms.Label oHELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PanelDatosLocalizacion = new System.Windows.Forms.Panel();
            this.PanelEmisionRequerimientos = new System.Windows.Forms.TableLayoutPanel();
            this.SelectEmision = new System.Windows.Forms.GroupBox();
            this.cmbAnho = new System.Windows.Forms.ComboBox();
            this.canhoFiscalBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblListo = new System.Windows.Forms.Label();
            this.FechaImpresion = new System.Windows.Forms.Label();
            this.listCEmisionActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.CmbEmision = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmision = new System.Windows.Forms.Label();
            this.cmbOHE = new System.Windows.Forms.ComboBox();
            this.coheActivaBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.GroupDatosContribuyente = new System.Windows.Forms.GroupBox();
            this.LayParticulares = new System.Windows.Forms.TableLayoutPanel();
            this.tituloRS = new System.Windows.Forms.Label();
            this.DatoRS = new System.Windows.Forms.Label();
            this.tituloNCTRL = new System.Windows.Forms.Label();
            this.DatoCTRL = new System.Windows.Forms.Label();
            this.tituloDescripcionObservacion = new System.Windows.Forms.Label();
            this.DatoDescripcion = new System.Windows.Forms.Label();
            this.tituloObservacion = new System.Windows.Forms.Label();
            this.DatoObservaciones = new System.Windows.Forms.Label();
            this.tituloEstatus = new System.Windows.Forms.Label();
            this.DatoEstatus = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblZonaName = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.cListaRequeridosBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBusquedaMasiva = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgReqActivos2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diligencia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FechaCitatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNotificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEnvioSefiplan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreNotificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MalCapturado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ActaNotificacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ActaCitatorio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NotificacionCitatorio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cListaCatObservacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NotasObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cNombreBimestreBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pbCarga = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.listCoheActivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cEmisionActualBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            oHELabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.PanelDatosLocalizacion.SuspendLayout();
            this.PanelEmisionRequerimientos.SuspendLayout();
            this.SelectEmision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canhoFiscalBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCEmisionActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coheActivaBOBindingSource)).BeginInit();
            this.GroupDatosContribuyente.SuspendLayout();
            this.LayParticulares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cListaRequeridosBOBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgReqActivos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListaCatObservacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNombreBimestreBOBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCoheActivaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEmisionActualBOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oHELabel
            // 
            oHELabel.AutoSize = true;
            oHELabel.Location = new System.Drawing.Point(736, 34);
            oHELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            oHELabel.Name = "oHELabel";
            oHELabel.Size = new System.Drawing.Size(48, 20);
            oHELabel.TabIndex = 9;
            oHELabel.Text = "OHE:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PanelDatosLocalizacion);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1924, 508);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú selección";
            // 
            // PanelDatosLocalizacion
            // 
            this.PanelDatosLocalizacion.Controls.Add(this.PanelEmisionRequerimientos);
            this.PanelDatosLocalizacion.Controls.Add(this.btnGuardar);
            this.PanelDatosLocalizacion.Controls.Add(this.lblZonaName);
            this.PanelDatosLocalizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDatosLocalizacion.Location = new System.Drawing.Point(4, 24);
            this.PanelDatosLocalizacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelDatosLocalizacion.Name = "PanelDatosLocalizacion";
            this.PanelDatosLocalizacion.Size = new System.Drawing.Size(1916, 445);
            this.PanelDatosLocalizacion.TabIndex = 14;
            // 
            // PanelEmisionRequerimientos
            // 
            this.PanelEmisionRequerimientos.ColumnCount = 2;
            this.PanelEmisionRequerimientos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.46781F));
            this.PanelEmisionRequerimientos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.53219F));
            this.PanelEmisionRequerimientos.Controls.Add(this.SelectEmision, 0, 0);
            this.PanelEmisionRequerimientos.Controls.Add(this.monthCalendar1, 1, 0);
            this.PanelEmisionRequerimientos.Controls.Add(this.GroupDatosContribuyente, 0, 1);
            this.PanelEmisionRequerimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEmisionRequerimientos.Location = new System.Drawing.Point(0, 0);
            this.PanelEmisionRequerimientos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelEmisionRequerimientos.Name = "PanelEmisionRequerimientos";
            this.PanelEmisionRequerimientos.RowCount = 2;
            this.PanelEmisionRequerimientos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.14286F));
            this.PanelEmisionRequerimientos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.85714F));
            this.PanelEmisionRequerimientos.Size = new System.Drawing.Size(1916, 445);
            this.PanelEmisionRequerimientos.TabIndex = 19;
            this.PanelEmisionRequerimientos.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelEmisionRequerimientos_Paint);
            // 
            // SelectEmision
            // 
            this.SelectEmision.Controls.Add(this.cmbAnho);
            this.SelectEmision.Controls.Add(this.lblListo);
            this.SelectEmision.Controls.Add(this.FechaImpresion);
            this.SelectEmision.Controls.Add(this.label1);
            this.SelectEmision.Controls.Add(this.lblFecha);
            this.SelectEmision.Controls.Add(this.CmbEmision);
            this.SelectEmision.Controls.Add(this.label2);
            this.SelectEmision.Controls.Add(oHELabel);
            this.SelectEmision.Controls.Add(this.lblEmision);
            this.SelectEmision.Controls.Add(this.cmbOHE);
            this.SelectEmision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectEmision.Location = new System.Drawing.Point(4, 5);
            this.SelectEmision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectEmision.Name = "SelectEmision";
            this.SelectEmision.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectEmision.Size = new System.Drawing.Size(1476, 110);
            this.SelectEmision.TabIndex = 0;
            this.SelectEmision.TabStop = false;
            this.SelectEmision.Text = "Seleccion de emision de requerimientos";
            // 
            // cmbAnho
            // 
            this.cmbAnho.DataSource = this.canhoFiscalBOBindingSource;
            this.cmbAnho.DisplayMember = "Anho";
            this.cmbAnho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnho.FormattingEnabled = true;
            this.cmbAnho.Location = new System.Drawing.Point(182, 29);
            this.cmbAnho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAnho.Name = "cmbAnho";
            this.cmbAnho.Size = new System.Drawing.Size(106, 28);
            this.cmbAnho.TabIndex = 0;
            this.cmbAnho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAnho_KeyDown);
            this.cmbAnho.Leave += new System.EventHandler(this.CmbAnho_Leave);
            // 
            // canhoFiscalBOBindingSource
            // 
            this.canhoFiscalBOBindingSource.DataSource = typeof(WindowsFormsApp6.BO.CanhoFiscalBO);
            // 
            // lblListo
            // 
            this.lblListo.AutoSize = true;
            this.lblListo.Location = new System.Drawing.Point(1092, 82);
            this.lblListo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListo.Name = "lblListo";
            this.lblListo.Size = new System.Drawing.Size(47, 20);
            this.lblListo.TabIndex = 13;
            this.lblListo.Text = "Listo.";
            // 
            // FechaImpresion
            // 
            this.FechaImpresion.AutoSize = true;
            this.FechaImpresion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listCEmisionActualBindingSource, "_fechaImpresion", true));
            this.FechaImpresion.Location = new System.Drawing.Point(1256, 42);
            this.FechaImpresion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaImpresion.Name = "FechaImpresion";
            this.FechaImpresion.Size = new System.Drawing.Size(154, 20);
            this.FechaImpresion.TabIndex = 15;
            this.FechaImpresion.Text = "Fecha de Impresion:";
            // 
            // listCEmisionActualBindingSource
            // 
            this.listCEmisionActualBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.ListCEmisionActual);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "EJERCICO FISCAL:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(1092, 42);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(154, 20);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha de Impresion:";
            // 
            // CmbEmision
            // 
            this.CmbEmision.DataSource = this.listCEmisionActualBindingSource;
            this.CmbEmision.DisplayMember = "NomEmision";
            this.CmbEmision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmision.FormattingEnabled = true;
            this.CmbEmision.Location = new System.Drawing.Point(444, 29);
            this.CmbEmision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbEmision.Name = "CmbEmision";
            this.CmbEmision.Size = new System.Drawing.Size(282, 28);
            this.CmbEmision.TabIndex = 1;
            this.CmbEmision.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmision_KeyDown);
            this.CmbEmision.Leave += new System.EventHandler(this.CmbEmision_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "EMISION:";
            // 
            // lblEmision
            // 
            this.lblEmision.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listCEmisionActualBindingSource, "Periodo", true));
            this.lblEmision.Location = new System.Drawing.Point(387, 34);
            this.lblEmision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(48, 29);
            this.lblEmision.TabIndex = 11;
            this.lblEmision.Text = "1";
            // 
            // cmbOHE
            // 
            this.cmbOHE.DataSource = this.coheActivaBOBindingSource;
            this.cmbOHE.DisplayMember = "OHE";
            this.cmbOHE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOHE.FormattingEnabled = true;
            this.cmbOHE.Location = new System.Drawing.Point(792, 29);
            this.cmbOHE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbOHE.Name = "cmbOHE";
            this.cmbOHE.Size = new System.Drawing.Size(271, 28);
            this.cmbOHE.TabIndex = 2;
            this.cmbOHE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOHE_KeyDown);
            this.cmbOHE.Leave += new System.EventHandler(this.CmbEmision_Leave);
            // 
            // coheActivaBOBindingSource
            // 
            this.coheActivaBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CoheActivaBO);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1498, 14);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // GroupDatosContribuyente
            // 
            this.GroupDatosContribuyente.Controls.Add(this.LayParticulares);
            this.GroupDatosContribuyente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupDatosContribuyente.Location = new System.Drawing.Point(4, 125);
            this.GroupDatosContribuyente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupDatosContribuyente.Name = "GroupDatosContribuyente";
            this.GroupDatosContribuyente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupDatosContribuyente.Size = new System.Drawing.Size(1476, 315);
            this.GroupDatosContribuyente.TabIndex = 13;
            this.GroupDatosContribuyente.TabStop = false;
            this.GroupDatosContribuyente.Text = "Datos particulares del contribuyente";
            // 
            // LayParticulares
            // 
            this.LayParticulares.ColumnCount = 2;
            this.LayParticulares.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.961686F));
            this.LayParticulares.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.03831F));
            this.LayParticulares.Controls.Add(this.tituloRS, 0, 0);
            this.LayParticulares.Controls.Add(this.DatoRS, 1, 0);
            this.LayParticulares.Controls.Add(this.tituloNCTRL, 0, 1);
            this.LayParticulares.Controls.Add(this.DatoCTRL, 1, 1);
            this.LayParticulares.Controls.Add(this.tituloDescripcionObservacion, 0, 5);
            this.LayParticulares.Controls.Add(this.DatoDescripcion, 1, 5);
            this.LayParticulares.Controls.Add(this.tituloObservacion, 0, 4);
            this.LayParticulares.Controls.Add(this.DatoObservaciones, 1, 4);
            this.LayParticulares.Controls.Add(this.tituloEstatus, 0, 3);
            this.LayParticulares.Controls.Add(this.DatoEstatus, 1, 3);
            this.LayParticulares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayParticulares.Location = new System.Drawing.Point(4, 24);
            this.LayParticulares.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LayParticulares.Name = "LayParticulares";
            this.LayParticulares.RowCount = 6;
            this.LayParticulares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.LayParticulares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.LayParticulares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.LayParticulares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.LayParticulares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.LayParticulares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.LayParticulares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.LayParticulares.Size = new System.Drawing.Size(1468, 286);
            this.LayParticulares.TabIndex = 0;
            // 
            // tituloRS
            // 
            this.tituloRS.AutoSize = true;
            this.tituloRS.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloRS.Location = new System.Drawing.Point(4, 0);
            this.tituloRS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloRS.Name = "tituloRS";
            this.tituloRS.Size = new System.Drawing.Size(138, 20);
            this.tituloRS.TabIndex = 2;
            this.tituloRS.Text = "Razón social:";
            // 
            // DatoRS
            // 
            this.DatoRS.AutoSize = true;
            this.DatoRS.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatoRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatoRS.Location = new System.Drawing.Point(150, 0);
            this.DatoRS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DatoRS.Name = "DatoRS";
            this.DatoRS.Size = new System.Drawing.Size(1314, 37);
            this.DatoRS.TabIndex = 3;
            // 
            // tituloNCTRL
            // 
            this.tituloNCTRL.AutoSize = true;
            this.tituloNCTRL.Location = new System.Drawing.Point(4, 49);
            this.tituloNCTRL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloNCTRL.Name = "tituloNCTRL";
            this.tituloNCTRL.Size = new System.Drawing.Size(91, 28);
            this.tituloNCTRL.TabIndex = 4;
            this.tituloNCTRL.Text = "Número de control:";
            // 
            // DatoCTRL
            // 
            this.DatoCTRL.AutoSize = true;
            this.DatoCTRL.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatoCTRL.Location = new System.Drawing.Point(150, 49);
            this.DatoCTRL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DatoCTRL.Name = "DatoCTRL";
            this.DatoCTRL.Size = new System.Drawing.Size(1314, 20);
            this.DatoCTRL.TabIndex = 5;
            // 
            // tituloDescripcionObservacion
            // 
            this.tituloDescripcionObservacion.AutoSize = true;
            this.tituloDescripcionObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tituloDescripcionObservacion.Location = new System.Drawing.Point(4, 155);
            this.tituloDescripcionObservacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloDescripcionObservacion.Name = "tituloDescripcionObservacion";
            this.tituloDescripcionObservacion.Size = new System.Drawing.Size(138, 131);
            this.tituloDescripcionObservacion.TabIndex = 10;
            this.tituloDescripcionObservacion.Text = "Descripcion:";
            // 
            // DatoDescripcion
            // 
            this.DatoDescripcion.AutoSize = true;
            this.DatoDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatoDescripcion.Location = new System.Drawing.Point(150, 155);
            this.DatoDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DatoDescripcion.Name = "DatoDescripcion";
            this.DatoDescripcion.Size = new System.Drawing.Size(1314, 20);
            this.DatoDescripcion.TabIndex = 11;
            this.DatoDescripcion.Text = "Descripcion";
            // 
            // tituloObservacion
            // 
            this.tituloObservacion.AutoSize = true;
            this.tituloObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tituloObservacion.Location = new System.Drawing.Point(4, 123);
            this.tituloObservacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloObservacion.Name = "tituloObservacion";
            this.tituloObservacion.Size = new System.Drawing.Size(138, 32);
            this.tituloObservacion.TabIndex = 8;
            this.tituloObservacion.Text = "Observaciones:";
            // 
            // DatoObservaciones
            // 
            this.DatoObservaciones.AutoSize = true;
            this.DatoObservaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatoObservaciones.Location = new System.Drawing.Point(150, 123);
            this.DatoObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DatoObservaciones.Name = "DatoObservaciones";
            this.DatoObservaciones.Size = new System.Drawing.Size(1314, 20);
            this.DatoObservaciones.TabIndex = 9;
            this.DatoObservaciones.Text = "Observaciones";
            // 
            // tituloEstatus
            // 
            this.tituloEstatus.AutoSize = true;
            this.tituloEstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tituloEstatus.Location = new System.Drawing.Point(4, 91);
            this.tituloEstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloEstatus.Name = "tituloEstatus";
            this.tituloEstatus.Size = new System.Drawing.Size(138, 32);
            this.tituloEstatus.TabIndex = 6;
            this.tituloEstatus.Text = "Estatus:";
            // 
            // DatoEstatus
            // 
            this.DatoEstatus.AutoSize = true;
            this.DatoEstatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatoEstatus.Location = new System.Drawing.Point(150, 91);
            this.DatoEstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DatoEstatus.Name = "DatoEstatus";
            this.DatoEstatus.Size = new System.Drawing.Size(1314, 20);
            this.DatoEstatus.TabIndex = 7;
            this.DatoEstatus.Text = "Estatus";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1786, 465);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 35);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            // 
            // lblZonaName
            // 
            this.lblZonaName.AutoSize = true;
            this.lblZonaName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblZonaName.Location = new System.Drawing.Point(0, 0);
            this.lblZonaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZonaName.Name = "lblZonaName";
            this.lblZonaName.Size = new System.Drawing.Size(0, 20);
            this.lblZonaName.TabIndex = 18;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.cListaRequeridosBOBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            this.toolStripLabel1,
            this.toolStripTextBusqueda,
            this.toolStripSeparator1,
            this.btnBusquedaMasiva,
            this.toolStripSeparator2,
            this.btnExcel,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.guardarToolStripButton,
            this.toolStripSeparator,
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(4, 469);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1916, 34);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // cListaRequeridosBOBindingSource
            // 
            this.cListaRequeridosBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CListaRequeridosBO);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 29);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 29);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 29);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 34);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 29);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 29);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(67, 29);
            this.toolStripLabel1.Text = "Buscar:";
            // 
            // toolStripTextBusqueda
            // 
            this.toolStripTextBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBusqueda.Name = "toolStripTextBusqueda";
            this.toolStripTextBusqueda.Size = new System.Drawing.Size(298, 34);
            this.toolStripTextBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBusqueda_KeyDown);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnBusquedaMasiva
            // 
            this.btnBusquedaMasiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBusquedaMasiva.Image = ((System.Drawing.Image)(resources.GetObject("btnBusquedaMasiva.Image")));
            this.btnBusquedaMasiva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBusquedaMasiva.Name = "btnBusquedaMasiva";
            this.btnBusquedaMasiva.Size = new System.Drawing.Size(154, 29);
            this.btnBusquedaMasiva.Text = "Busqueda masiva";
            this.btnBusquedaMasiva.Click += new System.EventHandler(this.btnBusquedaMasiva_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // btnExcel
            // 
            this.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExcel.Image = global::WindowsFormsApp6.Properties.Resources.excel;
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(54, 29);
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 29);
            this.toolStripButton1.Text = "Excel datos";
            this.toolStripButton1.ToolTipText = "Excel";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // guardarToolStripButton
            // 
            this.guardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guardarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripButton.Image")));
            this.guardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripButton.Name = "guardarToolStripButton";
            this.guardarToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.guardarToolStripButton.Text = "&Guardar";
            this.guardarToolStripButton.Click += new System.EventHandler(this.guardarToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(141, 29);
            this.toolStripButton2.Text = "Mostrar ocultos";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.DgReqActivos2);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cNombreBimestreBOBindingSource, "OHE", true));
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cNombreBimestreBOBindingSource, "OHE", true));
            this.groupBox2.Location = new System.Drawing.Point(4, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1916, 441);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // DgReqActivos2
            // 
            this.DgReqActivos2.AllowUserToAddRows = false;
            this.DgReqActivos2.AllowUserToDeleteRows = false;
            this.DgReqActivos2.AutoGenerateColumns = false;
            this.DgReqActivos2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgReqActivos2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DgReqActivos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgReqActivos2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Diligencia,
            this.FechaCitatorio,
            this.FechaNotificacion,
            this.dataGridViewTextBoxColumn9,
            this.FechaEnvioSefiplan,
            this.NombreNotificador,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.MalCapturado,
            this.ActaNotificacion,
            this.ActaCitatorio,
            this.NotificacionCitatorio,
            this.Observaciones,
            this.NotasObservaciones,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2});
            this.DgReqActivos2.DataSource = this.cListaRequeridosBOBindingSource;
            this.DgReqActivos2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgReqActivos2.Location = new System.Drawing.Point(4, 24);
            this.DgReqActivos2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgReqActivos2.Name = "DgReqActivos2";
            this.DgReqActivos2.RowHeadersWidth = 62;
            this.DgReqActivos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgReqActivos2.Size = new System.Drawing.Size(1908, 412);
            this.DgReqActivos2.TabIndex = 0;
            this.DgReqActivos2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgReqActivos2_CellClick);
            this.DgReqActivos2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgReqActivos2_CellContentDoubleClick);
            this.DgReqActivos2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgReqActivos2_CellEndEdit);
            this.DgReqActivos2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgReqActivos2_CellEnter);
            this.DgReqActivos2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgReqActivos_CellValidating);
            this.DgReqActivos2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgReqActivos2_CellValueChanged);
            this.DgReqActivos2.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgReqActivos2_ColumnHeaderMouseDoubleClick);
            this.DgReqActivos2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgReqActivos_DataError);
            this.DgReqActivos2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgReqActivos_EditingControlShowing);
            this.DgReqActivos2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgReqActivos_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NumReq";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rfc";
            this.dataGridViewTextBoxColumn2.HeaderText = "RFC";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NumCtrl";
            this.dataGridViewTextBoxColumn3.HeaderText = "Número de control";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RazonSocial";
            this.dataGridViewTextBoxColumn4.HeaderText = "Razón social";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Localidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Localidad";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // Diligencia
            // 
            this.Diligencia.DataPropertyName = "Diligencia";
            this.Diligencia.HeaderText = "Localizado/No localizado";
            this.Diligencia.Items.AddRange(new object[] {
            "LOCALIZADO",
            "NO LOCALIZADO",
            "NO TRABAJADO"});
            this.Diligencia.MinimumWidth = 8;
            this.Diligencia.Name = "Diligencia";
            this.Diligencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Diligencia.Sorted = true;
            this.Diligencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Diligencia.Width = 150;
            // 
            // FechaCitatorio
            // 
            this.FechaCitatorio.DataPropertyName = "FechaCitatorio";
            this.FechaCitatorio.HeaderText = "Fecha de citatorio";
            this.FechaCitatorio.MinimumWidth = 8;
            this.FechaCitatorio.Name = "FechaCitatorio";
            this.FechaCitatorio.Width = 150;
            // 
            // FechaNotificacion
            // 
            this.FechaNotificacion.DataPropertyName = "FechaNotificacion";
            this.FechaNotificacion.HeaderText = "Fecha de notificacion";
            this.FechaNotificacion.MinimumWidth = 8;
            this.FechaNotificacion.Name = "FechaNotificacion";
            this.FechaNotificacion.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OficioSEFIPLAN";
            this.dataGridViewTextBoxColumn9.HeaderText = "Oficio de envio a SEFIPLAN";
            this.dataGridViewTextBoxColumn9.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // FechaEnvioSefiplan
            // 
            this.FechaEnvioSefiplan.DataPropertyName = "FechaEnvioSefiplan";
            this.FechaEnvioSefiplan.HeaderText = "Fecha de envio a SEFIPLAN";
            this.FechaEnvioSefiplan.MinimumWidth = 8;
            this.FechaEnvioSefiplan.Name = "FechaEnvioSefiplan";
            this.FechaEnvioSefiplan.Visible = false;
            this.FechaEnvioSefiplan.Width = 150;
            // 
            // NombreNotificador
            // 
            this.NombreNotificador.DataPropertyName = "NombreNotificador";
            this.NombreNotificador.HeaderText = "Nombre del notificador";
            this.NombreNotificador.MinimumWidth = 8;
            this.NombreNotificador.Name = "NombreNotificador";
            this.NombreNotificador.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FechaEntregaNotificador";
            this.dataGridViewTextBoxColumn11.HeaderText = "FechaEntregaNotificador";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FechaRecepcion";
            this.dataGridViewTextBoxColumn12.HeaderText = "FechaRecepcion";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Estatus";
            this.dataGridViewTextBoxColumn14.HeaderText = "Estatus";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // MalCapturado
            // 
            this.MalCapturado.DataPropertyName = "MalCapturado";
            this.MalCapturado.HeaderText = "Mal Capturado";
            this.MalCapturado.MinimumWidth = 8;
            this.MalCapturado.Name = "MalCapturado";
            this.MalCapturado.Visible = false;
            this.MalCapturado.Width = 150;
            // 
            // ActaNotificacion
            // 
            this.ActaNotificacion.DataPropertyName = "ActaNotificacion";
            this.ActaNotificacion.HeaderText = "ActaNotificacion";
            this.ActaNotificacion.MinimumWidth = 8;
            this.ActaNotificacion.Name = "ActaNotificacion";
            this.ActaNotificacion.Width = 150;
            // 
            // ActaCitatorio
            // 
            this.ActaCitatorio.DataPropertyName = "ActaCitatorio";
            this.ActaCitatorio.HeaderText = "ActaCitatorio";
            this.ActaCitatorio.MinimumWidth = 8;
            this.ActaCitatorio.Name = "ActaCitatorio";
            this.ActaCitatorio.Width = 150;
            // 
            // NotificacionCitatorio
            // 
            this.NotificacionCitatorio.DataPropertyName = "NotificacionCitatorio";
            this.NotificacionCitatorio.HeaderText = "NotificacionCitatorio";
            this.NotificacionCitatorio.MinimumWidth = 8;
            this.NotificacionCitatorio.Name = "NotificacionCitatorio";
            this.NotificacionCitatorio.Width = 150;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.DataSource = this.cListaCatObservacionesBindingSource;
            this.Observaciones.DisplayMember = "ConatenadoObservacion";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MinimumWidth = 8;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Observaciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Observaciones.Width = 150;
            // 
            // cListaCatObservacionesBindingSource
            // 
            this.cListaCatObservacionesBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CListaCatObservaciones);
            // 
            // NotasObservaciones
            // 
            this.NotasObservaciones.DataPropertyName = "NotasObservaciones";
            this.NotasObservaciones.HeaderText = "NotasObservaciones";
            this.NotasObservaciones.MinimumWidth = 8;
            this.NotasObservaciones.Name = "NotasObservaciones";
            this.NotasObservaciones.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Modificado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Modificado";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "ModificaObservacion";
            this.dataGridViewCheckBoxColumn2.HeaderText = "ModificaObservacion";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Visible = false;
            this.dataGridViewCheckBoxColumn2.Width = 150;
            // 
            // cNombreBimestreBOBindingSource
            // 
            this.cNombreBimestreBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CNombreBimestreBO);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 508);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.30202F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.697987F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 474);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbCarga,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1924, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pbCarga
            // 
            this.pbCarga.Name = "pbCarga";
            this.pbCarga.Size = new System.Drawing.Size(150, 14);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 15);
            this.lblStatus.TextChanged += new System.EventHandler(this.lblStatus_TextChanged);
            // 
            // listCoheActivaBindingSource
            // 
            this.listCoheActivaBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.ListCoheActiva);
            // 
            // cEmisionActualBOBindingSource
            // 
            this.cEmisionActualBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CEmisionActualBO);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 982);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Captura requerimientos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelDatosLocalizacion.ResumeLayout(false);
            this.PanelDatosLocalizacion.PerformLayout();
            this.PanelEmisionRequerimientos.ResumeLayout(false);
            this.SelectEmision.ResumeLayout(false);
            this.SelectEmision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canhoFiscalBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCEmisionActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coheActivaBOBindingSource)).EndInit();
            this.GroupDatosContribuyente.ResumeLayout(false);
            this.LayParticulares.ResumeLayout(false);
            this.LayParticulares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cListaRequeridosBOBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgReqActivos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListaCatObservacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNombreBimestreBOBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCoheActivaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEmisionActualBOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource canhoFiscalBOBindingSource;
        private System.Windows.Forms.BindingSource cEmisionActualBOBindingSource;
        private System.Windows.Forms.BindingSource listCEmisionActualBindingSource;
        private System.Windows.Forms.BindingSource listCoheActivaBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource coheActivaBOBindingSource;
        private System.Windows.Forms.BindingSource cNombreBimestreBOBindingSource;
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripButton btnBusquedaMasiva;
        private System.Windows.Forms.DataGridView DgReqActivos2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton guardarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.BindingSource cListaRequeridosBOBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblListo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pbCarga;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel PanelDatosLocalizacion;
        private System.Windows.Forms.TableLayoutPanel PanelEmisionRequerimientos;
        private System.Windows.Forms.GroupBox SelectEmision;
        private System.Windows.Forms.ComboBox cmbAnho;
        private System.Windows.Forms.Label FechaImpresion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox CmbEmision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmision;
        private System.Windows.Forms.ComboBox cmbOHE;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox GroupDatosContribuyente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblZonaName;
        private System.Windows.Forms.TableLayoutPanel LayParticulares;
        private System.Windows.Forms.Label tituloRS;
        private System.Windows.Forms.Label DatoRS;
        private System.Windows.Forms.Label tituloNCTRL;
        private System.Windows.Forms.Label DatoCTRL;
        private System.Windows.Forms.Label tituloEstatus;
        private System.Windows.Forms.Label DatoEstatus;
        private System.Windows.Forms.Label tituloObservacion;
        private System.Windows.Forms.Label DatoObservaciones;
        private System.Windows.Forms.Label tituloDescripcionObservacion;
        private System.Windows.Forms.Label DatoDescripcion;
        private System.Windows.Forms.BindingSource cListaCatObservacionesBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Diligencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCitatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNotificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEnvioSefiplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreNotificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MalCapturado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActaNotificacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActaCitatorio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NotificacionCitatorio;
        private System.Windows.Forms.DataGridViewComboBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotasObservaciones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}