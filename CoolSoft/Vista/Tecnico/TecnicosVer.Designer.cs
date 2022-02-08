
namespace CoolSoft.Vista.Tecnico
{
    partial class TecnicosVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TecnicosVer));
            this.pFecha.SuspendLayout();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // mtbFinal
            // 
            this.mtbFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbFinal.Text = "06022022";
            // 
            // mtbInicial
            // 
            this.mtbInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbInicial.Text = "01022022";
            // 
            // bMinimizar
            // 
            this.bMinimizar.Location = new System.Drawing.Point(1168, 12);
            this.bMinimizar.Margin = new System.Windows.Forms.Padding(4);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(1208, 12);
            this.bCerrar.Margin = new System.Windows.Forms.Padding(4);
            // 
            // lTitulo
            // 
            this.lTitulo.Size = new System.Drawing.Size(162, 39);
            this.lTitulo.Text = "Tecnicos";
            // 
            // pTitulo
            // 
            this.pTitulo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // pMenu
            // 
            this.pMenu.Margin = new System.Windows.Forms.Padding(5);
            // 
            // TecnicosVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 719);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TecnicosVer";
            this.Text = "TecnicosVer";
            this.Load += new System.EventHandler(this.TecnicosVer_Load);
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