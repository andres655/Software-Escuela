using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dll_LibreriaClase;
using System.Windows.Forms;

namespace ProyectoProgramacion
{
    public partial class Servicio : Form
    {
        public Servicio()
        {
            InitializeComponent();
        }

        private void Servicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'estudianteDataSet2.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.estudianteDataSet2.Servicio);

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres agregar este servicio?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                     string cmd = String.Format("EXEC ActualizarServicio  '{0}','{1}','{2}'", TxtDescripcion.Text, float.Parse( TxtPrecio.Text),0);
                    Utilidades.Ejecutar(cmd);

                    MessageBox.Show("Gracias!");

                }
                catch (Exception error)
                { 
                    MessageBox.Show((" ha ocurrrido un error: " + error.Message),"Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Warning);


                }
            }

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres modificar este servicio?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    string cmd = String.Format("EXEC AlterServicio  '{0}','{1}'",float.Parse(TxtPrecio.Text), TxtID.Text);
                    Utilidades.Ejecutar(cmd);

                    MessageBox.Show("Gracias!");

                }
                catch (Exception error)
                {
                    MessageBox.Show((" ha ocurrrido un error: " + error.Message),"Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Warning);


                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Seguro que quieres elimnar este servicio?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    string cmd = String.Format("EXEC EliminarServicio  '{0}'",  int.Parse(TxtID.Text));
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
