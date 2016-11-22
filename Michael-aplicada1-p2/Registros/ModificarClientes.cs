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
    public partial class ModificarClientes : Form
    {
        public ModificarClientes()
        {
            InitializeComponent();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            ClientesBLL.Modificar(new Clientes()
            {
                ClienteId = Convert.ToInt32(UsuarioIDTextBox.Text),
                Nombre = NombreTextBox.Text,
                FechaNacimiento = FechaNacimientodateTimePicker.Value,
                LimiteCredito = Convert.ToInt32(LimiteCreditotextBox.Text),

            });

            DialogResult dialogo = MessageBox.Show("Datos Actualizados Correctamente");
         
            Close();
          

        }
    }
}
