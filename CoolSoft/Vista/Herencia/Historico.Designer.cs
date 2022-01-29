
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historico));
            this.dataGridHistorico = new System.Windows.Forms.DataGridView();
            this.bVer = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.dateTimeInicial = new System.Windows.Forms.DateTimePicker();
            this.labelFInicial = new System.Windows.Forms.Label();
            this.lFFinal = new System.Windows.Forms.Label();
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            this.pFecha = new System.Windows.Forms.Panel();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.pBuscar = new System.Windows.Forms.Panel();
            this.ssEstado = new System.Windows.Forms.StatusStrip();
            this.pTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorico)).BeginInit();
            this.pFecha.SuspendLayout();
            this.pBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridHistorico
            // 
            this.dataGridHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorico.Location = new System.Drawing.Point(12, 167);
            this.dataGridHistorico.Name = "dataGridHistorico";
            this.dataGridHistorico.Size = new System.Drawing.Size(581, 253);
            this.dataGridHistorico.TabIndex = 0;
            // 
            // bVer
            // 
            this.bVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVer.Image = ((System.Drawing.Image)(resources.GetObject("bVer.Image")));
            this.bVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVer.Location = new System.Drawing.Point(483, 111);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(110, 41);
            this.bVer.TabIndex = 1;
            this.bVer.Text = "Ver";
            this.bVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bCancelar.Image")));
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.Location = new System.Drawing.Point(483, 65);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(110, 41);
            this.bCancelar.TabIndex = 2;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // dateTimeInicial
            // 
            this.dateTimeInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInicial.Location = new System.Drawing.Point(58, 3);
            this.dateTimeInicial.Name = "dateTimeInicial";
            this.dateTimeInicial.Size = new System.Drawing.Size(103, 20);
            this.dateTimeInicial.TabIndex = 3;
            this.dateTimeInicial.Value = new System.DateTime(2022, 1, 28, 0, 0, 0, 0);
            // 
            // labelFInicial
            // 
            this.labelFInicial.AutoSize = true;
            this.labelFInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFInicial.Location = new System.Drawing.Point(3, 3);
            this.labelFInicial.Name = "labelFInicial";
            this.labelFInicial.Size = new System.Drawing.Size(49, 16);
            this.labelFInicial.TabIndex = 4;
            this.labelFInicial.Text = "Desde";
            // 
            // lFFinal
            // 
            this.lFFinal.AutoSize = true;
            this.lFFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFFinal.Location = new System.Drawing.Point(189, 3);
            this.lFFinal.Name = "lFFinal";
            this.lFFinal.Size = new System.Drawing.Size(44, 16);
            this.lFFinal.TabIndex = 5;
            this.lFFinal.Text = "Hasta";
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFinal.Location = new System.Drawing.Point(239, 3);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(102, 20);
            this.dateTimeFinal.TabIndex = 6;
            this.dateTimeFinal.ValueChanged += new System.EventHandler(this.dateTimeFinal_ValueChanged);
            // 
            // pFecha
            // 
            this.pFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFecha.Controls.Add(this.dateTimeFinal);
            this.pFecha.Controls.Add(this.dateTimeInicial);
            this.pFecha.Controls.Add(this.lFFinal);
            this.pFecha.Controls.Add(this.labelFInicial);
            this.pFecha.Location = new System.Drawing.Point(12, 61);
            this.pFecha.Name = "pFecha";
            this.pFecha.Size = new System.Drawing.Size(354, 45);
            this.pFecha.TabIndex = 7;
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Image = global::CoolSoft.Properties.Resources.add;
            this.bAgregar.Location = new System.Drawing.Point(602, 200);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(110, 37);
            this.bAgregar.TabIndex = 8;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Image = global::CoolSoft.Properties.Resources.edit;
            this.bModificar.Location = new System.Drawing.Point(602, 272);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(110, 37);
            this.bModificar.TabIndex = 9;
            this.bModificar.Text = "Modificar";
            this.bModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bModificar.UseVisualStyleBackColor = true;
            // 
            // bBuscar
            // 
            this.bBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Image = global::CoolSoft.Properties.Resources.search;
            this.bBuscar.Location = new System.Drawing.Point(239, 3);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(110, 37);
            this.bBuscar.TabIndex = 7;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // bEliminar
            // 
            this.bEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.Image = global::CoolSoft.Properties.Resources.delete;
            this.bEliminar.Location = new System.Drawing.Point(602, 346);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(110, 37);
            this.bEliminar.TabIndex = 10;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // pBuscar
            // 
            this.pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBuscar.Controls.Add(this.bBuscar);
            this.pBuscar.Location = new System.Drawing.Point(12, 111);
            this.pBuscar.Name = "pBuscar";
            this.pBuscar.Size = new System.Drawing.Size(354, 45);
            this.pBuscar.TabIndex = 13;
            // 
            // ssEstado
            // 
            this.ssEstado.Location = new System.Drawing.Point(0, 430);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Size = new System.Drawing.Size(724, 22);
            this.ssEstado.TabIndex = 14;
            this.ssEstado.Text = "statusStrip1";
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 452);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.pBuscar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.pFecha);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.dataGridHistorico);
            this.Name = "Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.Historico_Load);
            this.Controls.SetChildIndex(this.dataGridHistorico, 0);
            this.Controls.SetChildIndex(this.bVer, 0);
            this.Controls.SetChildIndex(this.bCancelar, 0);
            this.Controls.SetChildIndex(this.pFecha, 0);
            this.Controls.SetChildIndex(this.bAgregar, 0);
            this.Controls.SetChildIndex(this.bModificar, 0);
            this.Controls.SetChildIndex(this.bEliminar, 0);
            this.Controls.SetChildIndex(this.pBuscar, 0);
            this.Controls.SetChildIndex(this.ssEstado, 0);
            this.Controls.SetChildIndex(this.pTitulo, 0);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorico)).EndInit();
            this.pFecha.ResumeLayout(false);
            this.pFecha.PerformLayout();
            this.pBuscar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pFecha;
        public System.Windows.Forms.DataGridView dataGridHistorico;
        public System.Windows.Forms.Button bVer;
        public System.Windows.Forms.Button bCancelar;
        public System.Windows.Forms.DateTimePicker dateTimeInicial;
        public System.Windows.Forms.Label labelFInicial;
        public System.Windows.Forms.Label lFFinal;
        public System.Windows.Forms.DateTimePicker dateTimeFinal;
        private System.Windows.Forms.Button bBuscar;
        public System.Windows.Forms.Button bAgregar;
        public System.Windows.Forms.Button bModificar;
        public System.Windows.Forms.Button bEliminar;
        public System.Windows.Forms.Panel pBuscar;
        public System.Windows.Forms.StatusStrip ssEstado;
    }
}