namespace WindowsFormsApp6
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmision = new System.Windows.Forms.Label();
            this.listCEmisionActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblZonaName = new System.Windows.Forms.Label();
            this.cmbEmision = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnho = new System.Windows.Forms.ComboBox();
            this.canhoFiscalBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coheActivaBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listCoheActivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgAvance = new System.Windows.Forms.DataGridView();
            this.listaInformeAvanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cNombreBimestreBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noLocalizadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTrabajado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendientesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCEmisionActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canhoFiscalBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coheActivaBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCoheActivaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAvance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaInformeAvanceBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cNombreBimestreBOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmision);
            this.groupBox1.Controls.Add(this.lblZonaName);
            this.groupBox1.Controls.Add(this.cmbEmision);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbAnho);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú selección";
            // 
            // lblEmision
            // 
            this.lblEmision.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listCEmisionActualBindingSource, "Periodo", true));
            this.lblEmision.Location = new System.Drawing.Point(263, 58);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(23, 18);
            this.lblEmision.TabIndex = 7;
            this.lblEmision.Text = "11";
            // 
            // listCEmisionActualBindingSource
            // 
            this.listCEmisionActualBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.ListCEmisionActual);
            // 
            // lblZonaName
            // 
            this.lblZonaName.AutoSize = true;
            this.lblZonaName.Location = new System.Drawing.Point(43, 26);
            this.lblZonaName.Name = "lblZonaName";
            this.lblZonaName.Size = new System.Drawing.Size(0, 13);
            this.lblZonaName.TabIndex = 6;
            // 
            // cmbEmision
            // 
            this.cmbEmision.DataSource = this.listCEmisionActualBindingSource;
            this.cmbEmision.DisplayMember = "NomEmision";
            this.cmbEmision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmision.FormattingEnabled = true;
            this.cmbEmision.Location = new System.Drawing.Point(292, 55);
            this.cmbEmision.Name = "cmbEmision";
            this.cmbEmision.Size = new System.Drawing.Size(214, 21);
            this.cmbEmision.TabIndex = 1;
            this.cmbEmision.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmision_KeyDown);
            this.cmbEmision.Leave += new System.EventHandler(this.CmbEmision_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "EMISIÓN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EJERCICIO FISCAL:";
            // 
            // cmbAnho
            // 
            this.cmbAnho.DataSource = this.canhoFiscalBOBindingSource;
            this.cmbAnho.DisplayMember = "Anho";
            this.cmbAnho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnho.FormattingEnabled = true;
            this.cmbAnho.Location = new System.Drawing.Point(116, 55);
            this.cmbAnho.Name = "cmbAnho";
            this.cmbAnho.Size = new System.Drawing.Size(74, 21);
            this.cmbAnho.TabIndex = 0;
            this.cmbAnho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAnho_KeyDown);
            this.cmbAnho.Leave += new System.EventHandler(this.CmbAnho_Leave);
            // 
            // canhoFiscalBOBindingSource
            // 
            this.canhoFiscalBOBindingSource.DataSource = typeof(WindowsFormsApp6.BO.CanhoFiscalBO);
            // 
            // coheActivaBOBindingSource
            // 
            this.coheActivaBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CoheActivaBO);
            // 
            // listCoheActivaBindingSource
            // 
            this.listCoheActivaBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.ListCoheActiva);
            // 
            // dgAvance
            // 
            this.dgAvance.AllowUserToAddRows = false;
            this.dgAvance.AllowUserToDeleteRows = false;
            this.dgAvance.AutoGenerateColumns = false;
            this.dgAvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAvance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oheDataGridViewTextBoxColumn,
            this.TotalReq,
            this.localizadoDataGridViewTextBoxColumn,
            this.noLocalizadoDataGridViewTextBoxColumn,
            this.noTrabajado,
            this.pendientesDataGridViewTextBoxColumn});
            this.dgAvance.DataSource = this.listaInformeAvanceBindingSource;
            this.dgAvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAvance.Location = new System.Drawing.Point(3, 16);
            this.dgAvance.Name = "dgAvance";
            this.dgAvance.ReadOnly = true;
            this.dgAvance.Size = new System.Drawing.Size(1038, 322);
            this.dgAvance.TabIndex = 3;
            // 
            // listaInformeAvanceBindingSource
            // 
            this.listaInformeAvanceBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.ListaInformeAvance);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgAvance);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cNombreBimestreBOBindingSource, "OHE", true));
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cNombreBimestreBOBindingSource, "OHE", true));
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1044, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cNombreBimestreBOBindingSource
            // 
            this.cNombreBimestreBOBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CNombreBimestreBO);
            // 
            // oheDataGridViewTextBoxColumn
            // 
            this.oheDataGridViewTextBoxColumn.DataPropertyName = "Ohe";
            this.oheDataGridViewTextBoxColumn.HeaderText = "OHE";
            this.oheDataGridViewTextBoxColumn.Name = "oheDataGridViewTextBoxColumn";
            this.oheDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TotalReq
            // 
            this.TotalReq.DataPropertyName = "TotalReq";
            this.TotalReq.HeaderText = "Total";
            this.TotalReq.Name = "TotalReq";
            this.TotalReq.ReadOnly = true;
            // 
            // localizadoDataGridViewTextBoxColumn
            // 
            this.localizadoDataGridViewTextBoxColumn.DataPropertyName = "Localizado";
            this.localizadoDataGridViewTextBoxColumn.HeaderText = "LOCALIZADO";
            this.localizadoDataGridViewTextBoxColumn.Name = "localizadoDataGridViewTextBoxColumn";
            this.localizadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noLocalizadoDataGridViewTextBoxColumn
            // 
            this.noLocalizadoDataGridViewTextBoxColumn.DataPropertyName = "NoLocalizado";
            this.noLocalizadoDataGridViewTextBoxColumn.HeaderText = "NO LOCALIZADO";
            this.noLocalizadoDataGridViewTextBoxColumn.Name = "noLocalizadoDataGridViewTextBoxColumn";
            this.noLocalizadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noTrabajado
            // 
            this.noTrabajado.DataPropertyName = "noTrabajado";
            this.noTrabajado.HeaderText = "NO TRABAJADO";
            this.noTrabajado.Name = "noTrabajado";
            this.noTrabajado.ReadOnly = true;
            // 
            // pendientesDataGridViewTextBoxColumn
            // 
            this.pendientesDataGridViewTextBoxColumn.DataPropertyName = "Pendientes";
            this.pendientesDataGridViewTextBoxColumn.HeaderText = "PENDIENTES";
            this.pendientesDataGridViewTextBoxColumn.Name = "pendientesDataGridViewTextBoxColumn";
            this.pendientesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Avances";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCEmisionActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canhoFiscalBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coheActivaBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCoheActivaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAvance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaInformeAvanceBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cNombreBimestreBOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEmision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnho;
        private System.Windows.Forms.DataGridView dgAvance;
        private System.Windows.Forms.BindingSource listaInformeAvanceBindingSource;
        private System.Windows.Forms.BindingSource listCoheActivaBindingSource;
        private System.Windows.Forms.BindingSource listCEmisionActualBindingSource;
        private System.Windows.Forms.BindingSource canhoFiscalBOBindingSource;
        private System.Windows.Forms.Label lblZonaName;
        private System.Windows.Forms.BindingSource coheActivaBOBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource cNombreBimestreBOBindingSource;
        private System.Windows.Forms.Label lblEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn oheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noLocalizadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTrabajado;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendientesDataGridViewTextBoxColumn;
    }
}