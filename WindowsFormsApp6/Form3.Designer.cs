namespace WindowsFormsApp6
{
    partial class Form3
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
            System.Windows.Forms.Label anhoLabel;
            System.Windows.Forms.Label oHELabel;
            System.Windows.Forms.Label periodoLabel;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CListaRequeridosBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListadoRIFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetRIF = new WindowsFormsApp6.DataSetRIF();
            this.canhoFiscalBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombreBimestre = new System.Windows.Forms.Label();
            this.listaCNombreBimestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblZonaName = new System.Windows.Forms.Label();
            this.cmbEmision = new System.Windows.Forms.ComboBox();
            this.cEmisionActualBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbAnho = new System.Windows.Forms.ComboBox();
            this.cmbOHE = new System.Windows.Forms.ComboBox();
            this.listCoheActivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            anhoLabel = new System.Windows.Forms.Label();
            oHELabel = new System.Windows.Forms.Label();
            periodoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CListaRequeridosBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoRIFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canhoFiscalBOBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCNombreBimestreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEmisionActualBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCoheActivaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // anhoLabel
            // 
            anhoLabel.AutoSize = true;
            anhoLabel.Location = new System.Drawing.Point(49, 57);
            anhoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            anhoLabel.Name = "anhoLabel";
            anhoLabel.Size = new System.Drawing.Size(101, 13);
            anhoLabel.TabIndex = 0;
            anhoLabel.Text = "EJERCICO FISCAL:";
            // 
            // oHELabel
            // 
            oHELabel.AutoSize = true;
            oHELabel.Location = new System.Drawing.Point(439, 59);
            oHELabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            oHELabel.Name = "oHELabel";
            oHELabel.Size = new System.Drawing.Size(33, 13);
            oHELabel.TabIndex = 4;
            oHELabel.Text = "OHE:";
            // 
            // periodoLabel
            // 
            periodoLabel.AutoSize = true;
            periodoLabel.Location = new System.Drawing.Point(263, 61);
            periodoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            periodoLabel.Name = "periodoLabel";
            periodoLabel.Size = new System.Drawing.Size(55, 13);
            periodoLabel.TabIndex = 6;
            periodoLabel.Text = "EMISION:";
            // 
            // CListaRequeridosBOBindingSource
            // 
            this.CListaRequeridosBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CListaRequeridosBO);
            // 
            // ListadoRIFBindingSource
            // 
            this.ListadoRIFBindingSource.DataMember = "ListadoRIF";
            this.ListadoRIFBindingSource.DataSource = this.DataSetRIF;
            // 
            // DataSetRIF
            // 
            this.DataSetRIF.DataSetName = "DataSetRIF";
            this.DataSetRIF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // canhoFiscalBOBindingSource
            // 
            this.canhoFiscalBOBindingSource.DataSource = typeof(WindowsFormsApp6.BO.CanhoFiscalBO);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CListaRequeridosBO";
            reportDataSource1.Value = this.CListaRequeridosBOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp6.ReporteRIF.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 110);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(913, 182);
            this.reportViewer1.TabIndex = 0;
            
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombreBimestre);
            this.groupBox1.Controls.Add(this.lblZonaName);
            this.groupBox1.Controls.Add(this.cmbEmision);
            this.groupBox1.Controls.Add(periodoLabel);
            this.groupBox1.Controls.Add(this.cmbAnho);
            this.groupBox1.Controls.Add(oHELabel);
            this.groupBox1.Controls.Add(this.cmbOHE);
            this.groupBox1.Controls.Add(anhoLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(913, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblNombreBimestre
            // 
            this.lblNombreBimestre.AutoSize = true;
            this.lblNombreBimestre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCNombreBimestreBindingSource, "OHE", true));
            this.lblNombreBimestre.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.listaCNombreBimestreBindingSource, "OHE", true));
            this.lblNombreBimestre.Location = new System.Drawing.Point(8, 96);
            this.lblNombreBimestre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreBimestre.Name = "lblNombreBimestre";
            this.lblNombreBimestre.Size = new System.Drawing.Size(35, 13);
            this.lblNombreBimestre.TabIndex = 9;
            this.lblNombreBimestre.Text = "label1";
            // 
            // listaCNombreBimestreBindingSource
            // 
            this.listaCNombreBimestreBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CNombreBimestreBO);
            // 
            // lblZonaName
            // 
            this.lblZonaName.AutoSize = true;
            this.lblZonaName.Location = new System.Drawing.Point(28, 23);
            this.lblZonaName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZonaName.Name = "lblZonaName";
            this.lblZonaName.Size = new System.Drawing.Size(0, 13);
            this.lblZonaName.TabIndex = 8;
            // 
            // cmbEmision
            // 
            this.cmbEmision.DataSource = this.cEmisionActualBOBindingSource;
            this.cmbEmision.DisplayMember = "Periodo";
            this.cmbEmision.FormattingEnabled = true;
            this.cmbEmision.Location = new System.Drawing.Point(321, 57);
            this.cmbEmision.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmision.Name = "cmbEmision";
            this.cmbEmision.Size = new System.Drawing.Size(82, 21);
            this.cmbEmision.TabIndex = 7;
            this.cmbEmision.Leave += new System.EventHandler(this.cmbEmision_Leave);
            // 
            // cEmisionActualBOBindingSource
            // 
            this.cEmisionActualBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CEmisionActualBO);
            // 
            // cmbAnho
            // 
            this.cmbAnho.DataSource = this.canhoFiscalBOBindingSource;
            this.cmbAnho.DisplayMember = "Anho";
            this.cmbAnho.FormattingEnabled = true;
            this.cmbAnho.Location = new System.Drawing.Point(156, 55);
            this.cmbAnho.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAnho.Name = "cmbAnho";
            this.cmbAnho.Size = new System.Drawing.Size(82, 21);
            this.cmbAnho.TabIndex = 6;
            this.cmbAnho.ValueMember = "Anho";
            this.cmbAnho.Leave += new System.EventHandler(this.cmbAnho_Leave);
            // 
            // cmbOHE
            // 
            this.cmbOHE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listCoheActivaBindingSource, "OHE", true));
            this.cmbOHE.DataSource = this.listCoheActivaBindingSource;
            this.cmbOHE.DisplayMember = "OHE";
            this.cmbOHE.FormattingEnabled = true;
            this.cmbOHE.Location = new System.Drawing.Point(475, 57);
            this.cmbOHE.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOHE.Name = "cmbOHE";
            this.cmbOHE.Size = new System.Drawing.Size(217, 21);
            this.cmbOHE.TabIndex = 5;
            this.cmbOHE.Leave += new System.EventHandler(this.cmbOHE_Leave);
            // 
            // listCoheActivaBindingSource
            // 
            this.listCoheActivaBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CoheActivaBO);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 292);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CListaRequeridosBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoRIFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canhoFiscalBOBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCNombreBimestreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEmisionActualBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCoheActivaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CListaRequeridosBOBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource canhoFiscalBOBindingSource;
        private System.Windows.Forms.ComboBox cmbOHE;
        private System.Windows.Forms.BindingSource listCoheActivaBindingSource;
        private System.Windows.Forms.BindingSource cEmisionActualBOBindingSource;
        private System.Windows.Forms.ComboBox cmbAnho;
        private System.Windows.Forms.ComboBox cmbEmision;
        private System.Windows.Forms.Label lblZonaName;
        private System.Windows.Forms.BindingSource listaCNombreBimestreBindingSource;
        private System.Windows.Forms.Label lblNombreBimestre;
        private System.Windows.Forms.BindingSource ListadoRIFBindingSource;
        private DataSetRIF DataSetRIF;
    }
}