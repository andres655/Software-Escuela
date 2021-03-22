using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Dll_LibreriaClase;
namespace ProyectoProgramacion
{
    public partial class Reporte : Form
    {
       int  Codigo_Estudiante;
        string Nombre_Estudiante;
        int pagar;
        int TotalAPagar;
     
        int ID_Factura; 

        public Reporte()
        {
            InitializeComponent();
        }

        public DataSet LLenarDataGVLoad(string tabla)
        {
            DataSet Ds;
           
                string cmd = string.Format("select Codigo_Estudiante,Nombre_Estudiante,TotalAPagar, Fecha from Estudiante inner join DetalleFactura on Estudiante.Codigo_Estudiante= DetalleFactura.ID_Estudiante");
                Ds = Utilidades.Ejecutar(cmd);
            return Ds;
        }
        private void Reporte_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGVLoad("estudiante").Tables[0];

        }
        public DataSet LLenarDataGV(string tabla)
        {
            DataSet Ds;
           int seleccionar = int.Parse(ID_Estudiante.Text);
            string cmd = string.Format("select * from DetalleFactura where ID_Estudiante={0}",seleccionar);
            Ds = Utilidades.Ejecutar(cmd);
            return Ds;
        }
            private void Imprimir(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Image Logo = Image.FromFile("../../Resources/Escuela.png");
            Font font = new Font("Arial",16);
            int ancho = 500;
            int y = 150;
            //RectangleF srcRect = new RectangleF(50.0F, 50.0F, 300.0F, 300.0F);
            //GraphicsUnit units = GraphicsUnit.Pixel;
            //e.Graphics.DrawImage(Logo, 150, 0, srcRect, units);
            e.Graphics.DrawString(" ESCUELA DE CHOFERES BONAO ", font, Brushes.Black, new RectangleF(150, y += 20, ancho, 80));
            e.Graphics.DrawString("AV.LIBERTAD #132, BONAO, REP.DOM", font, Brushes.Black, new RectangleF(150, y += 40, ancho, 80));
            e.Graphics.DrawString("(809)-525-3001  (809-801-4940)", font, Brushes.Black, new RectangleF(150, y += 20, ancho, 80));
            e.Graphics.DrawString("------------------Factura de inscripcion-----------------",font,Brushes.Black, new RectangleF(150,y+=40,ancho,80));
            e.Graphics.DrawString("-----No.Factura:  "+ID_Factura.ToString(),font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            e.Graphics.DrawString("-----Estudiante:  " + Nombre_Estudiante, font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            e.Graphics.DrawString("-----Pagó:  $RD" + pagar.ToString(), font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            e.Graphics.DrawString("-----Total Por Pagar:  $RD" + TotalAPagar.ToString(), font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            // e.Graphics.DrawString("-----Cantidad por Pagar:  " + Total_Pagar.ToString(), font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80)) ;
            Font f = new Font("Arial", 24,FontStyle.Bold);
            e.Graphics.DrawString("--GRACIAS POR PREFERIRNOS-- ", f, Brushes.Black, new RectangleF(150, y += 90, ancho, 80));
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            String cmd = string.Format("select MAX (ID_Facturas) as ID_Factura from DetalleFactura", int.Parse(ID_Estudiante.Text));
            DataSet Ds = Utilidades.Ejecutar(cmd);
            ID_Factura = (int)Ds.Tables[0].Rows[0]["ID_Factura"];
         
            ID_Factura += 1;
           cmd = string.Format("select * from Estudiante where Codigo_Estudiante = {0}", int.Parse(ID_Estudiante.Text));
           Ds = Utilidades.Ejecutar(cmd);
          
            Codigo_Estudiante = (int)Ds.Tables[0].Rows[0]["Codigo_Estudiante"];
            Nombre_Estudiante = (string)Ds.Tables[0].Rows[0]["Nombre_Estudiante"];
            cmd = string.Format("select top 1 * from DetalleFactura where ID_Estudiante={0} order by Fecha desc ", int.Parse(ID_Estudiante.Text));
            Ds = Utilidades.Ejecutar(cmd);
            TotalAPagar = (int)Ds.Tables[0].Rows[0]["TotalAPagar"];
            pagar = int.Parse(TxtPagar.Text);
           TotalAPagar = TotalAPagar-pagar ;

            if (MessageBox.Show("¿Seguro que quieres realizar esta factura?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                 cmd = String.Format("EXEC updateActualizarDetalles  '{0}','{1}','{2}'", Codigo_Estudiante,pagar,TotalAPagar );
                    Utilidades.Ejecutar(cmd);
                   
                    MessageBox.Show("Gracias!","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                }
                catch (Exception error)
                {
                    MessageBox.Show(" ha ocurrrido un error: " + error.Message);


                }

            }
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printPreviewDialog1.Document = printDocument1;
            printDialog1.Document = printDocument1;
            //printDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();
            //printDocument1.Print();



        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("estudiante").Tables[0];
        }
    }
}
