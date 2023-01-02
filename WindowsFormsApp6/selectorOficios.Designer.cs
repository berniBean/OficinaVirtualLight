
namespace WindowsFormsApp6
{
    partial class selectorOficios
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.cListaTableroAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgReqPLUS = new System.Windows.Forms.DataGridView();
            this.detalleEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaNumerciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cTableroAdminBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catableroJefeRCOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRIF = new WindowsFormsApp6.DataSetRIF();
            this.listadoRIFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cListaTableroAdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReqPLUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTableroAdminBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catableroJefeRCOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoRIFBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cmbEjercicio);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgReqPLUS);
            this.splitContainer1.Size = new System.Drawing.Size(639, 450);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona el año:";
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.DataSource = this.cListaTableroAdminBindingSource;
            this.cmbEjercicio.DisplayMember = "_anho";
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(104, 12);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(121, 21);
            this.cmbEjercicio.TabIndex = 0;
            this.cmbEjercicio.Leave += new System.EventHandler(this.cmbEjercicio_Leave);
            // 
            // cListaTableroAdminBindingSource
            // 
            this.cListaTableroAdminBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CListaTableroAdmin);
            // 
            // dgReqPLUS
            // 
            this.dgReqPLUS.AllowUserToAddRows = false;
            this.dgReqPLUS.AllowUserToDeleteRows = false;
            this.dgReqPLUS.AutoGenerateColumns = false;
            this.dgReqPLUS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReqPLUS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalleEmisionDataGridViewTextBoxColumn,
            this.referenciaNumerciaDataGridViewTextBoxColumn,
            this.idEmisionDataGridViewTextBoxColumn});
            this.dgReqPLUS.DataSource = this.cTableroAdminBOBindingSource;
            this.dgReqPLUS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReqPLUS.Location = new System.Drawing.Point(0, 0);
            this.dgReqPLUS.Name = "dgReqPLUS";
            this.dgReqPLUS.ReadOnly = true;
            this.dgReqPLUS.Size = new System.Drawing.Size(639, 405);
            this.dgReqPLUS.TabIndex = 0;
            this.dgReqPLUS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // detalleEmisionDataGridViewTextBoxColumn
            // 
            this.detalleEmisionDataGridViewTextBoxColumn.DataPropertyName = "_detalleEmision";
            this.detalleEmisionDataGridViewTextBoxColumn.HeaderText = "Detalle de la emisión";
            this.detalleEmisionDataGridViewTextBoxColumn.Name = "detalleEmisionDataGridViewTextBoxColumn";
            this.detalleEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenciaNumerciaDataGridViewTextBoxColumn
            // 
            this.referenciaNumerciaDataGridViewTextBoxColumn.DataPropertyName = "_referenciaNumercia";
            this.referenciaNumerciaDataGridViewTextBoxColumn.HeaderText = "Nombre emision";
            this.referenciaNumerciaDataGridViewTextBoxColumn.Name = "referenciaNumerciaDataGridViewTextBoxColumn";
            this.referenciaNumerciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEmisionDataGridViewTextBoxColumn
            // 
            this.idEmisionDataGridViewTextBoxColumn.DataPropertyName = "_idEmision";
            this.idEmisionDataGridViewTextBoxColumn.HeaderText = "Emision";
            this.idEmisionDataGridViewTextBoxColumn.Name = "idEmisionDataGridViewTextBoxColumn";
            this.idEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmisionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idEmisionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cTableroAdminBOBindingSource
            // 
            this.cTableroAdminBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CTableroAdminBO);
            // 
            // catableroJefeRCOBindingSource
            // 
            this.catableroJefeRCOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CatableroJefeRCO);
            // 
            // dataSetRIF
            // 
            this.dataSetRIF.DataSetName = "DataSetRIF";
            this.dataSetRIF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listadoRIFBindingSource
            // 
            this.listadoRIFBindingSource.DataMember = "ListadoRIF";
            this.listadoRIFBindingSource.DataSource = this.dataSetRIF;
            // 
            // selectorOficios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "selectorOficios";
            this.Text = "selectorOficios";
            this.Load += new System.EventHandler(this.selectorOficios_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cListaTableroAdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReqPLUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTableroAdminBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catableroJefeRCOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoRIFBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEjercicio;
        private System.Windows.Forms.DataGridView dgReqPLUS;
        private DataSetRIF dataSetRIF;
        private System.Windows.Forms.BindingSource listadoRIFBindingSource;
        private System.Windows.Forms.BindingSource cListaTableroAdminBindingSource;
        private System.Windows.Forms.BindingSource cTableroAdminBOBindingSource;
        private System.Windows.Forms.BindingSource catableroJefeRCOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaNumerciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn idEmisionDataGridViewTextBoxColumn;
    }
}