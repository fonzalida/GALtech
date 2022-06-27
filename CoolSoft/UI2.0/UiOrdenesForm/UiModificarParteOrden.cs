using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.UI2._0.Genericos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.UI2._0.UiOrdenesForm
{
    public partial class UiModificarParteOrden : UiAgregarOrden
    {
        Orden vieja;
        public UiModificarParteOrden(Orden v)
        {
            vieja = v;
            InitializeComponent();
        }
    }
}
