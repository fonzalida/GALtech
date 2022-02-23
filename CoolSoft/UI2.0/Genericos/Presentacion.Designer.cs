
namespace CoolSoft.UI2._0.Genericos
{
    partial class Presentacion
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxPresentacion = new System.Windows.Forms.PictureBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.labelDia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPresentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPresentacion
            // 
            this.pictureBoxPresentacion.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPresentacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPresentacion.Image = global::CoolSoft.Properties.Resources.LOGO_COOLSOFT_original;
            this.pictureBoxPresentacion.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPresentacion.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPresentacion.Name = "pictureBoxPresentacion";
            this.pictureBoxPresentacion.Size = new System.Drawing.Size(1050, 660);
            this.pictureBoxPresentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPresentacion.TabIndex = 4;
            this.pictureBoxPresentacion.TabStop = false;
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(183)))), ((int)(((byte)(61)))));
            this.labelHora.Location = new System.Drawing.Point(843, 11);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(154, 56);
            this.labelHora.TabIndex = 5;
            this.labelHora.Text = "00:00";
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 800;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(183)))), ((int)(((byte)(61)))));
            this.labelDia.Location = new System.Drawing.Point(12, 9);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(154, 56);
            this.labelDia.TabIndex = 6;
            this.labelDia.Text = "00:00";
            // 
            // Presentacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(840, 528);
            this.Controls.Add(this.labelDia);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.pictureBoxPresentacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Presentacion";
            this.Text = "Presentacion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPresentacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPresentacion;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Label labelDia;
    }
}