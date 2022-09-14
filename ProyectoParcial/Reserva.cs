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
    public partial class Reserva : Form
    {
        List<Persona> personasAgregados = new List<Persona>();
        List<Persona> personasEliminadas = new List<Persona>();
        private int id = 0;
        public Reserva(int id)
        {
            InitializeComponent();
            this.id = id;
            TextNombre.Text = Cliente.BuscarclienteID(id)[0];
            textCedula.Text = Cliente.BuscarclienteID(id)[1];
            textApellido.Text = Cliente.BuscarclienteID(id)[2];
            List<string> taxi = Cliente.LlenarComboPlacaTaxi();
            foreach (string placa in taxi)
            {
                ComboBoxTaxi.Items.Add(placa);
            }
            reservasDataGrid(id);
        }

        private void reservasDataGrid(int id)
        {
            Cliente.LlenaDataGrid(DataGridReservas,id);
        }

        private void Reserva_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textPuntoDestino.Text) && !String.IsNullOrEmpty(textPuntoOrigen.Text) && !String.IsNullOrEmpty(ComboBoxTaxi.Text))
            {
                DateTime FechaActual = DateTime.Today;
                if (fechaViaje.Value.Date  >= FechaActual)
                {
                    string fecha = fechaViaje.Value.Date.ToString("d", CultureInfo.CreateSpecificCulture("en-US"));
                    string valor = Cliente.RegistrarReserva(bb.Value, fecha, numeroMa.Value, textPuntoOrigen.Text, textPuntoDestino.Text, id, ComboBoxTaxi.Text);
                    if (valor == "0")
                    {
                        MessageBox.Show("Se reservo correctamente");
                        DataGridReservas.Rows.Clear();
                        reservasDataGrid(id);
                    }
                    else
                    {
                        MessageBox.Show("No se reservo: "+ valor);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede seleccionar una fecha pasada");
                }
            }
            else
            {
                MessageBox.Show("Existe datos vacios");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DataGridReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int x = DataGridReservas.CurrentCell.RowIndex;
                int id_reserva = Convert.ToInt32(DataGridReservas.Rows[x].Cells[0].Value.ToString());
                Cliente.EliminarReserva(id_reserva);
                MessageBox.Show("eliminado con exito");
                DataGridReservas.Rows.Remove(DataGridReservas.CurrentRow);
            }
            if (e.ColumnIndex == 7)
            {
                int x = DataGridReservas.CurrentCell.RowIndex;
                int id_reserva = Convert.ToInt32(DataGridReservas.Rows[x].Cells[0].Value.ToString());
                EditarReserva formulario = new EditarReserva(id_reserva);
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.ShowDialog();
                DataGridReservas.Rows.Clear();
                reservasDataGrid(id);
            }
        }
    }
}
     
