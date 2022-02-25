using CoolSoft.Controlador;
using CoolSoft.UI2._0.Genericos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.UI2._0.UiClientesForm
{
    public partial class UiAgregarCliente : UiAgregar
    {
        public UiAgregarCliente()
        {
            InitializeComponent();
        }

        private void UiAgregarCliente_Load(object sender, EventArgs e)
        {
            buttonCargar.Enabled = false;
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClienteController.Cargar(
                textBoxDniCuit.Text,
                tbNombre.Text,
                tbDomicilio.Text,
                tbLocalidad.Text,
                tbProvincia.Text,
                textBoxTelefono1.Text,
                textBoxTelefono2.Text);
        }

        private void textBoxNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ValidarText();
        }

        private void ValidarText()
        {
            if (textBoxDniCuit.Text == "" || tbNombre.Text == "" ||
                textBoxDniCuit.Text.Length < 8)
            {
                buttonCargar.Enabled = false;
            }
            else
            {
                buttonCargar.Enabled = true;
            }
        }
    }
}
