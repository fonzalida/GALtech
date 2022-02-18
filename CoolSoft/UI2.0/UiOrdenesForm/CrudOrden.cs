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

        DataTable tablaOrden;
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

            fagregar = new UiAgregarOrden();
            fagregar.StartPosition = FormStartPosition.CenterScreen;
            var result = fagregar.ShowDialog();
            if (result == DialogResult.OK)
            {
                tablaOrden = OrdenRepository.ListarTodos();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tablaOrden;

                FormatearDataGrid();
            }

            //if (fagregar != null)
            //{
            //    if (fagregar.IsDisposed)
            //    {
            //        fagregar = new UiAgregarOrden();
            //        fagregar.StartPosition = FormStartPosition.CenterScreen;
            //        fagregar.Show();
            //    }
            //    else
            //    {
            //        fagregar.BringToFront();
            //    }
            //}
            //else
            //{
            //    fagregar = new UiAgregarOrden();
            //    fagregar.StartPosition = FormStartPosition.CenterScreen;
            //    fagregar.Show();
            //}
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {

            tablaOrden = OrdenRepository.ListarTodos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablaOrden;

            FormatearDataGrid();
            //dataGridView1.DataSource = OrdenRepository.ListarTodos();
            //FormatearDataGrid();
            //dataGridView1.ClearSelection();
        }

        private void FormatearDataGrid()
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

        private void BuscarTexto(TextBox actual, TextBox inactivo, int indice)
        {
            if (inactivo.Text != "")
            {
                inactivo.Text = "";
            }
            if (actual.Text != "")
            {
                if (tablaOrden == null)
                {
                    tablaOrden = OrdenRepository.ListarTodos();
                }

                EnumerableRowCollection<DataRow> resultado;

                if (indice == 1)
                {
                    resultado = from a in tablaOrden.AsEnumerable()
                                where a.Field<int>(indice).ToString().Contains(actual.Text)
                                select a;
                }
                else
                {
                    resultado = from a in tablaOrden.AsEnumerable()
                                where a.Field<string>(indice).Contains(actual.Text)
                                select a;
                }


                //dataGridView1.DataSource = null;
                if (resultado.Count() > 0)
                {
                    dataGridView1.DataSource = resultado.CopyToDataTable();
                    FormatearDataGrid();
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tablaOrden;
                FormatearDataGrid();
            }
        }

        private void OnTransitionCompleted(object sender, Transition.Args e)
        {
            formParte.Dock = DockStyle.Fill;
        }

        private void textBoxOrden_TextChanged(object sender, EventArgs e)
        {
            BuscarTexto(textBoxOrden, textBoxNombre, 1);
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            BuscarTexto(textBoxNombre, textBoxOrden, 3);
        }

        private void textBoxOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
