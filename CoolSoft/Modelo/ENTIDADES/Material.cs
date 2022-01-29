using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.DATOS.ENTIDADES
{
    public class Material
    {
        public int idMat { get; set; }
        public int idOrden { get; set; }
        public string cantidad { get; set; }
        public string descripcion { get; set; }

        public Material() { }
    }
}
