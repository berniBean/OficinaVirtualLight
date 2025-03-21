namespace WindowsFormsApp6
{
    partial class FormEditorCreador
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
            this.tabCrear = new System.Windows.Forms.TabControl();
            this.tabContainer = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabCrear.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCrear
            // 
            this.tabCrear.Controls.Add(this.tabContainer);
            this.tabCrear.Controls.Add(this.tabPage2);
            this.tabCrear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCrear.Location = new System.Drawing.Point(0, 0);
            this.tabCrear.Name = "tabCrear";
            this.tabCrear.SelectedIndex = 0;
            this.tabCrear.Size = new System.Drawing.Size(1472, 784);
            this.tabCrear.TabIndex = 0;
            // 
            // tabContainer
            // 
            this.tabContainer.Location = new System.Drawing.Point(4, 29);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.Padding = new System.Windows.Forms.Padding(3);
            this.tabContainer.Size = new System.Drawing.Size(1464, 751);
            this.tabContainer.TabIndex = 0;
            this.tabContainer.Text = "Nueva emisión";
            this.tabContainer.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1464, 751);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormEditorCreador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 784);
            this.Controls.Add(this.tabCrear);
            this.Name = "FormEditorCreador";
            this.Text = "Editor emisión requerimientos";
            this.Load += new System.EventHandler(this.FormEditorCreador_Load);
            this.tabCrear.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCrear;
        private System.Windows.Forms.TabPage tabContainer;
        private System.Windows.Forms.TabPage tabPage2;
    }
}