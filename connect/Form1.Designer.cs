namespace connect
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.Puerto = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.biosgastroDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biosgastroDataSet = new CoolSoft.biosgastroDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.tbIdOrden = new System.Windows.Forms.TextBox();
            this.tbFechaRecepcion = new System.Windows.Forms.TextBox();
            this.tbTareaDesarrollada = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbTareaADesarrollar = new System.Windows.Forms.TextBox();
            this.tbIdCliente = new System.Windows.Forms.TextBox();
            this.tbCompletado = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new CoolSoft.biosgastroDataSetTableAdapters.clienteTableAdapter();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaTableAdapter = new CoolSoft.biosgastroDataSetTableAdapters.personaTableAdapter();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new CoolSoft.biosgastroDataSetTableAdapters.materialTableAdapter();
            this.personaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biosgastroDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biosgastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(143, 13);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(4);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(293, 22);
            this.txtServidor.TabIndex = 1;
            this.txtServidor.Text = "localhost";
            // 
            // Puerto
            // 
            this.Puerto.AutoSize = true;
            this.Puerto.Location = new System.Drawing.Point(23, 88);
            this.Puerto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Puerto.Name = "Puerto";
            this.Puerto.Size = new System.Drawing.Size(50, 17);
            this.Puerto.TabIndex = 2;
            this.Puerto.Text = "Puerto";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(143, 88);
            this.txtPuerto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(293, 22);
            this.txtPuerto.TabIndex = 3;
            this.txtPuerto.Text = "3306";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(143, 154);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(293, 22);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(143, 241);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(293, 22);
            this.txtContraseña.TabIndex = 7;
            this.txtContraseña.Text = "galtech";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(191, 340);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(184, 46);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(539, 64);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 22);
            this.tbNombre.TabIndex = 9;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(539, 106);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(100, 22);
            this.tbApellido.TabIndex = 10;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(539, 21);
            this.tbDni.Mask = "99999999";
            this.tbDni.Name = "tbDni";
            this.tbDni.PromptChar = ' ';
            this.tbDni.Size = new System.Drawing.Size(100, 22);
            this.tbDni.TabIndex = 11;
            this.tbDni.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(539, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 217);
            this.dataGridView1.TabIndex = 13;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            this.dniDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // personaBindingSource1
            // 
            this.personaBindingSource1.DataMember = "persona";
            this.personaBindingSource1.DataSource = this.biosgastroDataSetBindingSource;
            // 
            // biosgastroDataSetBindingSource
            // 
            this.biosgastroDataSetBindingSource.DataSource = this.biosgastroDataSet;
            this.biosgastroDataSetBindingSource.Position = 0;
            // 
            // biosgastroDataSet
            // 
            this.biosgastroDataSet.DataSetName = "biosgastroDataSet";
            this.biosgastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ver tabla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbIdOrden
            // 
            this.tbIdOrden.Location = new System.Drawing.Point(959, 21);
            this.tbIdOrden.Name = "tbIdOrden";
            this.tbIdOrden.Size = new System.Drawing.Size(100, 22);
            this.tbIdOrden.TabIndex = 15;
            this.tbIdOrden.Text = "IdOrden";
            // 
            // tbFechaRecepcion
            // 
            this.tbFechaRecepcion.Location = new System.Drawing.Point(959, 49);
            this.tbFechaRecepcion.Name = "tbFechaRecepcion";
            this.tbFechaRecepcion.Size = new System.Drawing.Size(100, 22);
            this.tbFechaRecepcion.TabIndex = 16;
            this.tbFechaRecepcion.Text = "FechaRecepcion";
            // 
            // tbTareaDesarrollada
            // 
            this.tbTareaDesarrollada.Location = new System.Drawing.Point(959, 106);
            this.tbTareaDesarrollada.Name = "tbTareaDesarrollada";
            this.tbTareaDesarrollada.Size = new System.Drawing.Size(100, 22);
            this.tbTareaDesarrollada.TabIndex = 17;
            this.tbTareaDesarrollada.Text = "TareaDesarrollada";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(959, 134);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 22);
            this.tbPrecio.TabIndex = 18;
            this.tbPrecio.Text = "Precio";
            // 
            // tbTareaADesarrollar
            // 
            this.tbTareaADesarrollar.Location = new System.Drawing.Point(959, 77);
            this.tbTareaADesarrollar.Name = "tbTareaADesarrollar";
            this.tbTareaADesarrollar.Size = new System.Drawing.Size(100, 22);
            this.tbTareaADesarrollar.TabIndex = 19;
            this.tbTareaADesarrollar.Text = "TareaADesarrollar";
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.Location = new System.Drawing.Point(959, 162);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(100, 22);
            this.tbIdCliente.TabIndex = 20;
            this.tbIdCliente.Text = "IdCliente";
            // 
            // tbCompletado
            // 
            this.tbCompletado.Location = new System.Drawing.Point(959, 192);
            this.tbCompletado.Name = "tbCompletado";
            this.tbCompletado.Size = new System.Drawing.Size(100, 22);
            this.tbCompletado.TabIndex = 21;
            this.tbCompletado.Text = "Completado";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1123, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Cargar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(959, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Ver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.biosgastroDataSetBindingSource;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "persona";
            this.personaBindingSource.DataSource = this.biosgastroDataSetBindingSource;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "material";
            this.materialBindingSource.DataSource = this.biosgastroDataSetBindingSource;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // personaBindingSource2
            // 
            this.personaBindingSource2.DataMember = "persona";
            this.personaBindingSource2.DataSource = this.biosgastroDataSetBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 554);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbCompletado);
            this.Controls.Add(this.tbIdCliente);
            this.Controls.Add(this.tbTareaADesarrollar);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbTareaDesarrollada);
            this.Controls.Add(this.tbFechaRecepcion);
            this.Controls.Add(this.tbIdOrden);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.Puerto);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biosgastroDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biosgastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label Puerto;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.MaskedTextBox tbDni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbIdOrden;
        private System.Windows.Forms.TextBox tbFechaRecepcion;
        private System.Windows.Forms.TextBox tbTareaDesarrollada;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbTareaADesarrollar;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.TextBox tbCompletado;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource biosgastroDataSetBindingSource;
        private CoolSoft.biosgastroDataSet biosgastroDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private CoolSoft.biosgastroDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private CoolSoft.biosgastroDataSetTableAdapters.personaTableAdapter personaTableAdapter;
        private System.Windows.Forms.BindingSource personaBindingSource1;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private CoolSoft.biosgastroDataSetTableAdapters.materialTableAdapter materialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personaBindingSource2;
    }
}

