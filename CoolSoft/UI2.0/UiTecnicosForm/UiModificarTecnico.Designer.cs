
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
            this.buttonModificar = new System.Windows.Forms.Button();
            this.panelBorde.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Text = "Teléfono";
            // 
            // tbNombre
            // 
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbNombre.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxDni
            // 
            this.textBoxDni.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // panelBorde
            // 
            this.panelBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(55)))));
            this.panelBorde.Margin = new System.Windows.Forms.Padding(4);
            this.panelBorde.Size = new System.Drawing.Size(393, 50);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitulo.Size = new System.Drawing.Size(176, 19);
            this.labelTitulo.Text = "MODIFICAR TÉCNICO";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(55)))));
            this.buttonCancelar.Location = new System.Drawing.Point(229, 315);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(229, 116);
            this.buttonCargar.Visible = false;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(55)))));
            this.buttonModificar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonModificar.Image = global::CoolSoft.Properties.Resources.edit;
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificar.Location = new System.Drawing.Point(71, 315);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(152, 51);
            this.buttonModificar.TabIndex = 64;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // UiModificarTecnico
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(393, 381);
            this.Controls.Add(this.buttonModificar);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UiModificarTecnico";
            this.Text = "UiModificarTecnico";
            this.Load += new System.EventHandler(this.UiModificarTecnico_Load);
            this.Controls.SetChildIndex(this.buttonModificar, 0);
            this.Controls.SetChildIndex(this.textBoxDni, 0);
            this.Controls.SetChildIndex(this.textBoxTelefono, 0);
            this.Controls.SetChildIndex(this.panelBorde, 0);
            this.Controls.SetChildIndex(this.buttonCargar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonModificar;
    }
}