using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class DetallePedido
    {
        public int IdDetallePedidos { get; set; }
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }

        public DetallePedido()
        {
        }

        public DetallePedido(int idDetallePedidos, int idProducto, string codigoProducto, string descripcion, int cantidad, decimal precio, decimal total)
        {
            IdDetallePedidos = idDetallePedidos;
            IdProducto = idProducto;
            CodigoProducto = codigoProducto;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            Total = total;
        }
    }
}
