﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFecha.Value;
            lblFecha.Text = "Fecha seleccionada:" + fechaSeleccionada.ToString();
        }
    }
}
