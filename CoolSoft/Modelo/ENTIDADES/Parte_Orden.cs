using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.DATOS.ENTIDADES
{
    public class Parte_Orden
    {
        public int IdP { get; set; }
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int Completa { get; set; }

        public Parte_Orden() { }

        public Parte_Orden(int id)
        {
            Id = id;
        }
    }
}
