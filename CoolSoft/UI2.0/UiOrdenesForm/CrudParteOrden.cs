using CoolSoft.UI2._0.Genericos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using CoolSoft.Modelo.REPOSITORIO;
using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Controlador;

namespace CoolSoft.UI2._0.UiOrdenesForm
{
    public partial class CrudParteOrden : Form
    {
        UiAgregarParteOrden fagregar;
        UiPrincipal formPrincipal;
        CrudOrden formOrden;
        DataTable tablaParte;
        DataTable tablaTecnico;
        DataTable tablaMaterial;

        public CrudParteOrden(UiPrincipal p, CrudOrden o)
        {
            formPrincipal = p;
            formOrden = o;
            InitializeComponent();
        }

        private void CrudParteOrden_Load(object sender, EventArgs e)
        {
            
            EstadoInicial();
            Format.DataGridView(dataGridView1);
            Format.DataGridView(dataGridView2);
            Format.DataGridView(dataGridView3);


            formPrincipal.CambiarTextoTitulo("Trabajos de Órden N° "+ formOrden.dataGridView1.SelectedRows[0].Cells["IdOrden"].Value.ToString());

            
        }

        private void EstadoInicial()
        {
            //dataGridView1.ClearSelection();
            //tablaParte = ParteOrdenRepository.ListarTodos(int.Parse(formOrden.dataGridView1.SelectedRows[0].Cells["IdOrden"].Value.ToString()));
            //dataGridView1.ClearSelection();
            /*dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablaParte;
            
            FormatearDataGrid();*/
            //panelSuperior.Enabled = false;
            //panelFechas.Enabled = true;

            buttonAgregar.Enabled = true;
            buttonEliminar.Enabled = true;
            //buttonDetalles.Enabled = false;

            /*buttonPartes.Enabled = true;
            buttonPartes.Visible = false;*/


            //buttonLimpiarSeleccion.Visible = false;

            //buttonVer.Enabled = false;
            //buttonCancelar.Enabled = false;

            //buttonRefrescar.Visible = false;
            buttonVer.Visible = true;
            buttonCancelar.Visible = false;
            buttonDetalles.Visible = false;
            //dateTimePickerHasta.MinDate = dateTimePickerDesde.Value;
            
        }

        private void EstadoVer()
        {

           
            //panelSuperior.Enabled = true;
            //panelFechas.Enabled = false;

            buttonAgregar.Enabled = true;

            buttonVer.Enabled = false;
            buttonCancelar.Enabled = true;

            //buttonRefrescar.Visible = true;
            buttonVer.Visible = false;
            /*buttonPartes.Visible = true;
            buttonPartes.Enabled = false;*/

           
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            formPrincipal.CambiarTextoTitulo("ÓRDENES");
            this.Dock = DockStyle.None;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.TransitionCompletedEvent += new EventHandler<Transition.Args>(OnTransitionCompleted);

            //t.add(formOrden.tableLayoutPanel1, "Top", 12);
            //t.add(this, "Top", 690);

            t.add(formOrden.tableLayoutPanel1, "Left", 12);
            t.add(this, "Left", 1460);
            t.run();

        }


        private void OnTransitionCompleted(object sender, Transition.Args e)
        {
            
            this.Close();
        }

        private void buttonAgregar_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine(buttonAgregar.Size);
        }


        private void buttonVer_Click(object sender, EventArgs e)
        {
            
            EstadoVer();
            tablaParte = ParteOrdenRepository.ListarTodos(int.Parse(formOrden.dataGridView1.SelectedRows[0].Cells["IdOrden"].Value.ToString()));
            //dataGridView1.ClearSelection();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablaParte;

            FormatearDataGrid();


        }

