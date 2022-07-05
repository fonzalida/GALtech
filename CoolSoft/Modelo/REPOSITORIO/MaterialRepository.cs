using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.Modelo.ENTIDADES;
using System.Data;
using MySqlConnector;

namespace CoolSoft.Modelo.REPOSITORIO
{
    static class MaterialRepository
    {
        static public void agregar(Material p)
        {
            //String query = "Insert into material (IdMat, IdOrden, Cantidad, Descripcion) values (" + p.IdMat + "," + p.IdOrden + "," + p.cantidad + "," + p.descripcion + ")";
           
            MySqlCommand cmd = new MySqlCommand(
                           "INSERT INTO material" +
                           "(IdMat, IdOrden, Cantidad, Descripcion)" +
                           " VALUES (@IdMat, @IdOrden, @Cantidad, @Descripcion)"
                           );

            cmd.Parameters.AddWithValue("@IdMat", p.idMat);
            cmd.Parameters.AddWithValue("@IdOrden", p.idOrden);
            cmd.Parameters.AddWithValue("@Cantidad", p.cantidad);
            cmd.Parameters.AddWithValue("@descripcion", p.descripcion);

            Conexion conexion = new Conexion();
            conexion.QueryInsertDeleteUpdate(cmd);
        }

        static public void eliminar(Material p)
        {
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM material " +
                "where IdMat = @IdMat and IdOrden = @IdOrden"
                );

            cmd.Parameters.AddWithValue("@IdMat", p.idMat);
            cmd.Parameters.AddWithValue("@IdOrden", p.idOrden);

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static bool BuscarUno(int IdMat, int IdOrden)
        {
            String query = "SELECT * FROM material WHERE IdMat = \"" + IdMat + "\" and IdOrden = \"" + IdOrden + "\"";

            Conexion conexion = new Conexion();
            if (conexion.QuerySelect(query).Rows.Count == 1)
                return true;
            else
                return false;

        }

        public static void modificar(Material viejo, Material nuevo)
        {

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE material" +
                 "SET Cantidad = @Cantidad2, Descripcion = @Descripcion2 " +
                  "where IdMat = @IdMat and IdOrden = @IdOrden ");

            cmd.Parameters.AddWithValue("@IdMat", viejo.idMat);
            cmd.Parameters.AddWithValue("@IdOrden", viejo.idOrden);

            cmd.Parameters.AddWithValue("@Cantidad2", nuevo.cantidad);
            cmd.Parameters.AddWithValue("@Descripcion2", nuevo.descripcion);

            Conexion conexion = new Conexion();

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static DataTable ListarTodos()
        {
            String query = "SELECT * FROM material";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }

        public static DataTable ListarTodosMat(int idParte)
        {
            String query = "SELECT * FROM material "+
                           "WHERE material.IdParte = " + idParte ;

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }
    }
}
