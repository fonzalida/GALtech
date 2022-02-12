using System;
using CoolSoft.Controlador;
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
    public partial class UiModificarCliente : UiAgregarCliente
    {
        public UiModificarCliente()
        {
            InitializeComponent();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            /*ClienteController.Modificar(
                mtDniCuit.Text,
                tbNombre.Text,
                tbDomicilio.Text,
                tbLocalidad.Text,
                tbProvincia.Text,
                mtTelefono1.Text,
                mtTelefono2.Text);*/
        }
    }
}
