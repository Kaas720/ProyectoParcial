namespace ProyectoParcial
{
    partial class MenuPrincipal
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
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViajeDisponible = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReservaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaDestinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeleccionarRuta = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viajesToolStripMenuItem,
            this.ReservaMenu,
            this.taxisToolStripMenuItem,
            this.rutasToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViajeDisponible,
            this.eliminarToolStripMenuItem,
            this.crearToolStripMenuItem});
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.viajesToolStripMenuItem.Text = "Viajes";
            this.viajesToolStripMenuItem.Click += new System.EventHandler(this.viajesToolStripMenuItem_Click);
            // 
            // ViajeDisponible
            // 
            this.ViajeDisponible.Name = "ViajeDisponible";
            this.ViajeDisponible.Size = new System.Drawing.Size(165, 22);
            this.ViajeDisponible.Text = "ViajesDisponibles";
            this.ViajeDisponible.Click += new System.EventHandler(this.ViajeDisponible_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // ReservaMenu
            // 
            this.ReservaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaDestinoToolStripMenuItem});
            this.ReservaMenu.Name = "ReservaMenu";
            this.ReservaMenu.Size = new System.Drawing.Size(59, 20);
            this.ReservaMenu.Text = "Reserva";
            this.ReservaMenu.Click += new System.EventHandler(this.ReservaMenu_Click);
            // 
            // reservaDestinoToolStripMenuItem
            // 
            this.reservaDestinoToolStripMenuItem.Name = "reservaDestinoToolStripMenuItem";
            this.reservaDestinoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservaDestinoToolStripMenuItem.Text = "ReservaDestino";
            this.reservaDestinoToolStripMenuItem.Click += new System.EventHandler(this.reservaDestinoToolStripMenuItem_Click);
            // 
            // taxisToolStripMenuItem
            // 
            this.taxisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem});
            this.taxisToolStripMenuItem.Name = "taxisToolStripMenuItem";
            this.taxisToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.taxisToolStripMenuItem.Text = "Taxis";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // rutasToolStripMenuItem
            // 
            this.rutasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SeleccionarRuta});
            this.rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            this.rutasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.rutasToolStripMenuItem.Text = "Rutas";
            // 
            // SeleccionarRuta
            // 
            this.SeleccionarRuta.Name = "SeleccionarRuta";
            this.SeleccionarRuta.Size = new System.Drawing.Size(154, 22);
            this.SeleccionarRuta.Text = "SeleccioneRuta";
            this.SeleccionarRuta.Click += new System.EventHandler(this.SeleccionarRuta_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // busquedaUsuarioToolStripMenuItem
            // 
            this.busquedaUsuarioToolStripMenuItem.Name = "busquedaUsuarioToolStripMenuItem";
            this.busquedaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.busquedaUsuarioToolStripMenuItem.Text = "Busqueda Usuario";
            this.busquedaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.busquedaUsuarioToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(511, 379);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Logi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReservaMenu;
        private System.Windows.Forms.ToolStripMenuItem taxisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViajeDisponible;
        private System.Windows.Forms.ToolStripMenuItem reservaDestinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SeleccionarRuta;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaUsuarioToolStripMenuItem;
    }
}