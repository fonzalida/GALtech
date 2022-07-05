using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.REPOSITORIO;
using CoolSoft.Modelo.SERVICIO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySqlConnector;

namespace connect
{
    public partial class Test : Form
    {


        
        public Test()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            string servidor = txtServidor.Text;
            string puerto = txtPuerto.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;
            string datos = "";

            string cadenaConexion = "server=" + servidor + ";port=" + puerto + ";user id=" + usuario + ";password=" + contrasena + ";database=biosgastro;";

            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            try { 
                conexionBD.Open();

                MySqlDataReader reader = null;

                MySqlCommand cmd = new MySqlCommand("SHOW TABLES", conexionBD);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                }
            }
            catch (MySqlException ex)
            { 
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show(datos);

        }

        private void Test_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrdenRepository.ListarTodos();
            dataGridView1.Refresh();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClienteRepository.ListarTodos();
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Titular t = new Titular();
            //t.IdCliente = int.Parse(tbCIdCliente.Text);
            //t.dni = int.Parse(tbpDni.Text);
            //TitularRepository.agregar(t);

            


        }

        

        private void AgregarPersona_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //textBoxIDCLIENTE.Text = ClienteRepository.ObtenerId().ToString();
        }
    }
}
