using CoolSoft.Modelo.REPOSITORIO;
using CoolSoft.UI2._0.Genericos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoolSoft.UI2._0.UiOrdenesForm
{
    public partial class UiSeleccionarCliente : CoolSoft.UI2._0.Genericos.UiAgregar
    {

        DataTable tablaCliente;
        UiAgregarOrden formAgregar;

        public UiSeleccionarCliente(UiAgregarOrden f)
        {
            formAgregar = f;
            InitializeComponent();
        }

        private void UiSeleccionarCliente_Load(object sender, EventArgs e)
        {
            tablaCliente = ClienteRepository.ListarTodos();
            dataGridView1.DataSource = tablaCliente;
            Format.DataGridView(dataGridView1);
            buttonCargar.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                buttonCargar.Enabled = true;
                formAgregar.idCliente = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                formAgregar.idCliente = -1;
                buttonCargar.Enabled = false;
            }
        }

        private void BuscarTexto(TextBox actual, TextBox inactivo, int indice)
        {
            if (inactivo.Text != "")
            {
                inactivo.Text = "";
            }
            if (actual.Text != "")
            {
                if (tablaCliente == null)
                {
                    tablaCliente = ClienteRepository.ListarTodos();
                }

                EnumerableRowCollection<DataRow> resultado;

                if (indice == 1)
                {
                    //resultado = from a in tablaCliente.AsEnumerable() 
                    //            where a.Field<long>(indice).ToString().Contains(actual.Text)
                    //            select a;

                    resultado = from a in tablaCliente.AsEnumerable()
                                where a.Field<long>(indice).ToString().IndexOf(actual.Text, StringComparison.OrdinalIgnoreCase) >= 0
                                select a;
                }
                else
                {
                    resultado = from a in tablaCliente.AsEnumerable()
                                where a.Field<string>(indice).IndexOf(actual.Text, StringComparison.OrdinalIgnoreCase) >= 0
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
                dataGridView1.DataSource = tablaCliente;
                FormatearDataGrid();
            }
        }


        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {
            BuscarTexto(textBoxDni, textBoxNombre, 1);
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            BuscarTexto(textBoxNombre, textBoxDni, 2);
        }

        private void textBoxDni_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxNombre.Text = "";
        }

        private void textBoxNombre_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxDni.Text = "";
        }


        private void FormatearDataGrid()
        {

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "DNI / CUIT";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.ClearSelection();

        }

    }
}
