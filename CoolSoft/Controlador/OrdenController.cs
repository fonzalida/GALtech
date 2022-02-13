using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.REPOSITORIO;
using CoolSoft.Modelo.SERVICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
