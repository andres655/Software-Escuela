using Dll_LibreriaClase;
using System;
using System.Windows.Forms;

namespace ProyectoProgramacion
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'estudianteDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.estudianteDataSet.Empleado);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres guardar este Empleado?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    String cmd = String.Format("EXEC Actualizar_Empleados '{0}', '{1}', '{2}','{3}','{4}','{5}','{6}'", int.Parse(TxtIDEmpleado.Text.Trim()), TxtNombre.Text.Trim(), TxtTelefono.Text.Trim(), TxtDireccion.Text.Trim(), DateTime.Now, int.Parse(TxtSueldo.Text.Trim()),TxtCedula.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("se ha guardado correctamente");

                }
                catch (Exception error)
                {
                    MessageBox.Show(" ha ocurrrido un error: " + error.Message);


                }

            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            this.empleadoTableAdapter.Fill(this.estudianteDataSet.Empleado);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres eliminar este empleado?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    String cmd = String.Format("EXEC Eliminar_Empleado '{0}'", int.Parse(TxtIDEmpleado.Text.Trim()));
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("se heliminado correctamente");

                }
                catch (Exception error)
                {
                    MessageBox.Show(" ha ocurrrido un error: " + error.Message);


                }

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Form1.ExportarDatos(dataGridView1);

        }
    }
}
