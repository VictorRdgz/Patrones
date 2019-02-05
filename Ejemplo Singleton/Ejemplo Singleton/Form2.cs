using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//El patron singleton garantiza que una clase sea de instancia unica, una sola instancia para una clase creada
namespace Ejemplo_Singleton
{
    public partial class Form2 : Form
    {
        //Esto hace la funcion de Singleton 
        private static Form2 _instancia;

        public static Form2 ObtenerInstancia()
        {   //Esta funcion evalua si esta inciado o no

            if (_instancia == null || _instancia.IsDisposed)
            {   //Si esta inciado, o se cerro la ventana se crea otro de lo contrario no lo hara

                _instancia = new Form2();

            }
            //Esta funcion hace que el formulario elegido pase hasta el frente 
            _instancia.BringToFront();
            return _instancia;

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
