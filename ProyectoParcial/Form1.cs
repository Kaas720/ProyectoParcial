using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using ProyectoParcial;


namespace ProyectoParcial
{
    public partial class Login : Form
    {
        List<Usuario> user;
        public MenuPrincipal formularioPrinci;
        

        public Login()
        {
            InitializeComponent();
            textContra.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carga();
        }
        private void carga()
        {
           
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Registrar formil = new Registrar();
            formil.Show();
            this.Hide();
            
        }

        private void buttLogin_Click(object sender, EventArgs e)
        {
            buscarUsuario();
        }

        private void buscarUsuario()
        {
            int id = Cliente.BuscarclienteLogin(TextCorreo.Text, textContra.Text);
            if (id == 0)
            {
                MessageBox.Show("Usuario no registrado");
            }
            else
            {
                formularioPrinci = new MenuPrincipal(id);
                formularioPrinci.Show();
                //ocultar pantalla login
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
