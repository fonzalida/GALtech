using CoolSoft.Controlador;
using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.REPOSITORIO;
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
    public partial class UiModifParteOrden : CoolSoft.UI2._0.Genericos.UiAgregar
    {
        ParteOrden vieja;
        public UiModifParteOrden(ParteOrden v)
        {
            vieja = v;
            InitializeComponent();
        }

        private void UiModifParteOrden_Load(object sender, EventArgs e)
        {
            dtFechaInicio.Text = vieja.fechaInicio.ToString();
            tbTareaDesarrollada.Text = vieja.tareaDesarrollada;
            
            buttonModificar.Enabled = false;

            if (vieja.completa == 0)
                checkBoxCompletada.Checked = false;
            else
                checkBoxCompletada.Checked = true;

            //textBoxNombreTecnico.Text = TecnicoRepository.BuscarNombre(int.Parse(vieja.dni)); //aca mando dni para buscar por nombre
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            UiAgregParteOrden fagregar = new UiAgregParteOrden();
            UiSeleccionarTécnico formSelec = new UiSeleccionarTécnico(fagregar);
            var result = formSelec.ShowDialog();

            if (result == DialogResult.OK)
            {
                mtDni.Text = fagregar.dni.ToString();
                textBoxNombreTecnico.Text = TecnicoRepository.BuscarNombre(int.Parse(mtDni.Text));
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ParteOrdenController.Modificar(
                
                tbTareaDesarrollada.Text,
                checkBoxCompletada.Checked,
                vieja);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
