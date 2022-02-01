using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoolSoft.Vista.Herencia
{
    public partial class Historico : Base
    {
        public Historico()
        {
            InitializeComponent();
        }

        private void dateTimeFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {

        }

        private void bVer_Click(object sender, EventArgs e)
        {

        }

        private void Historico_Load(object sender, EventArgs e)
        {
            //this.Text = pMenu.Size.ToString();
            this.Size = new Size(941, 627);

            Random random = new Random();
            int x = random.Next(-60, 60);
            int y = random.Next(-60, 60);

            this.Location = new Point(((this.MdiParent.ClientSize.Width / 2) - (this.Width / 2))+x,
                ((this.MdiParent.ClientSize.Height / 2) - (this.Height / 2))+y);

            dateTimeInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimeFinal.Value = DateTime.Now;
           pMenu.Size = new Size(pMenu.Size.Width,107);
        }

        private void checkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {

            dateTimeInicial.Enabled = !checkBoxTodos.Checked;
            dateTimeFinal.Enabled = !checkBoxTodos.Checked;

        }

        private void bModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
