using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public  class UsuarioDA
    {

        readonly string cadena = "Server=localhost; Port=3306; Database=ExamenBD; Uid=root; Pwd=123456789;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuarios Login(string NombreUsuario, string Clave)
        {

            Usuarios user = null;

            try
            {

                string sql = "SELECT * FROM usuario WHERE NombreUsuario = @NombreUsuario AND Clave = @Clave;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("NombreUsuario", NombreUsuario);
                cmd.Parameters.AddWithValue("@Clave", Clave);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuarios ();
                    user.NombreUsuario= reader[0].ToString();
                    user.Clave = reader[1].ToString();
                }
                reader.Close();
                conn.Close();
            }

            catch (Exception ex)
            {

            }
            return user;

        }
    }
}
