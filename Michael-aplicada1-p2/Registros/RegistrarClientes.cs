using BLL;
using Entidades;
using Michael_aplicada1_p2.Consultas;
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
    public partial class RegistrarClientes : Form
    {
        public RegistrarClientes()
        {
            InitializeComponent();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            NombreTextBox.Enabled = true; ;
            LimiteCreditotextBox.Enabled = true;
            GuardarButton.Enabled = true;
            FechaNacimientodateTimePicker.Enabled = true;
            
            NombreTextBox.Clear();
            LimiteCreditotextBox.Clear();
           
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes();

            cliente.Nombre = NombreTextBox.Text;
            cliente.FechaNacimiento = FechaNacimientodateTimePicker.Value;
            cliente.LimiteCredito = Convert.ToInt32(LimiteCreditotextBox.Text);
           
           
            if (ClientesBLL.Guardar(cliente))
                   MessageBox.Show("Guardado");
                else
                    MessageBox.Show("Error al guardar");
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var cu = new ConsultarUsuarios();
            cu.Visible = true;
            Close();
        }
    }
}
