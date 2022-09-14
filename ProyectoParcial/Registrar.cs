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
    public partial class Registrar : Form
    {
        
        public Registrar()
        {
            InitializeComponent();
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            

            Login venta = new Login();
            this.Hide();
            venta.Show();
        }
        /*class User
        {
            // Dont forget to add // using System.Collections.Generic;
            // on top of the file otherwise List<> would not be available
            public static List<User> UserList = new List<User>();

            // make those fields public for accessibility
            public string Nombre;
            public string Password;
            public string Apelli;
            public int Cedu;

            public User(string Nombre, string Password, string Apelli, int Cedu)
            {
                // assign each fields with arguments from constructor
                this.Nombre = Nombre;
                this.Password = Password;
                this.Apelli = Apelli;
                this.Cedu = Cedu ;
            }

            public static void AddUserToList(User user)
            {
                UserList.Add(user);
            }
        */

        /*List<Contras> neo = new List<Contras>();*/
        private void buttRegistra_Click(object sender, EventArgs e)
        {

            /*string nombre = textNombre.Text;
            string apelli = textApell.Text;
            string cedu = textCedu.Text;
            string Corr = textCorreo.Text;
            string Contr = textCon.Text;
            string repi = textRepe.Text;
            // si los datos no estan ingresados se marcara que faltan datos
            if (nombre != "" && apelli != "" && cedu != "" && Corr != "" && Contr == repi)
            {
                MessageBox.Show("Estan llenos");
            }
            else
            {
                MessageBox.Show("Faltan datos o las contraseñas no coinciden");
            }
            */
            
            

            

        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textApell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textCedu_KeyPress(object sender, KeyPressEventArgs e)
        {
            textCedu.MaxLength = 10;
            if ( !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            { 

                e.Handled = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {


            Login venta = new Login();
            this.Hide();
            venta.Show();
        }
    }
}
