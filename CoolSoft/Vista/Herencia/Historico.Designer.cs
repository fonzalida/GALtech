
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
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.lFFinal = new System.Windows.Forms.Label();
            this.labelFInicial = new System.Windows.Forms.Label();
            this.pBuscar = new System.Windows.Forms.Panel();
            this.bBuscar = new System.Windows.Forms.Button();
            this.pCostado = new System.Windows.Forms.Panel();
            this.mtbInicial = new System.Windows.Forms.MaskedTextBox();
            this.mtbFinal = new System.Windows.Forms.MaskedTextBox();
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
            this.pTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pTitulo.Size = new System.Drawing.Size(921, 50);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.bCancelar);
            this.pMenu.Controls.Add(this.bVer);
            this.pMenu.Controls.Add(this.pBuscar);
            this.pMenu.Controls.Add(this.pFecha);
            this.pMenu.Size = new System.Drawing.Size(921, 107);
            // 
            // dataGridHistorico
            // 
            this.dataGridHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorico.Location = new System.Drawing.Point(10, 162);
            this.dataGridHistorico.Name = "dataGridHistorico";
            this.dataGridHistorico.RowHeadersWidth = 51;
            this.dataGridHistorico.Size = new System.Drawing.Size(782, 385);
            this.dataGridHistorico.TabIndex = 9;
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Image = global::CoolSoft.Properties.Resources.add;
            this.bAgregar.Location = new System.Drawing.Point(6, 3);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(105, 65);
            this.bAgregar.TabIndex = 3;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Image = global::CoolSoft.Properties.Resources.edit;
            this.bModificar.Location = new System.Drawing.Point(6, 77);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(105, 65);
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
            this.bEliminar.Location = new System.Drawing.Point(6, 151);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(105, 65);
            this.bEliminar.TabIndex = 5;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // ssEstado
            // 
            this.ssEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssEstado.Location = new System.Drawing.Point(0, 562);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Size = new System.Drawing.Size(921, 22);
            this.ssEstado.TabIndex = 14;
            this.ssEstado.Text = "statusStrip1";
            // 
            // bVer
            // 
            this.bVer.BackColor = System.Drawing.SystemColors.Control;
            this.bVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVer.Image = ((System.Drawing.Image)(resources.GetObject("bVer.Image")));
            this.bVer.Location = new System.Drawing.Point(400, 17);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(89, 64);
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
            this.bCancelar.Location = new System.Drawing.Point(495, 16);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(89, 65);
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
            this.pFecha.Controls.Add(this.mtbFinal);
            this.pFecha.Controls.Add(this.mtbInicial);
            this.pFecha.Controls.Add(this.checkBoxTodos);
            this.pFecha.Controls.Add(this.lFFinal);
            this.pFecha.Controls.Add(this.labelFInicial);
            this.pFecha.Location = new System.Drawing.Point(9, 8);
            this.pFecha.Name = "pFecha";
            this.pFecha.Size = new System.Drawing.Size(385, 78);
            this.pFecha.TabIndex = 15;
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTodos.Location = new System.Drawing.Point(7, 41);
            this.checkBoxTodos.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(161, 24);
            this.checkBoxTodos.TabIndex = 4;
            this.checkBoxTodos.Text = "Todos los registros";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            this.checkBoxTodos.CheckedChanged += new System.EventHandler(this.checkBoxTodos_CheckedChanged);
            // 
            // lFFinal
            // 
            this.lFFinal.AutoSize = true;
            this.lFFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFFinal.Location = new System.Drawing.Point(206, 3);
            this.lFFinal.Name = "lFFinal";
            this.lFFinal.Size = new System.Drawing.Size(52, 20);
            this.lFFinal.TabIndex = 2;
            this.lFFinal.Text = "Hasta";
            // 
            // labelFInicial
            // 
            this.labelFInicial.AutoSize = true;
            this.labelFInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFInicial.Location = new System.Drawing.Point(3, 3);
            this.labelFInicial.Name = "labelFInicial";
            this.labelFInicial.Size = new System.Drawing.Size(56, 20);
            this.labelFInicial.TabIndex = 0;
            this.labelFInicial.Text = "Desde";
            // 
            // pBuscar
            // 
            this.pBuscar.BackColor = System.Drawing.Color.LightGray;
            this.pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBuscar.Controls.Add(this.bBuscar);
            this.pBuscar.Location = new System.Drawing.Point(590, 11);
            this.pBuscar.Name = "pBuscar";
            this.pBuscar.Size = new System.Drawing.Size(318, 74);
            this.pBuscar.TabIndex = 18;
            // 
            // bBuscar
            // 
            this.bBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Image = global::CoolSoft.Properties.Resources.search;
            this.bBuscar.Location = new System.Drawing.Point(206, 3);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(107, 66);
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
            this.pCostado.Location = new System.Drawing.Point(798, 162);
            this.pCostado.Name = "pCostado";
            this.pCostado.Size = new System.Drawing.Size(123, 385);
            this.pCostado.TabIndex = 17;
            // 
            // mtbInicial
            // 
            this.mtbInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbInicial.Location = new System.Drawing.Point(65, 5);
            this.mtbInicial.Mask = "00/00/0000";
            this.mtbInicial.Name = "mtbInicial";
            this.mtbInicial.Size = new System.Drawing.Size(100, 26);
            this.mtbInicial.TabIndex = 5;
            this.mtbInicial.ValidatingType = typeof(System.DateTime);
            // 
            // mtbFinal
            // 
            this.mtbFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbFinal.Location = new System.Drawing.Point(264, 5);
            this.mtbFinal.Mask = "00/00/0000";
            this.mtbFinal.Name = "mtbFinal";
            this.mtbFinal.Size = new System.Drawing.Size(100, 26);
            this.mtbFinal.TabIndex = 6;
            this.mtbFinal.ValidatingType = typeof(System.DateTime);
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 584);
            this.Controls.Add(this.pCostado);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.dataGridHistorico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        public System.Windows.Forms.MaskedTextBox mtbFinal;
        public System.Windows.Forms.MaskedTextBox mtbInicial;
    }
}