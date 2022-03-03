using CoolSoft.Controlador;
using CoolSoft.Modelo.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.UI2._0.UiTecnicosForm
{
    public partial class UiModificarTecnico : UiAgregarTecnico
    {
        Tecnico viejo;
        public UiModificarTecnico(Tecnico t)
        {
            viejo = t;
            InitializeComponent();
        }

        private void UiModificarTecnico_Load(object sender, EventArgs e)
        {
            textBoxDni.Text = viejo.dni.ToString();
            tbNombre.Text = viejo.nombre;
            textBoxTelefono.Text = viejo.telefono;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            TecnicoController.Modificar(
                   textBoxDni.Text,
                   tbNombre.Text,
                   textBoxTelefono.Text,
                   viejo
                   );

        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ValidarText();
        }
        private void ValidarText()
        {
            if ((textBoxDni.Text == "" || tbNombre.Text == "") ||
                textBoxDni.Text.Length < 8)
            {
                buttonModificar.Enabled = false;
            }
            else
            {
                buttonModificar.Enabled = true;
            }
        }
    }
}
