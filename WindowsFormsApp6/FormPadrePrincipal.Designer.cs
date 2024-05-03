namespace WindowsFormsApp6
{
    partial class FormPadrePrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAvance = new System.Windows.Forms.ToolStripMenuItem();
            this.JefeRif_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaReqRIF = new System.Windows.Forms.ToolStripMenuItem();
            this.MultasRIF_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaMultasRIF = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaOficiosRIF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOficiosReqRIF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOficiosMultasRIF = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaPDFRIF = new System.Windows.Forms.ToolStripMenuItem();
            this.requerimientosPDFRIF = new System.Windows.Forms.ToolStripMenuItem();
            this.multasPDFRIF = new System.Windows.Forms.ToolStripMenuItem();
            this.dATOSPLUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanceReqPLUS = new System.Windows.Forms.ToolStripMenuItem();
            this.requerimientosPLUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caputraReqPLUS = new System.Windows.Forms.ToolStripMenuItem();
            this.multasPLUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaMultaPLUS = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaOficiosPLUS = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaOficioRequerimientoPLUS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCapturaOficiosMulta = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaPDFPLUS = new System.Windows.Forms.ToolStripMenuItem();
            this.requerimientosPDFPLUS = new System.Windows.Forms.ToolStripMenuItem();
            this.multasPDFPLUS = new System.Windows.Forms.ToolStripMenuItem();
            this.notificadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBusquedaMasiva = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaRIF = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaPLUS = new System.Windows.Forms.ToolStripMenuItem();
            this.tableroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionMenu,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionMenu
            // 
            this.opcionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.dATOSPLUSToolStripMenuItem,
            this.notificadoresToolStripMenuItem,
            this.menuAgenda,
            this.toolStripSeparator1,
            this.usuarioToolStripMenuItem,
            this.menuCerrar});
            this.opcionMenu.Name = "opcionMenu";
            this.opcionMenu.Size = new System.Drawing.Size(50, 20);
            this.opcionMenu.Text = "&Menú";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAvance,
            this.JefeRif_Item,
            this.capturaReqRIF,
            this.MultasRIF_Item,
            this.capturaMultasRIF,
            this.capturaOficiosRIF,
            this.cargaPDFRIF});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "DATOS &RIF";
            this.toolStripMenuItem1.Visible = false;
            // 
            // menuAvance
            // 
            this.menuAvance.Name = "menuAvance";
            this.menuAvance.Size = new System.Drawing.Size(226, 22);
            this.menuAvance.Text = "Consulta &Avance";
            this.menuAvance.Visible = false;
            // 
            // JefeRif_Item
            // 
            this.JefeRif_Item.Name = "JefeRif_Item";
            this.JefeRif_Item.Size = new System.Drawing.Size(226, 22);
            this.JefeRif_Item.Text = "&Informes Requerimientos RIF";
            this.JefeRif_Item.Visible = false;
            this.JefeRif_Item.Click += new System.EventHandler(this.JefeRif_Item_Click);
            // 
            // capturaReqRIF
            // 
            this.capturaReqRIF.Name = "capturaReqRIF";
            this.capturaReqRIF.Size = new System.Drawing.Size(226, 22);
            this.capturaReqRIF.Text = "Captura &Requerimientos";
            this.capturaReqRIF.Click += new System.EventHandler(this.capturaReqRIF_Click);
            // 
            // MultasRIF_Item
            // 
            this.MultasRIF_Item.Name = "MultasRIF_Item";
            this.MultasRIF_Item.Size = new System.Drawing.Size(226, 22);
            this.MultasRIF_Item.Text = "Informes M&ultas RIF";
            this.MultasRIF_Item.Visible = false;
            this.MultasRIF_Item.Click += new System.EventHandler(this.MultasRIF_Item_Click);
            // 
            // capturaMultasRIF
            // 
            this.capturaMultasRIF.Name = "capturaMultasRIF";
            this.capturaMultasRIF.Size = new System.Drawing.Size(226, 22);
            this.capturaMultasRIF.Text = "Captura &Multas";
            this.capturaMultasRIF.Click += new System.EventHandler(this.capturaMultasRIF_Click);
            // 
            // capturaOficiosRIF
            // 
            this.capturaOficiosRIF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOficiosReqRIF,
            this.tsOficiosMultasRIF});
            this.capturaOficiosRIF.Name = "capturaOficiosRIF";
            this.capturaOficiosRIF.Size = new System.Drawing.Size(226, 22);
            this.capturaOficiosRIF.Text = "Captura &Oficios";
            this.capturaOficiosRIF.Visible = false;
            // 
            // tsOficiosReqRIF
            // 
            this.tsOficiosReqRIF.Name = "tsOficiosReqRIF";
            this.tsOficiosReqRIF.Size = new System.Drawing.Size(157, 22);
            this.tsOficiosReqRIF.Text = "Requerimientos";
            this.tsOficiosReqRIF.Click += new System.EventHandler(this.tsOficiosReqRIF_Click);
            // 
            // tsOficiosMultasRIF
            // 
            this.tsOficiosMultasRIF.Name = "tsOficiosMultasRIF";
            this.tsOficiosMultasRIF.Size = new System.Drawing.Size(157, 22);
            this.tsOficiosMultasRIF.Text = "Multas";
            this.tsOficiosMultasRIF.Click += new System.EventHandler(this.tsOficiosMultasRIF_Click);
            // 
            // cargaPDFRIF
            // 
            this.cargaPDFRIF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requerimientosPDFRIF,
            this.multasPDFRIF});
            this.cargaPDFRIF.Name = "cargaPDFRIF";
            this.cargaPDFRIF.Size = new System.Drawing.Size(226, 22);
            this.cargaPDFRIF.Text = "Carga &PDF";
            // 
            // requerimientosPDFRIF
            // 
            this.requerimientosPDFRIF.Name = "requerimientosPDFRIF";
            this.requerimientosPDFRIF.Size = new System.Drawing.Size(157, 22);
            this.requerimientosPDFRIF.Text = "&Requerimientos";
            this.requerimientosPDFRIF.Click += new System.EventHandler(this.requerimientosPDFRIF_Click);
            // 
            // multasPDFRIF
            // 
            this.multasPDFRIF.Name = "multasPDFRIF";
            this.multasPDFRIF.Size = new System.Drawing.Size(157, 22);
            this.multasPDFRIF.Text = "&Multas";
            this.multasPDFRIF.Click += new System.EventHandler(this.multasPDFRIF_Click);
            // 
            // dATOSPLUSToolStripMenuItem
            // 
            this.dATOSPLUSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avanceReqPLUS,
            this.requerimientosPLUSToolStripMenuItem,
            this.caputraReqPLUS,
            this.multasPLUSToolStripMenuItem,
            this.capturaMultaPLUS,
            this.capturaOficiosPLUS,
            this.cargaPDFPLUS});
            this.dATOSPLUSToolStripMenuItem.Name = "dATOSPLUSToolStripMenuItem";
            this.dATOSPLUSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dATOSPLUSToolStripMenuItem.Text = "DATOS &PLUS";
            // 
            // avanceReqPLUS
            // 
            this.avanceReqPLUS.Name = "avanceReqPLUS";
            this.avanceReqPLUS.Size = new System.Drawing.Size(232, 22);
            this.avanceReqPLUS.Text = "Consulta &Avance";
            this.avanceReqPLUS.Visible = false;
            this.avanceReqPLUS.Click += new System.EventHandler(this.avanceReqPLUS_Click);
            // 
            // requerimientosPLUSToolStripMenuItem
            // 
            this.requerimientosPLUSToolStripMenuItem.Name = "requerimientosPLUSToolStripMenuItem";
            this.requerimientosPLUSToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.requerimientosPLUSToolStripMenuItem.Text = "&Informe Requerimientos PLUS";
            this.requerimientosPLUSToolStripMenuItem.Visible = false;
            this.requerimientosPLUSToolStripMenuItem.Click += new System.EventHandler(this.requerimientosPLUSToolStripMenuItem_Click);
            // 
            // caputraReqPLUS
            // 
            this.caputraReqPLUS.Name = "caputraReqPLUS";
            this.caputraReqPLUS.Size = new System.Drawing.Size(232, 22);
            this.caputraReqPLUS.Text = "Captura &Requerimientos PLUS";
            this.caputraReqPLUS.Click += new System.EventHandler(this.caputraReqPLUS_Click);
            // 
            // multasPLUSToolStripMenuItem
            // 
            this.multasPLUSToolStripMenuItem.Name = "multasPLUSToolStripMenuItem";
            this.multasPLUSToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.multasPLUSToolStripMenuItem.Text = "Informe M&ultas PLUS";
            this.multasPLUSToolStripMenuItem.Visible = false;
            this.multasPLUSToolStripMenuItem.Click += new System.EventHandler(this.multasPLUSToolStripMenuItem_Click);
            // 
            // capturaMultaPLUS
            // 
            this.capturaMultaPLUS.Name = "capturaMultaPLUS";
            this.capturaMultaPLUS.Size = new System.Drawing.Size(232, 22);
            this.capturaMultaPLUS.Text = "Captura &Multas PLUS";
            this.capturaMultaPLUS.Click += new System.EventHandler(this.capturaMultaPLUS_Click);
            // 
            // capturaOficiosPLUS
            // 
            this.capturaOficiosPLUS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturaOficioRequerimientoPLUS,
            this.tsCapturaOficiosMulta});
            this.capturaOficiosPLUS.Name = "capturaOficiosPLUS";
            this.capturaOficiosPLUS.Size = new System.Drawing.Size(232, 22);
            this.capturaOficiosPLUS.Text = "Captura &Oficios";
            this.capturaOficiosPLUS.Visible = false;
            // 
            // capturaOficioRequerimientoPLUS
            // 
            this.capturaOficioRequerimientoPLUS.Name = "capturaOficioRequerimientoPLUS";
            this.capturaOficioRequerimientoPLUS.Size = new System.Drawing.Size(157, 22);
            this.capturaOficioRequerimientoPLUS.Text = "Requerimientos";
            this.capturaOficioRequerimientoPLUS.Click += new System.EventHandler(this.capturaOficioRequerimientoPLUS_Click);
            // 
            // tsCapturaOficiosMulta
            // 
            this.tsCapturaOficiosMulta.Name = "tsCapturaOficiosMulta";
            this.tsCapturaOficiosMulta.Size = new System.Drawing.Size(157, 22);
            this.tsCapturaOficiosMulta.Text = "Multas";
            this.tsCapturaOficiosMulta.Click += new System.EventHandler(this.tsCapturaOficiosMulta_Click);
            // 
            // cargaPDFPLUS
            // 
            this.cargaPDFPLUS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requerimientosPDFPLUS,
            this.multasPDFPLUS});
            this.cargaPDFPLUS.Name = "cargaPDFPLUS";
            this.cargaPDFPLUS.Size = new System.Drawing.Size(232, 22);
            this.cargaPDFPLUS.Text = "Carga &PDF";
            this.cargaPDFPLUS.Click += new System.EventHandler(this.cargaPDFPLUS_Click);
            // 
            // requerimientosPDFPLUS
            // 
            this.requerimientosPDFPLUS.Name = "requerimientosPDFPLUS";
            this.requerimientosPDFPLUS.Size = new System.Drawing.Size(180, 22);
            this.requerimientosPDFPLUS.Text = "&Requerimientos";
            this.requerimientosPDFPLUS.Click += new System.EventHandler(this.requerimientosPDFPLUS_Click);
            // 
            // multasPDFPLUS
            // 
            this.multasPDFPLUS.Name = "multasPDFPLUS";
            this.multasPDFPLUS.Size = new System.Drawing.Size(180, 22);
            this.multasPDFPLUS.Text = "&Multas";
            this.multasPDFPLUS.Click += new System.EventHandler(this.multasPDFPLUS_Click);
            // 
            // notificadoresToolStripMenuItem
            // 
            this.notificadoresToolStripMenuItem.Name = "notificadoresToolStripMenuItem";
            this.notificadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notificadoresToolStripMenuItem.Text = "&Notificadores";
            this.notificadoresToolStripMenuItem.Click += new System.EventHandler(this.notificadoresToolStripMenuItem_Click);
            // 
            // menuAgenda
            // 
            this.menuAgenda.MergeIndex = 2;
            this.menuAgenda.Name = "menuAgenda";
            this.menuAgenda.Size = new System.Drawing.Size(180, 22);
            this.menuAgenda.Text = "A&genda";
            this.menuAgenda.Click += new System.EventHandler(this.menuAgenda_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem.Text = "&Usuario";
            // 
            // menuCerrar
            // 
            this.menuCerrar.MergeIndex = 3;
            this.menuCerrar.Name = "menuCerrar";
            this.menuCerrar.Size = new System.Drawing.Size(180, 22);
            this.menuCerrar.Text = "&Cerrar";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBusquedaMasiva,
            this.tableroToolStripMenuItem,
            this.muestraToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // menuBusquedaMasiva
            // 
            this.menuBusquedaMasiva.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaRIF,
            this.busquedaPLUS});
            this.menuBusquedaMasiva.Name = "menuBusquedaMasiva";
            this.menuBusquedaMasiva.Size = new System.Drawing.Size(209, 22);
            this.menuBusquedaMasiva.Text = "&Busqueda requerimientos";
            // 
            // busquedaRIF
            // 
            this.busquedaRIF.Name = "busquedaRIF";
            this.busquedaRIF.Size = new System.Drawing.Size(101, 22);
            this.busquedaRIF.Text = "RIF";
            this.busquedaRIF.Click += new System.EventHandler(this.busquedaRIF_Click);
            // 
            // busquedaPLUS
            // 
            this.busquedaPLUS.Name = "busquedaPLUS";
            this.busquedaPLUS.Size = new System.Drawing.Size(101, 22);
            this.busquedaPLUS.Text = "PLUS";
            this.busquedaPLUS.Click += new System.EventHandler(this.busquedaPLUS_Click);
            // 
            // tableroToolStripMenuItem
            // 
            this.tableroToolStripMenuItem.Name = "tableroToolStripMenuItem";
            this.tableroToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.tableroToolStripMenuItem.Text = "Tablero";
            this.tableroToolStripMenuItem.Visible = false;
            // 
            // muestraToolStripMenuItem
            // 
            this.muestraToolStripMenuItem.Name = "muestraToolStripMenuItem";
            this.muestraToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.muestraToolStripMenuItem.Text = "muestra";
            this.muestraToolStripMenuItem.Visible = false;
            // 
            // FormPadrePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPadrePrincipal";
            this.Text = "Oficina digital";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionMenu;
        private System.Windows.Forms.ToolStripMenuItem menuAgenda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuCerrar;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBusquedaMasiva;
        private System.Windows.Forms.ToolStripMenuItem tableroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem capturaReqRIF;
        private System.Windows.Forms.ToolStripMenuItem capturaMultasRIF;
        private System.Windows.Forms.ToolStripMenuItem dATOSPLUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanceReqPLUS;
        private System.Windows.Forms.ToolStripMenuItem caputraReqPLUS;
        private System.Windows.Forms.ToolStripMenuItem capturaMultaPLUS;
        private System.Windows.Forms.ToolStripMenuItem busquedaRIF;
        private System.Windows.Forms.ToolStripMenuItem busquedaPLUS;
        private System.Windows.Forms.ToolStripMenuItem JefeRif_Item;
        private System.Windows.Forms.ToolStripMenuItem MultasRIF_Item;
        private System.Windows.Forms.ToolStripMenuItem requerimientosPLUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multasPLUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturaOficiosRIF;
        private System.Windows.Forms.ToolStripMenuItem capturaOficiosPLUS;
        private System.Windows.Forms.ToolStripMenuItem tsOficiosReqRIF;
        private System.Windows.Forms.ToolStripMenuItem tsOficiosMultasRIF;
        private System.Windows.Forms.ToolStripMenuItem capturaOficioRequerimientoPLUS;
        private System.Windows.Forms.ToolStripMenuItem tsCapturaOficiosMulta;
        private System.Windows.Forms.ToolStripMenuItem cargaPDFRIF;
        private System.Windows.Forms.ToolStripMenuItem requerimientosPDFRIF;
        private System.Windows.Forms.ToolStripMenuItem multasPDFRIF;
        private System.Windows.Forms.ToolStripMenuItem cargaPDFPLUS;
        private System.Windows.Forms.ToolStripMenuItem requerimientosPDFPLUS;
        private System.Windows.Forms.ToolStripMenuItem multasPDFPLUS;
        private System.Windows.Forms.ToolStripMenuItem menuAvance;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificadoresToolStripMenuItem;
    }
}