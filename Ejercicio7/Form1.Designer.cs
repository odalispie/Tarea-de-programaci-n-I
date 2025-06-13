namespace Ejercicio7
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
            this.button1Agregar = new System.Windows.Forms.Button();
            this.listBox1Elemento = new System.Windows.Forms.ListBox();
            this.textBox1Elemento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1Agregar
            // 
            this.button1Agregar.Location = new System.Drawing.Point(61, 160);
            this.button1Agregar.Name = "button1Agregar";
            this.button1Agregar.Size = new System.Drawing.Size(75, 23);
            this.button1Agregar.TabIndex = 0;
            this.button1Agregar.Text = "button1";
            this.button1Agregar.UseVisualStyleBackColor = true;
            this.button1Agregar.Click += new System.EventHandler(this.button1Agregar_Click);
            // 
            // listBox1Elemento
            // 
            this.listBox1Elemento.FormattingEnabled = true;
            this.listBox1Elemento.ItemHeight = 16;
            this.listBox1Elemento.Location = new System.Drawing.Point(46, 237);
            this.listBox1Elemento.Name = "listBox1Elemento";
            this.listBox1Elemento.Size = new System.Drawing.Size(267, 84);
            this.listBox1Elemento.TabIndex = 2;
            // 
            // textBox1Elemento
            // 
            this.textBox1Elemento.Location = new System.Drawing.Point(182, 161);
            this.textBox1Elemento.Name = "textBox1Elemento";
            this.textBox1Elemento.Size = new System.Drawing.Size(100, 22);
            this.textBox1Elemento.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.textBox1Elemento);
            this.Controls.Add(this.listBox1Elemento);
            this.Controls.Add(this.button1Agregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Agregar;
        private System.Windows.Forms.ListBox listBox1Elemento;
        private System.Windows.Forms.TextBox textBox1Elemento;
    }
}

