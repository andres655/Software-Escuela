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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public DataSet LLenarDataGV(string tabla)
        {
            DataSet Ds;
                string cmd = string.Format("select Codigo_Estudiante as Codigo, Nombre_Estudiante as Nombre,Asistencia,Fecha_Asistencia as Ultima_Asistencia ,direccion  from Estudiante where Estado=1");
                Ds = Utilidades.Ejecutar(cmd);
            return Ds;
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {/*
            Abrir_Ruta(lb_ruta_elemento_objetivo, true);*/
        }

        private void Abrir_Ruta(Label label_objetivo, Boolean buscar_archivo = true)
        {/*
            if (buscar_archivo == true)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string nombre_archivo = ofd.FileName.ToString();
                    label_objetivo.Text = nombre_archivo;
                    System.IO.FileInfo info = new System.IO.FileInfo(ofd.FileName);
                    this.lb_extencion.Text = "" + info.Extension.ToString();
                    this.lb_peso.Text = info.Length.ToString();
                    this.lb_nombre.Text = info.Name.ToString();
                }
            }
            else
            {
                FolderBrowserDialog FBD = new FolderBrowserDialog();
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    label_objetivo.Text = FBD.SelectedPath.ToString() + @"\";
                }
            }
            */
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           // Abrir_Ruta(lb_ruta_objetivo, false);
        }


        private void Trabajo_archivos(int tarea)
        {/*
            try
            {
                switch (tarea)
                {
                    case 1:
                        lb_proceso.Text = "Copiando archivo";
                        Application.DoEvents();
                        System.IO.File.Copy(lb_ruta_elemento_objetivo.Text.ToString(), lb_ruta_objetivo.Text.ToString() + lb_nombre.Text, true);
                        lb_proceso.Text = "Archivo copiado con exito";
                        break;
                    case 2:
                        lb_proceso.Text = "Moviendo archivo";
                        Application.DoEvents();
                        System.IO.File.Move(lb_ruta_elemento_objetivo.Text, lb_ruta_objetivo.Text + lb_nombre.Text);
                        Application.DoEvents();
                        break;
                    case 3:
                        lb_proceso.Text = "Borrando archivo";
                        Application.DoEvents();
                        System.IO.File.Delete(lb_ruta_elemento_objetivo.Text);
                        lb_proceso.Text = "Archivo borrado";
                        Application.DoEvents();
                        break;
                    case 4:
                        lb_proceso.Text = "Ejecutando archivo";
                        Application.DoEvents();
                        System.Diagnostics.Process.Start(lb_ruta_elemento_objetivo.Text);
                        lb_proceso.Text = "Archivo ejecutado";
                        Application.DoEvents();
                        break;
                    case 5:
                        lb_proceso.Text = "Abriendo ruta archivo";
                        Application.DoEvents();
                        System.IO.FileInfo info = new System.IO.FileInfo(lb_ruta_elemento_objetivo.Text);
                        System.Diagnostics.Process.Start(info.Directory.ToString());
                        lb_proceso.Text = "Ruta abierta";
                        Application.DoEvents();
                        break;

                }
            }
            catch (Exception)
            {
            }*/
                    
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trabajo_archivos(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Trabajo_archivos(2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Trabajo_archivos(3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Trabajo_archivos(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Trabajo_archivos(5);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("estudiantes").Tables[0];

            String cmd = "Select DATEDIFF (Month, Fecha_Asistencia, GETDATE()) as Month From Estudiante" ;
            DataSet Ds = Utilidades.Ejecutar(cmd);


            int Diferencia_Mes = Int16.Parse(Ds.Tables[0].Rows[0]["Month"].ToString());

            if (Diferencia_Mes > 2)
            {

                cmd = String.Format("EXEC Actualizar_EstadoPorAusencia '{0}', '{1}'" ,0, 0);
                Utilidades.Ejecutar(cmd);

            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            if  (MessageBox.Show("Confirmar asistencia", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    int asistencia = 0;
                    String cmd = "select Asistencia,Nombre_estudiante from Estudiante where Codigo_Estudiante=" + TxtCodigo.Text;
                    DataSet Ds = Utilidades.Ejecutar(cmd);

                    LbAsistencia.Text = Ds.Tables[0].Rows[0]["Asistencia"].ToString();
                    asistencia = Int16.Parse(Ds.Tables[0].Rows[0]["Asistencia"].ToString());
                    asistencia++;

                    LbNombre.Text = Ds.Tables[0].Rows[0]["Nombre_estudiante"].ToString();

                    
                    cmd = String.Format("EXEC ActualizarAsistencia '{0}', '{1}','{2}'", asistencia, Int16.Parse(TxtCodigo.Text),DateTime.Now);
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("se ha guardado correctamente");

                    if (asistencia == 15)
                    {

                        cmd = String.Format("EXEC ActualizarEstado '{0}', '{1}','{2}'", 1, Int16.Parse(TxtCodigo.Text), 0);
                        Utilidades.Ejecutar(cmd);
                        MessageBox.Show("Felicidades ha terminado el curso");

                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(" ha ocurrrido un error: " + error.Message);

                }
            }

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form5 abrir = new Form5();
            abrir.ShowDialog();
        }
    }
}