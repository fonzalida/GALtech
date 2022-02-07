using CoolSoft.Properties;
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
    public partial class ClienteVer : Historico
    {

        ClienteAgregar fAgregar;

        public ClienteVer()
        {
            InitializeComponent();
            lTitulo.Text = "Clientes";
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void ClienteVer_Load(object sender, EventArgs e)
        {
            this.Name = "Clientes";
            InitBotonesMinClose();

        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            fAgregar = new ClienteAgregar(this);
            fAgregar.StartPosition = FormStartPosition.CenterScreen;

            this.Enabled = false;

            fAgregar.MdiParent = this.MdiParent;

            fAgregar.FormBorderStyle = FormBorderStyle.None;
            fAgregar.Show();
        }
    }
}
