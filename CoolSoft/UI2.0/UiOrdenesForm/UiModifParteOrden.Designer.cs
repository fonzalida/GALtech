
namespace CoolSoft.UI2._0.UiOrdenesForm
{
    partial class UiModifParteOrden
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
            this.textBoxNombreTecnico = new System.Windows.Forms.TextBox();
            this.checkBoxCompletada = new System.Windows.Forms.CheckBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtDni = new System.Windows.Forms.MaskedTextBox();
            this.tbTareaDesarrollada = new System.Windows.Forms.TextBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelBorde.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorde
            // 
            this.panelBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(55)))));
            this.panelBorde.Size = new System.Drawing.Size(538, 50);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Size = new System.Drawing.Size(220, 19);
            this.labelTitulo.Text = "MODIFICAR PARTE ÓRDEN";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(230, 654);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(72, 654);
            // 
            // textBoxNombreTecnico
            // 
            this.textBoxNombreTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(205)))));
            this.textBoxNombreTecnico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreTecnico.Location = new System.Drawing.Point(250, 298);
            this.textBoxNombreTecnico.Name = "textBoxNombreTecnico";
            this.textBoxNombreTecnico.ReadOnly = true;
            this.textBoxNombreTecnico.Size = new System.Drawing.Size(219, 19);
            this.textBoxNombreTecnico.TabIndex = 90;
            this.textBoxNombreTecnico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxCompletada
            // 
            this.checkBoxCompletada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCompletada.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCompletada.Location = new System.Drawing.Point(51, 424);
            this.checkBoxCompletada.Name = "checkBoxCompletada";
            this.checkBoxCompletada.Size = new System.Drawing.Size(403, 31);
            this.checkBoxCompletada.TabIndex = 87;
            this.checkBoxCompletada.Text = "Parte Órden completada";
            this.checkBoxCompletada.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBuscar.Image = global::CoolSoft.Properties.Resources.search;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(51, 347);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(152, 37);
            this.buttonBuscar.TabIndex = 86;
            this.buttonBuscar.Text = "Modificar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(273, 71);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(175, 29);
            this.dtFechaInicio.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 84;
            this.label3.Text = "Técnico/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 22);
            this.label2.TabIndex = 83;
            this.label2.Text = "Tarea desarrollada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 82;
            this.label1.Text = "Fecha Inicio";
            // 
            // mtDni
            // 
            this.mtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtDni.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtDni.Location = new System.Drawing.Point(250, 347);
            this.mtDni.Mask = "99999999999";
            this.mtDni.Name = "mtDni";
            this.mtDni.PromptChar = ' ';
            this.mtDni.ReadOnly = true;
            this.mtDni.Size = new System.Drawing.Size(219, 29);
            this.mtDni.TabIndex = 80;
            this.mtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTareaDesarrollada
            // 
            this.tbTareaDesarrollada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTareaDesarrollada.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTareaDesarrollada.Location = new System.Drawing.Point(51, 149);
            this.tbTareaDesarrollada.Multiline = true;
            this.tbTareaDesarrollada.Name = "tbTareaDesarrollada";
            this.tbTareaDesarrollada.Size = new System.Drawing.Size(397, 113);
            this.tbTareaDesarrollada.TabIndex = 81;
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
            this.buttonModificar.Location = new System.Drawing.Point(58, 485);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(152, 54);
            this.buttonModificar.TabIndex = 91;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Olive;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::CoolSoft.Properties.Resources.cancel;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(273, 485);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 54);
            this.button2.TabIndex = 92;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UiModifParteOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(538, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.textBoxNombreTecnico);
            this.Controls.Add(this.checkBoxCompletada);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtDni);
            this.Controls.Add(this.tbTareaDesarrollada);
            this.Name = "UiModifParteOrden";
            this.Text = "UiModifParteOrden";
            this.Load += new System.EventHandler(this.UiModifParteOrden_Load);
            this.Controls.SetChildIndex(this.panelBorde, 0);
            this.Controls.SetChildIndex(this.buttonCargar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.tbTareaDesarrollada, 0);
            this.Controls.SetChildIndex(this.mtDni, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dtFechaInicio, 0);
            this.Controls.SetChildIndex(this.buttonBuscar, 0);
            this.Controls.SetChildIndex(this.checkBoxCompletada, 0);
            this.Controls.SetChildIndex(this.textBoxNombreTecnico, 0);
            this.Controls.SetChildIndex(this.buttonModificar, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxNombreTecnico;
        private System.Windows.Forms.CheckBox checkBoxCompletada;
        public System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtDni;
        private System.Windows.Forms.TextBox tbTareaDesarrollada;
        public System.Windows.Forms.Button buttonModificar;
        public System.Windows.Forms.Button button2;
    }
}