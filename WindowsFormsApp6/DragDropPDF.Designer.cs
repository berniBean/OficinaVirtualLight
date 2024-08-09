
namespace WindowsFormsApp6
{
    partial class DragDropPDF
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ReqFirmados = new System.Windows.Forms.CheckBox();
            this.chRemplazo = new System.Windows.Forms.CheckBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmision = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.DropFiles = new System.Windows.Forms.ListBox();
            this.splitDivisor = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tpbProgresBar = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDivisor)).BeginInit();
            this.splitDivisor.Panel1.SuspendLayout();
            this.splitDivisor.Panel2.SuspendLayout();
            this.splitDivisor.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.ReqFirmados);
            this.splitContainer1.Panel1.Controls.Add(this.chRemplazo);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombre);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.lblEmision);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lblAño);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnCargar);
            this.splitContainer1.Panel1.Controls.Add(this.btnBorrar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DropFiles);
            this.splitContainer1.Size = new System.Drawing.Size(863, 553);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 0;
            // 
            // ReqFirmados
            // 
            this.ReqFirmados.AutoSize = true;
            this.ReqFirmados.Location = new System.Drawing.Point(15, 319);
            this.ReqFirmados.Name = "ReqFirmados";
            this.ReqFirmados.Size = new System.Drawing.Size(118, 17);
            this.ReqFirmados.TabIndex = 9;
            this.ReqFirmados.Text = "Req. Firmados PDF";
            this.ReqFirmados.UseVisualStyleBackColor = true;
            this.ReqFirmados.Visible = false;
            // 
            // chRemplazo
            // 
            this.chRemplazo.AutoSize = true;
            this.chRemplazo.Location = new System.Drawing.Point(15, 353);
            this.chRemplazo.Name = "chRemplazo";
            this.chRemplazo.Size = new System.Drawing.Size(106, 17);
            this.chRemplazo.TabIndex = 8;
            this.chRemplazo.Text = "Reemplazar PDF";
            this.chRemplazo.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(94, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre Emision:";
            // 
            // lblEmision
            // 
            this.lblEmision.AutoSize = true;
            this.lblEmision.Location = new System.Drawing.Point(150, 27);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(35, 13);
            this.lblEmision.TabIndex = 5;
            this.lblEmision.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emisión:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(38, 27);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(35, 13);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 276);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(110, 276);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // DropFiles
            // 
            this.DropFiles.AllowDrop = true;
            this.DropFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DropFiles.FormattingEnabled = true;
            this.DropFiles.Location = new System.Drawing.Point(0, 0);
            this.DropFiles.Name = "DropFiles";
            this.DropFiles.Size = new System.Drawing.Size(573, 553);
            this.DropFiles.TabIndex = 0;
            this.DropFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropFiles_DragDrop);
            this.DropFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropFiles_DragEnter);
            // 
            // splitDivisor
            // 
            this.splitDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDivisor.Location = new System.Drawing.Point(0, 0);
            this.splitDivisor.Name = "splitDivisor";
            this.splitDivisor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitDivisor.Panel1
            // 
            this.splitDivisor.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitDivisor.Panel2
            // 
            this.splitDivisor.Panel2.Controls.Add(this.toolStrip1);
            this.splitDivisor.Size = new System.Drawing.Size(863, 584);
            this.splitDivisor.SplitterDistance = 553;
            this.splitDivisor.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tpbProgresBar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(863, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tpbProgresBar
            // 
            this.tpbProgresBar.Name = "tpbProgresBar";
            this.tpbProgresBar.Size = new System.Drawing.Size(100, 24);
            // 
            // DragDropPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 584);
            this.Controls.Add(this.splitDivisor);
            this.Name = "DragDropPDF";
            this.Text = " ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitDivisor.Panel1.ResumeLayout(false);
            this.splitDivisor.Panel2.ResumeLayout(false);
            this.splitDivisor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDivisor)).EndInit();
            this.splitDivisor.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox DropFiles;
        private System.Windows.Forms.SplitContainer splitDivisor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripProgressBar tpbProgresBar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chRemplazo;
        private System.Windows.Forms.CheckBox ReqFirmados;
    }
}