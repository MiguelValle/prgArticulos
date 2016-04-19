using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Modelo;

namespace prgArticulos
{
    public partial class mdiMenu : Form
    {
        clsConexionSQL conexion;
       
        public mdiMenu(clsConexionSQL conexion)
        {
            this.conexion = conexion;  // importante andar el objeto cone para interactuar con la base de datos
            InitializeComponent();
        }

        private void mdiMenu_Load(object sender, EventArgs e)
        {

        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios(conexion);
            usuario.ShowDialog(); // esto significa que la ventana sera hija de donde fue invocada
        }
    }
}
