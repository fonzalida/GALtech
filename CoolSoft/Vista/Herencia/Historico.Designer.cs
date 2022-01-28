
namespace CoolSoft.Vista.Herencia
{
    partial class Historico
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
            this.dataGridHistorico = new System.Windows.Forms.DataGridView();
            this.bVer = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.dateTimeInicial = new System.Windows.Forms.DateTimePicker();
            this.labelFInicial = new System.Windows.Forms.Label();
            this.lFFinal = new System.Windows.Forms.Label();
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHistorico
            // 
            this.dataGridHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorico.Location = new System.Drawing.Point(102, 105);
            this.dataGridHistorico.Name = "dataGridHistorico";
            this.dataGridHistorico.Size = new System.Drawing.Size(641, 159);
            this.dataGridHistorico.TabIndex = 0;
            // 
            // bVer
            // 
            this.bVer.Location = new System.Drawing.Point(200, 300);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(75, 23);
            this.bVer.TabIndex = 1;
            this.bVer.Text = "Ver";
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(605, 300);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 2;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // dateTimeInicial
            // 
            this.dateTimeInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInicial.Location = new System.Drawing.Point(181, 51);
            this.dateTimeInicial.Name = "dateTimeInicial";
            this.dateTimeInicial.Size = new System.Drawing.Size(103, 20);
            this.dateTimeInicial.TabIndex = 3;
            this.dateTimeInicial.Value = new System.DateTime(2022, 1, 28, 0, 0, 0, 0);
            // 
            // labelFInicial
            // 
            this.labelFInicial.AutoSize = true;
            this.labelFInicial.Location = new System.Drawing.Point(112, 57);
            this.labelFInicial.Name = "labelFInicial";
            this.labelFInicial.Size = new System.Drawing.Size(38, 13);
            this.labelFInicial.TabIndex = 4;
            this.labelFInicial.Text = "Desde";
            // 
            // lFFinal
            // 
            this.lFFinal.AutoSize = true;
            this.lFFinal.Location = new System.Drawing.Point(477, 57);
            this.lFFinal.Name = "lFFinal";
            this.lFFinal.Size = new System.Drawing.Size(35, 13);
            this.lFFinal.TabIndex = 5;
            this.lFFinal.Text = "Hasta";
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFinal.Location = new System.Drawing.Point(543, 51);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(102, 20);
            this.dateTimeFinal.TabIndex = 6;
            this.dateTimeFinal.ValueChanged += new System.EventHandler(this.dateTimeFinal_ValueChanged);
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimeFinal);
            this.Controls.Add(this.lFFinal);
            this.Controls.Add(this.labelFInicial);
            this.Controls.Add(this.dateTimeInicial);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.dataGridHistorico);
            this.Name = "Historico";
            this.Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHistorico;
        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.DateTimePicker dateTimeInicial;
        private System.Windows.Forms.Label labelFInicial;
        private System.Windows.Forms.Label lFFinal;
        private System.Windows.Forms.DateTimePicker dateTimeFinal;
    }
}