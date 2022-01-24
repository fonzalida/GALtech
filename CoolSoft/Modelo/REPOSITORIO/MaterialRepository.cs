using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;
using System.Data;
using MySql.Data.MySqlClient;

namespace CoolSoft.DATOS.REPOSITORIO
{
    static class MaterialRepository
    {
        static public void agregar(Material p)
        {
            //String query = "Insert into material (IdMat, IdOrden, Cantidad, Descripcion) values (" + p.IdMat + "," + p.IdOrden + "," + p.cantidad + "," + p.descripcion + ")";
           
            MySqlCommand cmd = new MySqlCommand(
                           "INSERT INTO MATERIAL" +
                           "(IdMat, IdOrden, Cantidad, Descripcion)" +
                           " VALUES (@IdMat, @IdOrden, @Cantidad, @Descripcion)"
                           );

            cmd.Parameters.AddWithValue("@IdMat", p.IdMat);
            cmd.Parameters.AddWithValue("@IdOrden", p.IdOrden);
            cmd.Parameters.AddWithValue("@Cantidad", p.cantidad);
            cmd.Parameters.AddWithValue("@descripcion", p.descripcion);

            Conexion conexion = new Conexion();
            conexion.QueryInsert(cmd);
        }

        static public void eliminar(Material p)
        {
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM MATERIAL " +
                "where IdMat = @IdMat and IdOrden=@IdOrden"
                );

            cmd.Parameters.AddWithValue("@IdMat", p.IdMat);
            cmd.Parameters.AddWithValue("@IdOrden", p.IdOrden);

            conexion.QueryInsert(cmd);
        }

        public static DataTable/*List<Material>*/ ListarTodos()
        {
            String query = "SELECT * FROM MATERIAL";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }
    }
}
