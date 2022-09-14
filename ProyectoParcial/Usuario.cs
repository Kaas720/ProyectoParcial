using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial
{
    class Usuario
    {
        public string correo;
        public string contrasena;
        public string nombre;
        public string apellido;
        public string cedula;
        public string telefono;
        public Usuario(string correo, string contrasena, string nombre, string apellido, string cedula, string telefono)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            this.apellido = apellido;
            this.nombre = nombre;
            this.cedula = cedula;
            this.telefono = telefono;
        }

        public Usuario()
        {

        }
        public static Usuario BuscarUsuario(string cedula)
        {

            return null;
        }
    }
}
