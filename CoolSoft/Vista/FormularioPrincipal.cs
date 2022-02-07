using CoolSoft.Vista.Cliente;
using CoolSoft.Vista.Herencia;
using CoolSoft.Vista.Orden;
using CoolSoft.Vista.Tecnico;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoolSoft.VISTA
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            //TESTEOS       ------------------------------------

            //Test newFrm = new Test();
            //Historico form = new Historico();
            //Agregar form = new Agregar();
            //form.MdiParent = this;
            //form.Show();

            //FIN TESTEOS   ------------------------------------







            foreach (ToolStripMenuItem i in menuStripPrincipal.Items)
            {
                i.MouseEnter += ToolStripMenuItem_MouseEnter;
                i.MouseLeave += ToolStripMenuItem_MouseLeave;
            }

        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OrdenesVer form = new OrdenesVer();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.MdiParent = this;
            form.Show();
        }

        private void FormularioPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteVer form = new ClienteVer();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.MdiParent = this;
            form.Show();
        }

        private void tecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TecnicosVer form = new TecnicosVer();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.MdiParent = this;
            form.Show();
        }

        private void menuStripPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as ToolStripMenuItem;
            if (button != null)
            {
                button.ForeColor = Color.Black;
            }
        }

        private void ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as ToolStripMenuItem;
            if (button != null)
            {
                button.ForeColor = SystemColors.ButtonFace;
            }

            
        }
    }
}
