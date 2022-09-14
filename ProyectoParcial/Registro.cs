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
    public partial class Registro : Form
    {
        List<Vehiculo> vehiculoAgregados = new List<Vehiculo>();
        List<Vehiculo> vehiculoEliminados = new List<Vehiculo>();
        public Registro()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();

            DialogResult r = MessageBox.Show("Está seguro de guardar los datos del vehiculo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                vehiculoAgregados.Add(new Vehiculo(txtmarca.Text, txtmodelo.Text, txtcolor.Text, txtplaca.Text, txtmatricula.Text));

                for (int i = 0; i < vehiculoAgregados.Count; i++)
                {
                    ListViewItem lista = new ListViewItem(vehiculoAgregados[i].Marca);
                    lista.SubItems.Add(vehiculoAgregados[i].Modelo);
                    lista.SubItems.Add(vehiculoAgregados[i].Color);
                    lista.SubItems.Add(vehiculoAgregados[i].Placa);
                    lista.SubItems.Add(vehiculoAgregados[i].Matricula);
                    Lista.Items.Add(lista);

                }

            }
            else
            {
                for (int i = 0; i < vehiculoAgregados.Count; i++)
                {
                    ListViewItem lista = new ListViewItem(vehiculoAgregados[i].Marca);
                    lista.SubItems.Add(vehiculoAgregados[i].Modelo);
                    lista.SubItems.Add(vehiculoAgregados[i].Color);
                    lista.SubItems.Add(vehiculoAgregados[i].Placa);
                    lista.SubItems.Add(vehiculoAgregados[i].Matricula);
                    Lista.Items.Add(lista);

                }

            }

            txtLabel.Text = "                    ";

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();

            for (int i = 0; i < vehiculoAgregados.Count; i++)
            {
                ListViewItem lista2 = new ListViewItem(vehiculoAgregados[i].Marca);
                lista2.SubItems.Add(vehiculoAgregados[i].Modelo);
                lista2.SubItems.Add(vehiculoAgregados[i].Color);
                lista2.SubItems.Add(vehiculoAgregados[i].Placa);
                lista2.SubItems.Add(vehiculoAgregados[i].Matricula);
                Lista.Items.Add(lista2);

            }

            txtLabel.Text = "ELEMENTOS GUARDADOS";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult j = MessageBox.Show("Estas seguro de querer eliminar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (j == DialogResult.Yes)
            {
                vehiculoEliminados.Add(new Vehiculo(vehiculoAgregados[Lista.FocusedItem.Index].Marca, vehiculoAgregados[Lista.FocusedItem.Index].Modelo, vehiculoAgregados[Lista.FocusedItem.Index].Color, vehiculoAgregados[Lista.FocusedItem.Index].Placa, vehiculoAgregados[Lista.FocusedItem.Index].Matricula));
                vehiculoEliminados.RemoveAt(Lista.FocusedItem.Index);
                Lista.Items.Clear();

                for (int i = 0; i < vehiculoAgregados.Count; i++)
                {
                    ListViewItem lista3 = new ListViewItem(vehiculoAgregados[i].Marca);
                    lista3.SubItems.Add(vehiculoAgregados[i].Modelo);
                    lista3.SubItems.Add(vehiculoAgregados[i].Color);
                    lista3.SubItems.Add(vehiculoAgregados[i].Placa);
                    lista3.SubItems.Add(vehiculoAgregados[i].Matricula);
                    Lista.Items.Add(lista3);

                }

            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }

        
    }

