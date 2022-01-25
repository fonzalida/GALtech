using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.DATOS.ENTIDADES
{
    public class Titular
    {
        public int dni { get; set; }
        public int IdCliente { get; set; }


        public Titular() { }
        public Titular(int dni, int id) 
        {
            this.dni = dni;
            IdCliente = id;
        }
    }
}
