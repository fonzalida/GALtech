
namespace CoolSoft.Vista.Orden
{
    partial class OrdenesAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenesAgregar));
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAgregar.Location = new System.Drawing.Point(466, 4);
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.Location = new System.Drawing.Point(720, 4);
            // 
            // Limpiar
            // 
            this.Limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Limpiar.Location = new System.Drawing.Point(593, 4);
            // 
            // pTitulo
            // 
            this.pTitulo.Size = new System.Drawing.Size(882, 62);
            // 
            // pMenu
            // 
            this.pMenu.Size = new System.Drawing.Size(882, 98);
            // 
            // OrdenesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 678);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrdenesAgregar";
            this.Text = "OrdenesAgregar";
            this.Load += new System.EventHandler(this.OrdenesAgregar_Load);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}