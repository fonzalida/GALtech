using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            //FixBotones();

            
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Hola mundo");
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void IniciarTextBox()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Enter += new EventHandler(SeleccionarTodoTexto);

            }
        }

        public void IniciarMaskNumerico()
        {
            foreach (MaskedTextBox mt in this.Controls.OfType<MaskedTextBox>())
            {
                mt.Enter += new EventHandler(SeleccionarTodoTexto);
                MascaraNumerica11(mt);
            }
        }

        public void IniciarMaskNumericoIndividual_11(MaskedTextBox m)
        {
            m.Enter += new EventHandler(SeleccionarTodoTexto);
            m.Mask = "99999999999";
            m.PromptChar = ' ';
        }
        public void IniciarMaskFechasIndividual(MaskedTextBox m)
        {
            m.Enter += new EventHandler(SeleccionarTodoTexto);
            m.Mask = "00/00/0000";
            m.PromptChar = '0';
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

        public void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }


        //public void FixBotones()
        //{
            
        //    int x = 90;
            
        //    bCancelar.Location = new Point(440, 4);
        //    bLimpiar.Location = new Point(bCancelar.Location.X-x, 4);
        //    bAgregar.Location = new Point(bLimpiar.Location.X -x, 4);

        //    MessageBox.Show(this.Size.ToString());
        //}

    }
}
