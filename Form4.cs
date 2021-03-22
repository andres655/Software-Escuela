using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dll_LibreriaClase;
using System.Data.SqlClient;

namespace ProyectoProgramacion
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            String cmd = "select count (Codigo_Estudiante) as cuentas  from Estudiante ";
            DataSet Ds = Utilidades.Ejecutar(cmd);
            LbInscrito.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();

           cmd = "select count (Codigo_Estudiante) as cuentas  from Estudiante where EstadoPrueba=1 ";
           Ds = Utilidades.Ejecutar(cmd);
            LbAprobados.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();

            cmd = "select count (Codigo_Estudiante) as cuentas  from Estudiante where EstadoPrueba=0 ";
            Ds = Utilidades.Ejecutar(cmd);
            LbDesaprobaron.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();
            if ((Int16.Parse(LbAprobados.Text) + Int16.Parse(LbDesaprobaron.Text)) != 0)
            {
                int AprobaronPor = (Int16.Parse(LbAprobados.Text) / (Int16.Parse(LbAprobados.Text) + Int16.Parse(LbDesaprobaron.Text)) * 100);
                LbAprobadospor.Text = AprobaronPor.ToString() + "%";
                int DesprobaronPor = (Int16.Parse(LbDesaprobaron.Text) / (Int16.Parse(LbAprobados.Text) + Int16.Parse(LbDesaprobaron.Text)) * 100);
                LbDesaprobaronPor.Text = DesprobaronPor.ToString() + "%";
            }

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (ChkMes.Checked== true)
            {

                String cmd = "select count (Codigo_Estudiante) as cuentas  from Estudiante where  Month(FechaInscripcion) = (select DATEPART (month,getdate())) and year(FechaInscripcion) = (select DATEPART (YEAR,getdate())) ";
                DataSet Ds = Utilidades.Ejecutar(cmd);
                LbInscrito.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();

                cmd = "select count (Codigo_Estudiante) as cuentas  from Estudiante where EstadoPrueba=1  and Month(FechaInscripcion) = (select DATEPART (month,getdate())) and year(FechaInscripcion) = (select DATEPART (YEAR,getdate())) ";
                Ds = Utilidades.Ejecutar(cmd);
                LbAprobados.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();

                cmd = "select count (Codigo_Estudiante) as cuentas  from Estudiante where EstadoPrueba=0  and Month(FechaInscripcion) = (select DATEPART (month,getdate())) and year(FechaInscripcion) = (select DATEPART (YEAR,getdate())) ";
                Ds = Utilidades.Ejecutar(cmd);
                LbDesaprobaron.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();

                int AprobaronPor = (Int16.Parse(LbAprobados.Text) / (Int16.Parse(LbAprobados.Text) + Int16.Parse(LbDesaprobaron.Text)) * 100);
                LbAprobadospor.Text = AprobaronPor.ToString() + "%";
                int DesprobaronPor = (Int16.Parse(LbDesaprobaron.Text) / (Int16.Parse(LbAprobados.Text) + Int16.Parse(LbDesaprobaron.Text)) * 100);
                LbDesaprobaronPor.Text = DesprobaronPor.ToString() + "%";

            }
            else if (ChkAnio.Checked == true && ChkMes.Checked == false)
            {

                String cmd = "select count (Codigo_Estudiante) as cuentas  from Estudiante where   year(FechaInscripcion) = (select DATEPART (YEAR,getdate())) ";
                DataSet Ds = Utilidades.Ejecutar(cmd);
                LbInscrito.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();

                cmd = "select count (Codigo_Estudiante) as cuentas  from Estudiante where EstadoPrueba=1   and year(FechaInscripcion) = (select DATEPART (YEAR,getdate())) ";
                Ds = Utilidades.Ejecutar(cmd);
                LbAprobados.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();

                cmd = "select count (Codigo_Estudiante) as cuentas  from Estudiante where EstadoPrueba=0   and year(FechaInscripcion) = (select DATEPART (YEAR,getdate())) ";
                Ds = Utilidades.Ejecutar(cmd);
                LbDesaprobaron.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();

                int AprobaronPor = (Int16.Parse(LbAprobados.Text) / (Int16.Parse(LbAprobados.Text) + Int16.Parse(LbDesaprobaron.Text)) * 100);
                LbAprobadospor.Text = AprobaronPor.ToString() + "%";
                int DesprobaronPor = (Int16.Parse(LbDesaprobaron.Text) / (Int16.Parse(LbAprobados.Text) + Int16.Parse(LbDesaprobaron.Text)) * 100);
                LbDesaprobaronPor.Text = DesprobaronPor.ToString() + "%";

            }
            else
            {
                String cmd = "select count (Codigo_Estudiante) as cuentas  from Estudiante ";
                DataSet Ds = Utilidades.Ejecutar(cmd);
                LbInscrito.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();

                cmd = "select count (Codigo_Estudiante) as cuentas  from Estudiante where EstadoPrueba=1 ";
                Ds = Utilidades.Ejecutar(cmd);
                LbAprobados.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();

                cmd = "select count (Codigo_Estudiante) as cuentas  from Estudiante where EstadoPrueba=0 ";
                Ds = Utilidades.Ejecutar(cmd);
                LbDesaprobaron.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();

                int AprobaronPor = (Int16.Parse(LbAprobados.Text) / (Int16.Parse(LbAprobados.Text) + Int16.Parse(LbDesaprobaron.Text)) * 100);
                LbAprobadospor.Text = AprobaronPor.ToString() + "%";
                int DesprobaronPor = (Int16.Parse(LbDesaprobaron.Text) / (Int16.Parse(LbAprobados.Text) + Int16.Parse(LbDesaprobaron.Text)) * 100);
                LbDesaprobaronPor.Text = DesprobaronPor.ToString() + "%";

            }
        }
    }
}   
