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

        UiModificarOrden fModificar;
        CrudParteOrden formParte;
        UiPrincipal formPrincipal;

        DataTable tablaOrden;

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
            
            b.nuevaBusqueda = true;
            fagregar = null;
            InitializeComponent();
        }



        private void CrudOrden_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            Format.DataGridView(dataGridView1);

            checkBoxTodos.Checked = true;
            dateTimePickerDesde.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 01);
            dateTimePickerHasta.Value = DateTime.Now.Date;

            buttonRefrescar.Location = buttonVer.Location;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            fagregar = new UiAgregarOrden();
            Format.FormularioBorde(fagregar, false);
            fagregar.StartPosition = FormStartPosition.CenterScreen;
            var result = fagregar.ShowDialog();
            if (result == DialogResult.OK)
            {
                CargarGrid();
            }

        }

        private void EstadoInicial()
        {
            panelSuperior.Enabled = false;
            panelFechas.Enabled = true;

            buttonAgregar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonDetalles.Enabled = false;

            buttonPartes.Enabled = true;
            buttonPartes.Visible = false;


            buttonLimpiarSeleccion.Visible = false;

            buttonVer.Enabled = true;
            buttonCancelar.Enabled = false;

            buttonRefrescar.Visible = false;
            buttonVer.Visible = true;

            dateTimePickerHasta.MinDate = dateTimePickerDesde.Value;

        }

        private void EstadoVer()
        {
            panelSuperior.Enabled = true;
            panelFechas.Enabled = false;

            buttonAgregar.Enabled = true;

            buttonVer.Enabled = false;
            buttonCancelar.Enabled = true;

            buttonRefrescar.Visible = true;
            buttonVer.Visible = false;
            buttonPartes.Visible = true;
            buttonPartes.Enabled = false;


        }

        /*
           private void buttonVer_Click(object sender, EventArgs e)
        {
            EstadoVer();
            tablaCliente = ClienteRepository.ListarTodos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablaCliente;

            FormatearDataGrid();

        }

        

        private void FormatearDataGrid()
        {
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["IdCliente"].HeaderText = "ID";
            dataGridView1.Columns["DNICUIT"].HeaderText = "DNI / CUIT";
            dataGridView1.Columns["Domicilio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.ClearSelection();

        }

        dataGridView1.SelectedRows[0].Cells["IdOrden"].Value.ToString()

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            dataGridView1.DataSource = null;
        }
         
         */

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
            FiltrarGrid();

            FormatearDataGrid();
        }

        private void FormatearDataGrid()
        {

            dataGridView1.Columns["IdOrden"].HeaderText = "N° Órden";

            dataGridView1.Columns["TareaDesarrollar"].HeaderText = "Tarea";
            dataGridView1.Columns["TareaDesarrollar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dataGridView1.Columns["IdCliente"].Visible = false;
            dataGridView1.Columns["Completada"].Visible = false;

            dataGridView1.Columns["Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.ClearSelection();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            dataGridView1.DataSource = null;
        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {
            viejo = OrdenController.DataGridViewToOrden(dataGridView1.SelectedRows[0].Cells);
            

            fModificar = new UiModificarOrden(viejo);
            Format.FormularioBorde(fModificar, false);
            fModificar.StartPosition = FormStartPosition.CenterScreen;
            var result = fModificar.ShowDialog();
            if (result == DialogResult.OK)
            {
                CargarGrid();
            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            string texto = "Órden N° " + dataGridView1.SelectedRows[0].Cells["IdOrden"].Value.ToString();
            Eliminar fEliminar = new Eliminar(texto);
            Format.FormularioBorde(fEliminar, false);
            fEliminar.StartPosition = FormStartPosition.CenterScreen;
            var result = fEliminar.ShowDialog();
            if (result == DialogResult.OK)
            {

                OrdenController.EliminarOrden(dataGridView1.SelectedRows[0].Cells);
                CargarGrid();
            }
        }



        private void buttonPartes_Click(object sender, EventArgs e)
        {
            formParte = new CrudParteOrden(formPrincipal, this, dataGridView1.SelectedRows[0].Cells["IdOrden"].Value.ToString());
            formParte.TopLevel = false;
            formParte.Size = this.Size;
            this.Controls.Add(formParte);
            //formParte.Location = new Point(0, 690); //230; 60 //   686 1051
            //formParte.Location = new Point(1460, 0);
            formParte.Location = new Point(Screen.PrimaryScreen.Bounds.Width, 0);
            formParte.Show();

            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.TransitionCompletedEvent += new EventHandler<Transition.Args>(OnTransitionCompleted);


            
            //t.add(tableLayoutPanel1, "Left", -1460);
            t.add(tableLayoutPanel1, "Left", -Screen.PrimaryScreen.Bounds.Width);
            t.add(formParte, "Left", 0);
            t.run();

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
                var tablaTemp = (dataGridView1.DataSource as DataTable).DefaultView.ToTable();

                if (indice == 1)
                {
                    resultado = from a in tablaTemp.AsEnumerable()
                                where a.Field<int>(indice).ToString().Equals(actual.Text)
                                select tablaTemp.Rows.IndexOf(a);
                }
                else //busca por cliente
                {
                    resultado = from a in tablaTemp.AsEnumerable()
                                where a.Field<string>(indice).IndexOf(actual.Text, StringComparison.OrdinalIgnoreCase) >= 0
                                select tablaTemp.Rows.IndexOf(a);
                }

                if (resultado.Count() > 0)
                {
                    b.listaIndices = resultado.ToArray();

                    FormatearDataGrid();
                    Console.WriteLine("Indice de la busqueda " + b.listaIndices[b.actual]);
                    dataGridView1.Rows[b.listaIndices[b.actual]].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[b.listaIndices[b.actual]].Cells[0];
                    b.actual++;
                    b.nuevaBusqueda = false;
                    //FiltrarGrid();

                }
                else
                {
                    dataGridView1.ClearSelection();
                    MessageBox.Show("No se encontro ningun resultado");
                    b.nuevaBusqueda = true;

                    //b.nuevaBusqueda = true;
                    //BuscarTexto(actual, indice);

                }
            }
            else
            {
                if (b.listaIndices.Count() != b.actual)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[b.listaIndices[b.actual]].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[b.listaIndices[b.actual]].Cells[0];
                    b.actual++;
                }
                else
                {
                    //dataGridView1.ClearSelection();
                    //MessageBox.Show("No hay mas elementos que buscar");
                    //b.nuevaBusqueda = true;

                    b.nuevaBusqueda = true;
                    BuscarTexto(actual, indice);
                }
            }
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
                buttonLimpiarSeleccion.Visible = true;
                buttonEliminar.Enabled = true;
                buttonDetalles.Enabled = true;
                buttonPartes.Enabled = true;
            }
            else
            {
                buttonLimpiarSeleccion.Visible = false;
                buttonEliminar.Enabled = false;
                buttonDetalles.Enabled = false;
                buttonPartes.Enabled = false;
            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarGrid();
        }

        private void FiltrarGrid()
        {
            b.nuevaBusqueda = true;

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
            dataGridView1.ClearSelection();
            

        }

        private void checkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
                dateTimePickerDesde.Enabled = !(sender as CheckBox).Checked;
                dateTimePickerHasta.Enabled = !(sender as CheckBox).Checked;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int index = e.RowIndex;

            try
            {
                if (dataGridView1.Rows[index].Cells["Completada"].Value.ToString() == "False")
                {
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.PeachPuff;
                    dataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.PaleGreen;
                    dataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            catch
            {

            }
        }

        private void buttonLimpiarSeleccion_Click(object sender, EventArgs e)
        {
            textBoxOrden.Text = "";
            textBoxNombre.Text = "";
            dataGridView1.ClearSelection();
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            CargarGrid();
            FiltrarGrid();
        }

        private void dateTimePickerDesde_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerHasta.MinDate = dateTimePickerDesde.Value;
        }
    }
}
