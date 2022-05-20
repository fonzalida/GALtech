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


namespace CoolSoft.UI2._0.UiOrdenesForm
{
    public partial class CrudParteOrden : Form
    {
        
        UiPrincipal formPrincipal;
        CrudOrden formOrden;
        DataTable tablaParte;
        DataTable tablaTecnico;

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
            

            formPrincipal.CambiarTextoTitulo("Trabajos de Órden N° "+ formOrden.dataGridView1.SelectedRows[0].Cells["IdOrden"].Value.ToString());
            
        }

        private void EstadoInicial()
        {

            tablaParte = ParteOrdenRepository.ListarTodos(int.Parse(formOrden.dataGridView1.SelectedRows[0].Cells["IdOrden"].Value.ToString()));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablaParte;
            dataGridView1.ClearSelection();

            FormatearDataGrid();
            //panelSuperior.Enabled = false;
            //panelFechas.Enabled = true;

            buttonAgregar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonDetalles.Enabled = false;

            /*buttonPartes.Enabled = true;
            buttonPartes.Visible = false;*/


            //buttonLimpiarSeleccion.Visible = false;

            buttonVer.Enabled = false;
            buttonCancelar.Enabled = false;

            //buttonRefrescar.Visible = false;
            buttonVer.Visible = false;
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
            formPrincipal.CambiarTextoTitulo("ORDENES");
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
            

           

        }

        private void FormatearDataGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["IdParte"].HeaderText = "Parte";
            dataGridView1.Columns["TareaDesarrollada"].HeaderText = "Tarea";
            dataGridView1.Columns["TareaDesarrollada"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["IdOrden"].Visible = false;
            dataGridView1.Columns["Completa"].Visible = false;

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dataGridView1.ClearSelection();

           /* foreach (DataGridViewRow r in dataGridView1.Rows)
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
            }*/
        }

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
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tablaTecnico = TecnicoOrdenRepository.ListarTodos(int.Parse(dataGridView1.SelectedRows[0].Cells["IdParte"].Value.ToString()));
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = tablaTecnico;
            }
            else
            {
                dataGridView2.DataSource = null;
            }
        }
    }
}
