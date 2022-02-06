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
    public partial class Agregar : Base
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Hola mundo");
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        public void InicializarTextos()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Enter += new EventHandler(SeleccionarTodoTexto);

            }
            foreach (MaskedTextBox mt in this.Controls.OfType<MaskedTextBox>())
            {
                mt.Enter += new EventHandler(SeleccionarTodoTexto);
                MascaraNumerica11(mt);
            }

        }
        public void LimpiarTextBox()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = "";
            }
            foreach (MaskedTextBox mt in this.Controls.OfType<MaskedTextBox>())
            {
                mt.Text = "";
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }
    }
}
