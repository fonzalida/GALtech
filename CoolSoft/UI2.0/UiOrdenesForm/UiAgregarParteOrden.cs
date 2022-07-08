using CoolSoft.Controlador;
using CoolSoft.Modelo.REPOSITORIO;
using CoolSoft.UI2._0.Genericos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.UI2._0.UiOrdenesForm
{
    public partial class UiAgregarParteOrden : UiAgregarOrden
    {
        public int dni;
        public UiAgregarParteOrden()
        {
            InitializeComponent();
        }

        private void UiAgregarParteOrden_Load(object sender, EventArgs e)
        {
            buttonCargar.Enabled = false;
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            //ParteOrdenController.Cargar(
            //    tbTareaDesarrollar.Text,
            //    //hay q ver q mas se agrega
            //    dtFechaRecepcion.Text);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            /*UiSeleccionarTecnico formSelec = new UiSeleccionarTecnico(this);
            var result = formSelec.ShowDialog();

            if (result == DialogResult.OK)
            {
                //mtIdTecnico.Text = dni.ToString();
            }*/
        }

        private void mtIdCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtIdCliente.Text == "")
            {
                textBoxNombreCliente.Text = "";
                buttonCargar.Enabled = false;
            }
            else
            {
                textBoxNombreCliente.Text = TecnicoRepository.BuscarNombre(int.Parse(mtIdCliente.Text));
                buttonCargar.Enabled = true;
            }
        }
    }
}
