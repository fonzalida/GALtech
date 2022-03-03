using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.Modelo.ENTIDADES
{
    public class Tecnico
    {
        private string dni1;

        public int dni { get; set; }

        public string nombre { get; set; }

        public string telefono { get; set; }

        public int activo { get; set; }

        public Tecnico() { }
        public Tecnico(int dni)
        {
            this.dni = dni;
        }

        public Tecnico(string dni1, string nombre, string telefono)
        {
            this.dni1 = dni1;
            this.nombre = nombre;
            this.telefono = telefono;
        }
    }
}
