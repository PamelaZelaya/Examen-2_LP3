namespace Examen2LP3
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario_textBox = new System.Windows.Forms.TextBox();
            this.Clave_textBox = new System.Windows.Forms.TextBox();
            this.Aceptar_button = new System.Windows.Forms.Button();
            this.Cancelar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // Usuario_textBox
            // 
            this.Usuario_textBox.Location = new System.Drawing.Point(119, 37);
            this.Usuario_textBox.Name = "Usuario_textBox";
            this.Usuario_textBox.Size = new System.Drawing.Size(158, 20);
            this.Usuario_textBox.TabIndex = 2;
            // 
            // Clave_textBox
            // 
            this.Clave_textBox.Location = new System.Drawing.Point(119, 74);
            this.Clave_textBox.Name = "Clave_textBox";
            this.Clave_textBox.Size = new System.Drawing.Size(158, 20);
            this.Clave_textBox.TabIndex = 3;
            // 
            // Aceptar_button
            // 
            this.Aceptar_button.Location = new System.Drawing.Point(78, 138);
            this.Aceptar_button.Name = "Aceptar_button";
            this.Aceptar_button.Size = new System.Drawing.Size(89, 29);
            this.Aceptar_button.TabIndex = 4;
            this.Aceptar_button.Text = "Aceptar";
            this.Aceptar_button.UseVisualStyleBackColor = true;
            this.Aceptar_button.Click += new System.EventHandler(this.Aceptar_button_Click);
            // 
            // Cancelar_button
            // 
            this.Cancelar_button.Location = new System.Drawing.Point(189, 136);
            this.Cancelar_button.Name = "Cancelar_button";
            this.Cancelar_button.Size = new System.Drawing.Size(88, 32);
            this.Cancelar_button.TabIndex = 5;
            this.Cancelar_button.Text = "Cancelar";
            this.Cancelar_button.UseVisualStyleBackColor = true;
            this.Cancelar_button.Click += new System.EventHandler(this.Cancelar_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 235);
            this.Controls.Add(this.Cancelar_button);
            this.Controls.Add(this.Aceptar_button);
            this.Controls.Add(this.Clave_textBox);
            this.Controls.Add(this.Usuario_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usuario_textBox;
        private System.Windows.Forms.TextBox Clave_textBox;
        private System.Windows.Forms.Button Aceptar_button;
        private System.Windows.Forms.Button Cancelar_button;
    }
}

