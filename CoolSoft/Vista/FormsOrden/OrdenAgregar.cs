using CoolSoft.Vista.Herencia;
using CoolSoft.Vista.Orden.Orden_Agregar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.Vista.Orden
{
    public partial class OrdenAgregar : Agregar
    {
        ClienteSeleccion fCSeleccion;

        OrdenesVer ver;
        public OrdenAgregar(OrdenesVer v)
        {
            InitializeComponent();
            ver = v;
        }

        private void OrdenesAgregar_Load(object sender, EventArgs e)
        {
            lTitulo.Text = "Agregar Orden";
            IniciarMaskFechasIndividual(mtFechaRecepcion);
            IniciarMaskNumericoIndividual_11(mtIdCliente);
        }

        private void OrdenesAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            ver.Enabled = true;
        }

        private void bSeleccionarCliente_Click(object sender, EventArgs e)
        {
            fCSeleccion = new ClienteSeleccion(this);
            fCSeleccion.StartPosition = FormStartPosition.CenterScreen;

            this.Enabled = false;

            fCSeleccion.MdiParent = this.MdiParent;

            fCSeleccion.Show();
        }
    }
}
