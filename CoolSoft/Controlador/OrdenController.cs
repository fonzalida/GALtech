using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.REPOSITORIO;
using CoolSoft.Modelo.SERVICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.Controlador
{
    static class OrdenController
    {
        public static void Cargar(
            string TareaDesarrollar,
            string IdCliente,
            string FechaRecepcion
            )
        {
            Orden orden = new Orden();

            orden.idCliente = int.Parse(IdCliente);
            orden.tareaDesarrollar = CG.EsNullOString(TareaDesarrollar);
            orden.fechaRecepcion = DateTime.Parse(FechaRecepcion);

            OrdenService.Agregar(orden);
        }


        public static void EliminarOrden(
            DataGridViewCellCollection dr
            )
        {
            Orden orden = new Orden();

            orden.idOrden = int.Parse(dr["IdOrden"].Value.ToString());

            OrdenService.Eliminar(orden);

        }


        public static Orden DataGridViewToOrden(DataGridViewCellCollection dr)
        {
            float importe;

            Orden orden = new Orden();

            orden.idOrden = int.Parse(dr["IdOrden"].Value.ToString());
            orden.fechaRecepcion = DateTime.Parse(dr["Recepcion"].Value.ToString());
            orden.tareaDesarrollar = dr["TareaDesarrollar"].Value.ToString();

            if (float.TryParse(dr["Importe"].Value.ToString(), out importe))
            {
                orden.precio = importe;
            }


            orden.idCliente = int.Parse(dr["IdCliente"].Value.ToString());
            Console.WriteLine(dr["Completada"].Value.ToString());

            if(dr["Completada"].Value.ToString() == "True")
            {
                orden.completada = 1;
            }
            else
            {
                orden.completada = 0;
            }
            

            return orden;


        }

        internal static void Modificar(
            string fechaRecepcion,
            string tareaDesarrollar,
            string idCliente, 
            bool completada, 
            string importe,
            Orden vieja)
        {
            Orden orden = new Orden();
            orden.fechaRecepcion = DateTime.Parse(fechaRecepcion);
            orden.tareaDesarrollar = CG.EsNullOString(tareaDesarrollar);
            orden.idCliente = int.Parse(idCliente);

            if (completada)
                orden.completada = 1;
            else
                orden.completada = 0;

            float f;
            if (float.TryParse(importe, out f))
                orden.precio = f;

            OrdenService.modificar(vieja, orden);
        }
    }
}
