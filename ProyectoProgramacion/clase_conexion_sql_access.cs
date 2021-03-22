using System;
using System.Data.SqlClient;

namespace ProyectoProgramacion
{
    class conexionbd
    {
        String cadena = "Data Source = ECB-PC\\SQLEXPRESS;Initial Catalog= EscuelaDeChoferes; integrated security = true";
        public SqlConnection conetarbd = new SqlConnection();
        public conexionbd()
        {
            conetarbd.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                conetarbd.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);

            }

        }







    }
}
