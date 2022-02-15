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

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            
        }

        private void UiModificarTecnico_Load(object sender, EventArgs e)
        {
            mtDniCuit.Text = viejo.dni.ToString();
            tbNombre.Text = viejo.nombre;
            mtTelefono1.Text = viejo.telefono;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            TecnicoController.Modificar(
                   mtDniCuit.Text,
                   tbNombre.Text,
                   mtTelefono1.Text,
                   viejo
                   );

            this.Close();
        }
    }
}
