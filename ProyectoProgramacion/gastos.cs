using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion
{
    public partial class gastos : Form
    {
        public static int Cont_fila = 0;
        public static double Total;
        public bool existe;
        public int num_fila;
        int pagar;
        double Total_Pagar;
        public gastos()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cont_fila == 0)
                {
                    double Total_pagar = Double.Parse(TxtMonto.Text) * Double.Parse(TxtCantidad.Text);
                    dataGridView1.Rows.Add("1", TxtNombre.Text, TxtCantidad.Text, TxtMonto.Text, "0", "0", Total_Pagar);


                    dataGridView1.Rows[Cont_fila].Cells[6].Value = Total_pagar;
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

                    double Total_pagar = Double.Parse(TxtMonto.Text) * Double.Parse(TxtCantidad.Text);
                    dataGridView1.Rows.Add("1", TxtNombre.Text, TxtCantidad.Text, TxtMonto.Text, "0", "0", (int.Parse(TxtMonto.Text) * int.Parse(TxtMonto.Text)));

                    double importe = Convert.ToDouble(dataGridView1.Rows[Cont_fila].Cells[6].Value);
                    dataGridView1.Rows[Cont_fila].Cells[6].Value = Total_pagar;
                    Cont_fila++;

                }

                Total = 0;
                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    Total += Convert.ToDouble(Fila.Cells[3].Value);
                }
                LbTotal.Text = "RD$" + Total.ToString();
            }
             catch (Exception error)
            {
                MessageBox.Show(("Ha ocurrido un error:"+ error.Message),"Aviso!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

            TxtCantidad.Text = "";
            TxtMonto.Text = "";
            TxtNombre.Text = "";
            LbTotal.Text = "RD$ 0";
            dataGridView1.Rows.Clear();
            Cont_fila = 0;
            Total = 0;
            
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
    }
}