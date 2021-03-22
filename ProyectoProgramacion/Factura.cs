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
using System.Drawing.Printing;

namespace ProyectoProgramacion
{
    public partial class Factura : Form
    {
        #region Variables
        public static int Cont_fila = 0;
        public static double Total;
        public bool existe;
        public int num_fila;
        int Codigo_Estudiante;
        string Nombre_Estudiante;
        int pagar;
        double Total_Pagar;
        int ID_Factura;
        string Seleccionar_Estudiante;
        string seleccionar;
        #endregion
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cont_fila == 0)
            {
                dataGridView1.Rows.Add(TxtCodigo.Text, TxtDescripcion.Text, TxtPrecio.Text);

                double importe = int.Parse(TxtPrecio.Text);
                dataGridView1.Rows[Cont_fila].Cells[3].Value = importe;
                Cont_fila++;
            }
            else
            {
                /*foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    if (Fila.Cells[0].Value.ToString() == TxtCodigo.Text)
                    {
                        existe = true;
                        num_fila = Fila.Index;
                    }
                }

                if (existe == true)
                {

                    dataGridView1.Rows[num_fila].Cells[2].Value =  Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value).ToString();
                    double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);
                    dataGridView1.Rows[num_fila].Cells[3].Value = importe;
                }*/


                dataGridView1.Rows.Add(TxtCodigo.Text, TxtDescripcion.Text, TxtPrecio.Text);

                double importe = Convert.ToDouble(dataGridView1.Rows[Cont_fila].Cells[2].Value);
                dataGridView1.Rows[Cont_fila].Cells[3].Value = importe;
                Cont_fila++;



            }

