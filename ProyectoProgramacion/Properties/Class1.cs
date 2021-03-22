using ProyectoProgramacion.Properties;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Dll_LibreriaClase
{
    public class Utilidades
    {
        public static string ObtenerString()
        {
            return Settings.Default.EstudianteConnectionString;
        }

        public static DataSet Ejecutar(String cmd)
        {
            SqlConnection con = new SqlConnection(ObtenerString());
            con.Open();
            DataSet Ds = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);
            DP.Fill(Ds);
            con.Close();
            return Ds;
        }


    }
}
