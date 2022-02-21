using CoolSoft.UI2._0.UiClientesForm;
using CoolSoft.UI2._0.UiOrdenesForm;
using CoolSoft.UI2._0.UiTecnicosForm;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Transitions;

namespace CoolSoft.UI2._0
{
    public partial class UiPrincipal : Form
    {

        int formActivo = 0;
        string titulo = "Hola";
        Form formActual;
        

        /*************MOVER MOUSE**************/


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        /*************FIN MOVER MOUSE**********/

        public UiPrincipal()
        {
            InitializeComponent();

        }

        private void panelBorde_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                
            }
        }

        private void pictureCerrarForm_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            Application.Exit();
        }

        private void pictureMaximizarForm_Click(object sender, EventArgs e)
        {

            
            this.WindowState = FormWindowState.Maximized;

            
            pictureMaximizarForm.Visible = false;
            pictureNormalForm.Visible = true;
        }

        private void pictureNormalForm_Click(object sender, EventArgs e)
        {

            

            this.WindowState = FormWindowState.Normal;
            

            pictureMaximizarForm.Visible = true;
            pictureNormalForm.Visible = false;
        }

        private void pictureMinimizarForm_Click(object sender, EventArgs e)
        {


            this.WindowState = FormWindowState.Minimized;

        }

        /****************************/



        private void UiPrincipal_Resize(object sender, EventArgs e)
        {
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (formActivo != 0)
            {
                formActivo = 0;
                labelTitulo.Text = "BIENVENIDO";

                if (this.panelContenedor.Controls.Count > 0)
                    this.panelContenedor.Controls.RemoveAt(0);
                this.panelContenedor.Controls.Add(pictureBoxPresentacion);
            }
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            if(formActivo != 1)
            {
               

                formActivo = 1;
                CambiarTextoTitulo("CLIENTES");
                

                
                
                

                if (this.panelContenedor.Controls.Count > 0)
                    this.panelContenedor.Controls.RemoveAt(0);
                CrudCliente fh = new CrudCliente();
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            }
        }

        private void buttonTecnicos_Click(object sender, EventArgs e)
        {
            if (formActivo != 2)
            {
                formActivo = 2;
                CambiarTextoTitulo("TECNICOS");
                

                if (this.panelContenedor.Controls.Count > 0)
                    this.panelContenedor.Controls.RemoveAt(0);
                CrudTecnico fh = new CrudTecnico();
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            }
        }

        private void buttonOrdenes_Click(object sender, EventArgs e)
        {
            if (formActivo != 3)
            {
                formActivo = 3;
                CambiarTextoTitulo("ORDENES");

                if (this.panelContenedor.Controls.Count > 0)
                    this.panelContenedor.Controls.RemoveAt(0);
                CrudOrden fh = new CrudOrden(this);
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            }
        }

        private void panelBorde_Resize(object sender, EventArgs e)
        {
            CambiarTextoTitulo(labelTitulo.Text);
        }

       public void CambiarTextoTitulo(string texto)
        {
            labelTitulo.Text = texto;
            int x = panelBorde.Width / 2;
            int y = panelBorde.Height / 2;

            labelTitulo.Location = new Point(x - (labelTitulo.Size.Width / 2), y - (labelTitulo.Size.Height / 2));
            
        }
        

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            int iFormWidth;
            if (panelMenu.Width == 230)
            {
                iFormWidth = 65;
            }
            else
            {
                iFormWidth = 230;
            }
            //Transition.run(panelMenu, "Width", iFormWidth, new TransitionType_EaseInEaseOut(200));
            Transition.run(panelMenu, "Width", iFormWidth, new TransitionType_EaseInEaseOut(300));
        }

        private void UiPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        //private void Transicion(Form actual, Form siguiente, int ac, int si)
        //{
        //    Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
        //    if (ac < si)
        //    {
        //        siguiente.Location = new Point(0,670);

        //        t.add(siguiente, "Top", 0);
        //        t.add(actual, "Top", -670);
        //        t.run();
        //    }
        //    else
        //    {
        //        siguiente.Location = new Point(0, -670);
        //        t.add(siguiente, "Top", 0);
        //        t.add(actual, "Top", 670);
        //        t.run();
        //    }
        //}
    }
}
