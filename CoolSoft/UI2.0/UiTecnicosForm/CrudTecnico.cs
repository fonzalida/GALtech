using CoolSoft.Controlador;
using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.REPOSITORIO;
using CoolSoft.UI2._0.Genericos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.UI2._0.UiTecnicosForm
{
    public partial class CrudTecnico : Form
    {
        UiAgregarTecnico fagregar;
        UiModificarTecnico fModificar;
        Tecnico viejo;

        DataTable tablaTecnico;

        private struct Buscar
        {
            public int[] listaIndices;
            public int actual;
            public bool nuevaBusqueda;
        }

        Buscar b = new Buscar();

        public CrudTecnico()
        {
            b.nuevaBusqueda = true;
            fagregar = null;
            InitializeComponent();
        }

        private void CrudTecnico_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            Format.DataGridView(dataGridView1);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            fagregar = new UiAgregarTecnico();
            Format.FormularioBorde(fagregar, false);
            fagregar.StartPosition = FormStartPosition.CenterScreen;
            var result = fagregar.ShowDialog();
            if (result == DialogResult.OK)
            {
                tablaTecnico = TecnicoRepository.ListarTodos();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tablaTecnico;

                FormatearDataGrid();
            }

        }


        private void EstadoInicial()
        {
            panelSuperior.Enabled = false;
            

            buttonAgregar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonDetalles.Enabled = false;

            buttonBuscar.Enabled = false;
            buttonLimpiarSeleccion.Visible = false;

            buttonVer.Enabled = true;
            buttonCancelar.Enabled = false;

        }

        private void EstadoVer()
        {
            panelSuperior.Enabled = true;
            
            buttonAgregar.Enabled = true;

            buttonVer.Enabled = false;
            buttonCancelar.Enabled = true;


        }

        private void buttonVer_Click(object sender, EventArgs e)
        {

            EstadoVer();
            tablaTecnico = TecnicoRepository.ListarTodos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablaTecnico;

            FormatearDataGrid();

        }

        private void FormatearDataGrid()
        {
            Format.DataGridView(dataGridView1);
            dataGridView1.Columns["Activo"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClearSelection();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            dataGridView1.DataSource = null;
        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {
            viejo = TecnicoController.DataGridViewToTecnico(dataGridView1.SelectedRows[0].Cells);

            fModificar = new UiModificarTecnico(viejo);
            Format.FormularioBorde(fModificar, false);
            fModificar.StartPosition = FormStartPosition.CenterScreen;
            var result = fModificar.ShowDialog();
            if (result == DialogResult.OK)
            {
                tablaTecnico = TecnicoRepository.ListarTodos();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tablaTecnico;

                FormatearDataGrid();
            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar fEliminar = new Eliminar(dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString());
            Format.FormularioBorde(fEliminar, false);
            fEliminar.StartPosition = FormStartPosition.CenterScreen;
            var result = fEliminar.ShowDialog();
            if (result == DialogResult.OK)
            {

                TecnicoController.Eliminar(dataGridView1.SelectedRows[0].Cells);
                tablaTecnico = TecnicoRepository.ListarTodos();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tablaTecnico;

                FormatearDataGrid();
            }

        }

        private void TextBoxDni_TextChanged(object sender, EventArgs e)
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if(textBoxDni.Text != "")
            {
                BuscarTexto(textBoxDni, 0);
            }
            else
            {
                BuscarTexto(textBoxNombre, 1);
            }
        }

        private void BuscarTexto(TextBox actual, int indice)
        {
            if (b.nuevaBusqueda)
            {
                b.actual = 0;

                EnumerableRowCollection<int> resultado;


                if (indice == 0)
                {


                    resultado = from a in tablaTecnico.AsEnumerable()
                                where a.Field<int>(indice).ToString().StartsWith(actual.Text)
                                select tablaTecnico.Rows.IndexOf(a);


                }
                else
                {
                    resultado = from a in tablaTecnico.AsEnumerable()
                                where a.Field<string>(indice).IndexOf(actual.Text, StringComparison.OrdinalIgnoreCase) >= 0
                                select tablaTecnico.Rows.IndexOf(a);
                }


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

        private void textBoxDni_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxNombre.Text = "";
        }

        private void textBoxNombre_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxDni.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                buttonLimpiarSeleccion.Visible = true;
                buttonEliminar.Enabled = true;
                buttonDetalles.Enabled = true;
            }
            else
            {
                buttonLimpiarSeleccion.Visible = false;
                buttonEliminar.Enabled = false;
                buttonDetalles.Enabled = false;
            }

        }

        private void buttonLimpiarSeleccion_Click(object sender, EventArgs e)
        {
            textBoxDni.Text = "";
            textBoxNombre.Text = "";
            dataGridView1.ClearSelection();
        }
    }
}
