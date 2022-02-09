using CoolSoft.Properties;
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
    public partial class Base : Form
    {


        // MOVER FORMULARIOS    *******************************************************************

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //                      *******************************************************************


        public Base()
        {
            InitializeComponent();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.Icon = Resources.ICONO_COOLSOFT;
        }

        



        private void pTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }



        /***********************Agregar************************/

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


        public void SeleccionarTodoTexto(object sender, EventArgs e)
        {
            if (sender is MaskedTextBox)
            {
                var masked = sender as MaskedTextBox;
                masked.BeginInvoke(new Action(masked.SelectAll));
            }
            else if (sender is TextBox)
            {
                var text = sender as TextBox;
                text.BeginInvoke(new Action(text.SelectAll));
            }
        }

        public void MascaraNumerica11(MaskedTextBox m)
        {
            m.Mask = "99999999999";
            m.PromptChar = ' ';
        }

        /***********************Fin Agregar************************/



    }
}
