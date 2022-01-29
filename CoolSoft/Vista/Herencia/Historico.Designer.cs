
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
            this.pMenu = new System.Windows.Forms.Panel();
            this.pTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorico)).BeginInit();
            this.pFecha.SuspendLayout();
            this.pBuscar.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridHistorico
            // 
            this.dataGridHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorico.Location = new System.Drawing.Point(13, 207);
            this.dataGridHistorico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridHistorico.Name = "dataGridHistorico";
            this.dataGridHistorico.RowHeadersWidth = 51;
            this.dataGridHistorico.Size = new System.Drawing.Size(775, 342);
            this.dataGridHistorico.TabIndex = 9;
            // 
            // bVer
            // 
            this.bVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVer.Image = ((System.Drawing.Image)(resources.GetObject("bVer.Image")));
            this.bVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVer.Location = new System.Drawing.Point(648, 81);
            this.bVer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(147, 50);
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
            this.bCancelar.Location = new System.Drawing.Point(648, 24);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(147, 50);
            this.bCancelar.TabIndex = 2;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // dateTimeInicial
            // 
            this.dateTimeInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInicial.Location = new System.Drawing.Point(77, 4);
            this.dateTimeInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeInicial.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimeInicial.Name = "dateTimeInicial";
            this.dateTimeInicial.Size = new System.Drawing.Size(136, 22);
            this.dateTimeInicial.TabIndex = 1;
            this.dateTimeInicial.Value = new System.DateTime(2022, 1, 28, 0, 0, 0, 0);
            // 
            // labelFInicial
            // 
            this.labelFInicial.AutoSize = true;
            this.labelFInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFInicial.Location = new System.Drawing.Point(4, 4);
            this.labelFInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFInicial.Name = "labelFInicial";
            this.labelFInicial.Size = new System.Drawing.Size(58, 20);
            this.labelFInicial.TabIndex = 0;
            this.labelFInicial.Text = "Desde";
            // 
            // lFFinal
            // 
            this.lFFinal.AutoSize = true;
            this.lFFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFFinal.Location = new System.Drawing.Point(252, 4);
            this.lFFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFFinal.Name = "lFFinal";
            this.lFFinal.Size = new System.Drawing.Size(54, 20);
            this.lFFinal.TabIndex = 2;
            this.lFFinal.Text = "Hasta";
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFinal.Location = new System.Drawing.Point(319, 4);
            this.dateTimeFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeFinal.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(135, 22);
            this.dateTimeFinal.TabIndex = 3;
            this.dateTimeFinal.ValueChanged += new System.EventHandler(this.dateTimeFinal_ValueChanged);
            // 
            // pFecha
            // 
            this.pFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFecha.Controls.Add(this.dateTimeFinal);
            this.pFecha.Controls.Add(this.dateTimeInicial);
            this.pFecha.Controls.Add(this.lFFinal);
            this.pFecha.Controls.Add(this.labelFInicial);
            this.pFecha.Location = new System.Drawing.Point(20, 19);
            this.pFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pFecha.Name = "pFecha";
            this.pFecha.Size = new System.Drawing.Size(471, 55);
            this.pFecha.TabIndex = 0;
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Image = global::CoolSoft.Properties.Resources.add;
            this.bAgregar.Location = new System.Drawing.Point(803, 254);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(147, 46);
            this.bAgregar.TabIndex = 3;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Image = global::CoolSoft.Properties.Resources.edit;
            this.bModificar.Location = new System.Drawing.Point(803, 345);
            this.bModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(147, 46);
            this.bModificar.TabIndex = 4;
            this.bModificar.Text = "Modificar";
            this.bModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bModificar.UseVisualStyleBackColor = true;
            // 
            // bBuscar
            // 
            this.bBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Image = global::CoolSoft.Properties.Resources.search;
            this.bBuscar.Location = new System.Drawing.Point(319, 4);
            this.bBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(147, 46);
            this.bBuscar.TabIndex = 0;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // bEliminar
            // 
            this.bEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.Image = global::CoolSoft.Properties.Resources.delete;
            this.bEliminar.Location = new System.Drawing.Point(803, 435);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(147, 46);
            this.bEliminar.TabIndex = 5;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // pBuscar
            // 
            this.pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBuscar.Controls.Add(this.bBuscar);
            this.pBuscar.Location = new System.Drawing.Point(20, 81);
            this.pBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBuscar.Name = "pBuscar";
            this.pBuscar.Size = new System.Drawing.Size(471, 55);
            this.pBuscar.TabIndex = 13;
            // 
            // ssEstado
            // 
            this.ssEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssEstado.Location = new System.Drawing.Point(0, 570);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssEstado.Size = new System.Drawing.Size(965, 22);
            this.ssEstado.TabIndex = 14;
            this.ssEstado.Text = "statusStrip1";
            // 
            // pMenu
            // 
            this.pMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMenu.Controls.Add(this.bVer);
            this.pMenu.Controls.Add(this.bCancelar);
            this.pMenu.Controls.Add(this.pFecha);
            this.pMenu.Controls.Add(this.pBuscar);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Location = new System.Drawing.Point(0, 62);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(965, 150);
            this.pMenu.TabIndex = 15;
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 592);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.dataGridHistorico);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Historico_Load);
            this.Controls.SetChildIndex(this.dataGridHistorico, 0);
            this.Controls.SetChildIndex(this.bAgregar, 0);
            this.Controls.SetChildIndex(this.bModificar, 0);
            this.Controls.SetChildIndex(this.bEliminar, 0);
            this.Controls.SetChildIndex(this.ssEstado, 0);
            this.Controls.SetChildIndex(this.pTitulo, 0);
            this.Controls.SetChildIndex(this.pMenu, 0);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorico)).EndInit();
            this.pFecha.ResumeLayout(false);
            this.pFecha.PerformLayout();
            this.pBuscar.ResumeLayout(false);
            this.pMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pMenu;
    }
}