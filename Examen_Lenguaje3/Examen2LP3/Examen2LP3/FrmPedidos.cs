using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;


namespace Examen2LP3
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void Guardar_btn_Click(object sender, EventArgs e)
        {
           
            pedidos.IdentidadCliente = NombreCliente_txt.Text;
            pedidos.Fecha = Fecha_dateTimePicker.Value;
            pedidos.SubTotal = Convert.ToDecimal(SubTotal_txt.Text);
            pedidos.ISV = Convert.ToDecimal(isv_txt.Text);
            pedidos.Total = Convert.ToDecimal(Total_txt.Text);

            int IdPedidos = 0;



            if (IdPedidos != 0)
            {
                foreach (var item in detallePedidosLista)
                {
                    
                    pedidosDA.InsertarDetalle(item);
                }
            }
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            Detalles_dataGridView.DataSource = detallePedidosLista;
        }

        ProductoDA productoDA = new ProductoDA();
        Pedido pedidos = new Pedido();
        Producto producto;
        PedidoDA pedidosDA = new PedidoDA();

        List<DetallePedido> detallePedidosLista = new List<DetallePedido>();

        decimal SubTotal = decimal.Zero;
        decimal ISV = decimal.Zero;
        decimal Total = decimal.Zero;




        private void Cantidad_txt_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(Cantidad_txt.Text))
            {
                DetallePedido detallePedido = new DetallePedido();

                detallePedido.Descripcion = producto.Descripcion;
                detallePedido.Cantidad = Convert.ToInt32(Cantidad_txt.Text);
                detallePedido.Precio = producto.Precio;
                detallePedido.Total = producto.Precio * Convert.ToInt32(Cantidad_txt.Text);

                SubTotal += detallePedido.Total;
                ISV = SubTotal * 0.15M;
                Total = SubTotal + ISV;

                SubTotal_txt.Text = SubTotal.ToString();
                isv_txt.Text = ISV.ToString();
                Total_txt.Text = Total.ToString();

                detallePedidosLista.Add(detallePedido);
                Detalles_dataGridView.DataSource = null;
            }
        }

        private void Cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }
    }
}
