
namespace CoolSoft.UI2._0.UiTecnicosForm
{
    partial class UiModificarTecnico
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
            this.panelBorde.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.panelBorde.Size = new System.Drawing.Size(524, 41);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Size = new System.Drawing.Size(176, 19);
            this.labelTitulo.Text = "MODIFICAR TÉCNICO";
            // 
            // buttonCargar
            // 
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // UiModificarTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 507);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UiModificarTecnico";
            this.Text = "UiModificarTecnico";
            this.Load += new System.EventHandler(this.UiModificarTecnico_Load);
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}