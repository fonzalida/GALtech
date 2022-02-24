
namespace CoolSoft.UI2._0.UiOrdenesForm
{
    partial class UiAgregarOrden
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtFechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.tbTareaDesarrollar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.panelBorde.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorde
            // 
            this.panelBorde.Size = new System.Drawing.Size(430, 50);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Size = new System.Drawing.Size(186, 24);
            this.labelTitulo.Text = "AGREGAR ORDEN";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(266, 457);
            // 
            // buttonCargar
            // 
            this.buttonCargar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCargar.Location = new System.Drawing.Point(108, 457);
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // dtFechaRecepcion
            // 
            this.dtFechaRecepcion.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaRecepcion.Location = new System.Drawing.Point(20, 100);
            this.dtFechaRecepcion.Name = "dtFechaRecepcion";
            this.dtFechaRecepcion.Size = new System.Drawing.Size(205, 34);
            this.dtFechaRecepcion.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tarea a desarrollar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha de recepción";
            // 
            // mtIdCliente
            // 
            this.mtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtIdCliente.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtIdCliente.Location = new System.Drawing.Point(199, 355);
            this.mtIdCliente.Mask = "99999999999";
            this.mtIdCliente.Name = "mtIdCliente";
            this.mtIdCliente.PromptChar = ' ';
            this.mtIdCliente.ReadOnly = true;
            this.mtIdCliente.Size = new System.Drawing.Size(219, 27);
            this.mtIdCliente.TabIndex = 25;
            this.mtIdCliente.TextChanged += new System.EventHandler(this.mtIdCliente_TextChanged);
            // 
            // tbTareaDesarrollar
            // 
            this.tbTareaDesarrollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTareaDesarrollar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTareaDesarrollar.Location = new System.Drawing.Point(16, 190);
            this.tbTareaDesarrollar.Multiline = true;
            this.tbTareaDesarrollar.Name = "tbTareaDesarrollar";
            this.tbTareaDesarrollar.Size = new System.Drawing.Size(397, 113);
            this.tbTareaDesarrollar.TabIndex = 26;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBuscar.Image = global::CoolSoft.Properties.Resources.search;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(17, 352);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(152, 37);
            this.buttonBuscar.TabIndex = 66;
            this.buttonBuscar.Text = "Seleccionar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
            this.textBoxNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCliente.Location = new System.Drawing.Point(199, 321);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.ReadOnly = true;
            this.textBoxNombreCliente.Size = new System.Drawing.Size(219, 23);
            this.textBoxNombreCliente.TabIndex = 76;
            this.textBoxNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UiAgregarOrden
            // 
            this.ClientSize = new System.Drawing.Size(430, 523);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dtFechaRecepcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtIdCliente);
            this.Controls.Add(this.tbTareaDesarrollar);
            this.Name = "UiAgregarOrden";
            this.Load += new System.EventHandler(this.UiAgregarOrden_Load);
            this.Controls.SetChildIndex(this.tbTareaDesarrollar, 0);
            this.Controls.SetChildIndex(this.mtIdCliente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dtFechaRecepcion, 0);
            this.Controls.SetChildIndex(this.panelBorde, 0);
            this.Controls.SetChildIndex(this.buttonCargar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.buttonBuscar, 0);
            this.Controls.SetChildIndex(this.textBoxNombreCliente, 0);
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtFechaRecepcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtIdCliente;
        private System.Windows.Forms.TextBox tbTareaDesarrollar;
        public System.Windows.Forms.Button buttonBuscar;
        public System.Windows.Forms.TextBox textBoxNombreCliente;
    }
}
