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
using CoolSoft.Modelo.ENTIDADES;

namespace CoolSoft.UI2._0.UiClientesForm
{
    public partial class UiModificarCliente : UiAgregarCliente
    {
        Cliente viejo;

        public UiModificarCliente(Cliente c)
        {
            viejo = c;
            InitializeComponent();
        }

        private void UiModificarCliente_Load(object sender, EventArgs e)
        {
            
            mtDniCuit.Text = viejo.dniCuit.ToString();
            tbNombre.Text = viejo.nombre;
            tbDomicilio.Text = viejo.domicilio;
            tbLocalidad.Text = viejo.localidad;
            tbProvincia.Text = viejo.provincia;
            mtTelefono1.Text = viejo.telefono1;
            mtTelefono2.Text = viejo.telefono2;
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClienteController.Modificar(
                mtDniCuit.Text,
                tbNombre.Text,
                tbDomicilio.Text,
                tbLocalidad.Text,
                tbProvincia.Text,
                mtTelefono1.Text,
                mtTelefono2.Text,
                viejo.idCliente
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteController.Modificar(
                mtDniCuit.Text,
                tbNombre.Text,
                tbDomicilio.Text,
                tbLocalidad.Text,
                tbProvincia.Text,
                mtTelefono1.Text,
                mtTelefono2.Text,
                viejo.idCliente
                );

            this.Close();
        }
    }
}
