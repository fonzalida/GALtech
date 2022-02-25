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
            labelTitulo.Text = "MODIFICAR CLIENTE";
            textBoxDniCuit.Text = viejo.dniCuit.ToString();
            tbNombre.Text = viejo.nombre;
            tbDomicilio.Text = viejo.domicilio;
            tbLocalidad.Text = viejo.localidad;
            tbProvincia.Text = viejo.provincia;
            textBoxTelefono1.Text = viejo.telefono1;
            textBoxTelefono2.Text = viejo.telefono2;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ClienteController.Modificar(
                textBoxDniCuit.Text,
                tbNombre.Text,
                tbDomicilio.Text,
                tbLocalidad.Text,
                tbProvincia.Text,
                textBoxTelefono1.Text,
                textBoxTelefono2.Text,
                viejo.idCliente
                );

        }
    }
}
