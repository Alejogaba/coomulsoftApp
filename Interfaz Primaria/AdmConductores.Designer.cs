﻿namespace Interfaz_Primaria
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MarcoDeFoto = new System.Windows.Forms.PictureBox();
            this.dtimeLicVence = new System.Windows.Forms.DateTimePicker();
            this.dtimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.btnBorrarFoto = new System.Windows.Forms.Button();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.ofdSeleccionarImagen = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxBuscarPorCedula = new System.Windows.Forms.ComboBox();
            this.conductoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coomulsoftAppDataSet = new Interfaz_Primaria.CoomulsoftAppDataSet();
            this.conductoresTableAdapter = new Interfaz_Primaria.CoomulsoftAppDataSetTableAdapters.ConductoresTableAdapter();
            this.webView1 = new EO.WebBrowser.WebView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLicencia = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MarcoDeFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coomulsoftAppDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLicencia)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.labelnombre.Location = new System.Drawing.Point(37, 62);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(86, 22);
            this.labelnombre.TabIndex = 0;
            this.labelnombre.Text = "Nombres";
            this.labelnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelapellidos
            // 
            this.labelapellidos.AutoSize = true;
            this.labelapellidos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.labelapellidos.Location = new System.Drawing.Point(34, 111);
            this.labelapellidos.Name = "labelapellidos";
            this.labelapellidos.Size = new System.Drawing.Size(87, 22);
            this.labelapellidos.TabIndex = 4;
            this.labelapellidos.Text = "Apellidos";
            this.labelapellidos.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(34, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado Licencia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(37, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(37, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefono";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(77, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Gainsboro;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtId.Location = new System.Drawing.Point(143, 9);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(362, 26);
            this.txtId.TabIndex = 1;
            // 
            // txtLicencia
            // 
            this.txtLicencia.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLicencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicencia.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtLicencia.Location = new System.Drawing.Point(144, 215);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(360, 28);
            this.txtLicencia.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.Gainsboro;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtApellidos.Location = new System.Drawing.Point(143, 105);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(361, 28);
            this.txtApellidos.TabIndex = 3;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtNombres.Location = new System.Drawing.Point(144, 58);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(362, 26);
            this.txtNombres.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtTelefono.Location = new System.Drawing.Point(153, 410);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(352, 28);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtDireccion.Location = new System.Drawing.Point(153, 351);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(352, 28);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtEmail.Location = new System.Drawing.Point(153, 472);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(352, 28);
            this.txtEmail.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(8, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha De Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(37, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Licencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label9.Location = new System.Drawing.Point(46, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 22);
            this.label9.TabIndex = 29;
            this.label9.Text = "Email ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(35, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Licencia Vence";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(590, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 34);
            this.button3.TabIndex = 13;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(333, 538);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 34);
            this.button4.TabIndex = 11;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // MarcoDeFoto
            // 
            this.MarcoDeFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MarcoDeFoto.Image = ((System.Drawing.Image)(resources.GetObject("MarcoDeFoto.Image")));
            this.MarcoDeFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("MarcoDeFoto.InitialImage")));
            this.MarcoDeFoto.Location = new System.Drawing.Point(689, 100);
            this.MarcoDeFoto.Name = "MarcoDeFoto";
            this.MarcoDeFoto.Size = new System.Drawing.Size(186, 215);
            this.MarcoDeFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MarcoDeFoto.TabIndex = 35;
            this.MarcoDeFoto.TabStop = false;
            // 
            // dtimeLicVence
            // 
            this.dtimeLicVence.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeLicVence.Location = new System.Drawing.Point(190, 261);
            this.dtimeLicVence.Name = "dtimeLicVence";
            this.dtimeLicVence.Size = new System.Drawing.Size(304, 24);
            this.dtimeLicVence.TabIndex = 6;
            this.dtimeLicVence.ValueChanged += new System.EventHandler(this.DtimeLicVence_ValueChanged);
            // 
            // dtimeFechaNacimiento
            // 
            this.dtimeFechaNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeFechaNacimiento.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.dtimeFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeFechaNacimiento.Location = new System.Drawing.Point(207, 161);
            this.dtimeFechaNacimiento.Name = "dtimeFechaNacimiento";
            this.dtimeFechaNacimiento.Size = new System.Drawing.Size(299, 22);
            this.dtimeFechaNacimiento.TabIndex = 4;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnCargarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarFoto.FlatAppearance.BorderSize = 0;
            this.btnCargarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarFoto.Image")));
            this.btnCargarFoto.Location = new System.Drawing.Point(689, 335);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(78, 44);
            this.btnCargarFoto.TabIndex = 10;
            this.btnCargarFoto.UseVisualStyleBackColor = false;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // btnBorrarFoto
            // 
            this.btnBorrarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnBorrarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarFoto.FlatAppearance.BorderSize = 0;
            this.btnBorrarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarFoto.Image")));
            this.btnBorrarFoto.Location = new System.Drawing.Point(797, 335);
            this.btnBorrarFoto.Name = "btnBorrarFoto";
            this.btnBorrarFoto.Size = new System.Drawing.Size(78, 44);
            this.btnBorrarFoto.TabIndex = 39;
            this.btnBorrarFoto.UseVisualStyleBackColor = false;
            this.btnBorrarFoto.Click += new System.EventHandler(this.BtnBorrarFoto_Click);
            // 
            // ofdSeleccionarImagen
            // 
            this.ofdSeleccionarImagen.Filter = "JPEG (*.jpg*)|*.JPG|Archivo de mapas de bits (*.bmp*)|*.BMP|PNG (*.png*)|*.PNG*";
            this.ofdSeleccionarImagen.FileOk += new System.ComponentModel.CancelEventHandler(this.OfdSeleccionarImagen_FileOk);
            // 
            // comboBoxBuscarPorCedula
            // 
            this.comboBoxBuscarPorCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBuscarPorCedula.BackColor = System.Drawing.Color.White;
            this.comboBoxBuscarPorCedula.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxBuscarPorCedula.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuscarPorCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.comboBoxBuscarPorCedula.FormattingEnabled = true;
            this.comboBoxBuscarPorCedula.Location = new System.Drawing.Point(725, 19);
            this.comboBoxBuscarPorCedula.Name = "comboBoxBuscarPorCedula";
            this.comboBoxBuscarPorCedula.Size = new System.Drawing.Size(248, 24);
            this.comboBoxBuscarPorCedula.TabIndex = 42;
            this.comboBoxBuscarPorCedula.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBuscarPorCedula_SelectedIndexChanged);
            this.comboBoxBuscarPorCedula.Enter += new System.EventHandler(this.comboBoxBuscarPorCedula_Enter);
            this.comboBoxBuscarPorCedula.Leave += new System.EventHandler(this.comboBoxBuscarPorCedula_Leave);
            // 
            // conductoresBindingSource
            // 
            this.conductoresBindingSource.DataMember = "Conductores";
            this.conductoresBindingSource.DataSource = this.coomulsoftAppDataSet;
            // 
            // coomulsoftAppDataSet
            // 
            this.coomulsoftAppDataSet.DataSetName = "CoomulsoftAppDataSet";
            this.coomulsoftAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conductoresTableAdapter
            // 
            this.conductoresTableAdapter.ClearBeforeFill = true;
            // 
            // webView1
            // 
            this.webView1.InputMsgFilter = null;
            this.webView1.ObjectForScripting = null;
            this.webView1.Title = null;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBoxLicencia);
            this.panel1.Controls.Add(this.comboBoxBuscarPorCedula);
            this.panel1.Controls.Add(this.MarcoDeFoto);
            this.panel1.Controls.Add(this.btnBorrarFoto);
            this.panel1.Controls.Add(this.btnCargarFoto);
            this.panel1.Controls.Add(this.dtimeFechaNacimiento);
            this.panel1.Controls.Add(this.dtimeLicVence);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtNombres);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.txtLicencia);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelapellidos);
            this.panel1.Controls.Add(this.labelnombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 586);
            this.panel1.TabIndex = 43;
            // 
            // pictureBoxLicencia
            // 
            this.pictureBoxLicencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLicencia.BackgroundImage")));
            this.pictureBoxLicencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLicencia.Location = new System.Drawing.Point(191, 302);
            this.pictureBoxLicencia.Name = "pictureBoxLicencia";
            this.pictureBoxLicencia.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxLicencia.TabIndex = 43;
            this.pictureBoxLicencia.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(453, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label10.Location = new System.Drawing.Point(565, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 22);
            this.label10.TabIndex = 45;
            this.label10.Text = "Buscar por cedula";
            // 
            // AdmConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 610);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmConductores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdmConductores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MarcoDeFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coomulsoftAppDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLicencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox MarcoDeFoto;
        private System.Windows.Forms.DateTimePicker dtimeLicVence;
        private System.Windows.Forms.DateTimePicker dtimeFechaNacimiento;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.Button btnBorrarFoto;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.OpenFileDialog ofdSeleccionarImagen;
        private System.Windows.Forms.ComboBox comboBoxBuscarPorCedula;
        private CoomulsoftAppDataSet coomulsoftAppDataSet;
        private System.Windows.Forms.BindingSource conductoresBindingSource;
        private CoomulsoftAppDataSetTableAdapters.ConductoresTableAdapter conductoresTableAdapter;
        private EO.WebBrowser.WebView webView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLicencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}