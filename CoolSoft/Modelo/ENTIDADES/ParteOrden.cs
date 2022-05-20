using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.Modelo.ENTIDADES
{
    public class ParteOrden
    {
        public long idParte { get; set; }
        public int idOrden { get; set; }
        public int completa { get; set; }

        public ParteOrden() { }

        public ParteOrden(int idO)
        {
            idOrden = idO;
        }
    }
}
