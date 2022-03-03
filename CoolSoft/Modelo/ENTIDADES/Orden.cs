using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.Modelo.ENTIDADES
{
    public class Orden
    {
        
        public int idOrden { get; set; }
        public DateTime fechaRecepcion { get; set; } 
        public string tareaDesarrollar { get; set; }
        //public string tareaDesarrollada { get; set; }
        public float precio { get; set; }
        public int idCliente { get; set; }
        public int completada { get; set; }

        public Orden() { }

    }
}
