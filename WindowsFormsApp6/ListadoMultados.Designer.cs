
namespace WindowsFormsApp6
{
    partial class ListadoMultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoMultados));
            this.tsProgreso = new System.Windows.Forms.StatusStrip();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.tsFiltrar = new System.Windows.Forms.ToolStripButton();
            this.tsBusquedaMasiva = new System.Windows.Forms.ToolStripButton();
            this.dgMultados = new System.Windows.Forms.DataGridView();
            this.idMultaRif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridzona = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridOHE = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridTMulta = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridnumMulta = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridRFC = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridTipoC = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridnumCtrlReq = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridrs = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DataGridDetalleEmi = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridNumReq = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridDiligenicia = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridFC = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridFN = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridFP = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridimporte = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridhonorarios = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridfechaVencimiento = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridobservaciones = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridejecucion = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridestatus = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DataGridestatusPDF = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.cListaRequeridosBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tsProgreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListaRequeridosBOBindingSource)).BeginInit();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsProgreso
            // 
            this.tsProgreso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgress,
            this.FilterStatusLabel,
            this.ShowAllLabel});
            this.tsProgreso.Location = new System.Drawing.Point(0, 428);
            this.tsProgreso.Name = "tsProgreso";
            this.tsProgreso.Size = new System.Drawing.Size(1414, 22);
            this.tsProgreso.TabIndex = 0;
            this.tsProgreso.Text = "statusStrip1";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // FilterStatusLabel
            // 
            this.FilterStatusLabel.Name = "FilterStatusLabel";
            this.FilterStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.FilterStatusLabel.Visible = false;
            // 
            // ShowAllLabel
            // 
            this.ShowAllLabel.IsLink = true;
            this.ShowAllLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ShowAllLabel.Name = "ShowAllLabel";
            this.ShowAllLabel.Size = new System.Drawing.Size(53, 17);
            this.ShowAllLabel.Text = "Show &All";
            this.ShowAllLabel.Click += new System.EventHandler(this.showAllLabel_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgMultados);
            this.splitContainer1.Size = new System.Drawing.Size(1414, 428);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsBusqueda,
            this.tsFiltrar,
            this.tsBusquedaMasiva});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1414, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel1.Text = "Buscar: ";
            // 
            // tsBusqueda
            // 
            this.tsBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsBusqueda.Name = "tsBusqueda";
            this.tsBusqueda.Size = new System.Drawing.Size(300, 25);
            this.tsBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsBusqueda_KeyDown);
            // 
            // tsFiltrar
            // 
            this.tsFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("tsFiltrar.Image")));
            this.tsFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFiltrar.Name = "tsFiltrar";
            this.tsFiltrar.Size = new System.Drawing.Size(41, 22);
            this.tsFiltrar.Text = "Filtrar";
            this.tsFiltrar.Click += new System.EventHandler(this.tsFiltrar_Click);
            // 
            // tsBusquedaMasiva
            // 
            this.tsBusquedaMasiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBusquedaMasiva.Image = ((System.Drawing.Image)(resources.GetObject("tsBusquedaMasiva.Image")));
            this.tsBusquedaMasiva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBusquedaMasiva.Name = "tsBusquedaMasiva";
            this.tsBusquedaMasiva.Size = new System.Drawing.Size(103, 22);
            this.tsBusquedaMasiva.Text = "Busqueda masiva";
            this.tsBusquedaMasiva.Click += new System.EventHandler(this.tsBusquedaMasiva_Click);
            // 
            // dgMultados
            // 
            this.dgMultados.AllowUserToAddRows = false;
            this.dgMultados.AllowUserToDeleteRows = false;
            this.dgMultados.AutoGenerateColumns = false;
            this.dgMultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMultaRif,
            this.DataGridzona,
            this.DataGridOHE,
            this.DataGridTMulta,
            this.DataGridnumMulta,
            this.DataGridRFC,
            this.DataGridTipoC,
            this.DataGridnumCtrlReq,
            this.DataGridrs,
            this.DataGridDetalleEmi,
            this.DataGridNumReq,
            this.DataGridDiligenicia,
            this.DataGridFC,
            this.DataGridFN,
            this.DataGridFP,
            this.DataGridimporte,
            this.DataGridhonorarios,
            this.DataGridfechaVencimiento,
            this.DataGridobservaciones,
            this.DataGridejecucion,
            this.DataGridestatus,
            this.DataGridestatusPDF});
            this.dgMultados.DataSource = this.cListaRequeridosBOBindingSource;
            this.dgMultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMultados.Location = new System.Drawing.Point(0, 0);
            this.dgMultados.Name = "dgMultados";
            this.dgMultados.ReadOnly = true;
            this.dgMultados.Size = new System.Drawing.Size(1414, 399);
            this.dgMultados.TabIndex = 0;
            this.dgMultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMultados_CellContentClick);
            this.dgMultados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgMultados_DataBindingComplete);
            // 
            // idMultaRif
            // 
            this.idMultaRif.DataPropertyName = "_idMultaRif";
            this.idMultaRif.HeaderText = "_idMultaRif";
            this.idMultaRif.Name = "idMultaRif";
            this.idMultaRif.ReadOnly = true;
            this.idMultaRif.Visible = false;
            // 
            // DataGridzona
            // 
            this.DataGridzona.DataPropertyName = "_zona";
            this.DataGridzona.FilteringEnabled = false;
            this.DataGridzona.HeaderText = "Zona";
            this.DataGridzona.Name = "DataGridzona";
            this.DataGridzona.ReadOnly = true;
            this.DataGridzona.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridOHE
            // 
            this.DataGridOHE.DataPropertyName = "_OHE";
            this.DataGridOHE.FilteringEnabled = false;
            this.DataGridOHE.HeaderText = "OHE";
            this.DataGridOHE.Name = "DataGridOHE";
            this.DataGridOHE.ReadOnly = true;
            this.DataGridOHE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridTMulta
            // 
            this.DataGridTMulta.DataPropertyName = "_tipoMulta";
            this.DataGridTMulta.FilteringEnabled = false;
            this.DataGridTMulta.HeaderText = "Tipo multa";
            this.DataGridTMulta.Name = "DataGridTMulta";
            this.DataGridTMulta.ReadOnly = true;
            this.DataGridTMulta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridnumMulta
            // 
            this.DataGridnumMulta.DataPropertyName = "_numMulta";
            this.DataGridnumMulta.FilteringEnabled = false;
            this.DataGridnumMulta.HeaderText = "Numero de multa";
            this.DataGridnumMulta.Name = "DataGridnumMulta";
            this.DataGridnumMulta.ReadOnly = true;
            this.DataGridnumMulta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridRFC
            // 
            this.DataGridRFC.DataPropertyName = "Rfc";
            this.DataGridRFC.FilteringEnabled = false;
            this.DataGridRFC.HeaderText = "RFC";
            this.DataGridRFC.Name = "DataGridRFC";
            this.DataGridRFC.ReadOnly = true;
            this.DataGridRFC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridTipoC
            // 
            this.DataGridTipoC.DataPropertyName = "_tipoc";
            this.DataGridTipoC.FilteringEnabled = false;
            this.DataGridTipoC.HeaderText = "Tipo contribuyente";
            this.DataGridTipoC.Name = "DataGridTipoC";
            this.DataGridTipoC.ReadOnly = true;
            this.DataGridTipoC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridnumCtrlReq
            // 
            this.DataGridnumCtrlReq.DataPropertyName = "NumCtrl";
            this.DataGridnumCtrlReq.FilteringEnabled = false;
            this.DataGridnumCtrlReq.HeaderText = "Numero de control";
            this.DataGridnumCtrlReq.Name = "DataGridnumCtrlReq";
            this.DataGridnumCtrlReq.ReadOnly = true;
            this.DataGridnumCtrlReq.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridrs
            // 
            this.DataGridrs.DataPropertyName = "RazonSocial";
            this.DataGridrs.HeaderText = "Razon Social";
            this.DataGridrs.Name = "DataGridrs";
            this.DataGridrs.ReadOnly = true;
            this.DataGridrs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridrs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DataGridDetalleEmi
            // 
            this.DataGridDetalleEmi.DataPropertyName = "_detalleEmision";
            this.DataGridDetalleEmi.FilteringEnabled = false;
            this.DataGridDetalleEmi.HeaderText = "Detalle Requerimiento";
            this.DataGridDetalleEmi.Name = "DataGridDetalleEmi";
            this.DataGridDetalleEmi.ReadOnly = true;
            this.DataGridDetalleEmi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridNumReq
            // 
            this.DataGridNumReq.DataPropertyName = "NumReq";
            this.DataGridNumReq.FilteringEnabled = false;
            this.DataGridNumReq.HeaderText = "Numero de requerimiento";
            this.DataGridNumReq.Name = "DataGridNumReq";
            this.DataGridNumReq.ReadOnly = true;
            this.DataGridNumReq.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridDiligenicia
            // 
            this.DataGridDiligenicia.DataPropertyName = "Diligencia";
            this.DataGridDiligenicia.FilteringEnabled = false;
            this.DataGridDiligenicia.HeaderText = "Diligencia";
            this.DataGridDiligenicia.Name = "DataGridDiligenicia";
            this.DataGridDiligenicia.ReadOnly = true;
            this.DataGridDiligenicia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridFC
            // 
            this.DataGridFC.DataPropertyName = "FechaCitatorio";
            this.DataGridFC.FilteringEnabled = false;
            this.DataGridFC.HeaderText = "Fecha de citatorio";
            this.DataGridFC.Name = "DataGridFC";
            this.DataGridFC.ReadOnly = true;
            this.DataGridFC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridFN
            // 
            this.DataGridFN.DataPropertyName = "FechaNotificacion";
            this.DataGridFN.FilteringEnabled = false;
            this.DataGridFN.HeaderText = "Fecha de notificacion";
            this.DataGridFN.Name = "DataGridFN";
            this.DataGridFN.ReadOnly = true;
            this.DataGridFN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridFP
            // 
            this.DataGridFP.DataPropertyName = "FechaPago";
            this.DataGridFP.FilteringEnabled = false;
            this.DataGridFP.HeaderText = "Fecha de pago";
            this.DataGridFP.Name = "DataGridFP";
            this.DataGridFP.ReadOnly = true;
            this.DataGridFP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridimporte
            // 
            this.DataGridimporte.DataPropertyName = "Importe";
            this.DataGridimporte.FilteringEnabled = false;
            this.DataGridimporte.HeaderText = "Importe";
            this.DataGridimporte.Name = "DataGridimporte";
            this.DataGridimporte.ReadOnly = true;
            this.DataGridimporte.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridhonorarios
            // 
            this.DataGridhonorarios.DataPropertyName = "Honorarios";
            this.DataGridhonorarios.FilteringEnabled = false;
            this.DataGridhonorarios.HeaderText = "Honorarios";
            this.DataGridhonorarios.Name = "DataGridhonorarios";
            this.DataGridhonorarios.ReadOnly = true;
            this.DataGridhonorarios.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridfechaVencimiento
            // 
            this.DataGridfechaVencimiento.DataPropertyName = "_fechaVencimiento";
            this.DataGridfechaVencimiento.FilteringEnabled = false;
            this.DataGridfechaVencimiento.HeaderText = "Fechade vencimiento";
            this.DataGridfechaVencimiento.Name = "DataGridfechaVencimiento";
            this.DataGridfechaVencimiento.ReadOnly = true;
            this.DataGridfechaVencimiento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridobservaciones
            // 
            this.DataGridobservaciones.DataPropertyName = "Observaciones";
            this.DataGridobservaciones.FilteringEnabled = false;
            this.DataGridobservaciones.HeaderText = "Observaciones";
            this.DataGridobservaciones.Name = "DataGridobservaciones";
            this.DataGridobservaciones.ReadOnly = true;
            this.DataGridobservaciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridejecucion
            // 
            this.DataGridejecucion.DataPropertyName = "Ejecucion";
            this.DataGridejecucion.FilteringEnabled = false;
            this.DataGridejecucion.HeaderText = "Ejecucion";
            this.DataGridejecucion.Name = "DataGridejecucion";
            this.DataGridejecucion.ReadOnly = true;
            this.DataGridejecucion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridestatus
            // 
            this.DataGridestatus.DataPropertyName = "Estatus";
            this.DataGridestatus.FilteringEnabled = false;
            this.DataGridestatus.HeaderText = "Estatus";
            this.DataGridestatus.Name = "DataGridestatus";
            this.DataGridestatus.ReadOnly = true;
            this.DataGridestatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridestatusPDF
            // 
            this.DataGridestatusPDF.DataPropertyName = "_estatusPDF";
            this.DataGridestatusPDF.FilteringEnabled = false;
            this.DataGridestatusPDF.HeaderText = "Estatus PDF";
            this.DataGridestatusPDF.Name = "DataGridestatusPDF";
            this.DataGridestatusPDF.ReadOnly = true;
            this.DataGridestatusPDF.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cListaRequeridosBOBindingSource
            // 
            this.cListaRequeridosBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CListaRequeridosBO);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1414, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1414, 450);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // ListadoMultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tsProgreso);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "ListadoMultados";
            this.Text = "ListadoMultados";
            this.tsProgreso.ResumeLayout(false);
            this.tsProgreso.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListaRequeridosBOBindingSource)).EndInit();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip tsProgreso;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgMultados;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.ToolStripStatusLabel ShowAllLabel;
        private System.Windows.Forms.ToolStripStatusLabel FilterStatusLabel;
        private System.Windows.Forms.BindingSource cListaRequeridosBOBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tsBusqueda;
        private System.Windows.Forms.ToolStripButton tsFiltrar;
        private System.Windows.Forms.ToolStripButton tsBusquedaMasiva;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMultaRif;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridzona;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridOHE;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridTMulta;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridnumMulta;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridRFC;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridTipoC;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridnumCtrlReq;
        private System.Windows.Forms.DataGridViewLinkColumn DataGridrs;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridDetalleEmi;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridNumReq;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridDiligenicia;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridFC;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridFN;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridFP;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridimporte;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridhonorarios;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridfechaVencimiento;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridobservaciones;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridejecucion;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridestatus;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DataGridestatusPDF;
    }
}