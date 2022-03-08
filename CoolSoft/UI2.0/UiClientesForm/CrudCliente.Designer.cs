
namespace CoolSoft.UI2._0.UiClientesForm
{
    partial class CrudCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.buttonLimpiarSeleccion = new System.Windows.Forms.Button();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonRefrescar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonVer = new System.Windows.Forms.Button();
            this.buttonDetalles = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelSuperior, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelMenu, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 537);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panelSuperior, 2);
            this.panelSuperior.Controls.Add(this.buttonLimpiarSeleccion);
            this.panelSuperior.Controls.Add(this.textBoxDni);
            this.panelSuperior.Controls.Add(this.label4);
            this.panelSuperior.Controls.Add(this.label5);
            this.panelSuperior.Controls.Add(this.buttonBuscar);
            this.panelSuperior.Controls.Add(this.textBoxNombre);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSuperior.Location = new System.Drawing.Point(2, 2);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(766, 61);
            this.panelSuperior.TabIndex = 1;
            // 
            // buttonLimpiarSeleccion
            // 
            this.buttonLimpiarSeleccion.BackColor = System.Drawing.Color.Pink;
            this.buttonLimpiarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiarSeleccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiarSeleccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLimpiarSeleccion.Image = global::CoolSoft.Properties.Resources.limpiar;
            this.buttonLimpiarSeleccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpiarSeleccion.Location = new System.Drawing.Point(492, 24);
            this.buttonLimpiarSeleccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLimpiarSeleccion.Name = "buttonLimpiarSeleccion";
            this.buttonLimpiarSeleccion.Size = new System.Drawing.Size(174, 30);
            this.buttonLimpiarSeleccion.TabIndex = 17;
            this.buttonLimpiarSeleccion.Text = "Limpiar Selección";
            this.buttonLimpiarSeleccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLimpiarSeleccion.UseVisualStyleBackColor = false;
            this.buttonLimpiarSeleccion.Click += new System.EventHandler(this.buttonLimpiarSeleccion_Click);
            // 
            // textBoxDni
            // 
            this.textBoxDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDni.Location = new System.Drawing.Point(17, 28);
            this.textBoxDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDni.MaxLength = 11;
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(110, 26);
            this.textBoxDni.TabIndex = 0;
            this.textBoxDni.TextChanged += new System.EventHandler(this.textBoxDni_TextChanged);
            this.textBoxDni.Enter += new System.EventHandler(this.textBoxDni_Enter);
            this.textBoxDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDni_KeyPress);
            this.textBoxDni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxDni_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dni - Cuit";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBuscar.Image = global::CoolSoft.Properties.Resources.search;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(374, 24);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(114, 30);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(147, 28);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(213, 26);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.Enter += new System.EventHandler(this.textBoxNombre_Enter);
            this.textBoxNombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxNombre_MouseDown);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 403);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panelMenu
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelMenu, 2);
            this.panelMenu.Controls.Add(this.buttonRefrescar);
            this.panelMenu.Controls.Add(this.buttonCancelar);
            this.panelMenu.Controls.Add(this.buttonVer);
            this.panelMenu.Controls.Add(this.buttonDetalles);
            this.panelMenu.Controls.Add(this.buttonAgregar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(2, 474);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(766, 61);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefrescar.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonRefrescar.FlatAppearance.BorderSize = 0;
            this.buttonRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefrescar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefrescar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRefrescar.Image = global::CoolSoft.Properties.Resources.refresh;
            this.buttonRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefrescar.Location = new System.Drawing.Point(392, 2);
            this.buttonRefrescar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(114, 44);
            this.buttonRefrescar.TabIndex = 1;
            this.buttonRefrescar.Text = "Refrescar";
            this.buttonRefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefrescar.UseVisualStyleBackColor = false;
            this.buttonRefrescar.Click += new System.EventHandler(this.buttonRefrescar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.Image = global::CoolSoft.Properties.Resources.cancel;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(652, 2);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(114, 44);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonVer
            // 
            this.buttonVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVer.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVer.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVer.Image = global::CoolSoft.Properties.Resources.check;
            this.buttonVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVer.Location = new System.Drawing.Point(532, 2);
            this.buttonVer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(114, 44);
            this.buttonVer.TabIndex = 0;
            this.buttonVer.Text = "Ver";
            this.buttonVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonVer.UseVisualStyleBackColor = false;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // buttonDetalles
            // 
            this.buttonDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.buttonDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetalles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetalles.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDetalles.Image = global::CoolSoft.Properties.Resources.edit;
            this.buttonDetalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDetalles.Location = new System.Drawing.Point(118, 2);
            this.buttonDetalles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDetalles.Name = "buttonDetalles";
            this.buttonDetalles.Size = new System.Drawing.Size(114, 44);
            this.buttonDetalles.TabIndex = 4;
            this.buttonDetalles.Text = "Detalles";
            this.buttonDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDetalles.UseVisualStyleBackColor = false;
            this.buttonDetalles.Click += new System.EventHandler(this.buttonDetalles_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAgregar.Image = global::CoolSoft.Properties.Resources.add;
            this.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregar.Location = new System.Drawing.Point(0, 2);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(114, 44);
            this.buttonAgregar.TabIndex = 3;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // CrudCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(788, 557);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrudCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CrudCliente_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelSuperior;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.TextBox textBoxNombre;
        public System.Windows.Forms.Button buttonAgregar;
        public System.Windows.Forms.Button buttonBuscar;
        public System.Windows.Forms.Button buttonDetalles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button buttonCancelar;
        public System.Windows.Forms.Button buttonVer;
        public System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Button buttonLimpiarSeleccion;
        public System.Windows.Forms.Button buttonRefrescar;
    }
}