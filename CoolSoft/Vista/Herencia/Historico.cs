﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoolSoft.Vista.Herencia
{
    public partial class Historico : Base
    {
        public Historico()
        {
            InitializeComponent();
        }

        private void dateTimeFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {

        }

        private void bVer_Click(object sender, EventArgs e)
        {

        }

        private void Historico_Load(object sender, EventArgs e)
        {
            //this.Text = pMenu.Size.ToString();
            this.Size = new Size(941, 627);
            dateTimeInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimeFinal.Value = DateTime.Now;
           pMenu.Size = new Size(pMenu.Size.Width,107);
        }

        private void checkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {

            dateTimeInicial.Enabled = !checkBoxTodos.Checked;
            dateTimeFinal.Enabled = !checkBoxTodos.Checked;

        }
    }
}