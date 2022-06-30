using CoolSoft.Modelo.ENTIDADES;
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
    public partial class UiModificarParteOrden : UiAgregarOrden
    {
        ParteOrden vieja;
        public UiModificarParteOrden(ParteOrden v)
        {
            vieja = v;
            InitializeComponent();
        }

        private void UiModificarParteOrden_Load(object sender, EventArgs e)
        {
            dtFechaRecepcion.Text = vieja.fechaInicio.ToString();
            //tbTareaDesarrollar.Text = vieja.tareaDesarrollada;
            mtIdCliente.Text = vieja.idParte.ToString();
            //buttonModificar.Enabled = false;
            
            if (vieja.completa == 0)
                checkBox1.Checked = false;
            else
                checkBox1.Checked = true;

            //textBoxNombreCliente.Text = TecnicoRepository.BuscarNombre(vieja.dni); aca mando dni para buscar por nombre

        }
    }
}
