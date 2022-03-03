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

namespace CoolSoft.Vista.Herencia
{
    public partial class Agregar : Base
    {

        


        
        public Agregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            //FixBotones();

            
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Hola mundo");
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

        public void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }


        //public void FixBotones()
        //{
            
        //    int x = 90;
            
        //    bCancelar.Location = new Point(440, 4);
        //    bLimpiar.Location = new Point(bCancelar.Location.X-x, 4);
        //    bAgregar.Location = new Point(bLimpiar.Location.X -x, 4);

        //    MessageBox.Show(this.Size.ToString());
        //}

    }
}
