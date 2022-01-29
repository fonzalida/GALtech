using connect;
using CoolSoft.Vista.Herencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Historico form = new Historico();
            form.MdiParent = this;
            form.Show();
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
    }
}
