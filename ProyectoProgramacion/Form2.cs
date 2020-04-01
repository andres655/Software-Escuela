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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 abrir = new Form1();

            abrir.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 abrir = new Form3();
            abrir.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 abrir = new Form4();
            abrir.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 nuevo = new Form5();
            nuevo.Show();
            
            
        }

        Form5 f5;
        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f5 == null)
            {
                f5 = new Form5();
                f5.MdiParent = this;
                f5.FormClosed += f2_FormClosed;
                f5.Show();
            }
            else
                f5.Activate();

        }

        void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f5 = null;
            //throw new NotImplementedException();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 xml = new Form6();
            xml.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro que desea cerrar el Menu Principal?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
