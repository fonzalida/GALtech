using CoolSoft.Vista.Cliente;
using CoolSoft.Vista.Orden;
using CoolSoft.Vista.Tecnico;
using System;
using System.Windows.Forms;

namespace CoolSoft.VISTA
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPadre_Load(object sender, EventArgs e)
        {
            //Test newFrm = new Test();
            //Historico form = new Historico();
            //form.MdiParent = this;
            //form.Show();
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OrdenesVer form = new OrdenesVer();
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
            form.MdiParent = this;
            form.Show();
        }

        private void tecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TecnicosVer form = new TecnicosVer();
            form.MdiParent = this;
            form.Show();
        }
    }
}
