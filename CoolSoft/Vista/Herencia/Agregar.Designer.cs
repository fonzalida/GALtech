
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
            this.bLimpiar = new System.Windows.Forms.Button();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.Green;
            this.pTitulo.Margin = new System.Windows.Forms.Padding(5);
            this.pTitulo.Size = new System.Drawing.Size(619, 62);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.bLimpiar);
            this.pMenu.Controls.Add(this.bCancelar);
            this.pMenu.Controls.Add(this.bAgregar);
            this.pMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pMenu.Size = new System.Drawing.Size(619, 98);
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bAgregar.Image = global::CoolSoft.Properties.Resources.add;
            this.bAgregar.Location = new System.Drawing.Point(239, 4);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(119, 79);
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
            this.bCancelar.Location = new System.Drawing.Point(493, 4);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(119, 79);
            this.bCancelar.TabIndex = 1;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bLimpiar.Image = global::CoolSoft.Properties.Resources.delete;
            this.bLimpiar.Location = new System.Drawing.Point(366, 4);
            this.bLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(119, 79);
            this.bLimpiar.TabIndex = 2;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 475);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
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
        public System.Windows.Forms.Button bLimpiar;
    }
}