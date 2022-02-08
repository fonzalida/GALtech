
namespace CoolSoft.Vista.Cliente
{
    partial class ClienteAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteAgregar));
            this.mtDniCuit = new System.Windows.Forms.MaskedTextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDomicilio = new System.Windows.Forms.TextBox();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.mtTelefono1 = new System.Windows.Forms.MaskedTextBox();
            this.mtTelefono2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(357, 4);
            // 
            // bCancelar
            // 
            this.bCerrar.Location = new System.Drawing.Point(611, 4);
            this.bCerrar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bLimpiar
            // 
            this.bCancelar.Location = new System.Drawing.Point(484, 4);
            // 
            // lTitulo
            // 
            this.lTitulo.Size = new System.Drawing.Size(269, 39);
            this.lTitulo.Text = "Agregar Cliente";
            // 
            // mtDniCuit
            // 
            this.mtDniCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtDniCuit.Location = new System.Drawing.Point(156, 184);
            this.mtDniCuit.Margin = new System.Windows.Forms.Padding(4);
            this.mtDniCuit.Mask = "99999999999";
            this.mtDniCuit.Name = "mtDniCuit";
            this.mtDniCuit.PromptChar = ' ';
            this.mtDniCuit.Size = new System.Drawing.Size(132, 34);
            this.mtDniCuit.TabIndex = 17;
            this.mtDniCuit.ValidatingType = typeof(int);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(156, 225);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(345, 34);
            this.tbNombre.TabIndex = 18;
            // 
            // tbDomicilio
            // 
            this.tbDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDomicilio.Location = new System.Drawing.Point(156, 265);
            this.tbDomicilio.Name = "tbDomicilio";
            this.tbDomicilio.Size = new System.Drawing.Size(345, 34);
            this.tbDomicilio.TabIndex = 19;
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocalidad.Location = new System.Drawing.Point(156, 305);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(200, 34);
            this.tbLocalidad.TabIndex = 20;
            // 
            // tbProvincia
            // 
            this.tbProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProvincia.Location = new System.Drawing.Point(156, 345);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(200, 34);
            this.tbProvincia.TabIndex = 21;
            // 
            // mtTelefono1
            // 
            this.mtTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtTelefono1.Location = new System.Drawing.Point(156, 385);
            this.mtTelefono1.Name = "mtTelefono1";
            this.mtTelefono1.Size = new System.Drawing.Size(200, 34);
            this.mtTelefono1.TabIndex = 22;
            // 
            // mtTelefono2
            // 
            this.mtTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtTelefono2.Location = new System.Drawing.Point(156, 425);
            this.mtTelefono2.Name = "mtTelefono2";
            this.mtTelefono2.Size = new System.Drawing.Size(200, 34);
            this.mtTelefono2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "DNI/CUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Domicilio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Localidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Provincia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Telefono 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Telefono 2";
            // 
            // ClienteAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(744, 514);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtTelefono2);
            this.Controls.Add(this.mtTelefono1);
            this.Controls.Add(this.tbProvincia);
            this.Controls.Add(this.tbLocalidad);
            this.Controls.Add(this.tbDomicilio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.mtDniCuit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ClienteAgregar";
            this.Text = "ClienteAgregar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClienteAgregar_FormClosed);
            this.Load += new System.EventHandler(this.ClienteAgregar_Load);
            this.Controls.SetChildIndex(this.mtDniCuit, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.tbDomicilio, 0);
            this.Controls.SetChildIndex(this.tbLocalidad, 0);
            this.Controls.SetChildIndex(this.tbProvincia, 0);
            this.Controls.SetChildIndex(this.mtTelefono1, 0);
            this.Controls.SetChildIndex(this.mtTelefono2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.pTitulo, 0);
            this.Controls.SetChildIndex(this.pMenu, 0);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtDniCuit;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDomicilio;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.MaskedTextBox mtTelefono1;
        private System.Windows.Forms.MaskedTextBox mtTelefono2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}