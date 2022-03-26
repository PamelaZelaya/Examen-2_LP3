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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Aceptar_button_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuarios usuario = new Usuarios();

            usuario = usuarioDA.Login(Usuario_textBox.Text, Clave_textBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("Datos erroneos");
                return;
            }


            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();



        }

        private void Cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
