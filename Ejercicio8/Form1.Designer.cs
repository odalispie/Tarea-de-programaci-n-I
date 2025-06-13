namespace Ejercicio8
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
            this.button1Contar = new System.Windows.Forms.Button();
            this.label1Contador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1Contar
            // 
            this.button1Contar.Location = new System.Drawing.Point(201, 47);
            this.button1Contar.Name = "button1Contar";
            this.button1Contar.Size = new System.Drawing.Size(75, 23);
            this.button1Contar.TabIndex = 0;
            this.button1Contar.Text = "button1";
            this.button1Contar.UseVisualStyleBackColor = true;
            this.button1Contar.Click += new System.EventHandler(this.button1Contar_Click);
            // 
            // label1Contador
            // 
            this.label1Contador.AutoSize = true;
            this.label1Contador.Location = new System.Drawing.Point(214, 118);
            this.label1Contador.Name = "label1Contador";
            this.label1Contador.Size = new System.Drawing.Size(44, 16);
            this.label1Contador.TabIndex = 1;
            this.label1Contador.Text = "label1";
            this.label1Contador.Click += new System.EventHandler(this.label1Contador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1Contador);
            this.Controls.Add(this.button1Contar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Contar;
        private System.Windows.Forms.Label label1Contador;
    }
}

