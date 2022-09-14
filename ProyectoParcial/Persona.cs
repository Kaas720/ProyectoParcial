using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string correo;
        private string pago;
   


        public Persona(string nombre, string apellido, string correo, string pago)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.pago = pago;
          
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Pago
        {
            get { return pago; }
            set { pago = value; }

        }

        


    }
}
