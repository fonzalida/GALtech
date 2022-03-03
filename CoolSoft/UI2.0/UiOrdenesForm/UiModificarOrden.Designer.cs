
namespace CoolSoft.UI2._0.UiOrdenesForm
{
    partial class UiModificarOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dtFechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.tbTareaDesarrollar = new System.Windows.Forms.TextBox();
            this.checkBoxCompletada = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.panelBorde.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorde
            // 
            this.panelBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(55)))));
            this.panelBorde.Size = new System.Drawing.Size(427, 50);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Size = new System.Drawing.Size(197, 24);
            this.labelTitulo.Text = "MODIFICAR ORDEN";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(55)))));
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(263, 546);
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(-23, 576);
            this.buttonCargar.Size = new System.Drawing.Size(128, 50);
            this.buttonCargar.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBuscar.Image = global::CoolSoft.Properties.Resources.search;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(17, 343);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(152, 37);
            this.buttonBuscar.TabIndex = 73;
            this.buttonBuscar.Text = "Modificar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dtFechaRecepcion
            // 
            this.dtFechaRecepcion.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaRecepcion.Location = new System.Drawing.Point(243, 69);
            this.dtFechaRecepcion.Name = "dtFechaRecepcion";
            this.dtFechaRecepcion.Size = new System.Drawing.Size(175, 34);
            this.dtFechaRecepcion.TabIndex = 72;
            this.dtFechaRecepcion.ValueChanged += new System.EventHandler(this.dtFechaRecepcion_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 71;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 27);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tarea a desarrollar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 27);
            this.label1.TabIndex = 69;
            this.label1.Text = "Fecha de recepción";
            // 
            // mtIdCliente
            // 
            this.mtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtIdCliente.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtIdCliente.Location = new System.Drawing.Point(195, 346);
            this.mtIdCliente.Mask = "99999999999";
            this.mtIdCliente.Name = "mtIdCliente";
            this.mtIdCliente.PromptChar = ' ';
            this.mtIdCliente.ReadOnly = true;
            this.mtIdCliente.Size = new System.Drawing.Size(219, 34);
            this.mtIdCliente.TabIndex = 67;
            this.mtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtIdCliente.TextChanged += new System.EventHandler(this.mtIdCliente_TextChanged);
            // 
            // tbTareaDesarrollar
            // 
            this.tbTareaDesarrollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTareaDesarrollar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTareaDesarrollar.Location = new System.Drawing.Point(17, 159);
            this.tbTareaDesarrollar.Multiline = true;
            this.tbTareaDesarrollar.Name = "tbTareaDesarrollar";
            this.tbTareaDesarrollar.Size = new System.Drawing.Size(397, 113);
            this.tbTareaDesarrollar.TabIndex = 68;
            this.tbTareaDesarrollar.TextChanged += new System.EventHandler(this.textBoxImporte_TextChanged);
            // 
            // checkBoxCompletada
            // 
            this.checkBoxCompletada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCompletada.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCompletada.Location = new System.Drawing.Point(11, 404);
            this.checkBoxCompletada.Name = "checkBoxCompletada";
            this.checkBoxCompletada.Size = new System.Drawing.Size(403, 31);
            this.checkBoxCompletada.TabIndex = 74;
            this.checkBoxCompletada.Text = "Orden completada";
            this.checkBoxCompletada.UseVisualStyleBackColor = true;
            this.checkBoxCompletada.CheckedChanged += new System.EventHandler(this.checkBoxCompletada_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 27);
            this.label4.TabIndex = 77;
            this.label4.Text = "Importe";
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImporte.Location = new System.Drawing.Point(260, 467);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(154, 34);
            this.textBoxImporte.TabIndex = 78;
            this.textBoxImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxImporte.TextChanged += new System.EventHandler(this.textBoxImporte_TextChanged);
            this.textBoxImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxImporte_KeyPress);
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(205)))));
            this.textBoxNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCliente.Location = new System.Drawing.Point(195, 309);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.ReadOnly = true;
            this.textBoxNombreCliente.Size = new System.Drawing.Size(219, 23);
            this.textBoxNombreCliente.TabIndex = 79;
            this.textBoxNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(55)))));
            this.buttonModificar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonModificar.Image = global::CoolSoft.Properties.Resources.edit;
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificar.Location = new System.Drawing.Point(105, 546);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(152, 54);
            this.buttonModificar.TabIndex = 80;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // UiModificarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(427, 612);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxCompletada);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dtFechaRecepcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtIdCliente);
            this.Controls.Add(this.tbTareaDesarrollar);
            this.Name = "UiModificarOrden";
            this.Text = "UiModificarOrden";
            this.Load += new System.EventHandler(this.UiModificarOrden_Load);
            this.Controls.SetChildIndex(this.tbTareaDesarrollar, 0);
            this.Controls.SetChildIndex(this.mtIdCliente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dtFechaRecepcion, 0);
            this.Controls.SetChildIndex(this.buttonBuscar, 0);
            this.Controls.SetChildIndex(this.checkBoxCompletada, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBoxImporte, 0);
            this.Controls.SetChildIndex(this.panelBorde, 0);
            this.Controls.SetChildIndex(this.buttonCargar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.textBoxNombreCliente, 0);
            this.Controls.SetChildIndex(this.buttonModificar, 0);
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DateTimePicker dtFechaRecepcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtIdCliente;
        private System.Windows.Forms.TextBox tbTareaDesarrollar;
        private System.Windows.Forms.CheckBox checkBoxCompletada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxImporte;
        public System.Windows.Forms.TextBox textBoxNombreCliente;
        public System.Windows.Forms.Button buttonModificar;
    }
}