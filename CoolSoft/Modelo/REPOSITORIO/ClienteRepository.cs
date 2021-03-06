using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.Modelo.ENTIDADES;
using MySqlConnector;

namespace CoolSoft.Modelo.REPOSITORIO
{
    static class ClienteRepository
    {
        static public int Agregar(Cliente c)
        {

            MySqlCommand cmd = new MySqlCommand(
               "INSERT INTO cliente" +
               "(DniCuit, Nombre, Domicilio, Localidad, Provincia, Telefono1, Telefono2)" +
               " VALUES (@DniCuit, @Nombre, @Domicilio, @Localidad, @Provincia, @Telefono1, @Telefono2); " +
               "SELECT LAST_INSERT_ID();"
               );

            cmd.Parameters.AddWithValue("@DniCuit", c.dniCuit);
            cmd.Parameters.AddWithValue("@Nombre", c.nombre);
            cmd.Parameters.AddWithValue("@Domicilio", c.domicilio);
            cmd.Parameters.AddWithValue("@Localidad", c.localidad);
            cmd.Parameters.AddWithValue("@Provincia", c.provincia);
            cmd.Parameters.AddWithValue("@Telefono1", c.telefono1);
            cmd.Parameters.AddWithValue("@Telefono2", c.telefono2);

            Conexion conexion = new Conexion();

            return conexion.QueryId(cmd);

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

        }

        static public void eliminar(Cliente p)
        {
            
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
               "DELETE FROM cliente" +
               "where IdCliente = @IdCliente"
               );

            cmd.Parameters.AddWithValue("@IdCliente", p.idCliente);

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static bool BuscarUno(long DniCuit)
        {
            String query = "SELECT * FROM cliente WHERE DniCuit = \"" + DniCuit + "\"";

            Conexion conexion = new Conexion();
            if (conexion.QuerySelect(query).Rows.Count == 1)
                return true;
            else
                return false;

        }

        

        public static void modificar(Cliente viejo, Cliente nuevo)
        {

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE cliente " +
                 "SET DniCuit = @DniCuit2, Nombre = @Nombre2, Domicilio = @Domicilio2, Localidad = @Localidad2, Provincia = @Provincia2, Telefono1 = @Telefono12, Telefono2 = @Telefono22 " +
                  "where IdCliente = @idCliente  ");

            cmd.Parameters.AddWithValue("@idCliente", viejo.idCliente);

            cmd.Parameters.AddWithValue("@DniCuit2", nuevo.dniCuit);
            cmd.Parameters.AddWithValue("@Nombre2", nuevo.nombre);
            cmd.Parameters.AddWithValue("@Domicilio2", nuevo.domicilio);
            cmd.Parameters.AddWithValue("@Localidad2", nuevo.localidad);
            cmd.Parameters.AddWithValue("@Provincia2", nuevo.provincia);
            cmd.Parameters.AddWithValue("@Telefono12", nuevo.telefono1);
            cmd.Parameters.AddWithValue("@Telefono22", nuevo.telefono2);

            Conexion conexion = new Conexion();

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static DataTable ListarTodos()
        {
            String query = "SELECT * FROM cliente";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }

        //public static int ObtenerId()
        //{
        //    String query = "SELECT MAX(IdCliente) FROM CLIENTE";

        //    Conexion conexion = new Conexion();
        //    return conexion.QuerySelect(query).Rows[0].Field<int>(0);
        //}


        public static DataTable Buscar(long DniCuit)
        {
            //String query = "SELECT * FROM CLIENTE WHERE DNICUIT = \"" + DniCuit + "\"";
            String query = "SELECT IdCliente as Numero, DniCuit as 'Dni/Cuit', Nombre FROM CLIENTE ";
            string query2 = "WHERE CAST(DNICUIT as CHAR) LIKE '%" + DniCuit + "%'";

            Conexion conexion = new Conexion();

            if(DniCuit != -1)
            {
                query = query + query2;
            }

            var resultado = conexion.QuerySelect(query);

            
            return resultado;


        }

        public static string BuscarNombre(int idCliente)
        {
            String query = "SELECT Nombre FROM cliente WHERE IdCliente = " + idCliente;
            Conexion conexion = new Conexion();
            var resultado = conexion.QuerySelect(query);
            Console.WriteLine(resultado.Rows.Count);
            return resultado.Rows[0].Field<string>("Nombre");


        }
    }
}
