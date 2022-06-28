using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.SERVICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.Controlador
{
    class MaterialController
    {
        public static void Cargar(

            string cantidad,
            string descripcion
            )
        {
            Material mat = new Material();

            mat.cantidad = cantidad;
            mat.descripcion = descripcion;

            OrdenService.Agregar(mat);
        }


        public static void EliminarMaterial(
            DataGridViewCellCollection dr
            )
        {
            Material mat = new Material();

            mat.idOrden = int.Parse(dr["IdOrden"].Value.ToString());
            mat.idMat = int.Parse(dr["IdMat"].Value.ToString());

            OrdenService.Eliminar(mat);

        }


        public static Material DataGridViewToMaterial(DataGridViewCellCollection dr)
        {


            Material mat = new Material();

            mat.idOrden = int.Parse(dr["IdOrden"].Value.ToString());
            mat.cantidad = (dr["cantidad"].Value.ToString());
            mat.descripcion = (dr["descripcion"].Value.ToString());

            return mat;


        }
    }
}
