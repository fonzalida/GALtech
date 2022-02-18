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

namespace CoolSoft.UI2._0.UiOrdenesForm
{
    public partial class UiModificarOrden : UiAgregarOrden
    { 
        Orden viejo;
        public UiModificarOrden(Orden o)
        {
            viejo = o;
            InitializeComponent();
        }

        private void UiModificarOrden_Load(object sender, EventArgs e)
        {
            //dtFechaRecepcion.Text = viejo.fechaRecepcion.ToString();
            //tbTareaDesarrollar.Text = viejo.tareaDesarrollar;
            //tbIdCliente.Text = viejo.idCliente;
        }
    }
}
