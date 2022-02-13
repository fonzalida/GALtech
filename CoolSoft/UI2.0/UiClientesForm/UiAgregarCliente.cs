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

        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClienteController.Cargar(
                mtDniCuit.Text,
                tbNombre.Text,
                tbDomicilio.Text,
                tbLocalidad.Text,
                tbProvincia.Text,
                mtTelefono1.Text,
                mtTelefono2.Text);

            this.Close();
        }
    }
}
