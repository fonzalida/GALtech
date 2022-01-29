using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.DATOS.ENTIDADES
{
    public class Tecnico
    {
        public int dni { get; set; }

        public string nombre { get; set; }

        public string telefono { get; set; }

        public Tecnico() { }
        public Tecnico(int dni)
        {
            this.dni = dni;
        }

       
    }
}
