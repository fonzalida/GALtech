
namespace CoolSoft.Vista.Orden
{
    partial class OrdenesVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenesVer));
            this.pFecha.SuspendLayout();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeFinal
            // 
            //this.dateTimeFinal.Value = new System.DateTime(2022, 1, 30, 15, 29, 22, 858);
            //// 
            //// dateTimeInicial
            //// 
            //this.dateTimeInicial.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // pTitulo
            // 
            this.pTitulo.Size = new System.Drawing.Size(1241, 62);
            // 
            // pMenu
            // 
            this.pMenu.Size = new System.Drawing.Size(1241, 131);
            // 
            // OrdenesVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 667);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrdenesVer";
            this.Text = "OrdenesVer";
            this.Load += new System.EventHandler(this.OrdenesVer_Load);
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