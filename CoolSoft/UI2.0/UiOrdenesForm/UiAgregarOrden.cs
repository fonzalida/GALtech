using CoolSoft.Controlador;
using CoolSoft.Modelo.REPOSITORIO;
using CoolSoft.UI2._0.Genericos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoolSoft.UI2._0.UiOrdenesForm
{
    public partial class UiAgregarOrden : CoolSoft.UI2._0.Genericos.UiAgregar
    {

        public int idCliente;
        public UiAgregarOrden()
        {
            InitializeComponent();
        }

        private void UiAgregarOrden_Load(object sender, EventArgs e)
        {
            buttonCargar.Enabled = false;
            
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            OrdenController.Cargar(tbTareaDesarrollar.Text, mtIdCliente.Text, dtFechaRecepcion.Text);
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            UiSeleccionarCliente formSelec = new UiSeleccionarCliente(this);
            var result = formSelec.ShowDialog();

            if (result == DialogResult.OK)
            {
                mtIdCliente.Text = idCliente.ToString();
            }
        }

        private void mtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if(mtIdCliente.Text == "")
            {
                textBoxNombreCliente.Text = "";
                buttonCargar.Enabled = false;
            }
            else
            {
                textBoxNombreCliente.Text = ClienteRepository.BuscarNombre(int.Parse(mtIdCliente.Text));
                buttonCargar.Enabled = true;
            }
        }
    }
}
