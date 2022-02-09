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

namespace CoolSoft.Vista.Tecnico
{
    public partial class TecnicoAgregar : Agregar
    {
        TecnicosVer ver;
        public TecnicoAgregar(TecnicosVer v)
        {
            InitializeComponent();
            ver = v;
        }

     

        private void TecnicoAgregar_Load(object sender, EventArgs e)
        {
            lTitulo.Text = "Agregar Tecnico";

            IniciarTextBox();
            IniciarMaskNumerico();
        }

        private void TecnicoAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            ver.Enabled = true;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {

        }

        private void bAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
