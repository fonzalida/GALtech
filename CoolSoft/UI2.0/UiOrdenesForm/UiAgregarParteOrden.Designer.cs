
namespace CoolSoft.UI2._0.UiOrdenesForm
{
    partial class UiAgregarParteOrden
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
            // buttonBuscar
            // 
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.Text = "Técnico";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.Text = "Fecha Inicio";
            // 
            // mtIdCliente
            // 
            this.mtIdCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtIdCliente_MaskInputRejected);
            // 
            // panelBorde
            // 
            this.panelBorde.Size = new System.Drawing.Size(705, 50);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Size = new System.Drawing.Size(211, 19);
            this.labelTitulo.Text = "AGREGAR PARTE ÓRDEN";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(171, 411);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(13, 411);
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // UiAgregarParteOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Name = "UiAgregarParteOrden";
            this.Text = "UiAgregarParteOrden";
            this.Load += new System.EventHandler(this.UiAgregarParteOrden_Load);
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}