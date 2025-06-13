using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Validar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtEntrada.Text, out _))
           {
                MessageBox.Show("Es un numero  Valid.", "Validadacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
else 
                MessageBox.Show("Entrada no valida. Por Favor, Ingresa un numero. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }
    }

}


