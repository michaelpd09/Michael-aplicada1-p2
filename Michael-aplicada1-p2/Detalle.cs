using Michael_aplicada1_p2.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Michael_aplicada1_p2
{
    public partial class Detalle : Form
    {
        public Detalle()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarClientes rc = new RegistrarClientes();
            rc.Visible = true;
        }

        private void telefonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rtt = new RegistroTiposTelefono();
            rtt.Show();
        }
    }
}
