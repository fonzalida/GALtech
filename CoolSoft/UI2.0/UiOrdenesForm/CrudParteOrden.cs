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

        CrudOrden formOrden;
        public CrudParteOrden(CrudOrden f)
        {
            InitializeComponent();
            formOrden = f;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {

            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.TransitionCompletedEvent += new EventHandler<Transition.Args>(OnTransitionCompleted);
            t.add(formOrden.tableLayoutPanel1, "Top", 2);
            t.add(this, "Top", 690);
            t.run();



        }


        private void OnTransitionCompleted(object sender, Transition.Args e)
        {
            this.Close();
        }
    }
}
