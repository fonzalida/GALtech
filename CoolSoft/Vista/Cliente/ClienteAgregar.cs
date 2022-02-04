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
        public ClienteAgregar()
        {
            InitializeComponent();
        }

        private void ClienteAgregar_Load(object sender, EventArgs e)
        {
            lTitulo.Text = "Agregar Cliente";
        }
    }
}
