using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Datos.Accesos;


namespace Examen2LP3
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
      
        {
            InitializeComponent();
        }

        FrmProducto frmProducto = null;
        FrmPedidos frmPedidos = null;

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTabItem2_Click(object sender, EventArgs e)
        {

            if (frmProducto == null)
            {
                frmProducto = new FrmProducto();
                frmProducto.MdiParent = this;
                //frmProducto.FormClosed += toolStripButton1_FormClosed;
                frmProducto.Show();


            }
            



        }

        private void RibbonPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTabItem3_Click(object sender, EventArgs e)
        {
            if (frmPedidos == null)
            {
                frmPedidos = new FrmPedidos();
                frmPedidos.MdiParent = this;
                //frmPedidos.FormClosed += toolStripButton2_FormClosed;
                frmPedidos.Show();
            }






        }
    }
}
