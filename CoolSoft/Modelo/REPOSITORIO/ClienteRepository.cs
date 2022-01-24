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
        static void agregar(Cliente p)
        {
            //String query = "Insert into Cliente(IdCliente, nombre, domicilio, telefono) values ("+p.IdCliente+","+p.nombre+ "," +p.Domicilio+ "," +p.Telefono+")";

            MySqlCommand cmd = new MySqlCommand(
               "INSERT INTO CLIENTE" +
               "(IdCliente, nombre, domicilio, telefono)" +
               " VALUES (@IdCliente, @nombre, @domicilio, @telefono)"
               );

            cmd.Parameters.AddWithValue("@IdCliente", p.IdCliente);
            cmd.Parameters.AddWithValue("@nombre", p.nombre);
            cmd.Parameters.AddWithValue("@domicilio", p.Domicilio);
            cmd.Parameters.AddWithValue("@telefono", p.Telefono);
            
            Conexion conexion = new Conexion();
            conexion.QueryInsert(cmd);
        }

        static void eliminar(Cliente p)
        {
            
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
               "DELETE FROM CLIENTE" +
               "where IdCliente = @IdCliente"
               );

            cmd.Parameters.AddWithValue("@IdCliente", p.IdCliente);

            conexion.QueryInsert(cmd);
        }

        public static DataTable/*List<Cliente>*/ ListarTodos()
        {
            String query = "SELECT * FROM CLIENTE";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }
    }
}