        private void FormatearDataGrid()
        {
            dataGridView1.ClearSelection();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["IdParte"].HeaderText = "Parte";
            dataGridView1.Columns["TareaDesarrollada"].Visible = false;
            //dataGridView1.Columns["TareaDesarrollada"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           
            dataGridView1.Columns["IdOrden"].Visible = false;
            dataGridView1.Columns["Completa"].Visible = false;
            dataGridView1.Columns["FechaInicio"].HeaderText = "Inicio";
            dataGridView1.Columns["FechaFin"].HeaderText = "Fin";


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dataGridView1.ClearSelection();
            int index = e.RowIndex;
            
                if (dataGridView1.Rows[index].Cells["Completa"].Value.ToString() == "False")
                {
                dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.PeachPuff;
                dataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.PaleGreen;
                dataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.Black;
                }
        }

        //ya no hace falta este boton
        private void boton_chancho_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            //int index = e.RowIndex;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.Cells["Completa"].Value.ToString() == "False")
                {
                    r.DefaultCellStyle.BackColor = Color.PeachPuff;
                    r.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    r.DefaultCellStyle.BackColor = Color.PaleGreen;
                    r.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //FormatearDataGrid();
            //dataGridView1.ClearSelection();

            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                tablaTecnico = TecnicoOrdenRepository.ListarTodos(int.Parse(dataGridView1.SelectedRows[0].Cells["IdParte"].Value.ToString()));
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = tablaTecnico;
                dataGridView3.ClearSelection();
                FormatearDataGrid2();
                
                //textBox1.Text = dataGridView1.SelectedRows[1].Cells["TareaDesarrollada"].Value.ToString();

                tablaMaterial = MaterialRepository.ListarTodosMat(int.Parse(dataGridView1.SelectedRows[0].Cells["IdParte"].Value.ToString()));
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = tablaMaterial;
                dataGridView2.ClearSelection();
                
                FormatearDataGrid3();

                
            }
            else
            {
                dataGridView2.DataSource = null;
                dataGridView3.DataSource = null;
            }
        }

        private void FormatearDataGrid2()
        {
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView3.Columns["Dni"].Visible = false;
            dataGridView3.Columns["FechaInicio"].Visible = false;
            dataGridView3.Columns["FechaFin"].Visible = false;
            dataGridView3.Columns["IdParte"].Visible = false;
            dataGridView3.Columns["IdParte1"].Visible = false;
            dataGridView3.Columns["TareaDesarrollada"].Visible = false;
            dataGridView3.Columns["IdOrden"].Visible = false;
            dataGridView3.Columns["Completa"].Visible = false;
            dataGridView3.Columns["Dni1"].Visible = false;
            dataGridView3.Columns["Telefono"].Visible = false;
            dataGridView3.Columns["Activo"].Visible = false;

        }

        private void FormatearDataGrid3()
        {
            dataGridView3.ClearSelection();

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.Columns["IdParte"].Visible=false;
            dataGridView2.Columns["IdMat"].Visible = false;
            dataGridView2.Columns["IdOrden"].Visible = false;
            
            dataGridView2.Columns["Cantidad"].HeaderText = "Cantidad";
            dataGridView2.Columns["Descripcion"].HeaderText = "Material";

        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = dataGridView1.SelectedRows[1].Cells["TareaDesarrollada"].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string texto = "Parte Órden N° " + dataGridView1.SelectedRows[0].Cells["IdParte"].Value.ToString();
            Eliminar fEliminar = new Eliminar(texto);
            Format.FormularioBorde(fEliminar, false);
            fEliminar.StartPosition = FormStartPosition.CenterScreen;
            var result = fEliminar.ShowDialog();
            if (result == DialogResult.OK)
            {

                ParteOrdenController.EliminarParteOrden(dataGridView1.SelectedRows[0].Cells);
                EstadoVer();
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            fagregar = new UiAgregarParteOrden();
            Format.FormularioBorde(fagregar, false);
            fagregar.StartPosition = FormStartPosition.CenterScreen;
            var result = fagregar.ShowDialog();
            if (result == DialogResult.OK)
            {
                EstadoVer();
            }
        }
    }
}
