
namespace CoolSoft.Vista.FormsCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteVer));
            this.pFecha.SuspendLayout();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bMinimizar
            // 
            this.bMinimizar.Location = new System.Drawing.Point(876, 10);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(906, 10);
            // 
            // dtInicial
            // 
            this.dtInicial.Value = new System.DateTime(2022, 2, 1, 0, 0, 0, 0);
            // 
            // dtFinal
            // 
            this.dtFinal.Value = new System.DateTime(2022, 2, 10, 0, 0, 0, 0);
            // 
            // lTitulo
            // 
            this.lTitulo.Size = new System.Drawing.Size(154, 39);
            this.lTitulo.Text = "Ordenes";
            // 
            // ClienteVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 669);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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