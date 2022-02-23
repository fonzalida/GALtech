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
        }

        private void EstadoInicial()
        {
            panelSuperior.Enabled = false;
            panelFechas.Enabled = true;

            buttonAgregar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonDetalles.Enabled = false;
            buttonPartes.Enabled = false;

            buttonVer.Enabled = true;
            buttonCancelar.Enabled = false;

        }

        private void EstadoVer()
        {
            panelSuperior.Enabled = true;
            panelFechas.Enabled = false;

            buttonAgregar.Enabled = true;
            buttonEliminar.Enabled = true;
            buttonDetalles.Enabled = true;
            buttonPartes.Enabled = true;

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
                tablaOrden = OrdenRepository.ListarTodos();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tablaOrden;

                FormatearDataGrid();
            }


            //if (modificarOrden != null)
            //{
            //    if (modificarOrden.IsDisposed)
            //    {
            //        //modificarOrden = new UiModificarOrden();
            //        modificarOrden.StartPosition = FormStartPosition.CenterScreen;
            //        modificarOrden.Show();
            //    }
            //    else
            //    {
            //        modificarOrden.BringToFront();
            //    }
            //}
            //else
            //{
            //    //modificarOrden = new UiModificarOrden();
            //    modificarOrden.StartPosition = FormStartPosition.CenterScreen;
            //    modificarOrden.Show();
            //}
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
                    tablaActual = tablaOrden.Copy();
                }

                EnumerableRowCollection<DataRow> resultado;

                if (indice == 1)
                {
                    resultado = from a in tablaOrden.AsEnumerable()
                                where a.Field<int>(indice).ToString().StartsWith(actual.Text)
                                select a;
                }
                else
                {
                    resultado = from a in tablaOrden.AsEnumerable()
                                where a.Field<string>(indice).IndexOf(actual.Text, StringComparison.OrdinalIgnoreCase) >= 0
                                select a;
                }


                //dataGridView1.DataSource = null;
                if (resultado.Count() > 0)
                {
                    tablaActual = resultado.CopyToDataTable();
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

        private void textBoxOrden_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxNombre.Text = "";
        }

        private void textBoxNombre_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxOrden.Text = "";
        }

        //private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    switch (comboBox1.Text)
        //    {
        //        case "Todas":
        //            tablaOrden = OrdenRepository.ListarTodos();
        //            dataGridView1.DataSource = null;
        //            dataGridView1.DataSource = tablaOrden;
        //            break;
        //        case "Completas":
        //            tablaOrden = OrdenRepository.ListarFiltros(1);
        //            dataGridView1.DataSource = null;
        //            dataGridView1.DataSource = tablaOrden;
        //            break;

        //        case "En Curso":
        //            tablaOrden = OrdenRepository.ListarFiltros(0);
        //            dataGridView1.DataSource = null;
        //            dataGridView1.DataSource = tablaOrden;
        //            break;

        //       /*case "Pendientes":
        //            tablaOrden = OrdenRepository.ListarFiltros(0);
        //            dataGridView1.DataSource = null;
        //            dataGridView1.DataSource = tablaOrden;
        //            break;*/

        //    }
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string rowFilter;
            switch (comboBoxFiltro.Text)
            {

                case "Todas":

                    rowFilter = "";
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                    //FormatearDataGrid();


                    //var resultado = from a in tablaActual.AsEnumerable() select a;
                    //dataGridView1.DataSource = null;
                    //dataGridView1.DataSource = resultado.CopyToDataTable();
                    break;
                case "Completas":

                    rowFilter = string.Format("[{0}] = {1}", "Completada","True");
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                    //var resultado1 = from a in tablaActual.AsEnumerable()
                    //                where a.Field<int>("Completada") == 0          // arreglar query
                    //                select a;
                    //dataGridView1.DataSource = null;
                    //dataGridView1.DataSource = resultado1.CopyToDataTable();
                    break;

                case "En Curso":
                    rowFilter = string.Format("[{0}] = {1}", "Completada", "False");
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

                    //var resultado2 = from a in tablaActual.AsEnumerable()
                    //                 where a.Field<int>("Completada") == 1       //   arreglar query
                    //             select a;
                    //dataGridView1.DataSource = null;
                    //dataGridView1.DataSource = resultado2.CopyToDataTable();
                    break;

                    /*case "Pendientes":
                    tablaOrden = OrdenRepository.ListarFiltros(0);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = tablaOrden;
                    break;*/

            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //tablaOrden = OrdenRepository.ListarPorFecha(dateTimePicker1.Value, dateTimePicker2.Value);
            //dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablaOrden;

            //FormatearDataGrid();
        }

        private void checkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
                dateTimePickerDesde.Enabled = !(sender as CheckBox).Checked;
                dateTimePickerHasta.Enabled = !(sender as CheckBox).Checked;
        }
    }
}
