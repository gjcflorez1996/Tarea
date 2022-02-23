using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace serviciosReniec
{
    /// <summary>
    /// Descripción breve de wsDni
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsDni : System.Web.Services.WebService
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(cadena);

        [WebMethod(Description = "Listar los datos de la tabla Dni")]
        public DataSet Listar()
        {
            string consulta = "select * from Dni";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }
        [WebMethod(Description = "Agregar un Dni")]
        public bool Agregar(int dni, string nombre)
        {
            try
            {
                //coorrige papu
                string consulta = "insert into Dni values('" + dni + "','" + nombre + "')";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                //Ejecutar la consult
                int i = comando.ExecuteNonQuery();
                conexion.Close();
                if (i == 1) return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        [WebMethod(Description = "Buscar en la tabla Dni")]
        public DataSet Buscar(string Dni)
        {
            string consulta = String.Empty;
          
                consulta = "select * from Dni where dni = '" + Dni + "'";
         
            SqlCommand command = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;

        }

    
    }
}
