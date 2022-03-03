using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace CoolSoft.Modelo
{
    class Conexion
    {
        MySqlConnection conexionBD;
        string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString;
            //cadenaConexion = "server=localhost;port=3306;user id=root;password=;database=biosgastro"; 
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

        public int QueryId(MySqlCommand cmd)
        {
            int resultado = -1;
            try
            {
                conexionBD.Open();

                cmd.Connection = conexionBD;
                resultado = Convert.ToInt32(cmd.ExecuteScalar());

                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR " + ex.ToString());
            }
            return resultado;
            //return dt.Rows[0].Field<int>(0);
        }


        public string QueryInsertDeleteUpdate(MySqlCommand cmd) //QUERY INSERT, DELETE, UPDATE
        {
            string datos = "";
            try
            {
                conexionBD.Open();
                cmd.Connection = conexionBD;
                //MySqlCommand cmd = new MySqlCommand(Query, conexionBD);
                datos = cmd.ExecuteNonQuery().ToString();

            }
            catch (MySqlException ex)
            {
                
                datos = "ERROR " + ex.ToString();
                MessageBox.Show(datos);
            }

            return datos;
        }

        public void QueryInsertTransaction(List<string> querys)
        {
            conexionBD.Open();

            MySqlCommand myCommand = conexionBD.CreateCommand();
            MySqlTransaction myTrans;

            // Start a local transaction
            myTrans = conexionBD.BeginTransaction();
            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
            myCommand.Connection = conexionBD;
            myCommand.Transaction = myTrans;

            try
            {
                int i = 0;
                foreach(string query in querys)
                {
                    myCommand.CommandText = query;
                    i += myCommand.ExecuteNonQuery();

                }
                myTrans.Commit();
                Console.WriteLine(i +" registros cargados");
            }
            catch (Exception e)
            {
                try
                {
                    myTrans.Rollback();
                }
                catch (SqlException ex)
                {
                    if (myTrans.Connection != null)
                    {
                        Console.WriteLine("An exception of type " + ex.GetType() +
                        " was encountered while attempting to roll back the transaction.");
                    }
                }

                Console.WriteLine("An exception of type " + e.GetType() +
                " was encountered while inserting the data.");
                Console.WriteLine("Neither record was written to database.");
            }
            finally
            {
                conexionBD.Close();
            }
        }

    }
}
