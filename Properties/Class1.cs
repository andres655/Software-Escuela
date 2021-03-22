using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProyectoProgramacion.Properties;
using System.Configuration;

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
