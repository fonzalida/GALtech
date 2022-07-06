using CoolSoft.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.UI2._0.UiOrdenesForm
{
    public partial class UiAgregarMaterial : CoolSoft.UI2._0.Genericos.UiAgregar
    {
        public UiAgregarMaterial()
        {
            InitializeComponent();
        }

        private void UiAgregarMaterial_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaterialController.Cargar(
                textBoxMaterial.Text,
                textBoxCant.Text);
            //como sabe para q orden cargar?
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
