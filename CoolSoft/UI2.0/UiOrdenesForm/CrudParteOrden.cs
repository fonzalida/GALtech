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
        ParteOrden vieja;
        
        UiAgregParteOrden fagregar;
        UiAgregarMaterial fagregarMat;
        UiModifParteOrden fModificar;
        UiPrincipal formPrincipal;
        CrudOrden formOrden;
        DataTable tablaParte;
        DataTable tablaTecnico;
        DataTable tablaMaterial;
        int NroOrden;

        public CrudParteOrden(UiPrincipal p, CrudOrden o, string numero)
        {
            
            formPrincipal = p;
            formOrden = o;
            InitializeComponent();
            NroOrden = int.Parse(numero);
        }

        private void CrudParteOrden_Load(object sender, EventArgs e)
        {
            
            EstadoInicial();
            panelDetalles.Visible = false;
            Format.DataGridView(dataGridView1);
            Format.DataGridView(dataGridViewMateriales);
            Format.DataGridView(dataGridViewTecnicos);

            //formPrincipal.CambiarTextoTitulo("Trabajos de Órden N° "+ NroOrden);
            label2.Text = "Trabajos de Órden N° " + NroOrden;


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

            buttonAgregar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonRefrescar.Visible = false;
            //buttonDetalles.Enabled = false;

            /*buttonPartes.Enabled = true;
            buttonPartes.Visible = false;*/


            //buttonLimpiarSeleccion.Visible = false;

            //buttonVer.Enabled = false;
            //buttonCancelar.Enabled = false;

            //buttonRefrescar.Visible = false;
            buttonVer.Visible = true;
            //buttonCancelar.Visible = false;
            buttonDetalles.Visible = false;
            //dateTimePickerHasta.MinDate = dateTimePickerDesde.Value;
            
        }

        private void EstadoVer()
        {

           
            //panelSuperior.Enabled = true;
            //panelFechas.Enabled = false;

            buttonAgregar.Enabled = true;
            buttonDetalles.Enabled = true;
            //buttonCancelar.Enabled = true;
            buttonRefrescar.Visible = true;
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
            t.add(this, "Left", Screen.PrimaryScreen.Bounds.Width);
            //t.add(this, "Left", 1460);
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


        public void CargarPartes()
        {
            
            tablaParte = ParteOrdenRepository.ListarTodos(NroOrden);
            //dataGridView1.ClearSelection();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablaParte;

            FormatearDataGrid();

        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            
            EstadoVer();
            CargarPartes();


        }

        private void FormatearDataGrid()
        {
            dataGridView1.ClearSelection();

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["IdParte"].HeaderText = "Numero de Tarea";
            
            dataGridView1.Columns["TareaDesarrollada"].Visible = false;
            //dataGridView1.Columns["TareaDesarrollada"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           
            dataGridView1.Columns["IdOrden"].Visible = false;
            dataGridView1.Columns["Completa"].Visible = false;
            dataGridView1.Columns["FechaInicio"].Visible = false;
            dataGridView1.Columns["FechaFin"].Visible = false;


            dataGridView1.Columns["IdParte"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            


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

                labelTituloTarea.Text = "Tarea Nº " + dataGridView1.SelectedRows[0].Cells["IdParte"].Value.ToString();
                

                tablaTecnico = TecnicoOrdenRepository.ListarTodos(int.Parse(dataGridView1.SelectedRows[0].Cells["IdParte"].Value.ToString()));
                dataGridViewTecnicos.DataSource = null;
                dataGridViewTecnicos.DataSource = tablaTecnico;
                dataGridViewTecnicos.ClearSelection();
                FormatearDataGridTec();
                

                //textBox1.Text = dataGridView1.SelectedRows[1].Cells["TareaDesarrollada"].Value.ToString();

                tablaMaterial = MaterialRepository.ListarTodosMat(int.Parse(dataGridView1.SelectedRows[0].Cells["IdParte"].Value.ToString()));
                dataGridViewMateriales.DataSource = null;
                dataGridViewMateriales.DataSource = tablaMaterial;
                dataGridViewMateriales.ClearSelection();
                FormatearDataGridMat();

                MostrarDetalles(true);

                panelDetalles.Visible = true;
                buttonEliminar.Enabled = true;
                
            }
            else
            {
                panelDetalles.Visible = false;
                MostrarDetalles(false);
                labelTituloTarea.Text = "Tarea:";
                buttonEliminar.Enabled = false;
                dataGridViewMateriales.DataSource = null;
                dataGridViewTecnicos.DataSource = null;
            }
        }

        private void FormatearDataGridTec()
        {
            dataGridViewTecnicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridViewTecnicos.Columns["Dni"].Visible = false;
            dataGridViewTecnicos.Columns["FechaInicio"].Visible = false;
            dataGridViewTecnicos.Columns["FechaFin"].Visible = false;
            dataGridViewTecnicos.Columns["IdParte"].Visible = false;
            dataGridViewTecnicos.Columns["IdParte1"].Visible = false;
            dataGridViewTecnicos.Columns["TareaDesarrollada"].Visible = false;
            dataGridViewTecnicos.Columns["IdOrden"].Visible = false;
            dataGridViewTecnicos.Columns["Completa"].Visible = false;
            dataGridViewTecnicos.Columns["Dni1"].Visible = false;
            dataGridViewTecnicos.Columns["Telefono"].Visible = false;
            dataGridViewTecnicos.Columns["Activo"].Visible = false;
            dataGridViewTecnicos.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FormatearDataGridMat()
        {
            dataGridViewTecnicos.ClearSelection();

            dataGridViewMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMateriales.Columns["IdParte"].Visible=false;
            dataGridViewMateriales.Columns["IdMat"].Visible = false;
            dataGridViewMateriales.Columns["IdOrden"].Visible = false;
           // dataGridView2.Columns["TareaDesarrollada"].Visible = false;

            dataGridViewMateriales.Columns["Cantidad"].HeaderText = "Cantidad";
            dataGridViewMateriales.Columns["Descripcion"].HeaderText = "Material";
            dataGridViewMateriales.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = dataGridView1.SelectedRows[0].Cells["TareaDesarrollada"].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MostrarDetalles(bool v)
        {

            if (v)
            {
                ParteOrden p = ParteOrdenController.DataGridViewToParteOrden(dataGridView1.SelectedRows[0].Cells);

                checkBox1.Checked = (p.completa == 1);
                textBox1.Text = p.tareaDesarrollada;
                textFechas.Text = "Inicio: " + p.fechaInicio.ToString("dd-MM-yyyy HH:mm") + Environment.NewLine + "Inicio: "+  p.fechaFin.ToString("dd-MM-yyyy HH:mm");
                TimeSpan resta = p.fechaFin - p.fechaInicio;
                textHoras.Text = resta.Hours.ToString().PadLeft(2,'0') + ":" + resta.Minutes.ToString().PadLeft(2, '0');
            }
            else
            {
                checkBox1.Checked = false;
                textBox1.Text = "";
                textFechas.Text = "";
                textHoras.Text = "";
            }



            

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
                CargarPartes();

            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //fagregar = new UiAgregParteOrden();
            //Format.FormularioBorde(fagregar, false);
            //fagregar.StartPosition = FormStartPosition.CenterScreen;
            //var result = fagregar.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    EstadoVer();
            //}

            ParteOrdenController.Agregar(NroOrden);

            EstadoVer();
            tablaParte = ParteOrdenRepository.ListarTodos(NroOrden);
            //dataGridView1.ClearSelection();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablaParte;

            FormatearDataGrid();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarMateriales()
        {
            tablaMaterial = MaterialRepository.ListarTodosMat(int.Parse(dataGridView1.SelectedRows[0].Cells["IdParte"].Value.ToString()));
            dataGridViewMateriales.DataSource = null;
            dataGridViewMateriales.DataSource = tablaMaterial;
            dataGridViewMateriales.ClearSelection();
            FormatearDataGridMat();
        }

        private void buttonEliminarMat_Click(object sender, EventArgs e)
        {
            string texto =" Material "+ dataGridViewMateriales.SelectedRows[0].Cells["descripcion"].Value.ToString() + ", Cantidad " + dataGridViewMateriales.SelectedRows[0].Cells["cantidad"].Value.ToString();
            Eliminar fEliminar = new Eliminar(texto);
            Format.FormularioBorde(fEliminar, false);
            fEliminar.StartPosition = FormStartPosition.CenterScreen;
            var result = fEliminar.ShowDialog();
            if (result == DialogResult.OK)
            {

                MaterialController.EliminarMaterial(dataGridViewMateriales.SelectedRows[0].Cells);
                EstadoVer();
                ActualizarMateriales();
            }
        }

        private void buttonAgregarMat_Click(object sender, EventArgs e)
        {
            fagregarMat = new UiAgregarMaterial();
            Format.FormularioBorde(fagregarMat, false);
            fagregarMat.StartPosition = FormStartPosition.CenterScreen;
            var result = fagregarMat.ShowDialog();
            if (result == DialogResult.OK)
            {
                EstadoVer();
            }
        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {
            vieja = ParteOrdenController.DataGridViewToParteOrden(dataGridView1.SelectedRows[0].Cells);


            fModificar = new UiModifParteOrden(vieja);
            Format.FormularioBorde(fModificar, false);
            fModificar.StartPosition = FormStartPosition.CenterScreen;
            var result = fModificar.ShowDialog();
            if (result == DialogResult.OK)
            {
                EstadoVer();
            }
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            CargarPartes();
        }

        private void buttonGuardarParte_Click(object sender, EventArgs e)
        {

            ParteOrden p = new ParteOrden();

            vieja = ParteOrdenController.DataGridViewToParteOrden(dataGridView1.SelectedRows[0].Cells);
            ParteOrdenController.Modificar(textBox1.Text, checkBox1.Checked,vieja);

            dataGridView1.ClearSelection();
            CargarPartes();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string texto = " Tecnico " + dataGridViewTecnicos.SelectedRows[0].Cells["Nombre"].Value.ToString();
            Eliminar fEliminar = new Eliminar(texto);
            Format.FormularioBorde(fEliminar, false);
            fEliminar.StartPosition = FormStartPosition.CenterScreen;
            var result = fEliminar.ShowDialog();
            if (result == DialogResult.OK)
            {

                TecnicoOrdenController.Eliminar(dataGridViewTecnicos.SelectedRows[0].Cells);
                EstadoVer();
            }
        }

        private void buttonAgregarTec_Click(object sender, EventArgs e)
        {

        }
    }
}
