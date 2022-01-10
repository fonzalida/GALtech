using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            string cadenaConexion = "server = " + servidor + "; port = " + puerto + "; user = id= " + usuario + "; password = " + contrasena + "; database = mysql;";

            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            try { 
                conexionBD.Open();

                MySqlDataReader reader = null;

                MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", conexionBD);
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
    }
}
