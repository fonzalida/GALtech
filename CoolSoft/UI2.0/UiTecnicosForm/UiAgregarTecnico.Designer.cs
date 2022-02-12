
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
            this.mtTelefono1 = new System.Windows.Forms.MaskedTextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.mtDniCuit = new System.Windows.Forms.MaskedTextBox();
            this.panelBorde.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Size = new System.Drawing.Size(167, 19);
            this.labelTitulo.Text = "AGREGAR TECNICO";
            // 
            // buttonCargar
            // 
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 63;
            this.label6.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "DNI";
            // 
            // mtTelefono1
            // 
            this.mtTelefono1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtTelefono1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtTelefono1.Location = new System.Drawing.Point(32, 284);
            this.mtTelefono1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtTelefono1.Mask = "999999999999";
            this.mtTelefono1.Name = "mtTelefono1";
            this.mtTelefono1.PromptChar = ' ';
            this.mtTelefono1.Size = new System.Drawing.Size(150, 29);
            this.mtTelefono1.TabIndex = 60;
            // 
            // tbNombre
            // 
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(32, 196);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(259, 29);
            this.tbNombre.TabIndex = 59;
            // 
            // mtDniCuit
            // 
            this.mtDniCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtDniCuit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtDniCuit.Location = new System.Drawing.Point(32, 118);
            this.mtDniCuit.Mask = "99999999999";
            this.mtDniCuit.Name = "mtDniCuit";
            this.mtDniCuit.PromptChar = ' ';
            this.mtDniCuit.Size = new System.Drawing.Size(150, 29);
            this.mtDniCuit.TabIndex = 58;
            this.mtDniCuit.ValidatingType = typeof(int);
            // 
            // UiAgregarTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(492, 495);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtTelefono1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.mtDniCuit);
            this.Name = "UiAgregarTecnico";
            this.Text = "UiAgregarTecnico";
            this.Controls.SetChildIndex(this.panelBorde, 0);
            this.Controls.SetChildIndex(this.buttonCargar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.mtDniCuit, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.mtTelefono1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtTelefono1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.MaskedTextBox mtDniCuit;
    }
}
