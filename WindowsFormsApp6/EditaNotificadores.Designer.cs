
namespace WindowsFormsApp6
{
    partial class EditaNotificadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditaNotificadores));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGNotificadores = new System.Windows.Forms.DataGridView();
            this.idNotificadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClaveOHEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveNotificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreNotificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.cListNotificadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombramiento = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClaveNot = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.cmbOHE = new System.Windows.Forms.ComboBox();
            this.listCoheActivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGNotificadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListNotificadoresBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCoheActivaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DGNotificadores, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.30769F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.69231F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 442);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGNotificadores
            // 
            this.DGNotificadores.AllowUserToAddRows = false;
            this.DGNotificadores.AutoGenerateColumns = false;
            this.DGNotificadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGNotificadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNotificadorDataGridViewTextBoxColumn,
            this.idClaveOHEDataGridViewTextBoxColumn,
            this.claveNotificador,
            this.nombreNotificador,
            this.Edit,
            this.Delete});
            this.DGNotificadores.DataSource = this.cListNotificadoresBindingSource;
            this.DGNotificadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGNotificadores.Location = new System.Drawing.Point(3, 189);
            this.DGNotificadores.Name = "DGNotificadores";
            this.DGNotificadores.Size = new System.Drawing.Size(988, 250);
            this.DGNotificadores.TabIndex = 1;
            this.DGNotificadores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGNotificadores_CellContentDoubleClick);
            // 
            // idNotificadorDataGridViewTextBoxColumn
            // 
            this.idNotificadorDataGridViewTextBoxColumn.DataPropertyName = "IdNotificador";
            this.idNotificadorDataGridViewTextBoxColumn.HeaderText = "IdNotificador";
            this.idNotificadorDataGridViewTextBoxColumn.Name = "idNotificadorDataGridViewTextBoxColumn";
            this.idNotificadorDataGridViewTextBoxColumn.Visible = false;
            // 
            // idClaveOHEDataGridViewTextBoxColumn
            // 
            this.idClaveOHEDataGridViewTextBoxColumn.DataPropertyName = "IdClaveOHE";
            this.idClaveOHEDataGridViewTextBoxColumn.HeaderText = "IdClaveOHE";
            this.idClaveOHEDataGridViewTextBoxColumn.Name = "idClaveOHEDataGridViewTextBoxColumn";
            this.idClaveOHEDataGridViewTextBoxColumn.Visible = false;
            // 
            // claveNotificador
            // 
            this.claveNotificador.DataPropertyName = "ClaveNotificador";
            this.claveNotificador.HeaderText = "ClaveNotificador";
            this.claveNotificador.Name = "claveNotificador";
            this.claveNotificador.Visible = false;
            // 
            // nombreNotificador
            // 
            this.nombreNotificador.DataPropertyName = "NombreNotificador";
            this.nombreNotificador.HeaderText = "NombreNotificador";
            this.nombreNotificador.Name = "nombreNotificador";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cListNotificadoresBindingSource
            // 
            this.cListNotificadoresBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.CListNotificadores);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNombramiento);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtClaveNot);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.BtnNuevo);
            this.groupBox1.Controls.Add(this.cmbOHE);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Notificador:";
            // 
            // lblNombramiento
            // 
            this.lblNombramiento.AutoSize = true;
            this.lblNombramiento.Location = new System.Drawing.Point(308, 41);
            this.lblNombramiento.Name = "lblNombramiento";
            this.lblNombramiento.Size = new System.Drawing.Size(95, 13);
            this.lblNombramiento.TabIndex = 5;
            this.lblNombramiento.Text = "No Nombramiento:";
            this.lblNombramiento.Visible = false;
            this.lblNombramiento.Click += new System.EventHandler(this.lblNombramiento_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(412, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtClaveNot
            // 
            this.txtClaveNot.Location = new System.Drawing.Point(412, 38);
            this.txtClaveNot.Name = "txtClaveNot";
            this.txtClaveNot.Size = new System.Drawing.Size(208, 20);
            this.txtClaveNot.TabIndex = 3;
            this.txtClaveNot.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(820, 67);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(820, 38);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(135, 23);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "Agregar";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // cmbOHE
            // 
            this.cmbOHE.DataSource = this.listCoheActivaBindingSource;
            this.cmbOHE.DisplayMember = "OHE";
            this.cmbOHE.FormattingEnabled = true;
            this.cmbOHE.Location = new System.Drawing.Point(18, 40);
            this.cmbOHE.Name = "cmbOHE";
            this.cmbOHE.Size = new System.Drawing.Size(194, 21);
            this.cmbOHE.TabIndex = 0;
            this.cmbOHE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOHE_KeyDown);
            this.cmbOHE.Leave += new System.EventHandler(this.cmbOHE_Leave);
            // 
            // listCoheActivaBindingSource
            // 
            this.listCoheActivaBindingSource.DataSource = typeof(WindowsFormsApp6.CAD.BO.ListCoheActiva);
            // 
            // EditaNotificadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditaNotificadores";
            this.Text = "EditaNotificadores";
            this.Load += new System.EventHandler(this.EditaNotificadores_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGNotificadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListNotificadoresBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCoheActivaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGNotificadores;
        private System.Windows.Forms.BindingSource cListNotificadoresBindingSource;
        private System.Windows.Forms.ComboBox cmbOHE;
        private System.Windows.Forms.BindingSource listCoheActivaBindingSource;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Label lblNombramiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClaveNot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNotificadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClaveOHEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveNotificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreNotificador;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}