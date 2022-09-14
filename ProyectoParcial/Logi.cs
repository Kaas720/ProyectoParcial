using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParcial
{
    public partial class MenuPrincipal : Form
    {
        private int id = 0;
        public MenuPrincipal(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Logi_Load(object sender, EventArgs e)
        {

        }

        private void ViajeDisponible_Click(object sender, EventArgs e)
        {
            Disponibilidad_Viaje formulario = new Disponibilidad_Viaje();
            this.IsMdiContainer = true;
            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.Show();
        }

        private void reservaDestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reserva formulario = new Reserva(id);
            this.IsMdiContainer = true;
            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.Show();

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro formulario = new Registro();
            this.IsMdiContainer = true;
            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.Show();
        }

        private void SeleccionarRuta_Click(object sender, EventArgs e)
        {
            TipoRuta formulario = new TipoRuta();
            this.IsMdiContainer = true;
            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.Show();
        }

        private void ReservaMenu_Click(object sender, EventArgs e)
        {

        }

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void busquedaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarUsuario formulario = new BuscarUsuario();
            this.IsMdiContainer = true;
            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.Show();
        }
    }
}
