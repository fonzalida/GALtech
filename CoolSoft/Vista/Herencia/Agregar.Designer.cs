
namespace CoolSoft.Vista.Herencia
{
    partial class Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            this.bAgregar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.Size = new System.Drawing.Size(464, 50);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.bCancelar);
            this.pMenu.Controls.Add(this.bAgregar);
            this.pMenu.Size = new System.Drawing.Size(464, 80);
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bAgregar.Image = global::CoolSoft.Properties.Resources.add;
            this.bAgregar.Location = new System.Drawing.Point(275, 3);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(89, 64);
            this.bAgregar.TabIndex = 0;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bCancelar.Image = global::CoolSoft.Properties.Resources.clear;
            this.bCancelar.Location = new System.Drawing.Point(370, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(89, 64);
            this.bCancelar.TabIndex = 1;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 386);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button bAgregar;
        public System.Windows.Forms.Button bCancelar;
    }
}