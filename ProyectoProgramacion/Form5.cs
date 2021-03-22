using Dll_LibreriaClase;
using System;
using System.Data;
using System.Windows.Forms;


namespace ProyectoProgramacion
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public DataSet LLenarDataGV(string tabla)
        {
            DataSet Ds;
            string cmd = string.Format("select Codigo_Estudiante as Codigo, Nombre_Estudiante as Nombre,Asistencia,Cedula,direccion  from Estudiante where Terminado=1");
            Ds = Utilidades.Ejecutar(cmd);
            return Ds;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("estudiantes").Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            Dll_LibreriaClase.Class1 clase = new Dll_LibreriaClase.Class1();
            string HOla = null;
            HOla = clase.Hola();
            this.textBox1.Text = HOla.ToString();*/
        }

        private void Form5_MdiChildActivate(object sender, EventArgs e)
        {
            Form5 newMDIChild = new Form5();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void BtnAprobar_Click(object sender, EventArgs e)
        {
            String cmd = String.Format("EXEC Examen '{0}', '{1}'", 1, Int16.Parse(TxtCodigo.Text));
            Utilidades.Ejecutar(cmd);
            MessageBox.Show("se ha guardado correctamente");
        }

        private void BtnDesaprobrar_Click(object sender, EventArgs e)
        {
            String cmd = String.Format("EXEC Examen '{0}', '{1}'", 0, Int16.Parse(TxtCodigo.Text));
            Utilidades.Ejecutar(cmd);
            MessageBox.Show("se ha guardado correctamente");
        }
    }
}
