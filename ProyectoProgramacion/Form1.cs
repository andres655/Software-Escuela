using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Dll_LibreriaClase;
using System.Data.SqlClient;

namespace ProyectoProgramacion
{
    public partial class Form1 : Form
    {
       conexionbd conexion = new conexionbd();
       
       public DataSet LLenarDataGV(string tabla)
       {
           DataSet Ds;
            if (ChkActivos.Checked == true && ChkAnio.Checked == false  && ChkMes.Checked == false) {
                string cmd = string.Format("select * from Estudiante where Estado=1");
                Ds = Utilidades.Ejecutar(cmd);
            }
            else  if (ChkActivos.Checked == true && ChkAnio.Checked == true && ChkMes.Checked == false)
            {
                string cmd = string.Format("select * from Estudiante where Estado=1 and  year(FechaInscripcion) = (select DATEPART (YEAR,getdate()))");
                Ds = Utilidades.Ejecutar(cmd);
            }

          else   if (ChkActivos.Checked == true && ChkActivos.Checked == true && ChkAnio.Checked == false)
            {
                string cmd = string.Format("select * from Estudiante where Estado=1 and Month(FechaInscripcion) = (select DATEPART (month,getdate())) and year(FechaInscripcion) = (select DATEPART (YEAR,getdate()))");
                Ds = Utilidades.Ejecutar(cmd);
            }

         else    if (ChkActivos.Checked == false && ChkAnio.Checked == true && ChkActivos.Checked == false)
            {
                string cmd = string.Format("select * from Estudiante where  year(FechaInscripcion) = (select DATEPART (YEAR,getdate()))");
                Ds = Utilidades.Ejecutar(cmd);
            }

          else   if (ChkActivos.Checked == false && ChkMes.Checked == true && ChkAnio.Checked == false)
            {
                string cmd = string.Format("select * from Estudiante where   Month(FechaInscripcion) = (select DATEPART (month,getdate())) and year(FechaInscripcion) = (select DATEPART (YEAR,getdate()))");
                Ds = Utilidades.Ejecutar(cmd);
            }

            else
            {
                string cmd = string.Format("select * from Estudiante ");
                Ds = Utilidades.Ejecutar(cmd);
            }

            return Ds;
       }
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = LLenarDataGV("estudiantes").Tables[0];
            if (ChkActivos.Checked == true && ChkAnio.Checked == false && ChkMes.Checked == false)
            {
                String cmd = "select count (Codigo_Estudiante) as cuentas from Estudiante where estado = 1 ";
                DataSet Ds = Utilidades.Ejecutar(cmd);
                LbTotal.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();
            }
            else if (ChkActivos.Checked == true && ChkAnio.Checked == true && ChkMes.Checked == false)
            {
                String cmd = "select count (Codigo_Estudiante) as cuentas from Estudiante where estado = 1 and  year(FechaInscripcion) = (select DATEPART (YEAR,getdate())) ";
                DataSet Ds = Utilidades.Ejecutar(cmd);
                LbTotal.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();

            }
            else if (ChkActivos.Checked == true && ChkMes.Checked == true && ChkAnio.Checked == false)
            {
                String cmd = "select count (Codigo_Estudiante) as cuentas from Estudiante where estado = 1 and Month(FechaInscripcion) = (select DATEPART (month,getdate())) and year(FechaInscripcion) = (select DATEPART (YEAR,getdate())) ";
                DataSet Ds = Utilidades.Ejecutar(cmd);
                LbTotal.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();
            }
            else if (ChkActivos.Checked == false && ChkAnio.Checked == true && ChkActivos.Checked == false)
            {
                String cmd = "select count (Codigo_Estudiante) as cuentas from Estudiante where year(FechaInscripcion) = (select DATEPART (YEAR,getdate())) ";
                DataSet Ds = Utilidades.Ejecutar(cmd);
                LbTotal.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();
            }
            else if (ChkActivos.Checked == false && ChkMes.Checked == true && ChkAnio.Checked == false)
            {
                String cmd = "select count (Codigo_Estudiante) as cuentas from Estudiante where Month(FechaInscripcion) = (select DATEPART (month,getdate())) and year(FechaInscripcion) = (select DATEPART (YEAR,getdate())) ";
                DataSet Ds = Utilidades.Ejecutar(cmd);
                LbTotal.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();
            }

            else {
                String cmd = "select count (Codigo_Estudiante) as cuentas from Estudiante ";
                DataSet Ds = Utilidades.Ejecutar(cmd);
                LbTotal.Text = Ds.Tables[0].Rows[0]["cuentas"].ToString();
            }
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 abrir = new Form2();
            abrir.Show();
            this.Hide();
           
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro que desea cerrar el formulario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al registro de Alumnos.");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                txtNombre_Estudiante.Text = this.dataGridView1.SelectedRows[0].Cells["Cedula"].Value.ToString();
                txtDireccion.Text = this.dataGridView1.SelectedRows[0].Cells["Apellido_Estudiante"].Value.ToString();
                txtNumero.Text = this.dataGridView1.SelectedRows[0].Cells["Nombre_Estudiante"].Value.ToString();

                txtEdad.Text = this.dataGridView1.SelectedRows[0].Cells["edad"].Value.ToString();
                txtCorreo.Text = this.dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(info);           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres guardar este estudiante?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    String cmd = String.Format("EXEC Actualizar_Estudiante '{0}', '{1}', '{2}','{3}','{4}','{5}','{6}'", txtNombre_Estudiante.Text.Trim(), txtNumero.Text, txtDireccion.Text.Trim(), TxtCategoria.Text, TxtCedula.Text, txtCorreo.Text.Trim(), DateTime.Now);
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("se ha guardado correctamente");

                }
                catch (Exception error)
                {
                    MessageBox.Show(" ha ocurrrido un error: " + error.Message);


                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {/*
            try
            {
                conexionbd.actualizar_dato(txt_nombre.Text, txt_nombre.Text, txt_cedula.Text);
                MessageBox.Show("Datos Actualizados", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button3_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos" + Environment.NewLine + ex.Message);
            }*/
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres eliminar este estudiante?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    String cmd = String.Format("EXEC Eliminar_Estudiante '{0}'", TxtId.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha eliminado: ");

                }
                catch (Exception error)
                {
                    MessageBox.Show(" Ha ocurrrido un error: " + error.Message);

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

