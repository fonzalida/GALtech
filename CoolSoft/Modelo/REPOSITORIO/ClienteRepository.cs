using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;
using MySql.Data.MySqlClient;

namespace CoolSoft.DATOS.REPOSITORIO
{
    static class ClienteRepository
    {
        static public int Agregar(Cliente p)
        {
            //MySqlCommand cmd = new MySqlCommand(
            //   "INSERT INTO CLIENTE" +
            //   "(IdCliente, nombre, domicilio, telefono)" +
            //   " VALUES (@IdCliente, @nombre, @domicilio, @telefono)"
            //   );

            //cmd.Parameters.AddWithValue("@IdCliente", p.IdCliente);
            //cmd.Parameters.AddWithValue("@nombre", p.nombre);
            //cmd.Parameters.AddWithValue("@domicilio", p.Domicilio);
            //cmd.Parameters.AddWithValue("@telefono", p.Telefono);

            //Conexion conexion = new Conexion();
            //conexion.QueryInsertDeleteUpdate(cmd);

            ////RETORNAR EL ID DEL CLIENTE CARGADO
            //String query = "SELECT SCOPE_IDENTITY();";

            //return conexion.QuerySelect(query).Rows[0].Field<int>(0);

            MySqlCommand cmd = new MySqlCommand(
               "INSERT INTO CLIENTE" +
               "(nombre, domicilio, telefono)" +
               " VALUES (@nombre, @domicilio, @telefono); " +
               //"SELECT SCOPE_IDENTITY();"
               "SELECT LAST_INSERT_ID();"
               );

            cmd.Parameters.AddWithValue("@nombre", p.nombre);
            cmd.Parameters.AddWithValue("@domicilio", p.Domicilio);
            cmd.Parameters.AddWithValue("@telefono", p.Telefono);

            Conexion conexion = new Conexion();

            return conexion.QueryId(cmd);

        }

        static public void eliminar(Cliente p)
        {
            
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
               "DELETE FROM CLIENTE" +
               "where IdCliente = @IdCliente"
               );

            cmd.Parameters.AddWithValue("@IdCliente", p.IdCliente);

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static bool BuscarUno(int IdCliente)
        {
            String query = "SELECT * FROM CLIENTE WHERE IdCliente = \"" + IdCliente + "\"";

            Conexion conexion = new Conexion();
            if (conexion.QuerySelect(query).Rows.Count == 1)
                return true;
            else
                return false;

        }

        public static DataTable ListarTodos()
        {
            String query = "SELECT * FROM CLIENTE";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }

        //public static int ObtenerId()
        //{
        //    String query = "SELECT MAX(IdCliente) FROM CLIENTE";

        //    Conexion conexion = new Conexion();
        //    return conexion.QuerySelect(query).Rows[0].Field<int>(0);
        //}
    }
}
