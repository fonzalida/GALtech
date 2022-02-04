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

            Random random = new Random();
            int x = random.Next(-60, 60);
            int y = random.Next(-60, 60);

            this.Location = new Point(((this.MdiParent.ClientSize.Width / 2) - (this.Width / 2))+x,
                ((this.MdiParent.ClientSize.Height / 2) - (this.Height / 2))+y);

            mtbInicial.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Date.ToString("dd/MM/yyyy");
            mtbFinal.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");


           pMenu.Size = new Size(pMenu.Size.Width,107);


            ControlEnableSwap(false);


        }

        private void checkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {

            mtbInicial.Enabled = !checkBoxTodos.Checked;
            mtbFinal.Enabled = !checkBoxTodos.Checked;

        }

        private void bModificar_Click(object sender, EventArgs e)
        {

        }

        private void ControlEnableSwap(bool b)
        {

            pFecha.Enabled = !b;
            pBuscar.Enabled = b;
            pCostado.Enabled = b;

        }

        private void bVer_Click_1(object sender, EventArgs e)
        {
            ControlEnableSwap(true);
        }

        private void bCancelar_Click_1(object sender, EventArgs e)
        {
            ControlEnableSwap(false);
        }

        private void dateTime_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
