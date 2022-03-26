using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2LP3
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }
        string operacion = string.Empty;

        ProductoDA productoDA = new ProductoDA();
        private void Nuevo_Button_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            Codigo_textBox.Enabled = true;
            Nombrepro_textBox.Enabled = true;
            Descri_textBox.Enabled = true;
            Precio_textBox.Enabled = true;
            Existencia_textBox.Enabled = true;
            Nuevo_Button.Enabled = true;
            Modificar_Button.Enabled = true;
            Guardar_Button.Enabled = true;
            Cancelar_Button.Enabled = true;
        }

        private void DesabilitarControles()
        {
            Codigo_textBox.Enabled = false;
            Nombrepro_textBox.Enabled = false;
            Descri_textBox.Enabled = false;
            Precio_textBox.Enabled = false;
            Existencia_textBox.Enabled = false;
            Nuevo_Button.Enabled = false;
            Modificar_Button.Enabled = false;
            Guardar_Button.Enabled = false;
            Cancelar_Button.Enabled = false;
        }

        private void LimpiarControles()
        {
            Codigo_textBox.Clear();
            Nombrepro_textBox.Clear();
            Descri_textBox.Clear();
            Existencia_textBox.Clear();
        }






        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void ListarProductos()
        {
            Producto_dataGridView.DataSource = productoDA.ListarProductos();
        }



        private void Guardar_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Codigo_textBox.Text))
                {
                    //errorProvider1.SetError(Codigo_textBox, "Ingrese el código del producto");
                    Codigo_textBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(Nombrepro_textBox.Text))
                {
                    //errorProvider1.SetError(Nombrepro_textBox, "Ingrese el nombre del producto");
                    Nombrepro_textBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(Descri_textBox.Text))
                {
                    //errorProvider1.SetError(Descri_textBox, "Ingrese una descripción");
                    Descri_textBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(Precio_textBox.Text))
                {
                    //errorProvider1.SetError(Precio_textBox, "Ingrese un precio");
                    Precio_textBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(Existencia_textBox.Text))
                {
                    //errorProvider1.SetError(Existencia_textBox, "Ingrese una existencia");
                   Existencia_textBox.Focus();
                    return;
                }

                Producto producto = new Producto();
                producto.CodigoProducto = Codigo_textBox.Text;
                producto.Descripcion = Descri_textBox.Text;
                producto.Precio = Convert.ToDecimal(Precio_textBox.Text);
                producto.Existencia = Convert.ToInt32(Existencia_textBox.Text);



            }
            catch (Exception)

            { 
            }
        }

        private void Modificar_Button_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (Producto_dataGridView.SelectedRows.Count > 0)
            {
                Codigo_textBox.Text = Producto_dataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                Descri_textBox.Text = Producto_dataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                Precio_textBox.Text = Producto_dataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                Existencia_textBox.Text = Producto_dataGridView.CurrentRow.Cells["Existencia"].Value.ToString();

               
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }






        }

        private void Eliminar_Button_Click(object sender, EventArgs e)
        {
            if (Producto_dataGridView.SelectedRows.Count > 0)
            {

                bool elimino = productoDA.EliminarProducto(Producto_dataGridView.CurrentRow.Cells["Codigo"].Value.ToString());

                if (elimino)
                {
                    ListarProductos();
                    MessageBox.Show("Producto Eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}
