﻿using CoolSoft.Controlador;
using CoolSoft.UI2._0.Genericos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoolSoft.UI2._0.UiTecnicosForm
{
    public partial class UiAgregarTecnico : UiAgregar
    {
        public UiAgregarTecnico()
        {
            InitializeComponent();
        }

        private void UiAgregarTecnico_Load(object sender, EventArgs e)
        {

        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            TecnicoController.Cargar(
                textBoxDniCuit.Text,
                tbNombre.Text,
                textBoxTelefono.Text
                );
        }

        private void UiAgregarTecnico_Load_1(object sender, EventArgs e)
        {

        }

        private void textBoxNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
