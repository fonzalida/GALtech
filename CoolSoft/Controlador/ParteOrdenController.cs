﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.SERVICIO;

namespace CoolSoft.Controlador
{
    static class ParteOrdenController
    {
        public static void Cargar(
            
            //string IdParte,
            string FechaInicio,
            string TareaDesarrollada
            )
        {
            ParteOrden parte = new ParteOrden();

            //parte.idParte = int.Parse(IdParte);
            parte.fechaInicio = DateTime.Parse(FechaInicio);
            parte.tareaDesarrollada = CG.EsNullOString(TareaDesarrollada);
            OrdenService.Agregar(parte);
        }


        public static void EliminarParteOrden(
            DataGridViewCellCollection dr
            )
        {
            ParteOrden parte = new ParteOrden();

            parte.idParte = int.Parse(dr["IdParte"].Value.ToString());

            OrdenService.Eliminar(parte);

        }


        public static ParteOrden DataGridViewToParteOrden(DataGridViewCellCollection dr)
        {
           

            ParteOrden parte = new ParteOrden();

            parte.idParte = int.Parse(dr["IdParte"].Value.ToString());
            parte.fechaInicio = DateTime.Parse(dr["FechaInicio"].Value.ToString());
            parte.fechaFin = DateTime.Parse(dr["fechaFin"].Value.ToString());
            parte.tareaDesarrollada = dr["TareaDesarrollada"].Value.ToString();
            


            if (dr["Completa"].Value.ToString() == "True")
            {
                parte.completa = 1;
            }
            else
            {
                parte.completa = 0;
            }


            return parte;


        }

        internal static void Modificar(
            
            string FechaInicio,
            string TareaDesarrollada,
            bool completada,
            ParteOrden vieja)
        {
            ParteOrden parte = new ParteOrden();
            parte.fechaInicio = DateTime.Parse(FechaInicio);
            parte.tareaDesarrollada = CG.EsNullOString(TareaDesarrollada);
            parte.completa = int.Parse(completada.ToString());
            
          

            if (completada)
                parte.completa = 1;
            else
                parte.completa = 0;

            OrdenService.modificar(vieja, parte);
        }
    }
}
