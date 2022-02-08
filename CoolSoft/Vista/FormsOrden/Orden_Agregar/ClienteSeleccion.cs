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

namespace CoolSoft.Vista.Orden.Orden_Agregar
{
    public partial class ClienteSeleccion : Seleccion
    {

        OrdenAgregar fAgregar;
        public ClienteSeleccion(OrdenAgregar f)
        {
            InitializeComponent();
            fAgregar = f;
        }

        private void ClienteSeleccion_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            lTitulo.Text = "Seleccionar Cliente";
        }

        private void ClienteSeleccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            fAgregar.Enabled = true;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_Enter(object sender, EventArgs e)
        {
            LimpiarBusqueda(mtId, mtNombre);
        }
    }
}
