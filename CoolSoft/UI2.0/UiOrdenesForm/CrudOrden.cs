using CoolSoft.Modelo.REPOSITORIO;
using System;
using CoolSoft.UI2._0.Genericos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using CoolSoft.UI2._0.UiClientesForm;

namespace CoolSoft.UI2._0.UiOrdenesForm
{
    public partial class CrudOrden : Form
    {

        UiAgregarOrden fagregar;
        UiModificarOrden modificarOrden;
        CrudParteOrden formParte;
        UiPrincipal formPrincipal;
        public CrudOrden(UiPrincipal p)
        {
            formPrincipal = p;
            fagregar = null;
            InitializeComponent();
        }

        private void CrudOrden_Load(object sender, EventArgs e)
        {
            Format.DataGridView(dataGridView1);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (fagregar != null)
            {
                if (fagregar.IsDisposed)
                {
                    fagregar = new UiAgregarOrden();
                    fagregar.StartPosition = FormStartPosition.CenterScreen;
                    fagregar.Show();
                }
                else
                {
                    fagregar.BringToFront();
                }
            }
            else
            {
                fagregar = new UiAgregarOrden();
                fagregar.StartPosition = FormStartPosition.CenterScreen;
                fagregar.Show();
            }
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrdenRepository.ListarTodos();
            FormateatDataGrid();
            dataGridView1.ClearSelection();
        }

        private void FormateatDataGrid()
        {
            
            foreach(DataGridViewRow dr in dataGridView1.Rows)
            {

            }
           // dataGridView1.Columns[3].Visible = false;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;           
            // dataGridView1.Columns["FechaRecepcion"].HeaderText = "Recibida";   // HECHO EN REPOSITORY DE ORDEN
            dataGridView1.Columns["IdOrden"].HeaderText = "N° Orden";

            dataGridView1.Columns["TareaDesarrollar"].HeaderText = "Tarea";
            dataGridView1.Columns["TareaDesarrollar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["IdCliente"].Visible = false;

            //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {
            if (modificarOrden != null)
            {
                if (modificarOrden.IsDisposed)
                {
                    modificarOrden = new UiModificarOrden();
                    modificarOrden.StartPosition = FormStartPosition.CenterScreen;
                    modificarOrden.Show();
                }
                else
                {
                    modificarOrden.BringToFront();
                }
            }
            else
            {
                modificarOrden = new UiModificarOrden();
                modificarOrden.StartPosition = FormStartPosition.CenterScreen;
                modificarOrden.Show();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void buttonPartes_Click(object sender, EventArgs e)
        {
            formParte = new CrudParteOrden(formPrincipal,this);
            formParte.TopLevel = false;
            formParte.Size = this.Size;
            this.Controls.Add(formParte);
            //formParte.Location = new Point(0, 690); //230; 60 //   686 1051
            formParte.Location = new Point(1460, 0);
            formParte.Show();

            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.TransitionCompletedEvent += new EventHandler<Transition.Args>(OnTransitionCompleted);

            //t.add(tableLayoutPanel1, "Top", -690);
            //t.add(formParte, "Top", 0);

            t.add(tableLayoutPanel1, "Left", -1460);
            t.add(formParte, "Left", 0);
            t.run();


            //if (formActivo != 1)
            //{
            //    formActivo = 1;
            //    labelTitulo.Text = "CLIENTES";

            //    if (this.panelContenedor.Controls.Count > 0)
            //        this.panelContenedor.Controls.RemoveAt(0);
            //    CrudCliente fh = new CrudCliente();
            //    fh.TopLevel = false;
            //    fh.Dock = DockStyle.Fill;
            //    this.panelContenedor.Controls.Add(fh);
            //    this.panelContenedor.Tag = fh;
            //    fh.Show();
            //}

        }

        private void OnTransitionCompleted(object sender, Transition.Args e)
        {
            formParte.Dock = DockStyle.Fill;
        }



    }
}
