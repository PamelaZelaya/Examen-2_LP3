namespace Examen2LP3
{
    partial class FrmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Codigo_textBox = new System.Windows.Forms.TextBox();
            this.Nombrepro_textBox = new System.Windows.Forms.TextBox();
            this.Descri_textBox = new System.Windows.Forms.TextBox();
            this.Precio_textBox = new System.Windows.Forms.TextBox();
            this.Existencia_textBox = new System.Windows.Forms.TextBox();
            this.Producto_dataGridView = new System.Windows.Forms.DataGridView();
            this.Cancelar_Button = new System.Windows.Forms.Button();
            this.Eliminar_Button = new System.Windows.Forms.Button();
            this.Guardar_Button = new System.Windows.Forms.Button();
            this.Modificar_Button = new System.Windows.Forms.Button();
            this.Nuevo_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Producto_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Existencia";
            // 
            // Codigo_textBox
            // 
            this.Codigo_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_textBox.Location = new System.Drawing.Point(162, 31);
            this.Codigo_textBox.Name = "Codigo_textBox";
            this.Codigo_textBox.Size = new System.Drawing.Size(201, 21);
            this.Codigo_textBox.TabIndex = 5;
            // 
            // Nombrepro_textBox
            // 
            this.Nombrepro_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrepro_textBox.Location = new System.Drawing.Point(162, 62);
            this.Nombrepro_textBox.Name = "Nombrepro_textBox";
            this.Nombrepro_textBox.Size = new System.Drawing.Size(480, 21);
            this.Nombrepro_textBox.TabIndex = 6;
            // 
            // Descri_textBox
            // 
            this.Descri_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descri_textBox.Location = new System.Drawing.Point(162, 99);
            this.Descri_textBox.Multiline = true;
            this.Descri_textBox.Name = "Descri_textBox";
            this.Descri_textBox.Size = new System.Drawing.Size(480, 72);
            this.Descri_textBox.TabIndex = 7;
            // 
            // Precio_textBox
            // 
            this.Precio_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_textBox.Location = new System.Drawing.Point(162, 186);
            this.Precio_textBox.Name = "Precio_textBox";
            this.Precio_textBox.Size = new System.Drawing.Size(201, 21);
            this.Precio_textBox.TabIndex = 8;
            // 
            // Existencia_textBox
            // 
            this.Existencia_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Existencia_textBox.Location = new System.Drawing.Point(162, 224);
            this.Existencia_textBox.Name = "Existencia_textBox";
            this.Existencia_textBox.Size = new System.Drawing.Size(201, 21);
            this.Existencia_textBox.TabIndex = 9;
            // 
            // Producto_dataGridView
            // 
            this.Producto_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Producto_dataGridView.Location = new System.Drawing.Point(0, 351);
            this.Producto_dataGridView.Name = "Producto_dataGridView";
            this.Producto_dataGridView.Size = new System.Drawing.Size(863, 190);
            this.Producto_dataGridView.TabIndex = 10;
            // 
            // Cancelar_Button
            // 
            this.Cancelar_Button.Enabled = false;
            this.Cancelar_Button.Location = new System.Drawing.Point(550, 300);
            this.Cancelar_Button.Name = "Cancelar_Button";
            this.Cancelar_Button.Size = new System.Drawing.Size(78, 31);
            this.Cancelar_Button.TabIndex = 25;
            this.Cancelar_Button.Text = "Cancelar";
            this.Cancelar_Button.UseVisualStyleBackColor = true;
            // 
            // Eliminar_Button
            // 
            this.Eliminar_Button.Location = new System.Drawing.Point(436, 300);
            this.Eliminar_Button.Name = "Eliminar_Button";
            this.Eliminar_Button.Size = new System.Drawing.Size(78, 31);
            this.Eliminar_Button.TabIndex = 24;
            this.Eliminar_Button.Text = "Eliminar";
            this.Eliminar_Button.UseVisualStyleBackColor = true;
            this.Eliminar_Button.Click += new System.EventHandler(this.Eliminar_Button_Click);
            // 
            // Guardar_Button
            // 
            this.Guardar_Button.Enabled = false;
            this.Guardar_Button.Location = new System.Drawing.Point(309, 300);
            this.Guardar_Button.Name = "Guardar_Button";
            this.Guardar_Button.Size = new System.Drawing.Size(78, 31);
            this.Guardar_Button.TabIndex = 23;
            this.Guardar_Button.Text = "Guardar";
            this.Guardar_Button.UseVisualStyleBackColor = true;
            this.Guardar_Button.Click += new System.EventHandler(this.Guardar_Button_Click);
            // 
            // Modificar_Button
            // 
            this.Modificar_Button.Location = new System.Drawing.Point(194, 300);
            this.Modificar_Button.Name = "Modificar_Button";
            this.Modificar_Button.Size = new System.Drawing.Size(78, 31);
            this.Modificar_Button.TabIndex = 22;
            this.Modificar_Button.Text = "Modificar";
            this.Modificar_Button.UseVisualStyleBackColor = true;
            this.Modificar_Button.Click += new System.EventHandler(this.Modificar_Button_Click);
            // 
            // Nuevo_Button
            // 
            this.Nuevo_Button.Location = new System.Drawing.Point(85, 300);
            this.Nuevo_Button.Name = "Nuevo_Button";
            this.Nuevo_Button.Size = new System.Drawing.Size(78, 31);
            this.Nuevo_Button.TabIndex = 21;
            this.Nuevo_Button.Text = "Nuevo";
            this.Nuevo_Button.UseVisualStyleBackColor = true;
            this.Nuevo_Button.Click += new System.EventHandler(this.Nuevo_Button_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 539);
            this.Controls.Add(this.Cancelar_Button);
            this.Controls.Add(this.Eliminar_Button);
            this.Controls.Add(this.Guardar_Button);
            this.Controls.Add(this.Modificar_Button);
            this.Controls.Add(this.Nuevo_Button);
            this.Controls.Add(this.Producto_dataGridView);
            this.Controls.Add(this.Existencia_textBox);
            this.Controls.Add(this.Precio_textBox);
            this.Controls.Add(this.Descri_textBox);
            this.Controls.Add(this.Nombrepro_textBox);
            this.Controls.Add(this.Codigo_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Producto_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Codigo_textBox;
        private System.Windows.Forms.TextBox Nombrepro_textBox;
        private System.Windows.Forms.TextBox Descri_textBox;
        private System.Windows.Forms.TextBox Precio_textBox;
        private System.Windows.Forms.TextBox Existencia_textBox;
        private System.Windows.Forms.DataGridView Producto_dataGridView;
        private System.Windows.Forms.Button Cancelar_Button;
        private System.Windows.Forms.Button Eliminar_Button;
        private System.Windows.Forms.Button Guardar_Button;
        private System.Windows.Forms.Button Modificar_Button;
        private System.Windows.Forms.Button Nuevo_Button;
    }
}