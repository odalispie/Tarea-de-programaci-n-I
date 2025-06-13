using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Agregar_Click(object sender, EventArgs e)
        {
            string nuevoElemento = textBox1Elemento.Text.Trim(); 
            if (!string.IsNullOrEmpty(nuevoElemento))
            {
                listBox1Elemento.Items.Add(nuevoElemento);
                textBox1Elemento. Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un elemento válido.");


            }
        }
    }
}
