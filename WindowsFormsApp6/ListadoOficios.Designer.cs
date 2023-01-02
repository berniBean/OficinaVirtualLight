
namespace WindowsFormsApp6
{
    partial class ListadoOficios
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fechaOficiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgressOficio = new System.Windows.Forms.ToolStripProgressBar();
            this.dtpRetro = new System.Windows.Forms.DateTimePicker();
            this.idOficioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oHEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOficioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOficiosBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTableroAdminBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpOficio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechaOficiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOficiosBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTableroAdminBOBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dtpOficio);
            this.splitContainer1.Panel1.Controls.Add(this.dtpRetro);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnGuardar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(819, 450);
            this.splitContainer1.SplitterDistance = 63;
            this.splitContainer1.TabIndex = 0;
            // 
            // fechaOficiosBindingSource
            // 
            this.fechaOficiosBindingSource.DataSource = typeof(CleanArchitecture.Concretas.fechaOficios);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de retro alimentación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha del oficio:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(492, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOficioDataGridViewTextBoxColumn,
            this.referenciaDataGridViewTextBoxColumn,
            this.zonaDataGridViewTextBoxColumn,
            this.oHEDataGridViewTextBoxColumn,
            this.numOficioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOficiosBOBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(819, 361);
            this.dataGridView1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgressOficio});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(819, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgressOficio
            // 
            this.tsProgressOficio.Name = "tsProgressOficio";
            this.tsProgressOficio.Size = new System.Drawing.Size(100, 16);
            // 
            // dtpRetro
            // 
            this.dtpRetro.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fechaOficiosBindingSource, "FechaRetro", true));
            this.dtpRetro.Location = new System.Drawing.Point(156, 32);
            this.dtpRetro.Name = "dtpRetro";
            this.dtpRetro.Size = new System.Drawing.Size(200, 20);
            this.dtpRetro.TabIndex = 5;
            this.dtpRetro.UseWaitCursor = true;
            // 
            // idOficioDataGridViewTextBoxColumn
            // 
            this.idOficioDataGridViewTextBoxColumn.DataPropertyName = "IdOficio";
            this.idOficioDataGridViewTextBoxColumn.HeaderText = "IdOficio";
            this.idOficioDataGridViewTextBoxColumn.Name = "idOficioDataGridViewTextBoxColumn";
            this.idOficioDataGridViewTextBoxColumn.Visible = false;
            // 
            // referenciaDataGridViewTextBoxColumn
            // 
            this.referenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.HeaderText = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.Name = "referenciaDataGridViewTextBoxColumn";
            // 
            // zonaDataGridViewTextBoxColumn
            // 
            this.zonaDataGridViewTextBoxColumn.DataPropertyName = "Zona";
            this.zonaDataGridViewTextBoxColumn.HeaderText = "Zona";
            this.zonaDataGridViewTextBoxColumn.Name = "zonaDataGridViewTextBoxColumn";
            // 
            // oHEDataGridViewTextBoxColumn
            // 
            this.oHEDataGridViewTextBoxColumn.DataPropertyName = "OHE";
            this.oHEDataGridViewTextBoxColumn.HeaderText = "OHE";
            this.oHEDataGridViewTextBoxColumn.Name = "oHEDataGridViewTextBoxColumn";
            // 
            // numOficioDataGridViewTextBoxColumn
            // 
            this.numOficioDataGridViewTextBoxColumn.DataPropertyName = "NumOficio";
            this.numOficioDataGridViewTextBoxColumn.HeaderText = "NumOficio";
            this.numOficioDataGridViewTextBoxColumn.Name = "numOficioDataGridViewTextBoxColumn";
            // 
            // cOficiosBOBindingSource
            // 
            this.cOficiosBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.COficiosBO);
            // 
            // cTableroAdminBOBindingSource
            // 
            this.cTableroAdminBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CTableroAdminBO);
            // 
            // dtpOficio
            // 
            this.dtpOficio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fechaOficiosBindingSource, "FechaOficios", true));
            this.dtpOficio.Location = new System.Drawing.Point(156, 6);
            this.dtpOficio.Name = "dtpOficio";
            this.dtpOficio.Size = new System.Drawing.Size(200, 20);
            this.dtpOficio.TabIndex = 6;
            // 
            // ListadoOficios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ListadoOficios";
            this.Text = "ListadoOficios";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fechaOficiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOficiosBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTableroAdminBOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgressOficio;
        private System.Windows.Forms.BindingSource cTableroAdminBOBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cOficiosBOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOficioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oHEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOficioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fechaOficiosBindingSource;
        private System.Windows.Forms.DateTimePicker dtpRetro;
        private System.Windows.Forms.DateTimePicker dtpOficio;
    }
}