using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Vista.Herencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CoolSoft.Vista.FormsCliente
{
    public partial class ClienteDetalles : Detalles
    {
        Cliente clienteViejo;
        Cliente clienteNuevo;

        public ClienteDetalles(Cliente c)
        {
            InitializeComponent();
            clienteViejo = c;
            clienteNuevo = null;
        }

        private void ClienteDetalles_Load(object sender, EventArgs e)
        {
            IniciarTextBox();
            
            foreach(MaskedTextBox mt in this.Controls.OfType<MaskedTextBox>())
            {
                IniciarMaskNumericoIndividual_11(mt);
            }
        }
    }
}
