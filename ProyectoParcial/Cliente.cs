using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Data;

namespace ProyectoParcial
{
    public class Cliente
    {
        private string cedula;
        private string nombre;
        private string apellido;
        private string correo;
        private string contrasena;
        public string telefono;

        internal static string[] LlenarCampos(int id)
        {
            SqlCommand sql = new SqlCommand();
            ConexionProyect cn = new ConexionProyect();
            string msj = cn.conectar();
            Cliente e = null;
            List<Cliente> cliente = new List<Cliente>();
            SqlDataReader dr = null;
            string nombre = null;
            string[] datos = new string[9];
            try
            {
                sql.Connection = cn.Cn;
                sql.CommandText = "SELECT * from reservas inner join Cliente on reservas.idCliente = Cliente.IdClient inner join taxi on reservas.idTaxi = taxi.Id where reservas.Id = " + id;
                dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    datos[0] = (dr["fechaViaje"].ToString());
                    datos[1] = (dr["rangoViaje"].ToString());
                    datos[2] = (dr["puntoOrigen"].ToString());
                    datos[3] = (dr["puntoDestino"].ToString());
                    datos[4] = (dr["numeroMaletas"].ToString());
                    datos[5] = (dr["placaTaxi"].ToString());
                    datos[6] = (dr["Nombre"].ToString());
                    datos[7] = (dr["Apellido"].ToString());
                    datos[8] = (dr["Cedula"].ToString());

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error causado por: " + ex.Message);
            }
            cn.cerrar();
            return datos;
        }

        internal static string EditarReserva(int id,decimal rango, string fecha, decimal numeroMaletas, string origen, string destino, int idCliente, string placa)
        {
            SqlCommand sql = new SqlCommand();
            ConexionProyect cn = new ConexionProyect();
            string msj = cn.conectar();
            SqlDataReader dr = null;
            int idTaxi = buscarPlacaTaxi(placa);
            try
            {
                sql.Connection = cn.Cn;
                sql.CommandText = "UPDATE reservas set fechaViaje = '"+ fecha +"', rangoViaje = "+rango+", puntoOrigen = '"+origen+"' , puntoDestino = '"+destino+"' , numeroMaletas = "+ numeroMaletas+", idTaxi = "+idTaxi+" Where Id="+id;
                sql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
            cn.cerrar();
            return "0";
        }

        public Cliente() { }
        public Cliente(string cedula, string nombre, string apellido, string correo, string contrasena)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.contrasena = contrasena;
        }

