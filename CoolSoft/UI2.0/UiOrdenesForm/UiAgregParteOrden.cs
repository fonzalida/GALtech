using CoolSoft.Controlador;
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
    public partial class UiAgregParteOrden : CoolSoft.UI2._0.Genericos.UiAgregar
    {

        public int dni;
        public UiAgregParteOrden()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParteOrdenController.Cargar(
                dtFechaInicio.Text,
                tbTareaDesarrollada.Text
                );
        }

        private void UiAgregParteOrden_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            UiSeleccionarTécnico formSelec = new UiSeleccionarTécnico(this);
            var result = formSelec.ShowDialog();

            if (result == DialogResult.OK)
            {
                mtDni.Text = dni.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
