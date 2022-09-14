
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ConexionProyect
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Miconexion"].ConnectionString;
        private SqlConnection cn = null;

        public SqlConnection Cn { get => cn; set => cn = value; }

        public string conectar()
        {
            string x = "Conexion exitosa";
            try
            {
                Cn = new SqlConnection();
                Cn.ConnectionString = cadena;
                x = "1";
                Cn.Open();
            }
            catch (Exception ex)
            {
                x = "Error causado por: " + ex.Message;
            }
            return x;
        }

        public string cerrar()
        {
            string x = "1";
            try
            {
                Cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                x = "Error causado por" + ex.Message;
            }
            return x;
        }
    }
}