            Total = 0;
            foreach (DataGridViewRow Fila in dataGridView1.Rows)
            {
                Total += Convert.ToDouble(Fila.Cells[3].Value);
            }
            LbTotal.Text = "RD$" + Total.ToString();


        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Text = "";
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            TxtPrecio.Text = "";
            LbTotal.Text = "RD$ 0";
            dataGridView1.Rows.Clear();
            Cont_fila = 0;
            Total = 0;
            TxtCodigo.Focus();

        }

        public void CargarComboBox()
        {
            DataSet Ds;
            DataTable Dt;
            String cmd = string.Format("select Codigo_Estudiante, Nombre_Estudiante from Estudiante");
            Ds = Utilidades.Ejecutar(cmd);

            Dt = Ds.Tables[0];
            DataRow fila = Dt.NewRow();
            fila["Nombre_Estudiante"] = "seleccione estudiante";
            Dt.Rows.InsertAt(fila, 0);
            comboBox1.ValueMember = "Codigo_Estudiante";
            comboBox1.DisplayMember = "Nombre_Estudiante";
            comboBox1.DataSource = Dt;

            cmd = string.Format("select ID_Servicio , Descripcion from Servicio");
            Ds = Utilidades.Ejecutar(cmd);

            Dt = Ds.Tables[0];
            DataRow fil = Dt.NewRow();
            fil["Descripcion"] = "seleccione Servicio";
            Dt.Rows.InsertAt(fil, 0);
            comboBox2.ValueMember = "ID_Servicio";
            comboBox2.DisplayMember = "Descripcion";
            comboBox2.DataSource = Dt;


        }
        public void Seleccionar()
        {
            Seleccionar_Estudiante = comboBox1.SelectedValue.ToString();


            seleccionar = comboBox2.SelectedValue.ToString();
            DataSet Ds;

            String cmd = string.Format("select * from Servicio where ID_Servicio= {0}", int.Parse(seleccionar));
            Ds = Utilidades.Ejecutar(cmd);

            TxtCodigo.Text = seleccionar;
            TxtDescripcion.Text = (string)Ds.Tables[0].Rows[0]["Descripcion"];
            TxtPrecio.Text = Ds.Tables[0].Rows[0]["Precio"].ToString();

        }



        private void SeleccionarChange(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Cont_fila > 0)
            {
                Total = Total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value));
                LbTotal.Text = "RD$" + Total.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                Cont_fila--;
            }
        }

        private void Imprimir(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

           // Image Logo = Image.FromFile("../../Resources/Escuela.png");
            Font font = new Font("Arial", 16);
            int ancho = 500;
            int y = 300;
            int x = -100;
            int XRow = -100;
            RectangleF srcRect = new RectangleF(50.0F, 50.0F, 150.0F, 150.0F);
            GraphicsUnit units = GraphicsUnit.Pixel;
            //  e.Graphics.DrawImage(Logo, 150, 150, srcRect, units);
            e.Graphics.DrawString(" ESCUELA DE CHOFERES BONAO ", font, Brushes.Black, new RectangleF(150, y += 20, ancho, 80));
            e.Graphics.DrawString("AV.LIBERTAD #132, BONAO, REP.DOM", font, Brushes.Black, new RectangleF(150, y += 40, ancho, 80));
            e.Graphics.DrawString("(809)-525-3001  (809-801-4940)", font, Brushes.Black, new RectangleF(150, y += 20, ancho, 80));
            e.Graphics.DrawString("---------------------------------------Factura --------------", font, Brushes.Black, new RectangleF(150, y += 20, ancho, 80));
            e.Graphics.DrawString(" " + DateTime.Now.ToString(), font, Brushes.Black, new RectangleF(550, y += 20, ancho, 80));
            e.Graphics.DrawString("-----No.Factura:  " + ID_Factura.ToString(), font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            e.Graphics.DrawString("-----Estudiante:  " + Nombre_Estudiante, font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {

                e.Graphics.DrawString(" " + column.HeaderText, font, Brushes.Black, new RectangleF(x += 150, y + 50, ancho, 80));

            }
            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
                XRow = -100;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        e.Graphics.DrawString(" " + cell.Value.ToString(), font, Brushes.Black, new RectangleF(XRow += 150, y + 50, ancho, 80));
                    }
                }
            }
            //e.Graphics.DrawString("-----Pagó:  " + pagar.ToString(), font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            e.Graphics.DrawString("-----Cantidad por Pagar:  RD" + Total_Pagar.ToString(), font, Brushes.Black, new RectangleF(50, y += 50, ancho, 80));
            Font f = new Font("Arial", 24, FontStyle.Bold);
            e.Graphics.DrawString("GRACIAS POR PREFERIRNOS ", f, Brushes.Black, new RectangleF(150, y += 90, ancho, 80));
        }
        #region Imprimir
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            String cmd = string.Format("select MAX (ID_Facturas) as ID_Factura from DetalleFactura", int.Parse(Seleccionar_Estudiante));
            DataSet Ds = Utilidades.Ejecutar(cmd);
            ID_Factura = (int)Ds.Tables[0].Rows[0]["ID_Factura"];
            ID_Factura += 1;
            cmd = string.Format("select * from Estudiante where Codigo_Estudiante = {0}", int.Parse(Seleccionar_Estudiante));
            Ds = Utilidades.Ejecutar(cmd);

            Codigo_Estudiante = (int)Ds.Tables[0].Rows[0]["Codigo_Estudiante"];
            Nombre_Estudiante = (string)Ds.Tables[0].Rows[0]["Nombre_Estudiante"];
            pagar = 0;
            Total_Pagar = Total;

            if (MessageBox.Show("¿Seguro que quieres realizar esta factura?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    cmd = String.Format("EXEC ActualizarDetallesFactura  '{0}','{1}','{2}','{3}'", Codigo_Estudiante, pagar, Total_Pagar, DateTime.Now, TxtDescripcion.Text);
                    Utilidades.Ejecutar(cmd);

                    MessageBox.Show("Gracias!");

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
            LlenarBD();
        }
        #endregion
        public void LlenarBD()
        {
            String cmd = string.Format("select MAX (ID_Facturas) as ID_Factura from DetalleFactura", int.Parse(seleccionar));
            DataSet Ds = Utilidades.Ejecutar(cmd);
            ID_Factura = (int)Ds.Tables[0].Rows[0]["ID_Factura"];
            ID_Factura += 1;
            cmd = string.Format("select * from Estudiante where Codigo_Estudiante = {0}", int.Parse(seleccionar));
            Ds = Utilidades.Ejecutar(cmd);

            Codigo_Estudiante = (int)Ds.Tables[0].Rows[0]["Codigo_Estudiante"];
            Nombre_Estudiante = (string)Ds.Tables[0].Rows[0]["Nombre_Estudiante"];
            pagar = 0;
            

           /* if (MessageBox.Show("¿Seguro que quieres realizar esta factura?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    cmd = String.Format("EXEC ActualizarDetallesFactura  '{0}','{1}','{2}','{3}'", Codigo_Estudiante, pagar,Total_Pagar, DateTime.Now);
                    Utilidades.Ejecutar(cmd);

                    MessageBox.Show("Gracias!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                catch (Exception error)
                {
                    MessageBox.Show(" ha ocurrrido un error: " + error.Message);


                }
            }*/
        }
    }
}


    

