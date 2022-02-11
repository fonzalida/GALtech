
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
            this.bAgregar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.ssEstado = new System.Windows.Forms.StatusStrip();
            this.bVer = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.pFecha = new System.Windows.Forms.Panel();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.lFFinal = new System.Windows.Forms.Label();
            this.labelFInicial = new System.Windows.Forms.Label();
            this.pBuscar = new System.Windows.Forms.Panel();
            this.bBuscar = new System.Windows.Forms.Button();
            this.pCostado = new System.Windows.Forms.Panel();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bMinimizar = new System.Windows.Forms.Button();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorico)).BeginInit();
            this.pFecha.SuspendLayout();
            this.pBuscar.SuspendLayout();
            this.pCostado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.Controls.Add(this.bMinimizar);
            this.pTitulo.Controls.Add(this.bCerrar);
            this.pTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pTitulo.Size = new System.Drawing.Size(1228, 62);
            this.pTitulo.Controls.SetChildIndex(this.bCerrar, 0);
            this.pTitulo.Controls.SetChildIndex(this.bMinimizar, 0);
            this.pTitulo.Controls.SetChildIndex(this.lTitulo, 0);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.bCancelar);
            this.pMenu.Controls.Add(this.bVer);
            this.pMenu.Controls.Add(this.pBuscar);
            this.pMenu.Controls.Add(this.pFecha);
            this.pMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pMenu.Size = new System.Drawing.Size(1228, 107);
            // 
            // dataGridHistorico
            // 
            this.dataGridHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorico.Location = new System.Drawing.Point(13, 199);
            this.dataGridHistorico.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridHistorico.Name = "dataGridHistorico";
            this.dataGridHistorico.RowHeadersWidth = 51;
            this.dataGridHistorico.Size = new System.Drawing.Size(1043, 444);
            this.dataGridHistorico.TabIndex = 9;
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Image = global::CoolSoft.Properties.Resources.add;
            this.bAgregar.Location = new System.Drawing.Point(8, 4);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(140, 80);
            this.bAgregar.TabIndex = 3;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Image = global::CoolSoft.Properties.Resources.edit;
            this.bModificar.Location = new System.Drawing.Point(8, 95);
            this.bModificar.Margin = new System.Windows.Forms.Padding(4);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(140, 80);
            this.bModificar.TabIndex = 4;
            this.bModificar.Text = "Detalles";
            this.bModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.Image = global::CoolSoft.Properties.Resources.delete;
            this.bEliminar.Location = new System.Drawing.Point(8, 186);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(140, 80);
            this.bEliminar.TabIndex = 5;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // ssEstado
            // 
            this.ssEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssEstado.Location = new System.Drawing.Point(0, 647);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssEstado.Size = new System.Drawing.Size(1228, 22);
            this.ssEstado.TabIndex = 14;
            this.ssEstado.Text = "statusStrip1";
            // 
            // bVer
            // 
            this.bVer.BackColor = System.Drawing.SystemColors.Control;
            this.bVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVer.Image = ((System.Drawing.Image)(resources.GetObject("bVer.Image")));
            this.bVer.Location = new System.Drawing.Point(485, 10);
            this.bVer.Margin = new System.Windows.Forms.Padding(4);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(119, 79);
            this.bVer.TabIndex = 16;
            this.bVer.Text = "Ver";
            this.bVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVer.UseVisualStyleBackColor = false;
            this.bVer.Click += new System.EventHandler(this.bVer_Click_1);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bCancelar.Image")));
            this.bCancelar.Location = new System.Drawing.Point(612, 10);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(119, 80);
            this.bCancelar.TabIndex = 17;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click_1);
            // 
            // pFecha
            // 
            this.pFecha.BackColor = System.Drawing.Color.LightGray;
            this.pFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFecha.Controls.Add(this.dtFinal);
            this.pFecha.Controls.Add(this.dtInicial);
            this.pFecha.Controls.Add(this.checkBoxTodos);
            this.pFecha.Controls.Add(this.lFFinal);
            this.pFecha.Controls.Add(this.labelFInicial);
            this.pFecha.Location = new System.Drawing.Point(12, 10);
            this.pFecha.Margin = new System.Windows.Forms.Padding(4);
            this.pFecha.Name = "pFecha";
            this.pFecha.Size = new System.Drawing.Size(465, 80);
            this.pFecha.TabIndex = 15;
            // 
            // dtFinal
            // 
            this.dtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(86, 45);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(132, 30);
            this.dtFinal.TabIndex = 8;
            // 
            // dtInicial
            // 
            this.dtInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(86, 6);
            this.dtInicial.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(132, 30);
            this.dtInicial.TabIndex = 7;
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTodos.Location = new System.Drawing.Point(237, 25);
            this.checkBoxTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(199, 29);
            this.checkBoxTodos.TabIndex = 4;
            this.checkBoxTodos.Text = "Todos los registros";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            this.checkBoxTodos.CheckedChanged += new System.EventHandler(this.checkBoxTodos_CheckedChanged);
            // 
            // lFFinal
            // 
            this.lFFinal.AutoSize = true;
            this.lFFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFFinal.Location = new System.Drawing.Point(10, 45);
            this.lFFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFFinal.Name = "lFFinal";
            this.lFFinal.Size = new System.Drawing.Size(63, 25);
            this.lFFinal.TabIndex = 2;
            this.lFFinal.Text = "Hasta";
            // 
            // labelFInicial
            // 
            this.labelFInicial.AutoSize = true;
            this.labelFInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFInicial.Location = new System.Drawing.Point(4, 6);
            this.labelFInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFInicial.Name = "labelFInicial";
            this.labelFInicial.Size = new System.Drawing.Size(69, 25);
            this.labelFInicial.TabIndex = 0;
            this.labelFInicial.Text = "Desde";
            // 
            // pBuscar
            // 
            this.pBuscar.BackColor = System.Drawing.Color.LightGray;
            this.pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBuscar.Controls.Add(this.bBuscar);
            this.pBuscar.Location = new System.Drawing.Point(739, 14);
            this.pBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.pBuscar.Name = "pBuscar";
            this.pBuscar.Size = new System.Drawing.Size(475, 76);
            this.pBuscar.TabIndex = 18;
            // 
            // bBuscar
            // 
            this.bBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Image = global::CoolSoft.Properties.Resources.search;
            this.bBuscar.Location = new System.Drawing.Point(328, -1);
            this.bBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(143, 81);
            this.bBuscar.TabIndex = 0;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // pCostado
            // 
            this.pCostado.Controls.Add(this.bAgregar);
            this.pCostado.Controls.Add(this.bModificar);
            this.pCostado.Controls.Add(this.bEliminar);
            this.pCostado.Location = new System.Drawing.Point(1064, 199);
            this.pCostado.Margin = new System.Windows.Forms.Padding(4);
            this.pCostado.Name = "pCostado";
            this.pCostado.Size = new System.Drawing.Size(164, 444);
            this.pCostado.TabIndex = 17;
            // 
            // bCerrar
            // 
            this.bCerrar.BackColor = System.Drawing.Color.Navy;
            this.bCerrar.Image = global::CoolSoft.Properties.Resources.close;
            this.bCerrar.Location = new System.Drawing.Point(1167, 10);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(40, 40);
            this.bCerrar.TabIndex = 12;
            this.bCerrar.UseVisualStyleBackColor = false;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bMinimizar
            // 
            this.bMinimizar.BackColor = System.Drawing.Color.Navy;
            this.bMinimizar.Image = global::CoolSoft.Properties.Resources.minimize;
            this.bMinimizar.Location = new System.Drawing.Point(1121, 10);
            this.bMinimizar.Name = "bMinimizar";
            this.bMinimizar.Size = new System.Drawing.Size(40, 40);
            this.bMinimizar.TabIndex = 13;
            this.bMinimizar.UseVisualStyleBackColor = false;
            this.bMinimizar.Click += new System.EventHandler(this.bMinimizar_Click);
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 669);
            this.Controls.Add(this.pCostado);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.dataGridHistorico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Historico";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Historico_Load);
            this.Controls.SetChildIndex(this.dataGridHistorico, 0);
            this.Controls.SetChildIndex(this.ssEstado, 0);
            this.Controls.SetChildIndex(this.pCostado, 0);
            this.Controls.SetChildIndex(this.pTitulo, 0);
            this.Controls.SetChildIndex(this.pMenu, 0);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorico)).EndInit();
            this.pFecha.ResumeLayout(false);
            this.pFecha.PerformLayout();
            this.pBuscar.ResumeLayout(false);
            this.pCostado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridHistorico;
        public System.Windows.Forms.Button bAgregar;
        public System.Windows.Forms.Button bModificar;
        public System.Windows.Forms.Button bEliminar;
        public System.Windows.Forms.StatusStrip ssEstado;
        public System.Windows.Forms.Button bVer;
        public System.Windows.Forms.Button bCancelar;
        public System.Windows.Forms.Panel pFecha;
        public System.Windows.Forms.Label lFFinal;
        public System.Windows.Forms.Label labelFInicial;
        public System.Windows.Forms.Panel pBuscar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.CheckBox checkBoxTodos;
        private System.Windows.Forms.Panel pCostado;
        public System.Windows.Forms.Button bMinimizar;
        public System.Windows.Forms.Button bCerrar;
        public System.Windows.Forms.DateTimePicker dtInicial;
        public System.Windows.Forms.DateTimePicker dtFinal;
    }
}