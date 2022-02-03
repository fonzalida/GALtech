using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.DATOS.ENTIDADES
{
    public class ParteOrden
    {
        public int idParte { get; set; }
        public int idOrden { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public int completa { get; set; }

        public ParteOrden() { }

        public ParteOrden(int idP, int idO)
        {
            idParte = idP;
            idOrden = idO;
        }
    }
}
