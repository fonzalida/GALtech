﻿using connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.VISTA
{
    public partial class FormularioPadre : Form
    {
        public FormularioPadre()
        {
            InitializeComponent();
        }

        private void FormularioPadre_Load(object sender, EventArgs e)
        {
            Form1 newFrm = new Form1();
            
            newFrm.MdiParent = this;
            newFrm.Show();
        }
    }
}
