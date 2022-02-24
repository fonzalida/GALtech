
namespace CoolSoft.UI2._0
{
    partial class UiPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UiPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonOrdenes = new System.Windows.Forms.Button();
            this.buttonTecnicos = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.panelBorde = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureMinimizarForm = new System.Windows.Forms.PictureBox();
            this.pictureNormalForm = new System.Windows.Forms.PictureBox();
            this.pictureMaximizarForm = new System.Windows.Forms.PictureBox();
            this.pictureCerrarForm = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelBorde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNormalForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCerrarForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panelMenu.Controls.Add(this.buttonInicio);
            this.panelMenu.Controls.Add(this.buttonOrdenes);
            this.panelMenu.Controls.Add(this.buttonTecnicos);
            this.panelMenu.Controls.Add(this.buttonClientes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 720);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseHover += new System.EventHandler(this.Menu_MouseHover);
            // 
            // buttonInicio
            // 
            this.buttonInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInicio.Image = global::CoolSoft.Properties.Resources.inicio;
            this.buttonInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInicio.Location = new System.Drawing.Point(0, 60);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(230, 50);
            this.buttonInicio.TabIndex = 3;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // buttonOrdenes
            // 
            this.buttonOrdenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrdenes.FlatAppearance.BorderSize = 0;
            this.buttonOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrdenes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrdenes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOrdenes.Image = global::CoolSoft.Properties.Resources.orden1;
            this.buttonOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrdenes.Location = new System.Drawing.Point(0, 228);
            this.buttonOrdenes.Name = "buttonOrdenes";
            this.buttonOrdenes.Size = new System.Drawing.Size(230, 50);
            this.buttonOrdenes.TabIndex = 2;
            this.buttonOrdenes.Text = "Ordenes";
            this.buttonOrdenes.UseVisualStyleBackColor = true;
            this.buttonOrdenes.Click += new System.EventHandler(this.buttonOrdenes_Click);
            // 
            // buttonTecnicos
            // 
            this.buttonTecnicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTecnicos.FlatAppearance.BorderSize = 0;
            this.buttonTecnicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTecnicos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTecnicos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTecnicos.Image = global::CoolSoft.Properties.Resources.tecnico1;
            this.buttonTecnicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTecnicos.Location = new System.Drawing.Point(0, 172);
            this.buttonTecnicos.Name = "buttonTecnicos";
            this.buttonTecnicos.Size = new System.Drawing.Size(230, 50);
            this.buttonTecnicos.TabIndex = 1;
            this.buttonTecnicos.Text = "Tecnicos";
            this.buttonTecnicos.UseVisualStyleBackColor = true;
            this.buttonTecnicos.Click += new System.EventHandler(this.buttonTecnicos_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClientes.Image = global::CoolSoft.Properties.Resources.cliente1;
            this.buttonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientes.Location = new System.Drawing.Point(0, 116);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(230, 50);
            this.buttonClientes.TabIndex = 0;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // panelBorde
            // 
            this.panelBorde.BackColor = System.Drawing.SystemColors.Control;
            this.panelBorde.Controls.Add(this.buttonMenu);
            this.panelBorde.Controls.Add(this.labelTitulo);
            this.panelBorde.Controls.Add(this.pictureMinimizarForm);
            this.panelBorde.Controls.Add(this.pictureNormalForm);
            this.panelBorde.Controls.Add(this.pictureMaximizarForm);
            this.panelBorde.Controls.Add(this.pictureCerrarForm);
            this.panelBorde.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorde.Location = new System.Drawing.Point(230, 0);
            this.panelBorde.Name = "panelBorde";
            this.panelBorde.Size = new System.Drawing.Size(1050, 60);
            this.panelBorde.TabIndex = 1;
            this.panelBorde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorde_MouseDown);
            this.panelBorde.Resize += new System.EventHandler(this.panelBorde_Resize);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Image = global::CoolSoft.Properties.Resources.outline_menu_black_24dp;
            this.buttonMenu.Location = new System.Drawing.Point(0, 0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(60, 60);
            this.buttonMenu.TabIndex = 5;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitulo.Location = new System.Drawing.Point(400, 5);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(284, 52);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "BIENVENIDO";
            this.labelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorde_MouseDown);
            // 
            // pictureMinimizarForm
            // 
            this.pictureMinimizarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimizarForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pictureMinimizarForm.BackgroundImage = global::CoolSoft.Properties.Resources.minimizeForm;
            this.pictureMinimizarForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureMinimizarForm.Location = new System.Drawing.Point(936, 12);
            this.pictureMinimizarForm.Name = "pictureMinimizarForm";
            this.pictureMinimizarForm.Size = new System.Drawing.Size(30, 30);
            this.pictureMinimizarForm.TabIndex = 3;
            this.pictureMinimizarForm.TabStop = false;
            this.pictureMinimizarForm.Click += new System.EventHandler(this.pictureMinimizarForm_Click);
            // 
            // pictureNormalForm
            // 
            this.pictureNormalForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureNormalForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pictureNormalForm.BackgroundImage = global::CoolSoft.Properties.Resources.fullscreenExitForm;
            this.pictureNormalForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureNormalForm.Location = new System.Drawing.Point(972, 12);
            this.pictureNormalForm.Name = "pictureNormalForm";
            this.pictureNormalForm.Size = new System.Drawing.Size(30, 30);
            this.pictureNormalForm.TabIndex = 2;
            this.pictureNormalForm.TabStop = false;
            this.pictureNormalForm.Visible = false;
            this.pictureNormalForm.Click += new System.EventHandler(this.pictureNormalForm_Click);
            // 
            // pictureMaximizarForm
            // 
            this.pictureMaximizarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMaximizarForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pictureMaximizarForm.BackgroundImage = global::CoolSoft.Properties.Resources.fullscreenEnterForm;
            this.pictureMaximizarForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureMaximizarForm.Location = new System.Drawing.Point(972, 12);
            this.pictureMaximizarForm.Name = "pictureMaximizarForm";
            this.pictureMaximizarForm.Size = new System.Drawing.Size(30, 30);
            this.pictureMaximizarForm.TabIndex = 1;
            this.pictureMaximizarForm.TabStop = false;
            this.pictureMaximizarForm.Click += new System.EventHandler(this.pictureMaximizarForm_Click);
            // 
            // pictureCerrarForm
            // 
            this.pictureCerrarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureCerrarForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pictureCerrarForm.BackgroundImage = global::CoolSoft.Properties.Resources.closeForm;
            this.pictureCerrarForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureCerrarForm.Location = new System.Drawing.Point(1008, 12);
            this.pictureCerrarForm.Name = "pictureCerrarForm";
            this.pictureCerrarForm.Size = new System.Drawing.Size(30, 30);
            this.pictureCerrarForm.TabIndex = 0;
            this.pictureCerrarForm.TabStop = false;
            this.pictureCerrarForm.Click += new System.EventHandler(this.pictureCerrarForm_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Silver;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(230, 60);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 660);
            this.panelContenedor.TabIndex = 2;
            // 
            // UiPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBorde);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UiPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UiPrincipal";
            this.Load += new System.EventHandler(this.UiPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNormalForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCerrarForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBorde;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureCerrarForm;
        private System.Windows.Forms.PictureBox pictureMinimizarForm;
        private System.Windows.Forms.PictureBox pictureNormalForm;
        private System.Windows.Forms.PictureBox pictureMaximizarForm;
        private System.Windows.Forms.Button buttonOrdenes;
        private System.Windows.Forms.Button buttonTecnicos;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label labelTitulo;
    }
}