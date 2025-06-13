using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer8.Start();
        }
        
        private void btnDetener_Click(object sender, EventArgs e) { timer8.Stop(); }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum) { progressBar1.Value += 1; }
            else
            {
                timer8.Stop(); // Detiene el timer cuando se llena } } } 
            }
        }

    }
}

