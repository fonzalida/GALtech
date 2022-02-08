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

namespace CoolSoft.Vista.Tecnico
{
    public partial class TecnicosVer : Historico
    {

        TecnicoAgregar fAgregar;
        public TecnicosVer()
        {
            InitializeComponent();
            lTitulo.Text = "Tecnicos";
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void TecnicosVer_Load(object sender, EventArgs e)
        {
            this.Name = "Tecnicos";
            InitBotonesMinClose();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            fAgregar = new TecnicoAgregar(this);
            fAgregar.StartPosition = FormStartPosition.CenterScreen;

            this.Enabled = false;

            fAgregar.MdiParent = this.MdiParent;

            fAgregar.FormBorderStyle = FormBorderStyle.None;
            fAgregar.Show();
        }

        private void bVer_Click(object sender, EventArgs e)
        {

        }
    }
}
