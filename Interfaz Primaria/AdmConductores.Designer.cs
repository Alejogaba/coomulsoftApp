namespace Interfaz_Primaria
{
    partial class AdmConductores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmConductores));
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dataGridAddConductores = new System.Windows.Forms.DataGridView();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelapellidos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEstadoLicencia = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MarcoDeFoto = new System.Windows.Forms.PictureBox();
            this.dtimeLicVence = new System.Windows.Forms.DateTimePicker();
            this.dtimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.btnBorrarFoto = new System.Windows.Forms.Button();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.ofdSeleccionarImagen = new System.Windows.Forms.OpenFileDialog();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.comboBoxBuscarPorCedula = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddConductores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcoDeFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinalizar.Location = new System.Drawing.Point(377, 577);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(74, 25);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dataGridAddConductores
            // 
            this.dataGridAddConductores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAddConductores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.dataGridAddConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAddConductores.Location = new System.Drawing.Point(215, 374);
            this.dataGridAddConductores.Name = "dataGridAddConductores";
            this.dataGridAddConductores.Size = new System.Drawing.Size(581, 197);
            this.dataGridAddConductores.TabIndex = 17;
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(90, 67);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(49, 13);
            this.labelnombre.TabIndex = 0;
            this.labelnombre.Text = "Nombres";
            this.labelnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelapellidos
            // 
            this.labelapellidos.AutoSize = true;
            this.labelapellidos.Location = new System.Drawing.Point(90, 101);
            this.labelapellidos.Name = "labelapellidos";
            this.labelapellidos.Size = new System.Drawing.Size(55, 13);
            this.labelapellidos.TabIndex = 4;
            this.labelapellidos.Text = "Aapellidos";
            this.labelapellidos.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado Licencia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(197, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(227, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(197, 165);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(227, 20);
            this.txtLicencia.TabIndex = 11;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(197, 98);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(227, 20);
            this.txtApellidos.TabIndex = 13;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(197, 64);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(227, 20);
            this.txtNombres.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(857, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 38);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.TabStop = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(197, 304);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(227, 20);
            this.txtTelefono.TabIndex = 21;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(197, 269);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(227, 20);
            this.txtDireccion.TabIndex = 22;
            // 
            // txtEstadoLicencia
            // 
            this.txtEstadoLicencia.Location = new System.Drawing.Point(198, 236);
            this.txtEstadoLicencia.Name = "txtEstadoLicencia";
            this.txtEstadoLicencia.Size = new System.Drawing.Size(136, 20);
            this.txtEstadoLicencia.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(197, 339);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha De Nacim..";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Licencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Email @";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Lic. Vence";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(366, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 48);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(579, 577);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 25);
            this.button3.TabIndex = 33;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(479, 577);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 25);
            this.button4.TabIndex = 34;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // MarcoDeFoto
            // 
            this.MarcoDeFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MarcoDeFoto.Image = ((System.Drawing.Image)(resources.GetObject("MarcoDeFoto.Image")));
            this.MarcoDeFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("MarcoDeFoto.InitialImage")));
            this.MarcoDeFoto.Location = new System.Drawing.Point(681, 82);
            this.MarcoDeFoto.Name = "MarcoDeFoto";
            this.MarcoDeFoto.Size = new System.Drawing.Size(163, 168);
            this.MarcoDeFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MarcoDeFoto.TabIndex = 35;
            this.MarcoDeFoto.TabStop = false;
            // 
            // dtimeLicVence
            // 
            this.dtimeLicVence.Location = new System.Drawing.Point(197, 200);
            this.dtimeLicVence.Name = "dtimeLicVence";
            this.dtimeLicVence.Size = new System.Drawing.Size(137, 20);
            this.dtimeLicVence.TabIndex = 36;
            // 
            // dtimeFechaNacimiento
            // 
            this.dtimeFechaNacimiento.Location = new System.Drawing.Point(198, 132);
            this.dtimeFechaNacimiento.Name = "dtimeFechaNacimiento";
            this.dtimeFechaNacimiento.Size = new System.Drawing.Size(226, 20);
            this.dtimeFechaNacimiento.TabIndex = 37;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnCargarFoto.FlatAppearance.BorderSize = 0;
            this.btnCargarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarFoto.Image")));
            this.btnCargarFoto.Location = new System.Drawing.Point(681, 256);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(78, 44);
            this.btnCargarFoto.TabIndex = 38;
            this.btnCargarFoto.UseVisualStyleBackColor = false;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // btnBorrarFoto
            // 
            this.btnBorrarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnBorrarFoto.FlatAppearance.BorderSize = 0;
            this.btnBorrarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarFoto.Image")));
            this.btnBorrarFoto.Location = new System.Drawing.Point(766, 256);
            this.btnBorrarFoto.Name = "btnBorrarFoto";
            this.btnBorrarFoto.Size = new System.Drawing.Size(78, 44);
            this.btnBorrarFoto.TabIndex = 39;
            this.btnBorrarFoto.UseVisualStyleBackColor = false;
            // 
            // ofdSeleccionarImagen
            // 
            this.ofdSeleccionarImagen.FileName = "openFileDialog1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(760, 339);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 33);
            this.btnRefresh.TabIndex = 41;
            this.btnRefresh.TabStop = false;
            // 
            // comboBoxBuscarPorCedula
            // 
            this.comboBoxBuscarPorCedula.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxBuscarPorCedula.FormattingEnabled = true;
            this.comboBoxBuscarPorCedula.Location = new System.Drawing.Point(618, 33);
            this.comboBoxBuscarPorCedula.Name = "comboBoxBuscarPorCedula";
            this.comboBoxBuscarPorCedula.Size = new System.Drawing.Size(226, 21);
            this.comboBoxBuscarPorCedula.TabIndex = 42;
            this.comboBoxBuscarPorCedula.Text = "      BUSCAR POR NUMERO DE CEDULA";
            this.comboBoxBuscarPorCedula.Enter += new System.EventHandler(this.comboBoxBuscarPorCedula_Enter);
            this.comboBoxBuscarPorCedula.Leave += new System.EventHandler(this.comboBoxBuscarPorCedula_Leave);
            // 
            // AdmConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 610);
            this.Controls.Add(this.comboBoxBuscarPorCedula);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.MarcoDeFoto);
            this.Controls.Add(this.btnBorrarFoto);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.dtimeFechaNacimiento);
            this.Controls.Add(this.dtimeLicVence);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEstadoLicencia);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.dataGridAddConductores);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelapellidos);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.labelnombre);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmConductores";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddConductores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcoDeFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dataGridAddConductores;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelapellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEstadoLicencia;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox MarcoDeFoto;
        private System.Windows.Forms.DateTimePicker dtimeLicVence;
        private System.Windows.Forms.DateTimePicker dtimeFechaNacimiento;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.Button btnBorrarFoto;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.OpenFileDialog ofdSeleccionarImagen;
        private System.Windows.Forms.PictureBox btnRefresh;
        private System.Windows.Forms.ComboBox comboBoxBuscarPorCedula;
    }
}