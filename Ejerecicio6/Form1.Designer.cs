﻿namespace Ejerecicio6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1Colores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1Colores
            // 
            this.comboBox1Colores.FormattingEnabled = true;
            this.comboBox1Colores.Location = new System.Drawing.Point(77, 23);
            this.comboBox1Colores.Name = "comboBox1Colores";
            this.comboBox1Colores.Size = new System.Drawing.Size(121, 24);
            this.comboBox1Colores.TabIndex = 0;
            this.comboBox1Colores.SelectedIndexChanged += new System.EventHandler(this.comboBox1Colores_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.comboBox1Colores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1Colores;
    }
}

