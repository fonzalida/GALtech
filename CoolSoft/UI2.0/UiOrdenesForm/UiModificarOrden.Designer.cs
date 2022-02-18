
namespace CoolSoft.UI2._0.UiOrdenesForm
{
    partial class UiModificarOrden
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
            // textBoxNombre
            // 
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            // 
            // maskedTextDni
            // 
            this.maskedTextDni.Margin = new System.Windows.Forms.Padding(4);
            // 
            // panelBorde
            // 
            this.panelBorde.Margin = new System.Windows.Forms.Padding(4);
            this.panelBorde.Size = new System.Drawing.Size(1189, 50);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Size = new System.Drawing.Size(162, 19);
            this.labelTitulo.Text = "MODIFICAR ORDEN";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(1027, 478);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(868, 478);
            this.buttonCargar.Margin = new System.Windows.Forms.Padding(4);
            // 
            // UiModificarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 543);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UiModificarOrden";
            this.Text = "UiModificarOrden";
            this.Load += new System.EventHandler(this.UiModificarOrden_Load);
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}