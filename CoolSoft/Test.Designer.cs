namespace connect
{
    partial class Test
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbcNombre = new System.Windows.Forms.TextBox();
            this.tbcDomicilio = new System.Windows.Forms.TextBox();
            this.tbcTelefono = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.Transaccion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.AgregarPersona = new System.Windows.Forms.Button();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxIDCLIENTE = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(98, 15);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(98, 20);
            this.txtServidor.TabIndex = 1;
            this.txtServidor.Text = "localhost";
            // 
            // Puerto
            // 
            this.Puerto.AutoSize = true;
            this.Puerto.Location = new System.Drawing.Point(8, 39);
            this.Puerto.Name = "Puerto";
            this.Puerto.Size = new System.Drawing.Size(38, 13);
            this.Puerto.TabIndex = 2;
            this.Puerto.Text = "Puerto";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(98, 39);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(98, 20);
            this.txtPuerto.TabIndex = 3;
            this.txtPuerto.Text = "3306";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(98, 67);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(98, 20);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(98, 91);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(98, 20);
            this.txtContraseña.TabIndex = 7;
            this.txtContraseña.Text = "galtech";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(10, 122);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(138, 37);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(248, 108);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(76, 20);
            this.tbNombre.TabIndex = 9;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(248, 132);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(76, 20);
            this.tbApellido.TabIndex = 10;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(248, 85);
            this.tbDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDni.Mask = "99999999";
            this.tbDni.Name = "tbDni";
            this.tbDni.PromptChar = ' ';
            this.tbDni.Size = new System.Drawing.Size(76, 20);
            this.tbDni.TabIndex = 11;
            this.tbDni.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cargar Persona";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 386);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 19);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ver Persona";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbIdOrden
            // 
            this.tbIdOrden.Location = new System.Drawing.Point(353, 11);
            this.tbIdOrden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbIdOrden.Name = "tbIdOrden";
            this.tbIdOrden.Size = new System.Drawing.Size(76, 20);
            this.tbIdOrden.TabIndex = 15;
            this.tbIdOrden.Text = "IdOrden";
            // 
            // tbFechaRecepcion
            // 
            this.tbFechaRecepcion.Location = new System.Drawing.Point(353, 34);
            this.tbFechaRecepcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFechaRecepcion.Name = "tbFechaRecepcion";
            this.tbFechaRecepcion.Size = new System.Drawing.Size(76, 20);
            this.tbFechaRecepcion.TabIndex = 16;
            this.tbFechaRecepcion.Text = "FechaRecepcion";
            // 
            // tbTareaDesarrollada
            // 
            this.tbTareaDesarrollada.Location = new System.Drawing.Point(353, 80);
            this.tbTareaDesarrollada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTareaDesarrollada.Name = "tbTareaDesarrollada";
            this.tbTareaDesarrollada.Size = new System.Drawing.Size(76, 20);
            this.tbTareaDesarrollada.TabIndex = 17;
            this.tbTareaDesarrollada.Text = "TareaDesarrollada";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(353, 103);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(76, 20);
            this.tbPrecio.TabIndex = 18;
            this.tbPrecio.Text = "Precio";
            // 
            // tbTareaADesarrollar
            // 
            this.tbTareaADesarrollar.Location = new System.Drawing.Point(353, 57);
            this.tbTareaADesarrollar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTareaADesarrollar.Name = "tbTareaADesarrollar";
            this.tbTareaADesarrollar.Size = new System.Drawing.Size(76, 20);
            this.tbTareaADesarrollar.TabIndex = 19;
            this.tbTareaADesarrollar.Text = "TareaADesarrollar";
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.Location = new System.Drawing.Point(353, 126);
            this.tbIdCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(76, 20);
            this.tbIdCliente.TabIndex = 20;
            this.tbIdCliente.Text = "IdCliente";
            // 
            // tbCompletado
            // 
            this.tbCompletado.Location = new System.Drawing.Point(353, 150);
            this.tbCompletado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCompletado.Name = "tbCompletado";
            this.tbCompletado.Size = new System.Drawing.Size(76, 20);
            this.tbCompletado.TabIndex = 21;
            this.tbCompletado.Text = "Completado";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 173);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 28);
            this.button3.TabIndex = 22;
            this.button3.Text = "Cargar Orden";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(360, 386);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 19);
            this.button4.TabIndex = 24;
            this.button4.Text = "Ver Orden";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 214);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(296, 154);
            this.dataGridView1.TabIndex = 25;
            // 
            // tbcNombre
            // 
            this.tbcNombre.Location = new System.Drawing.Point(9, 32);
            this.tbcNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcNombre.Name = "tbcNombre";
            this.tbcNombre.Size = new System.Drawing.Size(76, 20);
            this.tbcNombre.TabIndex = 27;
            this.tbcNombre.Text = "Nombre";
            // 
            // tbcDomicilio
            // 
            this.tbcDomicilio.Location = new System.Drawing.Point(9, 56);
            this.tbcDomicilio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcDomicilio.Name = "tbcDomicilio";
            this.tbcDomicilio.Size = new System.Drawing.Size(76, 20);
            this.tbcDomicilio.TabIndex = 28;
            this.tbcDomicilio.Text = "Domicilio";
            // 
            // tbcTelefono
            // 
            this.tbcTelefono.Location = new System.Drawing.Point(9, 80);
            this.tbcTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcTelefono.Name = "tbcTelefono";
            this.tbcTelefono.Size = new System.Drawing.Size(76, 20);
            this.tbcTelefono.TabIndex = 29;
            this.tbcTelefono.Text = "Telefono";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(469, 386);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 19);
            this.button6.TabIndex = 34;
            this.button6.Text = "Ver Cliente";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(131, 143);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(76, 20);
            this.textBoxNombre.TabIndex = 35;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(131, 166);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(76, 20);
            this.textBoxApellido.TabIndex = 36;
            // 
            // Transaccion
            // 
            this.Transaccion.Location = new System.Drawing.Point(58, 339);
            this.Transaccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Transaccion.Name = "Transaccion";
            this.Transaccion.Size = new System.Drawing.Size(108, 24);
            this.Transaccion.TabIndex = 37;
            this.Transaccion.Text = "Cargar en bd";
            this.Transaccion.UseVisualStyleBackColor = true;
            this.Transaccion.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxDni);
            this.panel1.Controls.Add(this.AgregarPersona);
            this.panel1.Controls.Add(this.tbcTelefono);
            this.panel1.Controls.Add(this.dgvPersona);
            this.panel1.Controls.Add(this.tbcDomicilio);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.tbcNombre);
            this.panel1.Controls.Add(this.Transaccion);
            this.panel1.Controls.Add(this.textBoxApellido);
            this.panel1.Location = new System.Drawing.Point(576, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 367);
            this.panel1.TabIndex = 38;
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(131, 120);
            this.textBoxDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(76, 20);
            this.textBoxDni.TabIndex = 40;
            // 
            // AgregarPersona
            // 
            this.AgregarPersona.Location = new System.Drawing.Point(98, 188);
            this.AgregarPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AgregarPersona.Name = "AgregarPersona";
            this.AgregarPersona.Size = new System.Drawing.Size(108, 19);
            this.AgregarPersona.TabIndex = 39;
            this.AgregarPersona.Text = "AgregarPersona";
            this.AgregarPersona.UseVisualStyleBackColor = true;
            this.AgregarPersona.Click += new System.EventHandler(this.AgregarPersona_Click);
            // 
            // dgvPersona
            // 
            this.dgvPersona.AllowUserToAddRows = false;
            this.dgvPersona.AllowUserToDeleteRows = false;
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.Location = new System.Drawing.Point(20, 212);
            this.dgvPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.ReadOnly = true;
            this.dgvPersona.RowHeadersWidth = 51;
            this.dgvPersona.RowTemplate.Height = 24;
            this.dgvPersona.Size = new System.Drawing.Size(186, 122);
            this.dgvPersona.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxIDCLIENTE);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Location = new System.Drawing.Point(19, 288);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 81);
            this.panel2.TabIndex = 39;
            // 
            // textBoxIDCLIENTE
            // 
            this.textBoxIDCLIENTE.Location = new System.Drawing.Point(10, 8);
            this.textBoxIDCLIENTE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIDCLIENTE.Name = "textBoxIDCLIENTE";
            this.textBoxIDCLIENTE.Size = new System.Drawing.Size(76, 20);
            this.textBoxIDCLIENTE.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(10, 31);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 30);
            this.button7.TabIndex = 0;
            this.button7.Text = "ObtenerIdCliente";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnConectar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtServidor);
            this.panel3.Controls.Add(this.Puerto);
            this.panel3.Controls.Add(this.txtPuerto);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtUsuario);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtContraseña);
            this.panel3.Location = new System.Drawing.Point(9, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 167);
            this.panel3.TabIndex = 40;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 440);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Name = "Test";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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

        private System.Windows.Forms.BindingSource personaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbcNombre;
        private System.Windows.Forms.TextBox tbcDomicilio;
        private System.Windows.Forms.TextBox tbcTelefono;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Button Transaccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Button AgregarPersona;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxIDCLIENTE;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
    }
}

