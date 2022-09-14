using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial
{
    public class Vehiculo
    {
        private string marca;
        private string modelo;
        private string color;
        private string placa;
        private string matricula;



        public Vehiculo(string marca, string modelo, string color, string placa, string matricula)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.placa = placa;
            this.matricula = matricula;
        }


        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }

        }

        public string Color
        {
            get { return color; }
            set { color = value; }

        }


    }
}
