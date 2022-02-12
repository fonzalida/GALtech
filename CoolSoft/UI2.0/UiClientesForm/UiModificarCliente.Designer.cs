
namespace CoolSoft.UI2._0.UiClientesForm
{
    partial class UiModificarCliente
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
            this.panelBorde.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorde
            // 
            this.panelBorde.Size = new System.Drawing.Size(737, 41);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Size = new System.Drawing.Size(173, 19);
            this.labelTitulo.Text = "MODIFICAR CLIENTE";
            // 
            // buttonCargar
            // 
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // UiModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 529);
            this.Name = "UiModificarCliente";
            this.Text = "UiModificarCliente";
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}