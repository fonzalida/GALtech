using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.Controlador
{
    static class CG
    {


        public static String EsNullOString(string s)
        {
            if (s == "")
                return null;

            else
                return s;
        }
    }
}
