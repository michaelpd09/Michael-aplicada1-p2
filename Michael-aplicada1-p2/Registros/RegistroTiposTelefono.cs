using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Michael_aplicada1_p2.Registros
{
    public partial class RegistroTiposTelefono : Form
    {
        public RegistroTiposTelefono()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            DescripciontextBox.Enabled = true;
            Guardarbutton.Enabled = true;
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var tiposTelefonos = new TiposTelefonos();

            tiposTelefonos.Descripcion = DescripciontextBox.Text;
           


            if (TiposTelefonosBLL.Guardar(tiposTelefonos))
                MessageBox.Show("Guardado");
            else
                MessageBox.Show("Error al guardar");
        }
    }
}
