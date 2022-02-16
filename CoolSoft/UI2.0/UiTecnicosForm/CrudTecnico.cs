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
        UiModificarTecnico modificarTecnico;
        Tecnico viejo;

        DataTable tablaTecnico;
        public CrudTecnico()
        {
            fagregar = null;
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (fagregar != null)
            {
                if (fagregar.IsDisposed)
                {
                    fagregar = new UiAgregarTecnico();
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
                fagregar = new UiAgregarTecnico();
                fagregar.StartPosition = FormStartPosition.CenterScreen;
                fagregar.Show();
            }
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            tablaTecnico = TecnicoRepository.ListarTodos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablaTecnico;
           //Format.DataGridView(dataGridView1);

            FormatearDataGrid();

        }

        private void FormatearDataGrid()
        {
            Format.DataGridView(dataGridView1);
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dataGridView1.Columns[0].HeaderText = "ID";
            //dataGridView1.Columns[1].HeaderText = "DNI / CUIT";
            //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            TecnicoController.Eliminar(dataGridView1.SelectedCells[0].Value.ToString());
        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {
            viejo = TecnicoController.DataGridViewToTecnico(dataGridView1.SelectedRows[0].Cells);

            if (modificarTecnico != null)
            {
                if (modificarTecnico.IsDisposed)
                {
                    modificarTecnico = new UiModificarTecnico(viejo);
                    modificarTecnico.StartPosition = FormStartPosition.CenterScreen;
                    modificarTecnico.Show();
                }
                else
                {
                    modificarTecnico.BringToFront();
                }
            }
            else
            {
                modificarTecnico = new UiModificarTecnico(viejo);
                modificarTecnico.StartPosition = FormStartPosition.CenterScreen;
                modificarTecnico.Show();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBoxDni_TextChanged(object sender, EventArgs e)
        {
            BuscarTexto(textBoxDni, textBoxNombre, 0);
        }

       
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            BuscarTexto(textBoxNombre, textBoxDni, 1);
        }
        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BuscarTexto(TextBox actual, TextBox inactivo, int indice)
        {
            if (inactivo.Text != "")
            {
                inactivo.Text = "";
            }
            if (actual.Text != "")
            {
                if (tablaTecnico == null)
                {
                    tablaTecnico = TecnicoRepository.ListarTodos();
                }

                EnumerableRowCollection<DataRow> resultado;

                if(indice == 0)
                {
                    resultado = from a in tablaTecnico.AsEnumerable()
                                    where a.Field<int>(indice).ToString().Contains(actual.Text)
                                    select a;
                }
                else
                {
                    resultado = from a in tablaTecnico.AsEnumerable()
                                    where a.Field<string>(indice).Contains(actual.Text)
                                    select a;
                }
              
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
                dataGridView1.DataSource = tablaTecnico;
                FormatearDataGrid();
            }
        }

        
    }
}
