﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        int Contador = 0;


        public Form1()
        {
            InitializeComponent();
            label1Contador.Text = "presionando 0 veces";
        }

        private void label1Contador_Click(object sender, EventArgs e)
        {

           Contador++;
            label1Contador.Text = $" presionado {Contador} Veces.";
            
        }
    }
}
