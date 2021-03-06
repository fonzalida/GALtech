
namespace CoolSoft.VISTA
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.tecnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.AutoSize = false;
            this.menuStripPrincipal.BackColor = System.Drawing.Color.Navy;
            this.menuStripPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripPrincipal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tecnicosToolStripMenuItem,
            this.ordenesToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripPrincipal.Size = new System.Drawing.Size(226, 582);
            this.menuStripPrincipal.TabIndex = 1;
            this.menuStripPrincipal.Text = "menuStrip1";
            this.menuStripPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripPrincipal_ItemClicked);
            // 
            // tecnicosToolStripMenuItem
            // 
            this.tecnicosToolStripMenuItem.AutoSize = false;
            this.tecnicosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tecnicosToolStripMenuItem.Image = global::CoolSoft.Properties.Resources.tecnico;
            this.tecnicosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tecnicosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tecnicosToolStripMenuItem.Name = "tecnicosToolStripMenuItem";
            this.tecnicosToolStripMenuItem.Size = new System.Drawing.Size(170, 80);
            this.tecnicosToolStripMenuItem.Text = "Tecnicos";
            this.tecnicosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tecnicosToolStripMenuItem.Click += new System.EventHandler(this.tecnicosToolStripMenuItem_Click);
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.AutoSize = false;
            this.ordenesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ordenesToolStripMenuItem.Image = global::CoolSoft.Properties.Resources.orden;
            this.ordenesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordenesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(170, 80);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            this.ordenesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ordenesToolStripMenuItem.Click += new System.EventHandler(this.ordenesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.AutoSize = false;
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clientesToolStripMenuItem.Image = global::CoolSoft.Properties.Resources.cliente;
            this.clientesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(170, 80);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::CoolSoft.Properties.Resources.LOGO_CHIQUITO;
            this.ClientSize = new System.Drawing.Size(1163, 582);
            this.Controls.Add(this.menuStripPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioPrincipal";
            this.Text = "CoolSoft Sistema de Gestión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormularioPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tecnicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    }
}