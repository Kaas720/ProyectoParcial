using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlop
{
    public  class Contras 
    {
        private string contrasena;

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        
        public Contras()
        {

        }

        public Contras(string contrasena, string usuario)
        {
            this.contrasena = contrasena;
            this.usuario = usuario;
        }
    }
}
