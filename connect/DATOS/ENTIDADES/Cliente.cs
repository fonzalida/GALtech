using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.DATOS.ENTIDADES
{
    public class Cliente
    {
       public int IdCliente { get; set; }
       public string nombre { get; set; }
       public string Domicilio { get; set; }
       public int Telefono { get; set; }


        public Cliente() { }
    }
}
