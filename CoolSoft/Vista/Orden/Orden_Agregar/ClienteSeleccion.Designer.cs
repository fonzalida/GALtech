
namespace CoolSoft.Vista.Orden.Orden_Agregar
{
    partial class ClienteSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteSeleccion));
            this.mtNombre = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pSeleccion.SuspendLayout();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(668, 7);
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // mtId
            // 
            this.mtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtId.Size = new System.Drawing.Size(156, 30);
            this.mtId.Enter += new System.EventHandler(this.text_Enter);
            // 
            // lId
            // 
            this.lId.Size = new System.Drawing.Size(129, 29);
            this.lId.Text = "DNI / CUIT";
            // 
            // bBuscarCliente
            // 
            this.bBuscarCliente.Location = new System.Drawing.Point(542, 7);
            // 
            // lTitulo
            // 
            this.lTitulo.Size = new System.Drawing.Size(331, 39);
            this.lTitulo.Text = "Seleccionar Cliente";
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.label1);
            this.pMenu.Controls.Add(this.mtNombre);
            this.pMenu.Controls.SetChildIndex(this.lId, 0);
            this.pMenu.Controls.SetChildIndex(this.bCancelar, 0);
            this.pMenu.Controls.SetChildIndex(this.mtId, 0);
            this.pMenu.Controls.SetChildIndex(this.bBuscarCliente, 0);
            this.pMenu.Controls.SetChildIndex(this.mtNombre, 0);
            this.pMenu.Controls.SetChildIndex(this.label1, 0);
            // 
            // mtNombre
            // 
            this.mtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtNombre.Location = new System.Drawing.Point(186, 39);
            this.mtNombre.Name = "mtNombre";
            this.mtNombre.PromptChar = ' ';
            this.mtNombre.Size = new System.Drawing.Size(313, 30);
            this.mtNombre.TabIndex = 27;
            this.mtNombre.Enter += new System.EventHandler(this.text_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre Cliente";
            // 
            // ClienteSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClienteSeleccion";
            this.Text = "ClienteSeleccion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClienteSeleccion_FormClosed);
            this.Load += new System.EventHandler(this.ClienteSeleccion_Load);
            this.pSeleccion.ResumeLayout(false);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtNombre;
    }
}