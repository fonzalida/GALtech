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

namespace CoolSoft.UI2._0.Genericos
{
    public partial class Eliminar : Form
    {

        /*************MOVER MOUSE**************/


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        /*************FIN MOVER MOUSE**********/


        public Eliminar(String a)
        {
            InitializeComponent();
            label2.Text = a;
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {

            int x = this.Size.Width / 2;
            label1.Location = new Point(x - label1.Size.Width / 2, label1.Location.Y);
            label2.Location = new Point(x - label2.Size.Width / 2, label2.Location.Y);
        }


        private void panelBorde_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }
    }
}
