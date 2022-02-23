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
        UiAgregarTecnico fModificar;
        UiModificarTecnico modificarTecnico;
        Tecnico viejo;

        DataTable tablaTecnico;
        public CrudTecnico()
        {
            fModificar = null;
            InitializeComponent();
        }

        private void CrudTecnico_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {


            fModificar = new UiAgregarTecnico();
            fModificar.StartPosition = FormStartPosition.CenterScreen;
            var result = fModificar.ShowDialog();
            if (result == DialogResult.OK)
            {
                tablaTecnico = TecnicoRepository.ListarTodos();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tablaTecnico;

                FormatearDataGrid();
            }

            //if (fagregar != null)
            //{
            //    if (fagregar.IsDisposed)
            //    {
            //        fagregar = new UiAgregarTecnico();
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
            //    fagregar = new UiAgregarTecnico();
            //    fagregar.StartPosition = FormStartPosition.CenterScreen;
            //    fagregar.Show();
            //}
        }


        private void EstadoInicial()
        {
            panelSuperior.Enabled = false;
            

            buttonAgregar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonDetalles.Enabled = false;

            buttonBuscar.Enabled = false;

            buttonVer.Enabled = true;
            buttonCancelar.Enabled = false;

        }

        private void EstadoVer()
        {
            panelSuperior.Enabled = true;
            

            buttonAgregar.Enabled = true;
            //buttonEliminar.Enabled = true;
            //buttonDetalles.Enabled = true;

            buttonVer.Enabled = false;
            buttonCancelar.Enabled = true;


        }

        private void buttonVer_Click(object sender, EventArgs e)
        {

            EstadoVer();
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
            dataGridView1.ClearSelection();
            //dataGridView1.Columns[0].HeaderText = "ID";
            //dataGridView1.Columns[1].HeaderText = "DNI / CUIT";
            //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            dataGridView1.DataSource = null;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar fEliminar = new Eliminar(dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString());
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

            
            //TecnicoController.Eliminar(dataGridView1.SelectedCells[0].Value.ToString());
        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {
            viejo = TecnicoController.DataGridViewToTecnico(dataGridView1.SelectedRows[0].Cells);

            fModificar = new UiModificarTecnico(viejo);
            fModificar.StartPosition = FormStartPosition.CenterScreen;
            var result = fModificar.ShowDialog();
            if (result == DialogResult.OK)
            {
                tablaTecnico = TecnicoRepository.ListarTodos();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tablaTecnico;

                FormatearDataGrid();
            }



            //if (modificarTecnico != null)
            //{
            //    if (modificarTecnico.IsDisposed)
            //    {
            //        modificarTecnico = new UiModificarTecnico(viejo);
            //        modificarTecnico.StartPosition = FormStartPosition.CenterScreen;
            //        modificarTecnico.Show();
            //    }
            //    else
            //    {
            //        modificarTecnico.BringToFront();
            //    }
            //}
            //else
            //{
            //    modificarTecnico = new UiModificarTecnico(viejo);
            //    modificarTecnico.StartPosition = FormStartPosition.CenterScreen;
            //    modificarTecnico.Show();
            //}

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBoxDni_TextChanged(object sender, EventArgs e)
        {
            HabilitarBuscar();
        }

        public void HabilitarBuscar()
        {
            if (textBoxDni.Text == "" && textBoxNombre.Text == "")
                buttonBuscar.Enabled = false;
            else
                buttonBuscar.Enabled = true;
        }
       
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            HabilitarBuscar();
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
            if (tablaTecnico == null)
            {
                tablaTecnico = TecnicoRepository.ListarTodos();
            }
            EnumerableRowCollection<DataRow> resultado;
            int i = -1;

            if(indice == 0)
            {
                

                resultado = from a in tablaTecnico.AsEnumerable()
                                where a.Field<int>(indice).ToString().StartsWith(actual.Text)
                            select a;
            }
            else
            {
                resultado = from a in tablaTecnico.AsEnumerable()
                                where a.Field<string>(indice).IndexOf(actual.Text, StringComparison.OrdinalIgnoreCase) >= 0
                            select a;
            }
            
              
            if (resultado.Count() > 0)
            {
                
                Console.WriteLine("Indice de la busqueda " + i);
                dataGridView1.Rows[i].Selected = true;
                FormatearDataGrid();
            }
            else
            {
                dataGridView1.ClearSelection();
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
                buttonEliminar.Enabled = true;
                buttonDetalles.Enabled = true;
            }
            else
            {
                buttonEliminar.Enabled = false;
                buttonDetalles.Enabled = false;
            }

        }
    }
}
