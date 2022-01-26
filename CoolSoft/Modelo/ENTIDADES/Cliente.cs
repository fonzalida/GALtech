using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.DATOS.ENTIDADES
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public int telefono { get; set; }


        public Cliente() { }
    }
}

