using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Producto
    {
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
      

        public Producto()
        {
        }

        public Producto(string codigoProducto, string nombreProducto, string descripcion, decimal precio, int existencia)
        {
            CodigoProducto = codigoProducto;
            NombreProducto = nombreProducto;
            Descripcion = descripcion;
            Precio = precio;
            Existencia = existencia;
        }
    }
}
