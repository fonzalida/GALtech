using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace CoolSoft.UI2._0.UiOrdenesForm
{
    public partial class CrudParteOrden : Form
    {
        UiPrincipal formPrincipal;
        CrudOrden formOrden;
        DataTable tablaParte;

        public CrudParteOrden(UiPrincipal p, CrudOrden o)
        {
            formPrincipal = p;
            formOrden = o;
            InitializeComponent();
        }

        private void CrudParteOrden_Load(object sender, EventArgs e)
        {
            formPrincipal.CambiarTextoTitulo("Trabajos de Orden N° 908908060");
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            formPrincipal.CambiarTextoTitulo("ORDENES");
            this.Dock = DockStyle.None;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.TransitionCompletedEvent += new EventHandler<Transition.Args>(OnTransitionCompleted);

            //t.add(formOrden.tableLayoutPanel1, "Top", 12);
            //t.add(this, "Top", 690);

            t.add(formOrden.tableLayoutPanel1, "Left", 12);
            t.add(this, "Left", 1460);
            t.run();

        }


        private void OnTransitionCompleted(object sender, Transition.Args e)
        {
            
            this.Close();
        }

        private void buttonAgregar_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine(buttonAgregar.Size);
        }
    }
}
