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
            Format.DataGridView(dataGridView1);

          //  FormateatDataGrid();

        }

        private void FormateatDataGrid()
        {
            

           // dataGridView1.Columns[3].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
                       
            /*dataGridView1.Columns[0].HeaderText = "ID";

            dataGridView1.Columns[1].HeaderText = "DNI / CUIT";

            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
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
