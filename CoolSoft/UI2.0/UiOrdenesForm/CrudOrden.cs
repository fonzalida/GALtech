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
using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Controlador;

namespace CoolSoft.UI2._0.UiOrdenesForm
{
    public partial class CrudOrden : Form
    {

        Orden viejo;

        UiAgregarOrden fagregar;


        UiModificarOrden modificarOrden;
        CrudParteOrden formParte;
        UiPrincipal formPrincipal;

        DataTable tablaOrden;
        DataTable tablaActual;

        private struct Buscar
        {
            public int[] listaIndices;
            public int actual;
            public bool nuevaBusqueda;
        }

        Buscar b = new Buscar();


        public CrudOrden(UiPrincipal p)
        {
            formPrincipal = p;
            fagregar = null;
            InitializeComponent();
        }



        private void CrudOrden_Load(object sender, EventArgs e)
        {
            Format.DataGridView(dataGridView1);
            EstadoInicial();
            checkBoxTodos.Checked = true;
            dateTimePickerDesde.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 01);
        }

        private void EstadoInicial()
        {
            panelSuperior.Enabled = false;
            panelFechas.Enabled = true;

            buttonAgregar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonDetalles.Enabled = false;

            buttonPartes.Enabled = false;
            buttonPartes.Visible = false;

            buttonVer.Enabled = true;
            buttonCancelar.Enabled = false;

        }

        private void EstadoVer()
        {
            panelSuperior.Enabled = true;
            panelFechas.Enabled = false;

            buttonAgregar.Enabled = true;
            //buttonEliminar.Enabled = true;
            //buttonDetalles.Enabled = true;
            //buttonPartes.Enabled = true;

            buttonVer.Enabled = false;
            buttonCancelar.Enabled = true;


        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            fagregar = new UiAgregarOrden();
            fagregar.StartPosition = FormStartPosition.CenterScreen;
            var result = fagregar.ShowDialog();
            if (result == DialogResult.OK)
            {
                CargarGrid();
            }

        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            EstadoVer();

            switch (checkBoxTodos.Checked)
            {
                case true:
                    tablaOrden = OrdenRepository.ListarTodos();
                    break;

                case false:
                    tablaOrden = OrdenRepository.ListarPorFecha(dateTimePickerDesde.Value, dateTimePickerHasta.Value);
                    break;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablaOrden;

            FormatearDataGrid();
        }

        private void FormatearDataGrid()
        {

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

            }
            // dataGridView1.Columns[3].Visible = false;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;           
            // dataGridView1.Columns["FechaRecepcion"].HeaderText = "Recibida";   // HECHO EN REPOSITORY DE ORDEN
            dataGridView1.Columns["IdOrden"].HeaderText = "N° Orden";

            dataGridView1.Columns["TareaDesarrollar"].HeaderText = "Tarea";
            dataGridView1.Columns["TareaDesarrollar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["IdCliente"].Visible = false;
            dataGridView1.ClearSelection();

            //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {
            viejo = OrdenController.DataGridViewToOrden(dataGridView1.SelectedRows[0].Cells);
      
            modificarOrden = new UiModificarOrden(viejo);
            modificarOrden.StartPosition = FormStartPosition.CenterScreen;
            var result = modificarOrden.ShowDialog();
            if (result == DialogResult.OK)
            {
                CargarGrid();
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            dataGridView1.DataSource = null;
        }

        private void buttonPartes_Click(object sender, EventArgs e)
        {
            formParte = new CrudParteOrden(formPrincipal, this);
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

        private void textBoxOrden_TextChanged(object sender, EventArgs e)
        {
            HabilitarBuscar();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            HabilitarBuscar();
        }

        public void HabilitarBuscar()
        {
            b.nuevaBusqueda = true;
            if (textBoxOrden.Text == "" && textBoxNombre.Text == "")
                buttonBuscar.Enabled = false;
            else
                buttonBuscar.Enabled = true;
        }

        private void textBoxOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxOrden_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxNombre.Text = "";
        }

        private void textBoxNombre_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxOrden.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                buttonEliminar.Enabled = true;
                buttonDetalles.Enabled = true;
            }
            else
            {
                buttonEliminar.Enabled = false;
                buttonDetalles.Enabled = false;
            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarGrid();
        }

        private void FiltrarGrid()
        {
            string rowFilter;
            switch (comboBoxFiltro.Text)
            {

                case "Todas":
                    rowFilter = "";
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                    break;

                case "Completas":
                    rowFilter = string.Format("[{0}] = {1}", "Completada", "True");
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                    break;

                case "En Curso":
                    rowFilter = string.Format("[{0}] = {1}", "Completada", "False");
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                    break;

            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxOrden.Text != "")
            {
                BuscarTexto(textBoxOrden, 1);
            }
            else
            {
                BuscarTexto(textBoxNombre, 3);
            }
        }


        private void BuscarTexto(TextBox actual, int indice)
        {

            if (b.nuevaBusqueda)
            {
                b.actual = 0;

                EnumerableRowCollection<int> resultado;


                if (indice == 1)
                {
                    resultado = from a in tablaOrden.AsEnumerable()
                                where a.Field<int>(indice).ToString().StartsWith(actual.Text)
                                select tablaOrden.Rows.IndexOf(a);
                }
                else
                {
                    resultado = from a in tablaOrden.AsEnumerable()
                                where a.Field<string>(indice).IndexOf(actual.Text, StringComparison.OrdinalIgnoreCase) >= 0
                                select tablaOrden.Rows.IndexOf(a);
                }

                if (resultado.Count() > 0)
                {
                    b.listaIndices = resultado.ToArray();

                    FormatearDataGrid();
                    Console.WriteLine("Indice de la busqueda " + b.listaIndices[b.actual]);
                    dataGridView1.Rows[b.listaIndices[b.actual]].Selected = true;
                    b.actual++;
                    b.nuevaBusqueda = false;
                    FiltrarGrid();

                }
                else
                {
                    dataGridView1.ClearSelection();
                    MessageBox.Show("No se encontro ningun resultado");
                }
            }
            else
            {
                if (b.listaIndices.Count() != b.actual)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[b.listaIndices[b.actual]].Selected = true;
                    b.actual++;
                }
                else
                {
                    dataGridView1.ClearSelection();
                    MessageBox.Show("No hay mas elementos que buscar");
                }
            }
        }

        private void checkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
                dateTimePickerDesde.Enabled = !(sender as CheckBox).Checked;
                dateTimePickerHasta.Enabled = !(sender as CheckBox).Checked;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
