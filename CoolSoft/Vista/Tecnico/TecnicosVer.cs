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
        public TecnicosVer()
        {
            InitializeComponent();
            lTitulo.Text = "Tecnicos";
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void TecnicosVer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
