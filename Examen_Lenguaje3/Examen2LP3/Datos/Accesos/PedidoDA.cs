using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class PedidoDA
    {

        readonly string cadena = "Server=localhost; Port=3306; Database=ExamenBD; Uid=root; Pwd=123456789;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public int InsertarFactura(Pedido pedido)
        {
            int  IdProducto = 0;
            try

            {
                string sql = "INSERT INTO pedidos (IdentidadCliente, Cliente, Fecha, SubTotal, Impuesto, Total) VALUES (@IdentidadCliente, @Cliente, @Fecha, @SubTotal, @Impuesto, @Total); select last_insert_id();";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdentidadCliente", pedido.IdentidadCliente);
                cmd.Parameters.AddWithValue("@Cliente", pedido.Cliente);
                cmd.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                cmd.Parameters.AddWithValue("@SubTotal", pedido.SubTotal);
                cmd.Parameters.AddWithValue("@Impuesto", pedido.ISV);
                cmd.Parameters.AddWithValue("@Total", pedido.Total);
                IdProducto = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return IdProducto;

        }


        public bool InsertarDetalle(DetallePedido detallePedido)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO DetallePedidos (IdFactura, CodigoProducto, Descripcion, Cantidad, Precio, Total) VALUES (@IdFactura, @CodigoProducto, @Descripcion, @Cantidad, @Precio, @Total);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

               // cmd.Parameters.AddWithValue("@IdDetallePedidos", detallePedido.IdDetallePedidos);
                cmd.Parameters.AddWithValue("@IdProducto", detallePedido.IdProducto);
                cmd.Parameters.AddWithValue("@CodigoProducto", detallePedido.CodigoProducto);
                cmd.Parameters.AddWithValue("@Descripcion", detallePedido.Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad", detallePedido.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", detallePedido.Precio);
                cmd.Parameters.AddWithValue("@Total", detallePedido.Total);
                cmd.ExecuteNonQuery();

                inserto = true;
                conn.Close();
            }
            catch (Exception)
            {
            }
            return inserto;
        }
    }
}
