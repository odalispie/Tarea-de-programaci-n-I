using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio._8
{
    public partial class Form1 : Form
    {
        int Contador = 0;
        public Form1()
        {
            InitializeComponent();
            lblContador.Text = "presione 0 veses";
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            Contador++;
            lblContador.Text = $"Presionado {Contador} Veces.";
        }
    }
}
