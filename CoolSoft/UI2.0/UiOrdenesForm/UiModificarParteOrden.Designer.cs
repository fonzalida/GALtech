
namespace CoolSoft.UI2._0.UiOrdenesForm
{
    partial class UiModificarParteOrden
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelBorde.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.Text = "Técnico";
            // 
            // label2
            // 
            this.label2.Text = "Tarea desarrollada:";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.Text = "Fecha Inicio";
            // 
            // panelBorde
            // 
            this.panelBorde.Size = new System.Drawing.Size(800, 50);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Size = new System.Drawing.Size(220, 19);
            this.labelTitulo.Text = "MODIFICAR PARTE ÓRDEN";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(266, 434);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(108, 434);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox1.Location = new System.Drawing.Point(300, 93);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 24);
            this.checkBox1.TabIndex = 77;
            this.checkBox1.Text = "Completada";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // UiModificarParteOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.checkBox1);
            this.Name = "UiModificarParteOrden";
            this.Text = "UiModificarParteOrden";
            this.Load += new System.EventHandler(this.UiModificarParteOrden_Load);
            this.Controls.SetChildIndex(this.tbTareaDesarrollar, 0);
            this.Controls.SetChildIndex(this.mtIdCliente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dtFechaRecepcion, 0);
            this.Controls.SetChildIndex(this.panelBorde, 0);
            this.Controls.SetChildIndex(this.buttonCargar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.buttonBuscar, 0);
            this.Controls.SetChildIndex(this.textBoxNombreCliente, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
    }
}