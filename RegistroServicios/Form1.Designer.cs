namespace RegistroServicios
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_cliente = new System.Windows.Forms.ComboBox();
            this.vUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_reparacionDataSet1 = new RegistroServicios.bd_reparacionDataSet1();
            this.combo_servicio = new System.Windows.Forms.ComboBox();
            this.tipoServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_reparacionDataSet3 = new RegistroServicios.bd_reparacionDataSet3();
            this.num_precio = new System.Windows.Forms.NumericUpDown();
            this.clientePlus = new System.Windows.Forms.Button();
            this.servicioPlus = new System.Windows.Forms.Button();
            this.bd_reparacionDataSet = new RegistroServicios.bd_reparacionDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new RegistroServicios.bd_reparacionDataSetTableAdapters.UsuarioTableAdapter();
            this.vUsersTableAdapter = new RegistroServicios.bd_reparacionDataSet1TableAdapters.vUsersTableAdapter();
            this.bd_reparacionDataSet2 = new RegistroServicios.bd_reparacionDataSet2();
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioTableAdapter = new RegistroServicios.bd_reparacionDataSet2TableAdapters.ServicioTableAdapter();
            this.tipoServicioTableAdapter = new RegistroServicios.bd_reparacionDataSet3TableAdapters.TipoServicioTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_reparacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_reparacionDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_reparacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_reparacionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Servicios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // combo_cliente
            // 
            this.combo_cliente.DataSource = this.vUsersBindingSource;
            this.combo_cliente.DisplayMember = "Nombre";
            this.combo_cliente.FormattingEnabled = true;
            this.combo_cliente.Location = new System.Drawing.Point(84, 73);
            this.combo_cliente.Name = "combo_cliente";
            this.combo_cliente.Size = new System.Drawing.Size(150, 21);
            this.combo_cliente.TabIndex = 4;
            this.combo_cliente.ValueMember = "idUsuario";
            // 
            // vUsersBindingSource
            // 
            this.vUsersBindingSource.DataMember = "vUsers";
            this.vUsersBindingSource.DataSource = this.bd_reparacionDataSet1;
            // 
            // bd_reparacionDataSet1
            // 
            this.bd_reparacionDataSet1.DataSetName = "bd_reparacionDataSet1";
            this.bd_reparacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combo_servicio
            // 
            this.combo_servicio.DataSource = this.tipoServicioBindingSource;
            this.combo_servicio.DisplayMember = "nombreTipoServicio";
            this.combo_servicio.FormattingEnabled = true;
            this.combo_servicio.Location = new System.Drawing.Point(84, 100);
            this.combo_servicio.Name = "combo_servicio";
            this.combo_servicio.Size = new System.Drawing.Size(150, 21);
            this.combo_servicio.TabIndex = 5;
            this.combo_servicio.ValueMember = "idTipoServicio";
            // 
            // tipoServicioBindingSource
            // 
            this.tipoServicioBindingSource.DataMember = "TipoServicio";
            this.tipoServicioBindingSource.DataSource = this.bd_reparacionDataSet3;
            // 
            // bd_reparacionDataSet3
            // 
            this.bd_reparacionDataSet3.DataSetName = "bd_reparacionDataSet3";
            this.bd_reparacionDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // num_precio
            // 
            this.num_precio.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_precio.Location = new System.Drawing.Point(84, 127);
            this.num_precio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_precio.Name = "num_precio";
            this.num_precio.Size = new System.Drawing.Size(150, 20);
            this.num_precio.TabIndex = 6;
            this.num_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_precio.ThousandsSeparator = true;
            // 
            // clientePlus
            // 
            this.clientePlus.Location = new System.Drawing.Point(240, 72);
            this.clientePlus.Name = "clientePlus";
            this.clientePlus.Size = new System.Drawing.Size(25, 23);
            this.clientePlus.TabIndex = 7;
            this.clientePlus.Text = "+";
            this.clientePlus.UseVisualStyleBackColor = true;
            // 
            // servicioPlus
            // 
            this.servicioPlus.Location = new System.Drawing.Point(240, 99);
            this.servicioPlus.Name = "servicioPlus";
            this.servicioPlus.Size = new System.Drawing.Size(25, 23);
            this.servicioPlus.TabIndex = 8;
            this.servicioPlus.Text = "+";
            this.servicioPlus.UseVisualStyleBackColor = true;
            // 
            // bd_reparacionDataSet
            // 
            this.bd_reparacionDataSet.DataSetName = "bd_reparacionDataSet";
            this.bd_reparacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.bd_reparacionDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // vUsersTableAdapter
            // 
            this.vUsersTableAdapter.ClearBeforeFill = true;
            // 
            // bd_reparacionDataSet2
            // 
            this.bd_reparacionDataSet2.DataSetName = "bd_reparacionDataSet2";
            this.bd_reparacionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "Servicio";
            this.servicioBindingSource.DataSource = this.bd_reparacionDataSet2;
            // 
            // servicioTableAdapter
            // 
            this.servicioTableAdapter.ClearBeforeFill = true;
            // 
            // tipoServicioTableAdapter
            // 
            this.tipoServicioTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 31);
            this.button3.TabIndex = 9;
            this.button3.Text = "Ingresar Registro";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 196);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.servicioPlus);
            this.Controls.Add(this.clientePlus);
            this.Controls.Add(this.num_precio);
            this.Controls.Add(this.combo_servicio);
            this.Controls.Add(this.combo_cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_reparacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_reparacionDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_reparacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_reparacionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_cliente;
        private System.Windows.Forms.ComboBox combo_servicio;
        private System.Windows.Forms.NumericUpDown num_precio;
        private System.Windows.Forms.Button clientePlus;
        private System.Windows.Forms.Button servicioPlus;
        private bd_reparacionDataSet bd_reparacionDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private bd_reparacionDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private bd_reparacionDataSet1 bd_reparacionDataSet1;
        private System.Windows.Forms.BindingSource vUsersBindingSource;
        private bd_reparacionDataSet1TableAdapters.vUsersTableAdapter vUsersTableAdapter;
        private bd_reparacionDataSet2 bd_reparacionDataSet2;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private bd_reparacionDataSet2TableAdapters.ServicioTableAdapter servicioTableAdapter;
        private bd_reparacionDataSet3 bd_reparacionDataSet3;
        private System.Windows.Forms.BindingSource tipoServicioBindingSource;
        private bd_reparacionDataSet3TableAdapters.TipoServicioTableAdapter tipoServicioTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}

