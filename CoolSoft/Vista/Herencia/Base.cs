using CoolSoft.Properties;
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
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.Icon = Resources.ICONO_COOLSOFT;
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


    }
}
