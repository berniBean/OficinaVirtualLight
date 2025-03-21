namespace WindowsFormsApp6
{
    partial class RequerimientosControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbEjercicio = new System.Windows.Forms.MaskedTextBox();
            this.DtFechaRetro = new System.Windows.Forms.DateTimePicker();
            this.DtFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.txtUltimoReq = new System.Windows.Forms.TextBox();
            this.txtDetalleEmision = new System.Windows.Forms.TextBox();
            this.txtOficioSat = new System.Windows.Forms.TextBox();
            this.txtNombreEmisión = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnCatalogo = new System.Windows.Forms.Button();
            this.BtnOmisos = new System.Windows.Forms.Button();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.lblOmisos = new System.Windows.Forms.Label();
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LstResultados = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbEjercicio);
            this.groupBox1.Controls.Add(this.DtFechaRetro);
            this.groupBox1.Controls.Add(this.DtFechaEmision);
            this.groupBox1.Controls.Add(this.txtUltimoReq);
            this.groupBox1.Controls.Add(this.txtDetalleEmision);
            this.groupBox1.Controls.Add(this.txtOficioSat);
            this.groupBox1.Controls.Add(this.txtNombreEmisión);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(34, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 284);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de emisión";
            // 
            // TbEjercicio
            // 
            this.TbEjercicio.Location = new System.Drawing.Point(245, 120);
            this.TbEjercicio.Mask = "9999";
            this.TbEjercicio.Name = "TbEjercicio";
            this.TbEjercicio.Size = new System.Drawing.Size(370, 26);
            this.TbEjercicio.TabIndex = 3;
            // 
            // DtFechaRetro
            // 
            this.DtFechaRetro.Location = new System.Drawing.Point(245, 88);
            this.DtFechaRetro.Name = "DtFechaRetro";
            this.DtFechaRetro.Size = new System.Drawing.Size(370, 26);
            this.DtFechaRetro.TabIndex = 14;
            // 
            // DtFechaEmision
            // 
            this.DtFechaEmision.Location = new System.Drawing.Point(245, 59);
            this.DtFechaEmision.Name = "DtFechaEmision";
            this.DtFechaEmision.Size = new System.Drawing.Size(370, 26);
            this.DtFechaEmision.TabIndex = 3;
            // 
            // txtUltimoReq
            // 
            this.txtUltimoReq.Location = new System.Drawing.Point(245, 224);
            this.txtUltimoReq.Name = "txtUltimoReq";
            this.txtUltimoReq.Size = new System.Drawing.Size(370, 26);
            this.txtUltimoReq.TabIndex = 13;
            // 
            // txtDetalleEmision
            // 
            this.txtDetalleEmision.Location = new System.Drawing.Point(245, 190);
            this.txtDetalleEmision.Name = "txtDetalleEmision";
            this.txtDetalleEmision.Size = new System.Drawing.Size(370, 26);
            this.txtDetalleEmision.TabIndex = 12;
            // 
            // txtOficioSat
            // 
            this.txtOficioSat.Location = new System.Drawing.Point(245, 153);
            this.txtOficioSat.Name = "txtOficioSat";
            this.txtOficioSat.Size = new System.Drawing.Size(370, 26);
            this.txtOficioSat.TabIndex = 11;
            // 
            // txtNombreEmisión
            // 
            this.txtNombreEmisión.Location = new System.Drawing.Point(244, 28);
            this.txtNombreEmisión.Name = "txtNombreEmisión";
            this.txtNombreEmisión.Size = new System.Drawing.Size(371, 26);
            this.txtNombreEmisión.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ultimo registro requerimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Detalle emisión:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Numero de oficio SAT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ejercicio fiscal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha de retro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha de emisión:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre emisión:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnCatalogo
            // 
            this.BtnCatalogo.Location = new System.Drawing.Point(99, 21);
            this.BtnCatalogo.Name = "BtnCatalogo";
            this.BtnCatalogo.Size = new System.Drawing.Size(171, 35);
            this.BtnCatalogo.TabIndex = 3;
            this.BtnCatalogo.Text = "Selecciona catálogo";
            this.BtnCatalogo.UseVisualStyleBackColor = true;
            this.BtnCatalogo.Click += new System.EventHandler(this.BtnCatalogo_Click);
            // 
            // BtnOmisos
            // 
            this.BtnOmisos.Location = new System.Drawing.Point(99, 78);
            this.BtnOmisos.Name = "BtnOmisos";
            this.BtnOmisos.Size = new System.Drawing.Size(167, 35);
            this.BtnOmisos.TabIndex = 4;
            this.BtnOmisos.Text = "Selecciona omisos";
            this.BtnOmisos.UseVisualStyleBackColor = true;
            this.BtnOmisos.Click += new System.EventHandler(this.BtnOmisos_Click);
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Location = new System.Drawing.Point(302, 28);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(51, 20);
            this.lblCatalogo.TabIndex = 5;
            this.lblCatalogo.Text = "label1";
            // 
            // lblOmisos
            // 
            this.lblOmisos.AutoSize = true;
            this.lblOmisos.Location = new System.Drawing.Point(302, 85);
            this.lblOmisos.Name = "lblOmisos";
            this.lblOmisos.Size = new System.Drawing.Size(51, 20);
            this.lblOmisos.TabIndex = 6;
            this.lblOmisos.Text = "label2";
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Location = new System.Drawing.Point(1209, 472);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(143, 42);
            this.BtnEjecutar.TabIndex = 7;
            this.BtnEjecutar.Text = "Iniciar";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LstResultados);
            this.groupBox2.Location = new System.Drawing.Point(734, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 216);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ejecución";
            // 
            // LstResultados
            // 
            this.LstResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstResultados.HideSelection = false;
            this.LstResultados.Location = new System.Drawing.Point(3, 22);
            this.LstResultados.Name = "LstResultados";
            this.LstResultados.Size = new System.Drawing.Size(505, 191);
            this.LstResultados.TabIndex = 0;
            this.LstResultados.UseCompatibleStateImageBehavior = false;
            // 
            // RequerimientosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.lblOmisos);
            this.Controls.Add(this.lblCatalogo);
            this.Controls.Add(this.BtnOmisos);
            this.Controls.Add(this.BtnCatalogo);
            this.Controls.Add(this.groupBox1);
            this.Name = "RequerimientosControl";
            this.Size = new System.Drawing.Size(1383, 526);
            this.Load += new System.EventHandler(this.RequerimientosControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreEmisión;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUltimoReq;
        private System.Windows.Forms.TextBox txtDetalleEmision;
        private System.Windows.Forms.TextBox txtOficioSat;
        private System.Windows.Forms.DateTimePicker DtFechaRetro;
        private System.Windows.Forms.DateTimePicker DtFechaEmision;
        private System.Windows.Forms.MaskedTextBox TbEjercicio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnCatalogo;
        private System.Windows.Forms.Button BtnOmisos;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.Label lblOmisos;
        private System.Windows.Forms.Button BtnEjecutar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView LstResultados;
    }
}
