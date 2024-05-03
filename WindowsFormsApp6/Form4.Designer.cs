namespace WindowsFormsApp6
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.groupBoxPLUS = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gbMulta = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbSet = new System.Windows.Forms.GroupBox();
            this.NoTrabajado = new System.Windows.Forms.RadioButton();
            this.Nolocalizado = new System.Windows.Forms.RadioButton();
            this.Localizado = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridBusqueda = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBoxPLUS.SuspendLayout();
            this.gbMulta.SuspendLayout();
            this.gbSet.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDescargar);
            this.groupBox1.Controls.Add(this.groupBoxPLUS);
            this.groupBox1.Controls.Add(this.gbMulta);
            this.groupBox1.Controls.Add(this.gbSet);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(246, 12);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(75, 23);
            this.btnDescargar.TabIndex = 9;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Visible = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // groupBoxPLUS
            // 
            this.groupBoxPLUS.Controls.Add(this.radioButton5);
            this.groupBoxPLUS.Controls.Add(this.radioButton3);
            this.groupBoxPLUS.Controls.Add(this.radioButton4);
            this.groupBoxPLUS.Location = new System.Drawing.Point(165, 41);
            this.groupBoxPLUS.Name = "groupBoxPLUS";
            this.groupBoxPLUS.Size = new System.Drawing.Size(121, 88);
            this.groupBoxPLUS.TabIndex = 8;
            this.groupBoxPLUS.TabStop = false;
            this.groupBoxPLUS.Text = "Tipo PDF:";
            this.groupBoxPLUS.Visible = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(10, 17);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(84, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Escaneados";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Recibos";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(10, 40);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(67, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Firmados";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // gbMulta
            // 
            this.gbMulta.Controls.Add(this.radioButton2);
            this.gbMulta.Controls.Add(this.radioButton1);
            this.gbMulta.Location = new System.Drawing.Point(165, 41);
            this.gbMulta.Name = "gbMulta";
            this.gbMulta.Size = new System.Drawing.Size(121, 62);
            this.gbMulta.TabIndex = 7;
            this.gbMulta.TabStop = false;
            this.gbMulta.Text = "Tipo multa:";
            this.gbMulta.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "MI-RIF-";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ME-RIF-";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // gbSet
            // 
            this.gbSet.Controls.Add(this.NoTrabajado);
            this.gbSet.Controls.Add(this.Nolocalizado);
            this.gbSet.Controls.Add(this.Localizado);
            this.gbSet.Location = new System.Drawing.Point(12, 19);
            this.gbSet.Name = "gbSet";
            this.gbSet.Size = new System.Drawing.Size(124, 84);
            this.gbSet.TabIndex = 6;
            this.gbSet.TabStop = false;
            this.gbSet.Text = "Establecer como:";
            // 
            // NoTrabajado
            // 
            this.NoTrabajado.AutoSize = true;
            this.NoTrabajado.Location = new System.Drawing.Point(6, 61);
            this.NoTrabajado.Name = "NoTrabajado";
            this.NoTrabajado.Size = new System.Drawing.Size(108, 17);
            this.NoTrabajado.TabIndex = 2;
            this.NoTrabajado.TabStop = true;
            this.NoTrabajado.Text = "NO TRABAJADO";
            this.NoTrabajado.UseVisualStyleBackColor = true;
            // 
            // Nolocalizado
            // 
            this.Nolocalizado.AutoSize = true;
            this.Nolocalizado.Location = new System.Drawing.Point(6, 39);
            this.Nolocalizado.Name = "Nolocalizado";
            this.Nolocalizado.Size = new System.Drawing.Size(111, 17);
            this.Nolocalizado.TabIndex = 1;
            this.Nolocalizado.TabStop = true;
            this.Nolocalizado.Text = "NO LOCALIZADO";
            this.Nolocalizado.UseVisualStyleBackColor = true;
            // 
            // Localizado
            // 
            this.Localizado.AutoSize = true;
            this.Localizado.Location = new System.Drawing.Point(6, 16);
            this.Localizado.Name = "Localizado";
            this.Localizado.Size = new System.Drawing.Size(92, 17);
            this.Localizado.TabIndex = 0;
            this.Localizado.TabStop = true;
            this.Localizado.Text = "LOCALIZADO";
            this.Localizado.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(165, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridBusqueda);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridBusqueda
            // 
            this.dataGridBusqueda.AllowUserToAddRows = false;
            this.dataGridBusqueda.AllowUserToDeleteRows = false;
            this.dataGridBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBusqueda.Location = new System.Drawing.Point(3, 16);
            this.dataGridBusqueda.Name = "dataGridBusqueda";
            this.dataGridBusqueda.Size = new System.Drawing.Size(436, 237);
            this.dataGridBusqueda.TabIndex = 0;
            this.dataGridBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(458, 406);
            this.MinimumSize = new System.Drawing.Size(458, 406);
            this.Name = "Form4";
            this.Text = "Busqueda masiva";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxPLUS.ResumeLayout(false);
            this.groupBoxPLUS.PerformLayout();
            this.gbMulta.ResumeLayout(false);
            this.gbMulta.PerformLayout();
            this.gbSet.ResumeLayout(false);
            this.gbSet.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridBusqueda;
        private System.Windows.Forms.GroupBox gbSet;
        private System.Windows.Forms.RadioButton Nolocalizado;
        private System.Windows.Forms.RadioButton Localizado;
        private System.Windows.Forms.GroupBox gbMulta;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton NoTrabajado;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxPLUS;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}