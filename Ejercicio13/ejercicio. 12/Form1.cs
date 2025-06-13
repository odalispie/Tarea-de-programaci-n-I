using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
    {
                if (double.TryParse(txtCelsius.Text, out double celsius))
                {
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    lblFahrenheit.Text = $"Resultado: {fahrenheit} °F";
                }
                else
                {
                    MessageBox.Show("Introduce un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
        