using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.UI2._0.Genericos
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();

            

            labelHora.Text = DateTime.Now.ToString("HH:mm");
            labelDia.Text = DateTime.Now.ToString("ddd dd MMM");

            labelDia.Location = new Point(8, labelDia.Location.Y);
            labelHora.Location = new Point(this.Size.Width - 8 - labelHora.Width, labelDia.Location.Y);
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            if (labelHora.Text.IndexOf(':') != -1)
            {
                labelHora.Text = DateTime.Now.ToString("HH mm");

            }
            else
            {
                labelHora.Text = DateTime.Now.ToString("HH:mm");
            }

            labelDia.Text = DateTime.Now.ToString("ddd dd MMM");


        }
    }
}
