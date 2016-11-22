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

namespace Michael_aplicada1_p2.Consultas
{
    public partial class ConsultarUsuarios : Form
    {
        public ConsultarUsuarios()
        {
            InitializeComponent();
        }
        public List<Clientes> lista = new List<Clientes>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            this.DatosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.MultiSelect = false;

            CamposComboBox.Text = "Nombre y Fecha";


            if (CamposComboBox.SelectedItem.ToString() == "Nombre")
            {
                if (!String.IsNullOrEmpty(FiltroTextBox.Text))
                    lista = ClientesBLL.GetListaClientes(FiltroTextBox.Text);
                else
                    lista = ClientesBLL.GetLista();
            }
            else
            {

                lista = ClientesBLL.GetLista();
            }
            DatosDataGridView.DataSource = lista;
            EliminarButton.Enabled = true;
            EditarButton.Enabled = true;

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            var ru = new RegistrarClientes();
            ru.Visible = true;

            Close();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.CurrentRow != null)
            {
                var mc = new Registros.ModificarClientes();
                mc.Show();

                mc.UsuarioIDTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                mc.NombreTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                mc.LimiteCreditotextBox.Text = DatosDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                mc.FechaNacimientodateTimePicker.Text = DatosDataGridView.SelectedRows[0].Cells[2].Value.ToString();


            }
            else
            {
                MessageBox.Show("No hay Usuario para Modificar");

            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.CurrentRow != null)
            {
                DialogResult dialogo = MessageBox.Show("Desea Borrar el Querido Usuario", "Borrarando Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    int ClienteId = Convert.ToInt32(DatosDataGridView.CurrentRow.Cells["ClienteId"].Value);
                    ClientesBLL.Eliminar(ClienteId);
                    lista = ClientesBLL.GetLista();
                }
            }
            else
            {
                return;

            }
            DatosDataGridView.DataSource = lista;
        }
    }
}
