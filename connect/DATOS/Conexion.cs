using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CoolSoft.DATOS
{
    class Conexion
    {
        MySqlConnection conexionBD;

        public Conexion()
        {
            string cadenaConexion = "server=localhost;port=3306;user id=root;database=biosgastro"; 
            conexionBD = new MySqlConnection(cadenaConexion);
        }


        public Conexion(string server, string port, string user, string pass, string db)
        {
            string cadenaConexion = "server=" + server + ";port=" + port + ";user id=" + user + ";password=" + pass + ";database="+db+";";
            conexionBD = new MySqlConnection(cadenaConexion);
        }

        public DataTable QuerySelect(string Query)
        {
            DataTable dt = new DataTable();
            string datos = "";
            try
            {
                conexionBD.Open();

                MySqlCommand cmd = new MySqlCommand(Query, conexionBD);
                MySqlDataReader reader = cmd.ExecuteReader();

               
                dt.Load(reader);


                //while (reader.Read())
                //{
                //    datos += reader.GetString(0) + "\n";
                //}
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR " + ex.ToString());
            }

            return dt;
        }


        public string QueryInsert(MySqlCommand cmd) //QUERY INSERT, DELETE, UPDATE
        {
            string datos = "";
            try
            {
                conexionBD.Open();
                MySqlCommand cmd = new MySqlCommand(Query, conexionBD);
                datos = cmd.ExecuteNonQuery().ToString();

            }
            catch (MySqlException ex)
            {
                datos = "ERROR " + ex.ToString();
            }

            return datos;
        }

    }
}
