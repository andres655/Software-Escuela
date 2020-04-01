using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dll_LibreriaClase
{
    public class Utilidades
    {
        public static DataSet Ejecutar(String cmd)
        {
            SqlConnection con = new SqlConnection("Data Source = PCAG150OVRHKF\\SQLEXPRESS;Initial Catalog= Estudiante; integrated security = true");
            con.Open();
            DataSet Ds = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);
            DP.Fill(Ds);
            con.Close();
            return Ds;
        }
        

    }
}
