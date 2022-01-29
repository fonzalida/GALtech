using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.DATOS.ENTIDADES
{
    public class Orden
    {
        private object idClient;

        public int idOrden { get; set; }
        public DateTime fechaRecepcion { get; set; } 
        public string tareaDesarrollar { get; set; }
        public string tareaDesarrollada { get; set; }
        public float precio { get; set; }
        public int dniCuit { get; set; }
        public int completada { get; set; }

        public Orden() { }

    }
}
