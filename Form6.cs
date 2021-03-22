using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProyectoProgramacion
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement raiz = doc.CreateElement("Inicio");
            doc.AppendChild(raiz);

            XmlElement registro = doc.CreateElement("Registro");
            raiz.AppendChild(registro);

            XmlElement nombre = doc.CreateElement("Nombre");
            nombre.AppendChild(doc.CreateTextNode("IUNP"));
            registro.AppendChild(nombre);

            XmlElement fecha = doc.CreateElement("Fecha");
            fecha.AppendChild(doc.CreateTextNode("05/2015"));
            registro.AppendChild(fecha);

            doc.Save("c:\\xml\\archivo.xml");

            MessageBox.Show("Archivo Creado con Éxito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 leer = new Form7();
            leer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
