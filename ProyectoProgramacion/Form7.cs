using System;
using System.Windows.Forms;
using System.Xml;

namespace ProyectoProgramacion
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlTextReader = new XmlTextReader("C:\\xml\\archivo.xml");
            string ultimaEtiqueta = "";

            while (xmlTextReader.Read())
            {
                if (xmlTextReader.NodeType == XmlNodeType.Element)
                {
                    richTextBox1.Text += (new String(' ', xmlTextReader.Depth * 3) + "<" + xmlTextReader.Name + ">");
                    ultimaEtiqueta = xmlTextReader.Name;
                    continue;
                }
                if (xmlTextReader.NodeType == XmlNodeType.Text)
                {
                    richTextBox1.Text += xmlTextReader.ReadContentAsString() + "</" + ultimaEtiqueta + ">";
                }

                else
                {
                    richTextBox1.Text += "\r";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
