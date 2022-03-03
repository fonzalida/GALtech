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
    public partial class Seleccion : Base
    {
        public Seleccion()
        {
            InitializeComponent();
        }

        private void Seleccion_Load(object sender, EventArgs e)
        {

        }



        public void LimpiarBusqueda(MaskedTextBox tb1, MaskedTextBox tb2)
        {
            if(tb1.Text != "") tb1.Text = "";

            if (tb2.Text != "") tb2.Text = "";

        }
    }
}
