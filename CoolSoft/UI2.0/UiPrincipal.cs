using CoolSoft.UI2._0.Genericos;
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

        int indiceActivo = -1;
        string titulo = "Hola";
        bool transicionActiva = false;
        bool menuMinimizado = false;

        Form[] ListaForm = new Form[4];


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

        private void UiPrincipal_Load(object sender, EventArgs e)
        {
            Format.FormularioBorde(this,false);
            CambiarFormulario(0);
            foreach(Control c in panelMenu.Controls)
            {
                c.MouseHover += Menu_MouseHover;
            }
        }

        private void Menu_MouseHover(object sender, EventArgs e)
        {
            if (panelMenu.Width == 65)
            {
                int iFormWidth = 230;
                Transition.run(panelMenu, "Width", iFormWidth, new TransitionType_EaseInEaseOut(200));
            }

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




        private void buttonInicio_Click(object sender, EventArgs e)
        {

            CambiarFormulario(0);
            //if (formActivo != 0)
            //{
            //    if (this.panelContenedor.Controls.Count > 0)
            //        this.panelContenedor.Controls.RemoveAt(0);

            //    formActivo = 0;

            //    CambiarTextoTitulo("BIENVENIDO");

            //    if (ListaForm[formActivo] == null) 
            //    {
            //        Console.WriteLine("ENCONTRO NULL");
            //        Presentacion fh = new Presentacion();
            //        fh.TopLevel = false;
            //        fh.Dock = DockStyle.Fill;
            //        ListaForm[formActivo] = fh;
            //        fh.Show();
            //        this.panelContenedor.Controls.Add(ListaForm[formActivo]);
            //    }   
            //    else
            //        this.panelContenedor.Controls.Add(ListaForm[formActivo]);
            //}
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {

            CambiarFormulario(1);

        }

        private void buttonTecnicos_Click(object sender, EventArgs e)
        {

            CambiarFormulario(2);

        }

        private void buttonOrdenes_Click(object sender, EventArgs e)
        {

            CambiarFormulario(3);

        }

        private void CambiarFormulario(int indice)
        {
            if(!transicionActiva)
            {
                if (indiceActivo != indice)
                {
                    int indiceAntiguo = indiceActivo;

                    indiceActivo = indice;

                    if (ListaForm[indiceActivo] == null)
                    {
                        Form fh = new Form();
                        Console.WriteLine("ENCONTRO NULL");
                        switch (indice)
                        {
                            case 0:
                                CambiarTextoTitulo("INICIO");
                                fh = new Presentacion();
                                break;

                            case 1:
                                CambiarTextoTitulo("CLIENTES");
                                fh = new CrudCliente();
                                break;

                            case 2:
                                CambiarTextoTitulo("TECNICOS");
                                fh = new CrudTecnico();
                                break;

                            case 3:
                                CambiarTextoTitulo("ORDENES");
                                fh = new CrudOrden(this);
                                break;
                        }
                        fh.Size = panelContenedor.Size;
                        fh.TopLevel = false;
                        //fh.Dock = DockStyle.Fill;
                        ListaForm[indiceActivo] = fh;

                        this.panelContenedor.Controls.Add(ListaForm[indiceActivo]);
                    }
                    else
                    {
                        switch (indice)
                        {
                            case 0: CambiarTextoTitulo("INICIO"); break;
                            case 1: CambiarTextoTitulo("CLIENTES"); break;
                            case 2: CambiarTextoTitulo("TECNICOS"); break;
                            case 3: CambiarTextoTitulo("ORDENES"); break;
                        }
                        this.panelContenedor.Controls.Add(ListaForm[indiceActivo]);
                    }

                    Transicion(indiceAntiguo, indiceActivo);




                    //if (formActivo != indice)
                    //{
                    //    if (this.panelContenedor.Controls.Count > 0)
                    //        this.panelContenedor.Controls.RemoveAt(0);

                    //    formActivo = indice;

                    //    if (ListaForm[formActivo] == null)
                    //    {
                    //        Form fh = new Form();
                    //        Console.WriteLine("ENCONTRO NULL");
                    //        switch (indice)
                    //        {
                    //            case 0:
                    //                CambiarTextoTitulo("INICIO");
                    //                fh = new Presentacion();
                    //                break;   

                    //            case 1:
                    //                CambiarTextoTitulo("CLIENTES");
                    //                fh = new CrudCliente();
                    //                break;

                    //            case 2:
                    //                CambiarTextoTitulo("TECNICOS");
                    //                fh = new CrudTecnico();
                    //                break;

                    //            case 3:
                    //                CambiarTextoTitulo("ORDENES");
                    //                fh = new CrudOrden(this);
                    //                break;
                    //        }
                    //        fh.Size = panelContenedor.Size;
                    //        fh.TopLevel = false;
                    //        //fh.Dock = DockStyle.Fill;
                    //        ListaForm[formActivo] = fh;
                    //        fh.Show();
                    //        this.panelContenedor.Controls.Add(ListaForm[formActivo]);
                    //    }
                    //    else
                    //    {
                    //        switch (indice)
                    //        {
                    //            case 0:CambiarTextoTitulo("INICIO");break;
                    //            case 1:CambiarTextoTitulo("CLIENTES");break;
                    //            case 2:CambiarTextoTitulo("TECNICOS");break;
                    //            case 3:CambiarTextoTitulo("ORDENES"); break;
                    //        }
                    //        this.panelContenedor.Controls.Add(ListaForm[formActivo]);
                    //    }

                }
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
            TransicionMenu(true);
        }

        private void TransicionMenu(bool boton)
        {
            int iFormWidth;
            if (panelMenu.Width < 230)
                iFormWidth = 230;
            else
                iFormWidth = 65;

            if (boton)
            {
                menuMinimizado = !menuMinimizado;
                if (menuMinimizado)
                {
                }
                else
                {
                }
            }
            
            Transition.run(panelMenu, "Width", iFormWidth, new TransitionType_EaseInEaseOut(150));
        }

        private void Transicion(int an, int ac)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(200));
            if(an != -1)
            {
                t.TransitionCompletedEvent += new EventHandler<Transition.Args>(OnTransitionCompleted);

                this.panelContenedor.Controls[0].Dock = DockStyle.None;
                this.panelContenedor.Controls[0].Size = panelContenedor.Size;

                this.panelContenedor.Controls[1].Dock = DockStyle.None;
                this.panelContenedor.Controls[1].Size = panelContenedor.Size;
                


                if (an < ac)
                {
                    //Screen.PrimaryScreen.Bounds.Height;

                    this.panelContenedor.Controls[1].Location = new Point(0, panelContenedor.Height);
                    this.panelContenedor.Controls[1].Show();

                    //t.add(this.panelContenedor.Controls[0], "Top", -panelContenedor.Height);
                    t.add(this.panelContenedor.Controls[0], "Top", -Screen.PrimaryScreen.Bounds.Height);
                    t.add(this.panelContenedor.Controls[1], "Top", 0);
                    transicionActiva = true;
                    t.run();
                }
                else
                {

                    this.panelContenedor.Controls[1].Location = new Point(0, - Screen.PrimaryScreen.Bounds.Height);
                    this.panelContenedor.Controls[1].Show();

                    t.add(this.panelContenedor.Controls[0], "Top", Screen.PrimaryScreen.Bounds.Height);
                    t.add(this.panelContenedor.Controls[1], "Top", 0);
                    transicionActiva = true;
                    t.run();
                }
            }
            else
            {
                this.panelContenedor.Controls[0].Size = panelContenedor.Size;
                this.panelContenedor.Controls[0].Dock = DockStyle.Fill;
                this.panelContenedor.Controls[0].Show();
            }

            
        }

        private void OnTransitionCompleted(object sender, Transition.Args e)
        {
            this.panelContenedor.Controls.RemoveAt(0);
            this.panelContenedor.Controls[0].Dock = DockStyle.Fill;
            this.panelContenedor.Controls[0].Show();
            transicionActiva = false;
        }

        private void UiPrincipal_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
                Format.FormularioBorde(this, true);
            else
                Format.FormularioBorde(this, false);
        }
    }
}
