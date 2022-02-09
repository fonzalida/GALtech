using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.Vista.Herencia
{
    public partial class Detalles : Base
    {
        public Detalles()
        {
            InitializeComponent();
        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            pModificar.Enabled = false;
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            pModificar.Enabled = true;
            bEditar.Enabled = false;

        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            pModificar.Enabled = false;
            bEditar.Enabled = true;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            pModificar.Enabled = false;
            bEditar.Enabled = true;
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
