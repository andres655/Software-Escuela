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
    public partial class BuscarFactura : Form
    {
        string CadenaBD= "select DetalleFactura.ID_Facturas, Estudiante.Nombre_Estudiante,DetalleFactura.Pago,DetalleFactura.TotalAPagar,DetalleFactura.Fecha from DetalleFactura inner join Estudiante on DetalleFactura.ID_Estudiante=Estudiante.Codigo_Estudiante";
        public BuscarFactura()
        {
            InitializeComponent();
           
        }
        public DataSet LLenarDataGV(string tabla)
        {
            DataSet Ds;
      
            string cmd = string.Format(CadenaBD);
            Ds = Utilidades.Ejecutar(cmd);
            return Ds;
        }

            private void BuscarFactura_Load(object sender, EventArgs e)
        {
                dataGridView1.DataSource = LLenarDataGV("estudiantes").Tables[0];
            }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CadenaBD = string.Format("select DetalleFactura.ID_Facturas, Estudiante.Nombre_Estudiante,DetalleFactura.Pago,DetalleFactura.TotalAPagar,DetalleFactura.Fecha  from DetalleFactura inner join Estudiante on DetalleFactura.ID_Estudiante=Estudiante.Codigo_Estudiante where Nombre_Estudiante like '%{0}%'", TxtBuscar.Text);
            dataGridView1.DataSource = LLenarDataGV("estudiantes").Tables[0];
        }
        private void Imprimir(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
/*
            Image Logo = Image.FromFile("C:/Users/Administrator.RM-BEECH1/Desktop/Programa/ProyectoProgramacion/Vistobueno.png");
            Font font = new Font("Arial", 16);
            int ancho = 500;
            int y = 300;
            RectangleF srcRect = new RectangleF(50.0F, 50.0F, 150.0F, 150.0F);
            GraphicsUnit units = GraphicsUnit.Pixel;
            e.Graphics.DrawImage(Logo, 150, 150, srcRect, units);
            e.Graphics.DrawString("------------------Factura de inscripcion-----------------", font, Brushes.Black, new RectangleF(150, y += 20, ancho, 80));
            e.Graphics.DrawString("-----No.Factura:  " + ID_Factura.ToString(), font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            e.Graphics.DrawString("-----Estudiante:  " + Nombre_Estudiante, font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            e.Graphics.DrawString("-----Pagó:  " + pagar.ToString(), font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            e.Graphics.DrawString("-----Cantidad por Pagar:  " + Total_Pagar.ToString(), font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            Font f = new Font("Arial", 24, FontStyle.Bold);
            e.Graphics.DrawString("--GRACIAS POR PREFERIRNOS-- ", f, Brushes.Black, new RectangleF(150, y += 90, ancho, 80));*/
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {

        }
    }
}
