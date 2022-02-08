
namespace CoolSoft.Vista.Herencia
{
    partial class Seleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seleccion));
            this.bCancelar = new System.Windows.Forms.Button();
            this.bBuscarCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bSeleccionarCliente = new System.Windows.Forms.Button();
            this.mtId = new System.Windows.Forms.MaskedTextBox();
            this.lId = new System.Windows.Forms.Label();
            this.pSeleccion = new System.Windows.Forms.Panel();
            this.pTitulo.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.Goldenrod;
            this.pTitulo.Size = new System.Drawing.Size(800, 62);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.bBuscarCliente);
            this.pMenu.Controls.Add(this.mtId);
            this.pMenu.Controls.Add(this.bCancelar);
            this.pMenu.Controls.Add(this.lId);
            this.pMenu.Size = new System.Drawing.Size(800, 98);
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bCancelar.Image = global::CoolSoft.Properties.Resources.clear;
            this.bCancelar.Location = new System.Drawing.Point(667, 7);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(119, 79);
            this.bCancelar.TabIndex = 3;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bBuscarCliente
            // 
            this.bBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarCliente.Image = global::CoolSoft.Properties.Resources.search;
            this.bBuscarCliente.Location = new System.Drawing.Point(541, 7);
            this.bBuscarCliente.Name = "bBuscarCliente";
            this.bBuscarCliente.Size = new System.Drawing.Size(119, 79);
            this.bBuscarCliente.TabIndex = 21;
            this.bBuscarCliente.Text = "Buscar";
            this.bBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 234);
            this.dataGridView1.TabIndex = 23;
            // 
            // bSeleccionarCliente
            // 
            this.bSeleccionarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSeleccionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeleccionarCliente.Image = global::CoolSoft.Properties.Resources.ok;
            this.bSeleccionarCliente.Location = new System.Drawing.Point(594, 6);
            this.bSeleccionarCliente.Name = "bSeleccionarCliente";
            this.bSeleccionarCliente.Size = new System.Drawing.Size(194, 59);
            this.bSeleccionarCliente.TabIndex = 24;
            this.bSeleccionarCliente.Text = "Seleccionar";
            this.bSeleccionarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bSeleccionarCliente.UseVisualStyleBackColor = true;
            // 
            // mtId
            // 
            this.mtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtId.Location = new System.Drawing.Point(16, 39);
            this.mtId.Mask = "99999999999";
            this.mtId.Name = "mtId";
            this.mtId.PromptChar = ' ';
            this.mtId.Size = new System.Drawing.Size(180, 34);
            this.mtId.TabIndex = 25;
            this.mtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lId.Location = new System.Drawing.Point(11, 7);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(79, 29);
            this.lId.TabIndex = 26;
            this.lId.Text = "label1";
            // 
            // pSeleccion
            // 
            this.pSeleccion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pSeleccion.Controls.Add(this.dataGridView1);
            this.pSeleccion.Controls.Add(this.bSeleccionarCliente);
            this.pSeleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSeleccion.Location = new System.Drawing.Point(0, 160);
            this.pSeleccion.Name = "pSeleccion";
            this.pSeleccion.Size = new System.Drawing.Size(800, 303);
            this.pSeleccion.TabIndex = 28;
            // 
            // Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.pSeleccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Seleccion";
            this.Text = "Seleccion";
            this.Load += new System.EventHandler(this.Seleccion_Load);
            this.Controls.SetChildIndex(this.pTitulo, 0);
            this.Controls.SetChildIndex(this.pMenu, 0);
            this.Controls.SetChildIndex(this.pSeleccion, 0);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pSeleccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button bCancelar;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button bSeleccionarCliente;
        public System.Windows.Forms.MaskedTextBox mtId;
        public System.Windows.Forms.Label lId;
        public System.Windows.Forms.Panel pSeleccion;
        public System.Windows.Forms.Button bBuscarCliente;
    }
}