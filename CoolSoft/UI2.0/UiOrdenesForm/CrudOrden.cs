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

namespace CoolSoft.UI2._0.UiOrdenesForm
{
    public partial class CrudOrden : Form
    {

        UiAgregarOrden fagregar;
        UiModificarOrden modificarOrden;
        public CrudOrden()
        {

            fagregar = null;
            InitializeComponent();
        }

        private void CrudOrden_Load(object sender, EventArgs e)
        {
            Format.DataGridView(dataGridView1);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (fagregar != null)
            {
                if (fagregar.IsDisposed)
                {
                    fagregar = new UiAgregarOrden();
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
                fagregar = new UiAgregarOrden();
                fagregar.StartPosition = FormStartPosition.CenterScreen;
                fagregar.Show();
            }
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrdenRepository.ListarTodos();
            FormateatDataGrid();
            dataGridView1.ClearSelection();
        }

        private void FormateatDataGrid()
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

        
    }
}
