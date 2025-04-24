namespace WindowsFormsApp6
{
    partial class EliminaRequerimientoControl1
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
            this.components = new System.ComponentModel.Container();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgControlReq = new System.Windows.Forms.DataGridView();
            this.dgEliminarDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbEjercicio = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LstResultados = new System.Windows.Forms.ListView();
            this.idEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaNumericaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorResponseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgControlReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEliminarDTOBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1497, 761);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgControlReq);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.TbEjercicio);
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.btnEjecutar);
            this.splitContainer2.Size = new System.Drawing.Size(1497, 492);
            this.splitContainer2.SplitterDistance = 637;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgControlReq
            // 
            this.dgControlReq.AutoGenerateColumns = false;
            this.dgControlReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgControlReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmisionDataGridViewTextBoxColumn,
            this.nomEmisionDataGridViewTextBoxColumn,
            this.referenciaNumericaDataGridViewTextBoxColumn,
            this.errorResponseDataGridViewTextBoxColumn});
            this.dgControlReq.DataSource = this.dgEliminarDTOBindingSource;
            this.dgControlReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgControlReq.Location = new System.Drawing.Point(0, 0);
            this.dgControlReq.Name = "dgControlReq";
            this.dgControlReq.RowHeadersWidth = 62;
            this.dgControlReq.RowTemplate.Height = 28;
            this.dgControlReq.Size = new System.Drawing.Size(637, 492);
            this.dgControlReq.TabIndex = 0;
            this.dgControlReq.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControlReq_CellContentDoubleClick);
            // 
            // dgEliminarDTOBindingSource
            // 
            this.dgEliminarDTOBindingSource.DataSource = typeof(App_VerFormsAPI.DTO.DgEliminarDTO);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Emisión seleccionada:";
            // 
            // TbEjercicio
            // 
            this.TbEjercicio.Location = new System.Drawing.Point(90, 46);
            this.TbEjercicio.Mask = "9999";
            this.TbEjercicio.Name = "TbEjercicio";
            this.TbEjercicio.Size = new System.Drawing.Size(49, 26);
            this.TbEjercicio.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ejercicio fiscal";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(118, 222);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(100, 41);
            this.btnEjecutar.TabIndex = 0;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LstResultados);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1497, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejecución";
            // 
            // LstResultados
            // 
            this.LstResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstResultados.HideSelection = false;
            this.LstResultados.Location = new System.Drawing.Point(3, 22);
            this.LstResultados.Name = "LstResultados";
            this.LstResultados.Size = new System.Drawing.Size(1491, 240);
            this.LstResultados.TabIndex = 0;
            this.LstResultados.UseCompatibleStateImageBehavior = false;
            // 
            // idEmisionDataGridViewTextBoxColumn
            // 
            this.idEmisionDataGridViewTextBoxColumn.DataPropertyName = "IdEmision";
            this.idEmisionDataGridViewTextBoxColumn.HeaderText = "IdEmision";
            this.idEmisionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idEmisionDataGridViewTextBoxColumn.Name = "idEmisionDataGridViewTextBoxColumn";
            this.idEmisionDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomEmisionDataGridViewTextBoxColumn
            // 
            this.nomEmisionDataGridViewTextBoxColumn.DataPropertyName = "NomEmision";
            this.nomEmisionDataGridViewTextBoxColumn.HeaderText = "NomEmision";
            this.nomEmisionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomEmisionDataGridViewTextBoxColumn.Name = "nomEmisionDataGridViewTextBoxColumn";
            this.nomEmisionDataGridViewTextBoxColumn.Width = 150;
            // 
            // referenciaNumericaDataGridViewTextBoxColumn
            // 
            this.referenciaNumericaDataGridViewTextBoxColumn.DataPropertyName = "ReferenciaNumerica";
            this.referenciaNumericaDataGridViewTextBoxColumn.HeaderText = "ReferenciaNumerica";
            this.referenciaNumericaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.referenciaNumericaDataGridViewTextBoxColumn.Name = "referenciaNumericaDataGridViewTextBoxColumn";
            this.referenciaNumericaDataGridViewTextBoxColumn.Width = 150;
            // 
            // errorResponseDataGridViewTextBoxColumn
            // 
            this.errorResponseDataGridViewTextBoxColumn.DataPropertyName = "ErrorResponse";
            this.errorResponseDataGridViewTextBoxColumn.HeaderText = "ErrorResponse";
            this.errorResponseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.errorResponseDataGridViewTextBoxColumn.Name = "errorResponseDataGridViewTextBoxColumn";
            this.errorResponseDataGridViewTextBoxColumn.Visible = false;
            this.errorResponseDataGridViewTextBoxColumn.Width = 150;
            // 
            // EliminaRequerimientoControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "EliminaRequerimientoControl1";
            this.Size = new System.Drawing.Size(1497, 761);
            this.Load += new System.EventHandler(this.EliminaRequerimientoControl1_Load_1);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgControlReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEliminarDTOBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgControlReq;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox TbEjercicio;
        private System.Windows.Forms.BindingSource dgEliminarDTOBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView LstResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaNumericaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorResponseDataGridViewTextBoxColumn;
    }
}
