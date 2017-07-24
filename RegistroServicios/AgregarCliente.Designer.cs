namespace RegistroServicios
{
    partial class AgregarCliente
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_ciudad = new System.Windows.Forms.ComboBox();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_reparacionDataSet4 = new RegistroServicios.bd_reparacionDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bd_reparacionDataSet = new RegistroServicios.bd_reparacionDataSet();
            this.bdreparacionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadTableAdapter = new RegistroServicios.bd_reparacionDataSet4TableAdapters.CiudadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_reparacionDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_reparacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdreparacionDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres";
            // 
            // combo_ciudad
            // 
            this.combo_ciudad.DataSource = this.ciudadBindingSource;
            this.combo_ciudad.DisplayMember = "nombreCiudad";
            this.combo_ciudad.FormattingEnabled = true;
            this.combo_ciudad.Location = new System.Drawing.Point(89, 133);
            this.combo_ciudad.Name = "combo_ciudad";
            this.combo_ciudad.Size = new System.Drawing.Size(150, 21);
            this.combo_ciudad.TabIndex = 8;
            this.combo_ciudad.ValueMember = "idCiudad";
            // 
            // ciudadBindingSource
            // 
            this.ciudadBindingSource.DataMember = "Ciudad";
            this.ciudadBindingSource.DataSource = this.bd_reparacionDataSet4;
            // 
            // bd_reparacionDataSet4
            // 
            this.bd_reparacionDataSet4.DataSetName = "bd_reparacionDataSet4";
            this.bd_reparacionDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(44, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cliente Nuevo";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(89, 55);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(150, 20);
            this.txt_nombre.TabIndex = 11;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(89, 107);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(150, 20);
            this.txt_telefono.TabIndex = 12;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(89, 81);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(150, 20);
            this.txt_apellido.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefono";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agregar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bd_reparacionDataSet
            // 
            this.bd_reparacionDataSet.DataSetName = "bd_reparacionDataSet";
            this.bd_reparacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdreparacionDataSetBindingSource
            // 
            this.bdreparacionDataSetBindingSource.DataSource = this.bd_reparacionDataSet;
            this.bdreparacionDataSetBindingSource.Position = 0;
            // 
            // ciudadTableAdapter
            // 
            this.ciudadTableAdapter.ClearBeforeFill = true;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_ciudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_reparacionDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_reparacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdreparacionDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_ciudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bdreparacionDataSetBindingSource;
        private bd_reparacionDataSet bd_reparacionDataSet;
        private bd_reparacionDataSet4 bd_reparacionDataSet4;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        private bd_reparacionDataSet4TableAdapters.CiudadTableAdapter ciudadTableAdapter;
    }
}