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
        UiModificarCliente modificarCliente;
        Cliente viejo;

        DataTable tablaCliente;

        public CrudCliente()
        {
            fagregar = null;

            InitializeComponent();
        }

        private void CrudCliente_Load(object sender, EventArgs e)
        {
            Format.DataGridView(dataGridView1);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            fagregar = new UiAgregarCliente();
            fagregar.StartPosition = FormStartPosition.CenterScreen;
            var result = fagregar.ShowDialog();
            if (result == DialogResult.OK)
            {
                tablaCliente = ClienteRepository.ListarTodos();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tablaCliente;

                FormatearDataGrid();
            }


            //if (fagregar != null)
            //{
            //    if (!fagregar.IsDisposed)
            //    {
            //        fagregar = new UiAgregarCliente();
            //        fagregar.StartPosition = FormStartPosition.CenterScreen;
            //        var result = fagregar.ShowDialog();
            //        if (result == DialogResult.OK)
            //        {
            //            tablaCliente = ClienteRepository.ListarTodos();
            //            dataGridView1.DataSource = null;
            //            dataGridView1.DataSource = tablaCliente;

            //            FormatearDataGrid();
            //        }
            //    }
            //    else
            //    {
            //        fagregar.BringToFront();
            //    }
            //}
            //else
            //{

            //}
        }

            

        private void buttonVer_Click(object sender, EventArgs e)
        {
            tablaCliente = ClienteRepository.ListarTodos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablaCliente;

            FormatearDataGrid();

        }

        private void FormatearDataGrid()
        {
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "DNI / CUIT";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.ClearSelection();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {


            viejo = ClienteController.DataGridViewToCliente(dataGridView1.SelectedRows[0].Cells);

            if (modificarCliente != null)
            {
                if (modificarCliente.IsDisposed)
                {
                    modificarCliente = new UiModificarCliente(viejo);
                    modificarCliente.StartPosition = FormStartPosition.CenterScreen;
                    modificarCliente.Show();
                }
                else
                {
                    modificarCliente.BringToFront();
                }
            }
            else
            {
                modificarCliente = new UiModificarCliente(viejo);

                modificarCliente.StartPosition = FormStartPosition.CenterScreen;
                modificarCliente.Show();
            }




            //ClienteController.DataGridViewToCliente(dataGridView1.SelectedRows[0].Cells);
            //foreach (DataGridViewCell cell in dataGridView1.SelectedRows[0].Cells)
            //{
            //    Debug.WriteLine(cell.Value.ToString());
            //}

        }


        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxDni_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxNombre.Text = "";
        }

        private void textBoxNombre_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxDni.Text = "";
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

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {
            BuscarTexto(textBoxDni, textBoxNombre, 1);
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            BuscarTexto(textBoxNombre, textBoxDni, 2);
        }
    }
}
