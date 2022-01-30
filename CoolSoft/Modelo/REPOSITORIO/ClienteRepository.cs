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
        static public int Agregar(Cliente c)
        {

            MySqlCommand cmd = new MySqlCommand(
               "INSERT INTO CLIENTE" +
               "(DniCuit, Nombre, Domicilio, Localidad, Provincia, Telefono1, Telefono2)" +
               " VALUES (@DniCuit, @Nombre, @Domicilio, @Localidad, @Provincia, @Telefono1, @Telefono2); " +
               "SELECT LAST_INSERT_ID();"
               );

            cmd.Parameters.AddWithValue("@DniCuit", c.dniCuil);
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
               "DELETE FROM CLIENTE" +
               "where IdCliente = @IdCliente"
               );

            cmd.Parameters.AddWithValue("@IdCliente", p.idCliente);

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

        public static void modificar(Cliente p, Cliente pn)
        {

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE CLIENTE" +
                 "SET DniCuit = @DniCuit2, Nombre = @Nombre2, Domicilio = @Domicilio2, Localidad = @Localidad2, Provincia = @Provincia2, Telefono1 = @Telefono12, Telefono2 = @Telefono22 " +
                  "where IdCliente = @idCliente  ");

            cmd.Parameters.AddWithValue("@idCliente", p.idCliente);

            cmd.Parameters.AddWithValue("@DniCuit2", pn.dniCuil);
            cmd.Parameters.AddWithValue("@Nombre2", pn.nombre);
            cmd.Parameters.AddWithValue("@Domicilio2", pn.domicilio);
            cmd.Parameters.AddWithValue("@Localidad2", pn.localidad);
            cmd.Parameters.AddWithValue("@Provincia2", pn.provincia);
            cmd.Parameters.AddWithValue("@Telefono12", pn.telefono1);
            cmd.Parameters.AddWithValue("@Telefono22", pn.telefono2);

            Conexion conexion = new Conexion();

            conexion.QueryInsertDeleteUpdate(cmd);
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
