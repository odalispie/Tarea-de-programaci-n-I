using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        

        

        private void button1Aceptar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Seleccionaste:Opción 1";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "Seleccionaste: Opsión 2";
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "Seleccionaste: Opsión 3";
            }
            else
            {
                label1.Text = " No Seleccionaste ninguna opción.";
}


        }
    }
}
