﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.DATOS.ENTIDADES
{
    public class Orden
    {
        private object idClient;

        public int IdOrden { get; set; }
        public DateTime FechaRecepcion { get; set; } 
        public string TareaDesarrollar { get; set; }
        public string TareaDesarrollada { get; set; }
        public float Precio { get; set; }
        public int IdCliente { get; set; }
        public bool Completada { get; set; }

        public Orden() { }

        public Orden(int idOrden, object idClient)
        {
            IdOrden = idOrden;
            this.idClient = idClient;
        }
    }
}
