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
        public long dniCuil { get; set; }
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public string localidad { get; set; }
        public string provincia { get; set; }
        public long telefono1 { get; set; }
        public long telefono2 { get; set; }


        public Cliente() { }
    }
}

