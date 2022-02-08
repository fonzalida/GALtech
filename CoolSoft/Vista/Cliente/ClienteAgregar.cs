using CoolSoft.Vista.Herencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.Vista.Cliente
{
    public partial class ClienteAgregar : Agregar
    {
        ClienteVer ver;
        public ClienteAgregar(ClienteVer v)
        {
            InitializeComponent();
            ver = v;
        }

        private void ClienteAgregar_Load(object sender, EventArgs e)
        {
            lTitulo.Text = "Agregar Cliente";

            IniciarTextBox();
            IniciarMaskNumerico();
        }

        private void ClienteAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            ver.Enabled = true;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
