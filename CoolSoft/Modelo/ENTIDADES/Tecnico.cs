using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.DATOS.ENTIDADES
{
    public class Tecnico
    {
        public Tecnico(int dni)
        {
            this.dni = dni;
        }

        public int dni { get; set; }
    }
}
