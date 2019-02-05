using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Singleton
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void formulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ofrm = new Form1();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se llama a la funcion que evalua si esta instanciado o no
            Form2 ofrm = Form2.ObtenerInstancia();
            ofrm.MdiParent = this;
            ofrm.Show();
        }
    }
}
