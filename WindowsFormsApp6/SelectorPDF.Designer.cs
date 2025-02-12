namespace WindowsFormsApp6
{
    partial class PDFTipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFTipo));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BoxGeneralesRequerimientos = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.lblCitatorio = new System.Windows.Forms.Label();
            this.lblURI = new System.Windows.Forms.Label();
            this.lblRs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiligencia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSAT = new System.Windows.Forms.Label();
            this.lblNumREQ = new System.Windows.Forms.Label();
            this.SelectorTipo = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.cbDocumento = new System.Windows.Forms.ComboBox();
            this.ContainerPDF = new System.Windows.Forms.GroupBox();
            this.LayObservaciones = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.BoxGeneralesRequerimientos.SuspendLayout();
            this.SelectorTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.ContainerPDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayObservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ContainerPDF);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.BoxGeneralesRequerimientos);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.SelectorTipo);
            this.splitContainer2.Size = new System.Drawing.Size(305, 450);
            this.splitContainer2.SplitterDistance = 214;
            this.splitContainer2.TabIndex = 0;
            // 
            // BoxGeneralesRequerimientos
            // 
            this.BoxGeneralesRequerimientos.Controls.Add(this.label7);
            this.BoxGeneralesRequerimientos.Controls.Add(this.label6);
            this.BoxGeneralesRequerimientos.Controls.Add(this.lblNotificacion);
            this.BoxGeneralesRequerimientos.Controls.Add(this.lblCitatorio);
            this.BoxGeneralesRequerimientos.Controls.Add(this.lblURI);
            this.BoxGeneralesRequerimientos.Controls.Add(this.lblRs);
            this.BoxGeneralesRequerimientos.Controls.Add(this.label5);
            this.BoxGeneralesRequerimientos.Controls.Add(this.label2);
            this.BoxGeneralesRequerimientos.Controls.Add(this.label1);
            this.BoxGeneralesRequerimientos.Controls.Add(this.lblDiligencia);
            this.BoxGeneralesRequerimientos.Controls.Add(this.label3);
            this.BoxGeneralesRequerimientos.Controls.Add(this.lblRFC);
            this.BoxGeneralesRequerimientos.Controls.Add(this.label4);
            this.BoxGeneralesRequerimientos.Controls.Add(this.lblSAT);
            this.BoxGeneralesRequerimientos.Controls.Add(this.lblNumREQ);
            this.BoxGeneralesRequerimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxGeneralesRequerimientos.Location = new System.Drawing.Point(0, 0);
            this.BoxGeneralesRequerimientos.Name = "BoxGeneralesRequerimientos";
            this.BoxGeneralesRequerimientos.Size = new System.Drawing.Size(305, 214);
            this.BoxGeneralesRequerimientos.TabIndex = 25;
            this.BoxGeneralesRequerimientos.TabStop = false;
            this.BoxGeneralesRequerimientos.Text = "Generales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Notificación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Citatorio:";
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.AutoSize = true;
            this.lblNotificacion.Location = new System.Drawing.Point(82, 147);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Size = new System.Drawing.Size(78, 13);
            this.lblNotificacion.TabIndex = 34;
            this.lblNotificacion.Text = "F. Notificación:";
            // 
            // lblCitatorio
            // 
            this.lblCitatorio.AutoSize = true;
            this.lblCitatorio.Location = new System.Drawing.Point(82, 123);
            this.lblCitatorio.Name = "lblCitatorio";
            this.lblCitatorio.Size = new System.Drawing.Size(60, 13);
            this.lblCitatorio.TabIndex = 33;
            this.lblCitatorio.Text = "F. Citatorio:";
            // 
            // lblURI
            // 
            this.lblURI.AutoSize = true;
            this.lblURI.Location = new System.Drawing.Point(10, 184);
            this.lblURI.Name = "lblURI";
            this.lblURI.Size = new System.Drawing.Size(35, 13);
            this.lblURI.TabIndex = 14;
            this.lblURI.Text = "label5";
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Location = new System.Drawing.Point(82, 77);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(0, 13);
            this.lblRs.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Razón social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "RFC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "IdSAT:";
            // 
            // lblDiligencia
            // 
            this.lblDiligencia.AutoSize = true;
            this.lblDiligencia.Location = new System.Drawing.Point(82, 100);
            this.lblDiligencia.Name = "lblDiligencia";
            this.lblDiligencia.Size = new System.Drawing.Size(0, 13);
            this.lblDiligencia.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, -29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Número REQ:";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(82, 50);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(0, 13);
            this.lblRFC.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Diligencia:";
            // 
            // lblSAT
            // 
            this.lblSAT.AutoSize = true;
            this.lblSAT.Location = new System.Drawing.Point(82, 23);
            this.lblSAT.Name = "lblSAT";
            this.lblSAT.Size = new System.Drawing.Size(0, 13);
            this.lblSAT.TabIndex = 28;
            // 
            // lblNumREQ
            // 
            this.lblNumREQ.AutoSize = true;
            this.lblNumREQ.Location = new System.Drawing.Point(101, -29);
            this.lblNumREQ.Name = "lblNumREQ";
            this.lblNumREQ.Size = new System.Drawing.Size(0, 13);
            this.lblNumREQ.TabIndex = 27;
            // 
            // SelectorTipo
            // 
            this.SelectorTipo.Controls.Add(this.splitContainer3);
            this.SelectorTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectorTipo.Location = new System.Drawing.Point(0, 0);
            this.SelectorTipo.Name = "SelectorTipo";
            this.SelectorTipo.Size = new System.Drawing.Size(305, 232);
            this.SelectorTipo.TabIndex = 0;
            this.SelectorTipo.TabStop = false;
            this.SelectorTipo.Text = "Tipo documento";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 16);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.cbDocumento);
            this.splitContainer3.Size = new System.Drawing.Size(299, 213);
            this.splitContainer3.SplitterDistance = 106;
            this.splitContainer3.TabIndex = 1;
            // 
            // cbDocumento
            // 
            this.cbDocumento.FormattingEnabled = true;
            this.cbDocumento.Location = new System.Drawing.Point(45, 39);
            this.cbDocumento.Name = "cbDocumento";
            this.cbDocumento.Size = new System.Drawing.Size(192, 21);
            this.cbDocumento.TabIndex = 0;
            this.cbDocumento.SelectedIndexChanged += new System.EventHandler(this.cbDocumento_SelectedIndexChanged);
            // 
            // ContainerPDF
            // 
            this.ContainerPDF.Controls.Add(this.LayObservaciones);
            this.ContainerPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPDF.Location = new System.Drawing.Point(0, 0);
            this.ContainerPDF.Name = "ContainerPDF";
            this.ContainerPDF.Size = new System.Drawing.Size(491, 450);
            this.ContainerPDF.TabIndex = 0;
            this.ContainerPDF.TabStop = false;
            this.ContainerPDF.Text = "Visor PDF";
            // 
            // LayObservaciones
            // 
            this.LayObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayObservaciones.Enabled = true;
            this.LayObservaciones.Location = new System.Drawing.Point(3, 16);
            this.LayObservaciones.Name = "LayObservaciones";
            this.LayObservaciones.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("LayObservaciones.OcxState")));
            this.LayObservaciones.Size = new System.Drawing.Size(485, 431);
            this.LayObservaciones.TabIndex = 3;
            // 
            // PDFTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PDFTipo";
            this.Text = "SelectorPDF";
            this.Load += new System.EventHandler(this.PDFTipo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.BoxGeneralesRequerimientos.ResumeLayout(false);
            this.BoxGeneralesRequerimientos.PerformLayout();
            this.SelectorTipo.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ContainerPDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LayObservaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox ContainerPDF;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox BoxGeneralesRequerimientos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNotificacion;
        private System.Windows.Forms.Label lblCitatorio;
        private System.Windows.Forms.Label lblURI;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiligencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSAT;
        private System.Windows.Forms.Label lblNumREQ;
        private System.Windows.Forms.GroupBox SelectorTipo;
        private AxAcroPDFLib.AxAcroPDF LayObservaciones;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ComboBox cbDocumento;
    }
}