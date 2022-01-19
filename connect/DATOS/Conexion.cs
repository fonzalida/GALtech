using MySql.Data.MySqlClient;


namespace CoolSoft.DATOS
{
    class Conexion
    {
        MySqlConnection conexionBD;

        public Conexion()
        {
            string cadenaConexion = "server=localhost;port=3306;user id=root;password=;database=biosgatro;"; 
            conexionBD = new MySqlConnection(cadenaConexion);
        }


        public Conexion(string server, string port, string user, string pass, string db)
        {
            string cadenaConexion = "server=" + server + ";port=" + port + ";user id=" + user + ";password=" + pass + ";database="+db+";";
            conexionBD = new MySqlConnection(cadenaConexion);
        }

        public string QuerySelect(string Query)
        {
            string datos = "";
            try
            {
                conexionBD.Open();

                MySqlDataReader reader = null;

                MySqlCommand cmd = new MySqlCommand(Query, conexionBD);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                }
            }
            catch (MySqlException ex)
            {
                datos = "ERROR " + ex.ToString();
            }

            return datos;
        }

        public string QueryInsert(string Query) //QUERY INSERT, DELETE, UPDATE
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
