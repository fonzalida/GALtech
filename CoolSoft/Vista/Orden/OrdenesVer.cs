using CoolSoft.Vista.Herencia;
using System;
using System.Windows.Forms;

namespace CoolSoft.Vista.Orden
{
    public partial class OrdenesVer : Historico
    {
        public OrdenesVer()
        {
            InitializeComponent();
            lTitulo.Text = "Ordenes";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void OrdenesVer_Load(object sender, EventArgs e)
        {
            this.Name = "Ordenes";
            InitBotonesMinClose();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
