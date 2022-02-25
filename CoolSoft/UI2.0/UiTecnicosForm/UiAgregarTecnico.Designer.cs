
namespace CoolSoft.UI2._0.UiTecnicosForm
{
    partial class UiAgregarTecnico
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.panelBorde.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorde
            // 
            this.panelBorde.Size = new System.Drawing.Size(411, 50);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Size = new System.Drawing.Size(167, 19);
            this.labelTitulo.Text = "AGREGAR TECNICO";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(247, 283);
            // 
            // buttonCargar
            // 
            this.buttonCargar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCargar.Location = new System.Drawing.Point(89, 283);
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 63;
            this.label6.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 61;
            this.label1.Text = "DNI";
            // 
            // tbNombre
            // 
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(34, 155);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(345, 26);
            this.tbNombre.TabIndex = 59;
            this.tbNombre.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxDni
            // 
            this.textBoxDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDni.Location = new System.Drawing.Point(34, 90);
            this.textBoxDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDni.MaxLength = 8;
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(200, 26);
            this.textBoxDni.TabIndex = 64;
            this.textBoxDni.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumerico_KeyPress);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.Location = new System.Drawing.Point(34, 221);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(200, 26);
            this.textBoxTelefono.TabIndex = 65;
            this.textBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumerico_KeyPress);
            // 
            // UiAgregarTecnico
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(411, 349);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UiAgregarTecnico";
            this.Text = "UiAgregarTecnico";
            this.Load += new System.EventHandler(this.UiAgregarTecnico_Load);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.panelBorde, 0);
            this.Controls.SetChildIndex(this.buttonCargar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.textBoxDni, 0);
            this.Controls.SetChildIndex(this.textBoxTelefono, 0);
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox textBoxDni;
        public System.Windows.Forms.TextBox textBoxTelefono;
    }
}
