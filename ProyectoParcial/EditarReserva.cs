using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParcial
{
    public partial class EditarReserva : Form
    {
        private int id = 0;
        public EditarReserva(int id)
        {
            InitializeComponent();
            this.id = id;
            string[] lista =Cliente.LlenarCampos(id);
            textCedula.Text = lista[8];
            TextNombre.Text = lista[6];
            textApellido.Text = lista[7];
            rangoViaje.Value = Convert.ToDecimal(lista[1]);
            fechaViaje.Text = lista[0];
            ComboBoxTaxi.Text = lista[5];
            textPuntoDestino.Text = lista[3];   
            textPuntoOrigen.Text = lista[2];
            numeroMa.Value = Convert.ToDecimal(lista[4]);
            List<string> taxi = Cliente.LlenarComboPlacaTaxi();
            foreach (string placa in taxi)
            {
                ComboBoxTaxi.Items.Add(placa);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textPuntoDestino.Text) && !String.IsNullOrEmpty(ComboBoxTaxi.Text)  && !String.IsNullOrEmpty(textPuntoOrigen.Text))
            {
                DateTime FechaActual = DateTime.Today;
                if (fechaViaje.Value.Date >= FechaActual)
                {
                    string fecha = fechaViaje.Value.Date.ToString("d", CultureInfo.CreateSpecificCulture("en-US"));
                    string texto = Cliente.EditarReserva(id, rangoViaje.Value, fecha, numeroMa.Value, textPuntoOrigen.Text, textPuntoDestino.Text, id, ComboBoxTaxi.Text);
                    if (texto == "0")
                    {
                        MessageBox.Show("Se edito correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al editar por: "+texto);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede seleccionar una fecha pasada:");
                }
            }
            else
            {
                MessageBox.Show("Existe datos vacios");
            }
        }
    }
}
