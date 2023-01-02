namespace WindowsFormsApp6
{
    partial class pdfGestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pdfGestor));
            this.LayObservaciones = new AxAcroPDFLib.AxAcroPDF();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblURI = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PanelDeDatos = new System.Windows.Forms.TableLayoutPanel();
            this.BoxGeneralesRequerimientos = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.lblCitatorio = new System.Windows.Forms.Label();
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
            this.BoxObservaciones = new System.Windows.Forms.GroupBox();
            this.panelDescripcionObservaciones = new System.Windows.Forms.TableLayoutPanel();
            this.BoxIndetificarPorblema = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.rbCitatorio = new System.Windows.Forms.RadioButton();
            this.rbAmbos = new System.Windows.Forms.RadioButton();
            this.rbNotificacion = new System.Windows.Forms.RadioButton();
            this.cmbObservacion = new System.Windows.Forms.ComboBox();
            this.boxNotas = new System.Windows.Forms.GroupBox();
            this.textNotas = new System.Windows.Forms.RichTextBox();
            this.boxAcciones = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SplitControlesObservaciones = new System.Windows.Forms.SplitContainer();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.LayObservaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PanelDeDatos.SuspendLayout();
            this.BoxGeneralesRequerimientos.SuspendLayout();
            this.BoxObservaciones.SuspendLayout();
            this.panelDescripcionObservaciones.SuspendLayout();
            this.BoxIndetificarPorblema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.boxNotas.SuspendLayout();
            this.boxAcciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitControlesObservaciones)).BeginInit();
            this.SplitControlesObservaciones.Panel1.SuspendLayout();
            this.SplitControlesObservaciones.Panel2.SuspendLayout();
            this.SplitControlesObservaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayObservaciones
            // 
            this.LayObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayObservaciones.Enabled = true;
            this.LayObservaciones.Location = new System.Drawing.Point(3, 16);
            this.LayObservaciones.Name = "LayObservaciones";
            this.LayObservaciones.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("LayObservaciones.OcxState")));
            this.LayObservaciones.Size = new System.Drawing.Size(797, 663);
            this.LayObservaciones.TabIndex = 2;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(37, 35);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(149, 35);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(266, 35);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos PDF(*.pdf)|*.pdf";
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
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos PDF(*.pdf)|*.pdf";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PanelDeDatos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 682);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos requerimiento";
            // 
            // PanelDeDatos
            // 
            this.PanelDeDatos.ColumnCount = 1;
            this.PanelDeDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDeDatos.Controls.Add(this.BoxGeneralesRequerimientos, 0, 0);
            this.PanelDeDatos.Controls.Add(this.BoxObservaciones, 0, 1);
            this.PanelDeDatos.Controls.Add(this.boxAcciones, 0, 2);
            this.PanelDeDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDeDatos.Location = new System.Drawing.Point(3, 16);
            this.PanelDeDatos.Name = "PanelDeDatos";
            this.PanelDeDatos.RowCount = 4;
            this.PanelDeDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDeDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDeDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.PanelDeDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PanelDeDatos.Size = new System.Drawing.Size(478, 663);
            this.PanelDeDatos.TabIndex = 23;
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
            this.BoxGeneralesRequerimientos.Location = new System.Drawing.Point(3, 3);
            this.BoxGeneralesRequerimientos.Name = "BoxGeneralesRequerimientos";
            this.BoxGeneralesRequerimientos.Size = new System.Drawing.Size(472, 266);
            this.BoxGeneralesRequerimientos.TabIndex = 24;
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
            // BoxObservaciones
            // 
            this.BoxObservaciones.Controls.Add(this.panelDescripcionObservaciones);
            this.BoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxObservaciones.Location = new System.Drawing.Point(3, 275);
            this.BoxObservaciones.Name = "BoxObservaciones";
            this.BoxObservaciones.Size = new System.Drawing.Size(472, 266);
            this.BoxObservaciones.TabIndex = 25;
            this.BoxObservaciones.TabStop = false;
            this.BoxObservaciones.Text = "Observaciones del requerimiento";
            // 
            // panelDescripcionObservaciones
            // 
            this.panelDescripcionObservaciones.ColumnCount = 1;
            this.panelDescripcionObservaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDescripcionObservaciones.Controls.Add(this.BoxIndetificarPorblema, 0, 0);
            this.panelDescripcionObservaciones.Controls.Add(this.boxNotas, 0, 1);
            this.panelDescripcionObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDescripcionObservaciones.Location = new System.Drawing.Point(3, 16);
            this.panelDescripcionObservaciones.Name = "panelDescripcionObservaciones";
            this.panelDescripcionObservaciones.RowCount = 2;
            this.panelDescripcionObservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.panelDescripcionObservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.panelDescripcionObservaciones.Size = new System.Drawing.Size(466, 247);
            this.panelDescripcionObservaciones.TabIndex = 0;
            // 
            // BoxIndetificarPorblema
            // 
            this.BoxIndetificarPorblema.Controls.Add(this.splitContainer2);
            this.BoxIndetificarPorblema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxIndetificarPorblema.Location = new System.Drawing.Point(3, 3);
            this.BoxIndetificarPorblema.Name = "BoxIndetificarPorblema";
            this.BoxIndetificarPorblema.Size = new System.Drawing.Size(460, 105);
            this.BoxIndetificarPorblema.TabIndex = 0;
            this.BoxIndetificarPorblema.TabStop = false;
            this.BoxIndetificarPorblema.Text = "Identificar las observaciones";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.rbCitatorio);
            this.splitContainer2.Panel1.Controls.Add(this.rbAmbos);
            this.splitContainer2.Panel1.Controls.Add(this.rbNotificacion);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.cmbObservacion);
            this.splitContainer2.Size = new System.Drawing.Size(454, 86);
            this.splitContainer2.SplitterDistance = 151;
            this.splitContainer2.TabIndex = 4;
            // 
            // rbCitatorio
            // 
            this.rbCitatorio.AutoSize = true;
            this.rbCitatorio.Location = new System.Drawing.Point(22, 41);
            this.rbCitatorio.Name = "rbCitatorio";
            this.rbCitatorio.Size = new System.Drawing.Size(63, 17);
            this.rbCitatorio.TabIndex = 1;
            this.rbCitatorio.Text = "Citatorio";
            this.rbCitatorio.UseVisualStyleBackColor = true;
            // 
            // rbAmbos
            // 
            this.rbAmbos.AutoSize = true;
            this.rbAmbos.Location = new System.Drawing.Point(22, 64);
            this.rbAmbos.Name = "rbAmbos";
            this.rbAmbos.Size = new System.Drawing.Size(57, 17);
            this.rbAmbos.TabIndex = 2;
            this.rbAmbos.Text = "Ambos";
            this.rbAmbos.UseVisualStyleBackColor = true;
            // 
            // rbNotificacion
            // 
            this.rbNotificacion.AutoSize = true;
            this.rbNotificacion.Checked = true;
            this.rbNotificacion.Location = new System.Drawing.Point(22, 18);
            this.rbNotificacion.Name = "rbNotificacion";
            this.rbNotificacion.Size = new System.Drawing.Size(119, 17);
            this.rbNotificacion.TabIndex = 0;
            this.rbNotificacion.TabStop = true;
            this.rbNotificacion.Text = "Acta de notificación";
            this.rbNotificacion.UseVisualStyleBackColor = true;
            // 
            // cmbObservacion
            // 
            this.cmbObservacion.FormattingEnabled = true;
            this.cmbObservacion.Location = new System.Drawing.Point(3, 18);
            this.cmbObservacion.Name = "cmbObservacion";
            this.cmbObservacion.Size = new System.Drawing.Size(293, 21);
            this.cmbObservacion.TabIndex = 3;
            // 
            // boxNotas
            // 
            this.boxNotas.Controls.Add(this.textNotas);
            this.boxNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxNotas.Location = new System.Drawing.Point(3, 114);
            this.boxNotas.Name = "boxNotas";
            this.boxNotas.Size = new System.Drawing.Size(460, 130);
            this.boxNotas.TabIndex = 1;
            this.boxNotas.TabStop = false;
            this.boxNotas.Text = "Notas de observaciones";
            // 
            // textNotas
            // 
            this.textNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNotas.Location = new System.Drawing.Point(3, 16);
            this.textNotas.Name = "textNotas";
            this.textNotas.Size = new System.Drawing.Size(454, 111);
            this.textNotas.TabIndex = 0;
            this.textNotas.Text = "";
            // 
            // boxAcciones
            // 
            this.boxAcciones.Controls.Add(this.btnAbrir);
            this.boxAcciones.Controls.Add(this.lblStatus);
            this.boxAcciones.Controls.Add(this.btnGuardar);
            this.boxAcciones.Controls.Add(this.btnEliminar);
            this.boxAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxAcciones.Location = new System.Drawing.Point(3, 547);
            this.boxAcciones.Name = "boxAcciones";
            this.boxAcciones.Size = new System.Drawing.Size(472, 83);
            this.boxAcciones.TabIndex = 26;
            this.boxAcciones.TabStop = false;
            this.boxAcciones.Text = "Acciones";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(38, 66);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LayObservaciones);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 682);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // SplitControlesObservaciones
            // 
            this.SplitControlesObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitControlesObservaciones.Location = new System.Drawing.Point(0, 0);
            this.SplitControlesObservaciones.Name = "SplitControlesObservaciones";
            // 
            // SplitControlesObservaciones.Panel1
            // 
            this.SplitControlesObservaciones.Panel1.Controls.Add(this.groupBox1);
            // 
            // SplitControlesObservaciones.Panel2
            // 
            this.SplitControlesObservaciones.Panel2.Controls.Add(this.groupBox2);
            this.SplitControlesObservaciones.Size = new System.Drawing.Size(1291, 682);
            this.SplitControlesObservaciones.SplitterDistance = 484;
            this.SplitControlesObservaciones.TabIndex = 17;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // pdfGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 682);
            this.Controls.Add(this.SplitControlesObservaciones);
            this.Name = "pdfGestor";
            this.Text = "pdfGestor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pdfGestor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.LayObservaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.PanelDeDatos.ResumeLayout(false);
            this.BoxGeneralesRequerimientos.ResumeLayout(false);
            this.BoxGeneralesRequerimientos.PerformLayout();
            this.BoxObservaciones.ResumeLayout(false);
            this.panelDescripcionObservaciones.ResumeLayout(false);
            this.BoxIndetificarPorblema.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.boxNotas.ResumeLayout(false);
            this.boxAcciones.ResumeLayout(false);
            this.boxAcciones.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.SplitControlesObservaciones.Panel1.ResumeLayout(false);
            this.SplitControlesObservaciones.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitControlesObservaciones)).EndInit();
            this.SplitControlesObservaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AxAcroPDFLib.AxAcroPDF LayObservaciones;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblURI;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer SplitControlesObservaciones;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TableLayoutPanel PanelDeDatos;
        private System.Windows.Forms.GroupBox BoxGeneralesRequerimientos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNotificacion;
        private System.Windows.Forms.Label lblCitatorio;
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
        private System.Windows.Forms.GroupBox BoxObservaciones;
        private System.Windows.Forms.TableLayoutPanel panelDescripcionObservaciones;
        private System.Windows.Forms.GroupBox BoxIndetificarPorblema;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RadioButton rbCitatorio;
        private System.Windows.Forms.RadioButton rbAmbos;
        private System.Windows.Forms.RadioButton rbNotificacion;
        private System.Windows.Forms.ComboBox cmbObservacion;
        private System.Windows.Forms.GroupBox boxNotas;
        private System.Windows.Forms.RichTextBox textNotas;
        private System.Windows.Forms.GroupBox boxAcciones;
    }
}