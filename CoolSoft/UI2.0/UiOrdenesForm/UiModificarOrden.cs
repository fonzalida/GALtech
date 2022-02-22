using CoolSoft.Modelo.ENTIDADES;
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
    public partial class UiModificarOrden : UiAgregar
    {
        Orden vieja;

        public UiModificarOrden(Orden v)
        {
            vieja = v;
            InitializeComponent();
            Console.WriteLine(vieja.idOrden);
        }

        private void textBoxImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
             

            if (
            !char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && (e.KeyChar != '.'))
            {
                // Then it is NOT a character we want allowed in the text box.
                e.Handled = false;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ( char.IsDigit(e.KeyChar) && ((sender as TextBox).Text.IndexOf('.') > -1) &&  ((sender as TextBox).Text.IndexOf('.') == ((sender as TextBox).TextLength) -3))
            {
                e.Handled = true;
            }
        }

        private void UiModificarOrden_Load(object sender, EventArgs e)
        {
            dtFechaRecepcion.Text = vieja.fechaRecepcion.ToString();
            tbTareaDesarrollar.Text = vieja.tareaDesarrollar;
            mtIdCliente.Text = vieja.idCliente.ToString();
        }

        //private void buttonModificar_Click(object sender, EventArgs e)
        //{
        //    OrdenController.Modificar(
        //           dtFechaRecepcion.Text,
        //           tbTareaDesarrollar.Text,
        //           mtIdCliente.Text,
        //           vieja
        //           );

        //    this.Close();
        //}
    }
}
