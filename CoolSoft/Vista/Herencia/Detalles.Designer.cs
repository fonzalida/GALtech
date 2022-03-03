
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
            this.bModificar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.pModificar = new System.Windows.Forms.Panel();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.pModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.Olive;
            this.pTitulo.Size = new System.Drawing.Size(744, 62);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.pModificar);
            this.pMenu.Controls.Add(this.bEditar);
            this.pMenu.Controls.Add(this.bCerrar);
            this.pMenu.Size = new System.Drawing.Size(744, 98);
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bCancelar.Image = global::CoolSoft.Properties.Resources.delete;
            this.bCancelar.Location = new System.Drawing.Point(130, 3);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(119, 79);
            this.bCancelar.TabIndex = 5;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
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
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bModificar.Image = global::CoolSoft.Properties.Resources.ok;
            this.bModificar.Location = new System.Drawing.Point(3, 3);
            this.bModificar.Margin = new System.Windows.Forms.Padding(4);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(119, 79);
            this.bModificar.TabIndex = 3;
            this.bModificar.Text = "Modificar";
            this.bModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bEditar
            // 
            this.bEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bEditar.Image = global::CoolSoft.Properties.Resources.edit;
            this.bEditar.Location = new System.Drawing.Point(492, 7);
            this.bEditar.Margin = new System.Windows.Forms.Padding(4);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(119, 79);
            this.bEditar.TabIndex = 6;
            this.bEditar.Text = "Editar";
            this.bEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // pModificar
            // 
            this.pModificar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pModificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pModificar.Controls.Add(this.bModificar);
            this.pModificar.Controls.Add(this.bCancelar);
            this.pModificar.Location = new System.Drawing.Point(11, 3);
            this.pModificar.Name = "pModificar";
            this.pModificar.Size = new System.Drawing.Size(255, 90);
            this.pModificar.TabIndex = 7;
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
            this.pModificar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button bCancelar;
        public System.Windows.Forms.Button bCerrar;
        public System.Windows.Forms.Button bModificar;
        public System.Windows.Forms.Button bEditar;
        public System.Windows.Forms.Panel pModificar;
    }
}