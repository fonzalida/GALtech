
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
            // tbNombre
            // 
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // panelBorde
            // 
            this.panelBorde.Margin = new System.Windows.Forms.Padding(4);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitulo.Size = new System.Drawing.Size(215, 24);
            this.labelTitulo.Text = "MODIFICAR TÉCNICO";
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(259, 70);
            this.buttonCargar.Visible = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.buttonModificar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonModificar.Image = global::CoolSoft.Properties.Resources.edit;
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificar.Location = new System.Drawing.Point(115, 330);
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
            this.ClientSize = new System.Drawing.Size(437, 396);
            this.Controls.Add(this.buttonModificar);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UiModificarTecnico";
            this.Text = "UiModificarTecnico";
            this.Load += new System.EventHandler(this.UiModificarTecnico_Load);
            this.Controls.SetChildIndex(this.textBoxDniCuit, 0);
            this.Controls.SetChildIndex(this.textBoxTelefono, 0);
            this.Controls.SetChildIndex(this.panelBorde, 0);
            this.Controls.SetChildIndex(this.buttonCargar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.buttonModificar, 0);
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonModificar;
    }
}