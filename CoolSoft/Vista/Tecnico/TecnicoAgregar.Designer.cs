
namespace CoolSoft.Vista.Tecnico
{
    partial class TecnicoAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TecnicoAgregar));
            this.mtDni = new System.Windows.Forms.MaskedTextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.mtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(245, 3);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(436, 3);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(340, 3);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(2);
            // 
            // pTitulo
            // 
            this.pTitulo.Margin = new System.Windows.Forms.Padding(3);
            this.pTitulo.Size = new System.Drawing.Size(558, 50);
            // 
            // pMenu
            // 
            this.pMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pMenu.Size = new System.Drawing.Size(558, 80);
            // 
            // mtDni
            // 
            this.mtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtDni.Location = new System.Drawing.Point(117, 150);
            this.mtDni.Mask = "99999999999";
            this.mtDni.Name = "mtDni";
            this.mtDni.PromptChar = ' ';
            this.mtDni.Size = new System.Drawing.Size(100, 28);
            this.mtDni.TabIndex = 17;
            this.mtDni.ValidatingType = typeof(int);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(117, 185);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(260, 28);
            this.tbNombre.TabIndex = 18;
            // 
            // mtTelefono
            // 
            this.mtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtTelefono.Location = new System.Drawing.Point(117, 226);
            this.mtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.mtTelefono.Name = "mtTelefono";
            this.mtTelefono.Size = new System.Drawing.Size(151, 28);
            this.mtTelefono.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Teléfono";
            // 
            // TecnicoAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(558, 418);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtTelefono);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.mtDni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TecnicoAgregar";
            this.Text = "TecnicoAgregar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TecnicoAgregar_FormClosed);
            this.Load += new System.EventHandler(this.TecnicoAgregar_Load);
            this.Controls.SetChildIndex(this.mtDni, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.mtTelefono, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.pTitulo, 0);
            this.Controls.SetChildIndex(this.pMenu, 0);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtDni;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.MaskedTextBox mtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}