﻿using CoolSoft.DATOS.ENTIDADES;
using CoolSoft.DATOS.REPOSITORIO;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace connect
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PersonaRepository.ListarTodos();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.dni = int.Parse(tbDni.Text);
            p.nombre = tbNombre.Text;
            p.apellido = tbApellido.Text;

            PersonaRepository.agregar(p);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orden o = new Orden();
            o.IdOrden = 1; //int.Parse(tbIdOrden.Text);
            o.FechaRecepcion = DateTime.Now.Date; //DateTime.Parse(tbFechaRecepcion.Text)
            o.TareaDesarrollar = tbTareaADesarrollar.Text;
            o.TareaDesarrollada = tbTareaDesarrollada.Text;
            o.Precio = float.Parse(tbPrecio.Text);
            o.IdCliente = 1; //int.Parse(tbIdCliente.Text);
            o.Completada = true; //bool.Parse(tbCompletado.Text);

            OrdenRepository.agregar(o);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrdenRepository.ListarTodos();
            dataGridView1.Refresh();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
