using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuarios
    {
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }


        public Usuarios()
        {
        }

        public Usuarios(string nombreUsuario, string clave)
        {
            NombreUsuario = nombreUsuario;
            Clave = clave;
        }
    }
}
