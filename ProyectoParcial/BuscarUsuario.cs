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
    public partial class BuscarUsuario : Form
    {
        public BuscarUsuario()
        {
            InitializeComponent();
            rellenarDataGridInicio("");
        }
        public void rellenarDataGridInicio(string x)
        {
            dataCliente.Rows.Clear();
            List<Cliente> listaNueva = Cliente.BuscarclientePorCedula(x);
            if (listaNueva.Count == 0)
            {
                MessageBox.Show("No existe cliente registrado");
            }
            else
            {
                foreach (Cliente c in listaNueva)
                {
                    int numerofila = dataCliente.Rows.Count;
                    dataCliente.Rows.Add(1);
                    dataCliente.Rows[numerofila].Cells[0].Value = c.Cedula;
                    dataCliente.Rows[numerofila].Cells[1].Value = c.Apellido;
                    dataCliente.Rows[numerofila].Cells[2].Value = c.Nombre;
                }
               
            }
        }
        public void rellenarDataGridNombre()
        {
            dataCliente.Rows.Clear();
            List<Cliente> listaNueva = Cliente.BuscarclientePorNombre(txtNombre.Text);
            if (listaNueva.Count == 0)
            {
                MessageBox.Show("No existe cliente registrado");
            }
            else
            {
                foreach (Cliente c in listaNueva)
                {
                    int numerofila = dataCliente.Rows.Count;
                    dataCliente.Rows.Add(1);
                    dataCliente.Rows[numerofila].Cells[0].Value = c.Cedula;
                    dataCliente.Rows[numerofila].Cells[1].Value = c.Apellido;
                    dataCliente.Rows[numerofila].Cells[2].Value = c.Nombre;
                }

            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txCedula.Enabled == true)
            {
                rellenarDataGridInicio(txCedula.Text);
            }
            else
            {
                rellenarDataGridNombre();
            }
            
        }

        private void ckNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txCedula.Enabled = false;
        }

        private void ckCedula_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txCedula.Enabled = true;
        }
    }
}
