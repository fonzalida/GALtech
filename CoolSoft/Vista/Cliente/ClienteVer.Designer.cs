
namespace CoolSoft.Vista.Cliente
{
    partial class ClienteVer
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
            this.pFecha.SuspendLayout();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.Size = new System.Drawing.Size(1228, 62);
            // 
            // pMenu
            // 
            this.pMenu.Size = new System.Drawing.Size(1228, 80);
            // 
            // ClienteVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 719);
            this.Name = "ClienteVer";
            this.Text = "ClienteVer";
            this.Load += new System.EventHandler(this.ClienteVer_Load);
            this.pFecha.ResumeLayout(false);
            this.pFecha.PerformLayout();
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}