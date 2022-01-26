using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.DATOS.ENTIDADES
{
    public class ParteOrden
    {
        public int IdParte { get; set; }
        public int IdOrden { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int Completa { get; set; }

        public ParteOrden() { }

        public ParteOrden(int idP, int idO)
        {
            IdParte = idP;
            IdOrden = idO;
        }
    }
}
