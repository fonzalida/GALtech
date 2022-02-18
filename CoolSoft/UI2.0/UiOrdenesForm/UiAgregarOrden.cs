using CoolSoft.Controlador;
using CoolSoft.Modelo.REPOSITORIO;
using CoolSoft.UI2._0.Genericos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoolSoft.UI2._0.UiOrdenesForm
{
    public partial class UiAgregarOrden : CoolSoft.UI2._0.Genericos.UiAgregar
    {


        DataTable clientes;
        public UiAgregarOrden()
        {
            InitializeComponent();
        }

        private void UiAgregarOrden_Load(object sender, EventArgs e)
        {
            clientes = ClienteRepository.ListarTodos();

            Format.DataGridView(dataGridView1);
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            OrdenController.Cargar(tbTareaDesarrollar.Text, mtIdCliente.Text, dtFechaRecepcion.Text);
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if(maskedTextDni.Text != "")
            {
                dataGridView1.DataSource = ClienteRepository.Buscar(long.Parse(maskedTextDni.Text));
                dataGridView1.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dataGridView1.DataSource = ClienteRepository.Buscar(-1);
                dataGridView1.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if(i >= 0)
            {
                //MessageBox.Show(i.ToString());
                //MessageBox.Show(mtIdCliente.Text = dataGridView1.Rows[i].Cells[0].Value.ToString());

                mtIdCliente.Text = mtIdCliente.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            }
        }
    }
}
