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

                    String cmd = String.Format("EXEC Eliminar_Empleado '{0}'", int.Parse(TxtID_Empleado.Text.Trim()));
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("se heliminado correctamente");

                }
                catch (Exception error)
                {
                    MessageBox.Show(" ha ocurrrido un error: " + error.Message);


                }

            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres guardar este Empleado?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    String cmd = String.Format("EXEC Actualizar_Empleados '{0}', '{1}', '{2}','{3}','{4}','{5}'", int.Parse(TxtID_Empleado.Text.Trim()), TxtNombre.Text.Trim(), TxtTelefono.Text.Trim(), TxtDireccion.Text.Trim(), DateTime.Now, int.Parse(TxtSueldo.Text.Trim()));
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("se ha guardado correctamente");

                }
                catch (Exception error)
                {
                    MessageBox.Show(" ha ocurrrido un error: " + error.Message);


                }

            }
        }
    }
}