        internal static List<string> LlenarComboPlacaTaxi()
        {
            SqlCommand sql = new SqlCommand();
            ConexionProyect cn = new ConexionProyect();
            string msj = cn.conectar();
            List<string> lista = new List<string>();
            SqlDataReader dr = null;
            try
            {
                sql.Connection = cn.Cn;
                sql.CommandText = "SELECT * from taxi";
                dr = sql.ExecuteReader();
               
                while (dr.Read())
                {
                    lista.Add(dr["placaTaxi"].ToString());
                   
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error causado por: " + ex.Message);
            }
            cn.cerrar();
            return lista; 
        }

        internal static void LlenaDataGrid(DataGridView dataGridReservas, int id)
        {
            SqlCommand sql = new SqlCommand();
            ConexionProyect cn = new ConexionProyect();
            string msj = cn.conectar();
            SqlDataReader dr = null;
            try
            {
                sql.Connection = cn.Cn;
                sql.CommandText = "SELECT * from reservas inner join Cliente on reservas.idCliente = Cliente.IdClient inner join taxi on reservas.idTaxi = taxi.Id where Cliente.IdClient = "+id;
                dr = sql.ExecuteReader();
                
                while (dr.Read())
                {
                    int numerofila = dataGridReservas.Rows.Count;
                    dataGridReservas.Rows.Add(1);
                    dataGridReservas.Rows[numerofila].Cells[0].Value = dr["Id"].ToString();
                    dataGridReservas.Rows[numerofila].Cells[1].Value = dr["placaTaxi"].ToString();
                    dataGridReservas.Rows[numerofila].Cells[2].Value = dr["puntoDestino"].ToString();
                    dataGridReservas.Rows[numerofila].Cells[3].Value = dr["puntoOrigen"].ToString();
                    dataGridReservas.Rows[numerofila].Cells[4].Value = Convert.ToDateTime(dr["fechaViaje"]).ToString("dd-MM-yyyy");
                    dataGridReservas.Rows[numerofila].Cells[5].Value = dr["numeroMaletas"].ToString();
                    dataGridReservas.Rows[numerofila].Cells[6].Value = "Eliminar";
                    dataGridReservas.Rows[numerofila].Cells[7].Value = "Editar";
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error causado por: " + ex.Message);
            }
            cn.cerrar();
        }

        internal static void EliminarReserva(int id_reserva)
        {
            SqlCommand sql = new SqlCommand();
            ConexionProyect cn = new ConexionProyect();
            string msj = cn.conectar();
            SqlDataReader dr = null;
            try
            {
                sql.Connection = cn.Cn;
                sql.CommandText = "DELETE FROM reservas WHERE Id = "+id_reserva;
                sql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error causado por: " + ex.Message);
            }
            cn.cerrar();
           
        }

        public static string RegistrarReserva(decimal rango, string fecha, decimal numeroMaletas, string origen, string destino,int idCliente,string placa)
        {
            SqlCommand sql = new SqlCommand();
            ConexionProyect cn = new ConexionProyect();
            string msj = cn.conectar();
            SqlDataReader dr = null;
            int idPlaca = buscarPlacaTaxi(placa);
            try
            {
                sql.Connection = cn.Cn;
                sql.CommandText = "Insert Into reservas (idCliente, fechaViaje, rangoViaje, puntoOrigen, puntoDestino, numeroMaletas, idTaxi, estado) values("+ idCliente+", '"+ fecha + "',"+ rango + ", '"+ origen + "', '"+destino+"',"+ numeroMaletas + ", "+ idPlaca + ", 'A')";
                sql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
            cn.cerrar();
            return "0";
        }

        private static int buscarPlacaTaxi(string placa)
        {
            SqlCommand sql = new SqlCommand();
            ConexionProyect cn = new ConexionProyect();
            string msj = cn.conectar();
            SqlDataReader dr = null;
            int idPlaca = 0;
            try
            {
                sql.Connection = cn.Cn;
                sql.CommandText = "SELECT * from taxi where placaTaxi = '"+placa+"'";
                dr = sql.ExecuteReader();

                while (dr.Read())
                {
                   idPlaca= Convert.ToInt32((dr["Id"]));

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            cn.cerrar();
            return idPlaca;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }


        public static List<Cliente> BuscarclientePorCedula(string cedula)
        {
            SqlCommand sql = new SqlCommand();
            ConexionProyect cn = new ConexionProyect();
            string msj = cn.conectar();
            Cliente e = null;
            List<Cliente> cliente = new List<Cliente>();
            SqlDataReader dr = null;
            try
            {
                sql.Connection = cn.Cn;
                sql.CommandText = "SELECT * from Cliente where Cedula like"+ "'"+ cedula + "%'";
                dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    e = new Cliente();
                    e.nombre = dr["Nombre"].ToString();
                    e.cedula = dr["Cedula"].ToString();
                    e.apellido = dr["Apellido"].ToString();
                    e.correo = dr["Correo"].ToString();
                    e.contrasena = dr["Contrasena"].ToString();
                    cliente.Add(e);
                    msj = "1";
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error causado por: " + ex.Message);
            }
            cn.cerrar();
            return cliente;

            }

        internal static List<Cliente> BuscarclientePorNombre(string nombre)
        {
            SqlCommand sql = new SqlCommand();
            ConexionProyect cn = new ConexionProyect();
            string msj = cn.conectar();
            Cliente e = null;
            List<Cliente> cliente = new List<Cliente>();
            SqlDataReader dr = null;
            try
            {
                sql.Connection = cn.Cn;
                sql.CommandText = "SELECT * from Cliente where Nombre like" + "'" + nombre + "%'";
                dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    e = new Cliente();
                    e.nombre = dr["Nombre"].ToString();
                    e.cedula = dr["Cedula"].ToString();
                    e.apellido = dr["Apellido"].ToString();
                    e.correo = dr["Correo"].ToString();
                    e.contrasena = dr["Contrasena"].ToString();
                    cliente.Add(e);
                    msj = "1";
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error causado por: " + ex.Message);
            }
            cn.cerrar();
            return cliente;
        }
        public static int BuscarclienteLogin(string correo,string contrasena)
        {
            SqlCommand sql = new SqlCommand();
            ConexionProyect cn = new ConexionProyect();
            string msj = cn.conectar();
            Cliente e = null;
            List<Cliente> cliente = new List<Cliente>();
            SqlDataReader dr = null;
            int id=0;
            try
            {
                sql.Connection = cn.Cn;
                sql.CommandText = "SELECT *from Cliente where Correo="+"'"+correo+"' and Contrasena= '"+contrasena+"'";
                dr = sql.ExecuteReader();

                while (dr.Read()) { 
                    id= Convert.ToInt32(dr["IdClient"]);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error causado por: " + ex.Message);
            }
            cn.cerrar();
            return id;

        }
        public static string[] BuscarclienteID(int id)
        {
            SqlCommand sql = new SqlCommand();
            ConexionProyect cn = new ConexionProyect();
            string msj = cn.conectar();
            Cliente e = null;
            List<Cliente> cliente = new List<Cliente>();
            SqlDataReader dr = null;
            string nombre = null;
            string[] datos = new string[3];
            try
            {
                sql.Connection = cn.Cn;
                sql.CommandText = "SELECT *from Cliente where IdClient="+id;
                dr = sql.ExecuteReader();
                
                while (dr.Read())
                {
                    datos[0] = (dr["Nombre"].ToString());
                    datos[1] = (dr["Cedula"].ToString());
                    datos[2] = (dr["Apellido"].ToString());
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error causado por: " + ex.Message);
            }
            cn.cerrar();
            return datos;
        }
    }
}
