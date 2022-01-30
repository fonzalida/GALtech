
namespace CoolSoft.Vista.Herencia
{
    partial class Base
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
            this.lTitulo = new System.Windows.Forms.Label();
            this.pTitulo = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.pTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.BackColor = System.Drawing.Color.Navy;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lTitulo.Location = new System.Drawing.Point(27, 11);
            this.lTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(107, 39);
            this.lTitulo.TabIndex = 11;
            this.lTitulo.Text = "Titulo";
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.Navy;
            this.pTitulo.Controls.Add(this.lTitulo);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(965, 62);
            this.pTitulo.TabIndex = 13;
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Location = new System.Drawing.Point(0, 62);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(965, 80);
            this.pMenu.TabIndex = 16;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 564);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Base";
            this.Text = "Base";
            this.Load += new System.EventHandler(this.Base_Load);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lTitulo;
        public System.Windows.Forms.Panel pTitulo;
        public System.Windows.Forms.Panel pMenu;
    }
}