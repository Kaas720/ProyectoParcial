using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlop
{
    public class Class1
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;
        public string Apellido
        {            
             get { return apellido; }
             set { apellido = value; }            
        }
        private int cedula;
        public int Cedula
        {
            
             get { return cedula; }
             set { cedula = value; }
            
        }
        private string correo;
        public string Correo
        {
            
             get { return nombre; }
             set { nombre = value; }
            
        }
        public Class1()
        {

        }

        public Class1(string nombre, string apellido, int cedula, string correo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.correo = correo;
        }
    }
}
