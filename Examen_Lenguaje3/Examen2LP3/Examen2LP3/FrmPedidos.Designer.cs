namespace Examen2LP3
{
    partial class FrmPedidos
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
            this.Fecha_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Guardar_btn = new System.Windows.Forms.Button();
            this.Descripcion_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubTotal_txt = new System.Windows.Forms.TextBox();
            this.isv_txt = new System.Windows.Forms.TextBox();
            this.CodigoProducto_txt = new System.Windows.Forms.TextBox();
            this.Detalles_dataGridView = new System.Windows.Forms.DataGridView();
            this.Total_txt = new System.Windows.Forms.TextBox();
            this.Cantidad_txt = new System.Windows.Forms.TextBox();
            this.CodigoPedido_txt = new System.Windows.Forms.TextBox();
            this.NombreCliente_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancelar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Detalles_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Fecha_dateTimePicker
            // 
            this.Fecha_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_dateTimePicker.Location = new System.Drawing.Point(613, 12);
            this.Fecha_dateTimePicker.Name = "Fecha_dateTimePicker";
            this.Fecha_dateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.Fecha_dateTimePicker.TabIndex = 46;
            // 
            // Guardar_btn
            // 
            this.Guardar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_btn.Location = new System.Drawing.Point(412, 332);
            this.Guardar_btn.Name = "Guardar_btn";
            this.Guardar_btn.Size = new System.Drawing.Size(89, 23);
            this.Guardar_btn.TabIndex = 45;
            this.Guardar_btn.Text = "Guardar";
            this.Guardar_btn.UseVisualStyleBackColor = true;
            this.Guardar_btn.Click += new System.EventHandler(this.Guardar_btn_Click);
            // 
            // Descripcion_txt
            // 
            this.Descripcion_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion_txt.Location = new System.Drawing.Point(165, 130);
            this.Descripcion_txt.Multiline = true;
            this.Descripcion_txt.Name = "Descripcion_txt";
            this.Descripcion_txt.Size = new System.Drawing.Size(196, 37);
            this.Descripcion_txt.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Descripcion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "SubTotal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "ISV:";
            // 
            // SubTotal_txt
            // 
            this.SubTotal_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal_txt.Location = new System.Drawing.Point(88, 247);
            this.SubTotal_txt.Name = "SubTotal_txt";
            this.SubTotal_txt.Size = new System.Drawing.Size(100, 21);
            this.SubTotal_txt.TabIndex = 40;
            // 
            // isv_txt
            // 
            this.isv_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isv_txt.Location = new System.Drawing.Point(274, 249);
            this.isv_txt.Name = "isv_txt";
            this.isv_txt.Size = new System.Drawing.Size(100, 21);
            this.isv_txt.TabIndex = 39;
            // 
            // CodigoProducto_txt
            // 
            this.CodigoProducto_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoProducto_txt.Location = new System.Drawing.Point(165, 95);
            this.CodigoProducto_txt.Name = "CodigoProducto_txt";
            this.CodigoProducto_txt.Size = new System.Drawing.Size(100, 21);
            this.CodigoProducto_txt.TabIndex = 38;
            // 
            // Detalles_dataGridView
            // 
            this.Detalles_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detalles_dataGridView.Location = new System.Drawing.Point(0, 361);
            this.Detalles_dataGridView.Name = "Detalles_dataGridView";
            this.Detalles_dataGridView.Size = new System.Drawing.Size(824, 151);
            this.Detalles_dataGridView.TabIndex = 37;
            // 
            // Total_txt
            // 
            this.Total_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_txt.Location = new System.Drawing.Point(477, 247);
            this.Total_txt.Name = "Total_txt";
            this.Total_txt.Size = new System.Drawing.Size(100, 21);
            this.Total_txt.TabIndex = 36;
            // 
            // Cantidad_txt
            // 
            this.Cantidad_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad_txt.Location = new System.Drawing.Point(165, 182);
            this.Cantidad_txt.Name = "Cantidad_txt";
            this.Cantidad_txt.Size = new System.Drawing.Size(100, 21);
            this.Cantidad_txt.TabIndex = 35;
            // 
            // CodigoPedido_txt
            // 
            this.CodigoPedido_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoPedido_txt.Location = new System.Drawing.Point(165, 20);
            this.CodigoPedido_txt.Name = "CodigoPedido_txt";
            this.CodigoPedido_txt.Size = new System.Drawing.Size(100, 21);
            this.CodigoPedido_txt.TabIndex = 34;
            // 
            // NombreCliente_txt
            // 
            this.NombreCliente_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCliente_txt.Location = new System.Drawing.Point(165, 53);
            this.NombreCliente_txt.Name = "NombreCliente_txt";
            this.NombreCliente_txt.Size = new System.Drawing.Size(228, 21);
            this.NombreCliente_txt.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(394, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Total a pagar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Nombre del cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Codigo de Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Codigo de Pedido:";
            // 
            // Cancelar_button
            // 
            this.Cancelar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar_button.Location = new System.Drawing.Point(521, 332);
            this.Cancelar_button.Name = "Cancelar_button";
            this.Cancelar_button.Size = new System.Drawing.Size(89, 23);
            this.Cancelar_button.TabIndex = 47;
            this.Cancelar_button.Text = "Cancelar";
            this.Cancelar_button.UseVisualStyleBackColor = true;
            this.Cancelar_button.Click += new System.EventHandler(this.Cancelar_button_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 513);
            this.Controls.Add(this.Cancelar_button);
            this.Controls.Add(this.Fecha_dateTimePicker);
            this.Controls.Add(this.Guardar_btn);
            this.Controls.Add(this.Descripcion_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubTotal_txt);
            this.Controls.Add(this.isv_txt);
            this.Controls.Add(this.CodigoProducto_txt);
            this.Controls.Add(this.Detalles_dataGridView);
            this.Controls.Add(this.Total_txt);
            this.Controls.Add(this.Cantidad_txt);
            this.Controls.Add(this.CodigoPedido_txt);
            this.Controls.Add(this.NombreCliente_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmPedidos";
            this.Text = "FrmPedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Detalles_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Fecha_dateTimePicker;
        private System.Windows.Forms.Button Guardar_btn;
        private System.Windows.Forms.TextBox Descripcion_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SubTotal_txt;
        private System.Windows.Forms.TextBox isv_txt;
        private System.Windows.Forms.TextBox CodigoProducto_txt;
        private System.Windows.Forms.DataGridView Detalles_dataGridView;
        private System.Windows.Forms.TextBox Total_txt;
        private System.Windows.Forms.TextBox Cantidad_txt;
        private System.Windows.Forms.TextBox CodigoPedido_txt;
        private System.Windows.Forms.TextBox NombreCliente_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancelar_button;
    }
}