using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RegistroServicios
{
    class conexion
    {
        String query = "Data Source=localhost;Initial Catalog=bd_reparacion;Integrated Security=True;";
        SqlConnection con;

        public conexion()
        {
            con = new SqlConnection(query);
        }

        public void conectar()
        {
            try
            {
                con.Open();
            }
            catch { }

        }
        public void desconectar()
        {
            try
            {
                con.Close();
            }
            catch { }
        }
        public SqlDataReader consulta(String sentencia)
        {
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand(sentencia, con);
                return comando.ExecuteReader();
            }
            catch { return null; }
        }

        public int ejecutar(String sentencia)
        {
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand(sentencia, con);
                return comando.ExecuteNonQuery();
            }
            catch { return -1; }
        }
    }
}
