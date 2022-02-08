
namespace CoolSoft.Vista.Orden
{
    partial class OrdenAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenAgregar));
            this.mtFechaRecepcion = new System.Windows.Forms.MaskedTextBox();
            this.tbTareaDesarrollar = new System.Windows.Forms.TextBox();
            this.mtIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.bSeleccionarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAgregar.Location = new System.Drawing.Point(357, 8);
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.Location = new System.Drawing.Point(611, 8);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLimpiar.Location = new System.Drawing.Point(484, 8);
            // 
            // pTitulo
            // 
            this.pTitulo.Size = new System.Drawing.Size(744, 62);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.bSeleccionarCliente);
            this.pMenu.Size = new System.Drawing.Size(744, 98);
            this.pMenu.Controls.SetChildIndex(this.bSeleccionarCliente, 0);
            this.pMenu.Controls.SetChildIndex(this.bAgregar, 0);
            this.pMenu.Controls.SetChildIndex(this.bCancelar, 0);
            this.pMenu.Controls.SetChildIndex(this.bLimpiar, 0);
            // 
            // mtFechaRecepcion
            // 
            this.mtFechaRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtFechaRecepcion.Location = new System.Drawing.Point(275, 169);
            this.mtFechaRecepcion.Mask = "00/00/0000";
            this.mtFechaRecepcion.Name = "mtFechaRecepcion";
            this.mtFechaRecepcion.Size = new System.Drawing.Size(162, 34);
            this.mtFechaRecepcion.TabIndex = 1;
            this.mtFechaRecepcion.ValidatingType = typeof(System.DateTime);
            // 
            // tbTareaDesarrollar
            // 
            this.tbTareaDesarrollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTareaDesarrollar.Location = new System.Drawing.Point(275, 280);
            this.tbTareaDesarrollar.Multiline = true;
            this.tbTareaDesarrollar.Name = "tbTareaDesarrollar";
            this.tbTareaDesarrollar.Size = new System.Drawing.Size(397, 113);
            this.tbTareaDesarrollar.TabIndex = 3;
            // 
            // mtIdCliente
            // 
            this.mtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtIdCliente.Location = new System.Drawing.Point(275, 222);
            this.mtIdCliente.Name = "mtIdCliente";
            this.mtIdCliente.Size = new System.Drawing.Size(162, 34);
            this.mtIdCliente.TabIndex = 2;
            // 
            // bSeleccionarCliente
            // 
            this.bSeleccionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeleccionarCliente.Image = global::CoolSoft.Properties.Resources.search;
            this.bSeleccionarCliente.Location = new System.Drawing.Point(33, 8);
            this.bSeleccionarCliente.Name = "bSeleccionarCliente";
            this.bSeleccionarCliente.Size = new System.Drawing.Size(222, 79);
            this.bSeleccionarCliente.TabIndex = 20;
            this.bSeleccionarCliente.Text = "Seleccionar Cliente";
            this.bSeleccionarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bSeleccionarCliente.UseVisualStyleBackColor = true;
            this.bSeleccionarCliente.Click += new System.EventHandler(this.bSeleccionarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha de recepción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tarea a desarrollar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Num Cliente";
            // 
            // OrdenAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 514);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtIdCliente);
            this.Controls.Add(this.tbTareaDesarrollar);
            this.Controls.Add(this.mtFechaRecepcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrdenAgregar";
            this.Text = "OrdenesAgregar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdenesAgregar_FormClosed);
            this.Load += new System.EventHandler(this.OrdenesAgregar_Load);
            this.Controls.SetChildIndex(this.pTitulo, 0);
            this.Controls.SetChildIndex(this.pMenu, 0);
            this.Controls.SetChildIndex(this.mtFechaRecepcion, 0);
            this.Controls.SetChildIndex(this.tbTareaDesarrollar, 0);
            this.Controls.SetChildIndex(this.mtIdCliente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtFechaRecepcion;
        private System.Windows.Forms.TextBox tbTareaDesarrollar;
        private System.Windows.Forms.MaskedTextBox mtIdCliente;
        private System.Windows.Forms.Button bSeleccionarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}