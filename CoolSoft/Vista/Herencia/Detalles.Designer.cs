
namespace CoolSoft.Vista.Herencia
{
    partial class Detalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalles));
            this.bCancelar = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.Olive;
            this.pTitulo.Size = new System.Drawing.Size(744, 62);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.button1);
            this.pMenu.Controls.Add(this.bCancelar);
            this.pMenu.Controls.Add(this.bCerrar);
            this.pMenu.Controls.Add(this.bAgregar);
            this.pMenu.Size = new System.Drawing.Size(744, 98);
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bCancelar.Image = global::CoolSoft.Properties.Resources.delete;
            this.bCancelar.Location = new System.Drawing.Point(492, 7);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(119, 79);
            this.bCancelar.TabIndex = 5;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bCerrar
            // 
            this.bCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bCerrar.Image = global::CoolSoft.Properties.Resources.clear;
            this.bCerrar.Location = new System.Drawing.Point(619, 7);
            this.bCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(119, 79);
            this.bCerrar.TabIndex = 4;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bCerrar.UseVisualStyleBackColor = true;
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bAgregar.Image = global::CoolSoft.Properties.Resources.add;
            this.bAgregar.Location = new System.Drawing.Point(238, 7);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(119, 79);
            this.bAgregar.TabIndex = 3;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = global::CoolSoft.Properties.Resources.add;
            this.button1.Location = new System.Drawing.Point(365, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 79);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 514);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Detalles";
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.Detalles_Load);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button bCancelar;
        public System.Windows.Forms.Button bCerrar;
        public System.Windows.Forms.Button bAgregar;
        public System.Windows.Forms.Button button1;
    }
}