
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
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.panelBorde.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorde
            // 
            this.panelBorde.Size = new System.Drawing.Size(590, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(367, 656);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(209, 656);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBuscar.Image = global::CoolSoft.Properties.Resources.search;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(258, 379);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(152, 37);
            this.buttonBuscar.TabIndex = 73;
            this.buttonBuscar.Text = "Modificar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // dtFechaRecepcion
            // 
            this.dtFechaRecepcion.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaRecepcion.Location = new System.Drawing.Point(17, 103);
            this.dtFechaRecepcion.Name = "dtFechaRecepcion";
            this.dtFechaRecepcion.Size = new System.Drawing.Size(205, 29);
            this.dtFechaRecepcion.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 71;
            this.label3.Text = "N° de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 22);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tarea a desarrollar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 69;
            this.label1.Text = "Fecha de recepción";
            // 
            // mtIdCliente
            // 
            this.mtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtIdCliente.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtIdCliente.Location = new System.Drawing.Point(13, 379);
            this.mtIdCliente.Mask = "99999999999";
            this.mtIdCliente.Name = "mtIdCliente";
            this.mtIdCliente.PromptChar = ' ';
            this.mtIdCliente.ReadOnly = true;
            this.mtIdCliente.Size = new System.Drawing.Size(162, 29);
            this.mtIdCliente.TabIndex = 67;
            // 
            // tbTareaDesarrollar
            // 
            this.tbTareaDesarrollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTareaDesarrollar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTareaDesarrollar.Location = new System.Drawing.Point(13, 193);
            this.tbTareaDesarrollar.Multiline = true;
            this.tbTareaDesarrollar.Name = "tbTareaDesarrollar";
            this.tbTareaDesarrollar.Size = new System.Drawing.Size(397, 113);
            this.tbTareaDesarrollar.TabIndex = 68;
            // 
            // checkBoxCompletada
            // 
            this.checkBoxCompletada.AutoSize = true;
            this.checkBoxCompletada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCompletada.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCompletada.Location = new System.Drawing.Point(12, 477);
            this.checkBoxCompletada.Name = "checkBoxCompletada";
            this.checkBoxCompletada.Size = new System.Drawing.Size(186, 26);
            this.checkBoxCompletada.TabIndex = 74;
            this.checkBoxCompletada.Text = "Orden completada";
            this.checkBoxCompletada.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(12, 349);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.ReadOnly = true;
            this.textBoxNombreCliente.Size = new System.Drawing.Size(398, 20);
            this.textBoxNombreCliente.TabIndex = 75;
            this.textBoxNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 77;
            this.label4.Text = "Importe";
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImporte.Location = new System.Drawing.Point(178, 536);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(154, 28);
            this.textBoxImporte.TabIndex = 78;
            this.textBoxImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxImporte_KeyPress);
            // 
            // UiModificarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 736);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNombreCliente);
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
            this.Controls.SetChildIndex(this.panelBorde, 0);
            this.Controls.SetChildIndex(this.buttonCargar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.tbTareaDesarrollar, 0);
            this.Controls.SetChildIndex(this.mtIdCliente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dtFechaRecepcion, 0);
            this.Controls.SetChildIndex(this.buttonBuscar, 0);
            this.Controls.SetChildIndex(this.checkBoxCompletada, 0);
            this.Controls.SetChildIndex(this.textBoxNombreCliente, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBoxImporte, 0);
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
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxImporte;
    }
}