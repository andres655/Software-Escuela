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
    public partial class calificacion : Form
    {
        public calificacion()
        {
            InitializeComponent();
        }

        private void calificacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'estudianteDataSet3.Clasificacion' Puede moverla o quitarla según sea necesario.
            this.clasificacionTableAdapter.Fill(this.estudianteDataSet3.Clasificacion);

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres agregar esta clasificacion?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    string cmd = String.Format("EXEC Agregar_clasificacion  '{0}','{1}'", int.Parse(TxtReferencia.Text),TxtDescripcion.Text);
                    Utilidades.Ejecutar(cmd);

                    MessageBox.Show("Gracias!");

                }
                catch (Exception error)
                {
                    MessageBox.Show(" ha ocurrrido un error: " + error.Message);


                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres elimnar este servicio?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    string cmd = String.Format("EXEC eliminar_clasificacion  '{0}'", int.Parse(TxtReferencia.Text));
                    Utilidades.Ejecutar(cmd);

                    MessageBox.Show("Gracias!");

                }
                catch (Exception error)
                {
                    MessageBox.Show(" ha ocurrrido un error: " + error.Message);


                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres modificar este servicio?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    string cmd = String.Format("Actualizar_Clasificacion'{0}','{1}'", int.Parse(TxtReferencia.Text), TxtDescripcion.Text);
                    Utilidades.Ejecutar(cmd);

                    MessageBox.Show("Gracias!");

                }
                catch (Exception error)
                {
                    MessageBox.Show(" ha ocurrrido un error: " + error.Message);


                }
            }
        }
    }
}
