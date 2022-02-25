using CoolSoft.Controlador;
using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.REPOSITORIO;
using CoolSoft.UI2._0.Genericos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace CoolSoft.UI2._0.UiClientesForm
{
    public partial class CrudCliente : Form
    {
        UiAgregarCliente fagregar;
        UiModificarCliente fModificar;
        Cliente viejo;

        DataTable tablaCliente;


        private struct Buscar
        {
            public int[] listaIndices;
            public int actual;
            public bool nuevaBusqueda;
        }

        Buscar b = new Buscar();
        public CrudCliente()
        {
            b.nuevaBusqueda = true;
            fagregar = null;
            InitializeComponent();
        }

        private void CrudCliente_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            Format.DataGridView(dataGridView1);

            buttonRefrescar.Location = buttonVer.Location;

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            fagregar = new UiAgregarCliente();
            Format.FormularioBorde(fagregar, false);
            fagregar.StartPosition = FormStartPosition.CenterScreen;
           
            var result = fagregar.ShowDialog();
            if (result == DialogResult.OK)
            {
                tablaCliente = ClienteRepository.ListarTodos();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tablaCliente;

                FormatearDataGrid();
            }
        }

        private void EstadoInicial()
        {
            panelSuperior.Enabled = false;


            buttonAgregar.Enabled = false;
           
            buttonDetalles.Enabled = false;

            buttonBuscar.Enabled = false;

            buttonVer.Enabled = true;
            buttonCancelar.Enabled = false;

            buttonLimpiarSeleccion.Visible = false;

            buttonRefrescar.Visible = false;
            buttonVer.Visible = true;

        }

        private void EstadoVer()
        {
            panelSuperior.Enabled = true;

            buttonAgregar.Enabled = true;

            buttonVer.Enabled = false;
            buttonCancelar.Enabled = true;

            buttonRefrescar.Visible = true;
            buttonVer.Visible = false;
        }



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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            dataGridView1.DataSource = null;
        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {


            viejo = ClienteController.DataGridViewToCliente(dataGridView1.SelectedRows[0].Cells);

            fModificar = new UiModificarCliente(viejo);
            Format.FormularioBorde(fModificar, false);
            fModificar.StartPosition = FormStartPosition.CenterScreen;
            var result = fModificar.ShowDialog();
            if (result == DialogResult.OK)
            {
                tablaCliente = ClienteRepository.ListarTodos();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tablaCliente;

                FormatearDataGrid();
            }
        }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
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
            if (textBoxDni.Text == "" && textBoxNombre.Text == "")
                buttonBuscar.Enabled = false;
            else
                buttonBuscar.Enabled = true;
        }

        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BuscarTexto(TextBox actual, int indice)
        {
            if (b.nuevaBusqueda)
            {
                b.actual = 0;

                EnumerableRowCollection<int> resultado;


                if (indice == 1) 
                {
                    //resultado = from a in tablaCliente.AsEnumerable() 
                    //            where a.Field<long>(indice).ToString().Contains(actual.Text)
                    //            select a;

                    resultado = from a in tablaCliente.AsEnumerable()
                                where a.Field<long>(indice).ToString().StartsWith(actual.Text)
                                select tablaCliente.Rows.IndexOf(a);
                }
                else
                {
                    resultado = from a in tablaCliente.AsEnumerable()
                                where a.Field<string>(indice).IndexOf(actual.Text, StringComparison.OrdinalIgnoreCase) >= 0
                                select tablaCliente.Rows.IndexOf(a);
                }


                //dataGridView1.DataSource = null;
                if (resultado.Count() > 0)
                {
                    b.listaIndices = resultado.ToArray();

                    FormatearDataGrid();
                    Console.WriteLine("Indice de la busqueda " + b.listaIndices[b.actual]);
                    dataGridView1.Rows[b.listaIndices[b.actual]].Selected = true;
                    b.actual++;
                    b.nuevaBusqueda = false;
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


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                buttonLimpiarSeleccion.Visible = true;
                buttonDetalles.Enabled = true;
            }
            else
            {
                buttonLimpiarSeleccion.Visible = false;
                buttonDetalles.Enabled = false;
            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxDni.Text != "")
            {
                BuscarTexto(textBoxDni, 1);
            }
            else
            {
                BuscarTexto(textBoxNombre, 2);
            }
        }


        private void textBoxDni_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxNombre.Text = "";
        }

        private void textBoxNombre_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxDni.Text = "";
        }

        private void buttonLimpiarSeleccion_Click(object sender, EventArgs e)
        {
            textBoxDni.Text = "";
            textBoxNombre.Text = "";
            dataGridView1.ClearSelection();
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            EstadoVer();
            tablaCliente = ClienteRepository.ListarTodos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablaCliente;

            FormatearDataGrid();
        }
    }
}
