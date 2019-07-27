namespace Interfaz_Primaria
{
    partial class IniciarViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarViaje));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.dtimeHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtimeFecha = new System.Windows.Forms.DateTimePicker();
            this.PanelPlanilla = new System.Windows.Forms.Panel();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.panelVehiculos = new System.Windows.Forms.Panel();
            this.txtLicencia = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.pictureBoxconductor = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxBuscarConductor = new System.Windows.Forms.ComboBox();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.labelmaximo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelcontador = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelIdentificacion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCantPasajeros = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.Label();
            this.pictureBoxvehiculo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBuscarVehiculo = new System.Windows.Forms.ComboBox();
            this.labelmodelo = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PanelPlanilla.SuspendLayout();
            this.panelVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxconductor)).BeginInit();
            this.panelClientes.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxvehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxOrigen);
            this.panel1.Controls.Add(this.comboBoxDestino);
            this.panel1.Controls.Add(this.dtimeHoraSalida);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtimeFecha);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 227);
            this.panel1.TabIndex = 3;
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(186, 10);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(201, 27);
            this.comboBoxOrigen.TabIndex = 11;
            this.comboBoxOrigen.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOrigen_SelectedIndexChanged);
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(186, 68);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(202, 27);
            this.comboBoxDestino.TabIndex = 10;
            // 
            // dtimeHoraSalida
            // 
            this.dtimeHoraSalida.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtimeHoraSalida.Location = new System.Drawing.Point(170, 172);
            this.dtimeHoraSalida.Name = "dtimeHoraSalida";
            this.dtimeHoraSalida.Size = new System.Drawing.Size(218, 20);
            this.dtimeHoraSalida.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(47, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(47, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(29, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora de Salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origen";
            // 
            // dtimeFecha
            // 
            this.dtimeFecha.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.dtimeFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeFecha.Location = new System.Drawing.Point(170, 121);
            this.dtimeFecha.Name = "dtimeFecha";
            this.dtimeFecha.Size = new System.Drawing.Size(229, 21);
            this.dtimeFecha.TabIndex = 0;
            // 
            // PanelPlanilla
            // 
            this.PanelPlanilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPlanilla.Controls.Add(this.buttonRegistrar);
            this.PanelPlanilla.Controls.Add(this.panelVehiculos);
            this.PanelPlanilla.Controls.Add(this.panelClientes);
            this.PanelPlanilla.Controls.Add(this.panel2);
            this.PanelPlanilla.Controls.Add(this.panel1);
            this.PanelPlanilla.Location = new System.Drawing.Point(0, 0);
            this.PanelPlanilla.Name = "PanelPlanilla";
            this.PanelPlanilla.Size = new System.Drawing.Size(1000, 610);
            this.PanelPlanilla.TabIndex = 9;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.buttonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrar.FlatAppearance.BorderSize = 0;
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistrar.Location = new System.Drawing.Point(428, 568);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(79, 30);
            this.buttonRegistrar.TabIndex = 13;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.ButtonRegistrar_Click);
            // 
            // panelVehiculos
            // 
            this.panelVehiculos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelVehiculos.BackColor = System.Drawing.SystemColors.Control;
            this.panelVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVehiculos.Controls.Add(this.txtLicencia);
            this.panelVehiculos.Controls.Add(this.txtCelular);
            this.panelVehiculos.Controls.Add(this.txtIdentificacion);
            this.panelVehiculos.Controls.Add(this.txtNombre);
            this.panelVehiculos.Controls.Add(this.pictureBoxconductor);
            this.panelVehiculos.Controls.Add(this.label11);
            this.panelVehiculos.Controls.Add(this.label10);
            this.panelVehiculos.Controls.Add(this.label9);
            this.panelVehiculos.Controls.Add(this.label8);
            this.panelVehiculos.Controls.Add(this.comboBoxBuscarConductor);
            this.panelVehiculos.Enabled = false;
            this.panelVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelVehiculos.Location = new System.Drawing.Point(496, 282);
            this.panelVehiculos.Name = "panelVehiculos";
            this.panelVehiculos.Size = new System.Drawing.Size(419, 260);
            this.panelVehiculos.TabIndex = 12;
            this.panelVehiculos.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelVehiculos_Paint);
            // 
            // txtLicencia
            // 
            this.txtLicencia.AutoSize = true;
            this.txtLicencia.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtLicencia.Location = new System.Drawing.Point(113, 195);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(138, 16);
            this.txtLicencia.TabIndex = 17;
            this.txtLicencia.Text = "--------------------------";
            // 
            // txtCelular
            // 
            this.txtCelular.AutoSize = true;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtCelular.Location = new System.Drawing.Point(113, 150);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(138, 16);
            this.txtCelular.TabIndex = 16;
            this.txtCelular.Text = "--------------------------";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.AutoSize = true;
            this.txtIdentificacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtIdentificacion.Location = new System.Drawing.Point(113, 65);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(138, 16);
            this.txtIdentificacion.TabIndex = 15;
            this.txtIdentificacion.Text = "--------------------------";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtNombre.Location = new System.Drawing.Point(113, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 16);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.Text = "--------------------------";
            // 
            // pictureBoxconductor
            // 
            this.pictureBoxconductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxconductor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxconductor.Image")));
            this.pictureBoxconductor.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxconductor.InitialImage")));
            this.pictureBoxconductor.Location = new System.Drawing.Point(286, 20);
            this.pictureBoxconductor.Name = "pictureBoxconductor";
            this.pictureBoxconductor.Size = new System.Drawing.Size(121, 143);
            this.pictureBoxconductor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxconductor.TabIndex = 11;
            this.pictureBoxconductor.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label11.Location = new System.Drawing.Point(23, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label10.Location = new System.Drawing.Point(32, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label9.Location = new System.Drawing.Point(22, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "N° Licencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(15, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Identificacion";
            // 
            // comboBoxBuscarConductor
            // 
            this.comboBoxBuscarConductor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuscarConductor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.comboBoxBuscarConductor.FormattingEnabled = true;
            this.comboBoxBuscarConductor.Location = new System.Drawing.Point(25, 12);
            this.comboBoxBuscarConductor.Name = "comboBoxBuscarConductor";
            this.comboBoxBuscarConductor.Size = new System.Drawing.Size(213, 27);
            this.comboBoxBuscarConductor.TabIndex = 0;
            this.comboBoxBuscarConductor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBuscarConductor_SelectedIndexChanged);
            // 
            // panelClientes
            // 
            this.panelClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelClientes.BackColor = System.Drawing.SystemColors.Control;
            this.panelClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientes.Controls.Add(this.button1);
            this.panelClientes.Controls.Add(this.textBoxDir);
            this.panelClientes.Controls.Add(this.textBoxTel);
            this.panelClientes.Controls.Add(this.textBoxApellidos);
            this.panelClientes.Controls.Add(this.textBoxNombres);
            this.panelClientes.Controls.Add(this.textBoxid);
            this.panelClientes.Controls.Add(this.labelmaximo);
            this.panelClientes.Controls.Add(this.label12);
            this.panelClientes.Controls.Add(this.labelcontador);
            this.panelClientes.Controls.Add(this.label16);
            this.panelClientes.Controls.Add(this.label15);
            this.panelClientes.Controls.Add(this.label14);
            this.panelClientes.Controls.Add(this.label13);
            this.panelClientes.Controls.Add(this.labelIdentificacion);
            this.panelClientes.Enabled = false;
            this.panelClientes.Location = new System.Drawing.Point(12, 282);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(419, 260);
            this.panelClientes.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(360, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(137, 196);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(166, 20);
            this.textBoxDir.TabIndex = 12;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(137, 146);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(166, 20);
            this.textBoxTel.TabIndex = 11;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(137, 101);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(166, 20);
            this.textBoxApellidos.TabIndex = 10;
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(137, 63);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(166, 20);
            this.textBoxNombres.TabIndex = 9;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(137, 15);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(166, 20);
            this.textBoxid.TabIndex = 8;
            // 
            // labelmaximo
            // 
            this.labelmaximo.AutoSize = true;
            this.labelmaximo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmaximo.Location = new System.Drawing.Point(203, -1);
            this.labelmaximo.Name = "labelmaximo";
            this.labelmaximo.Size = new System.Drawing.Size(23, 16);
            this.labelmaximo.TabIndex = 7;
            this.labelmaximo.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(177, -1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "de";
            // 
            // labelcontador
            // 
            this.labelcontador.AutoSize = true;
            this.labelcontador.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcontador.Location = new System.Drawing.Point(157, -1);
            this.labelcontador.Name = "labelcontador";
            this.labelcontador.Size = new System.Drawing.Size(15, 16);
            this.labelcontador.TabIndex = 5;
            this.labelcontador.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label16.Location = new System.Drawing.Point(30, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Telefono";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label15.Location = new System.Drawing.Point(29, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Direccion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label14.Location = new System.Drawing.Point(28, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Apellidos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label13.Location = new System.Drawing.Point(30, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nombres";
            // 
            // labelIdentificacion
            // 
            this.labelIdentificacion.AutoSize = true;
            this.labelIdentificacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.labelIdentificacion.Location = new System.Drawing.Point(18, 15);
            this.labelIdentificacion.Name = "labelIdentificacion";
            this.labelIdentificacion.Size = new System.Drawing.Size(99, 19);
            this.labelIdentificacion.TabIndex = 0;
            this.labelIdentificacion.Text = "Identificacion";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelmodelo);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtCantPasajeros);
            this.panel2.Controls.Add(this.txtPlaca);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.pictureBoxvehiculo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxBuscarVehiculo);
            this.panel2.Location = new System.Drawing.Point(496, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 231);
            this.panel2.TabIndex = 10;
            // 
            // txtCantPasajeros
            // 
            this.txtCantPasajeros.AutoSize = true;
            this.txtCantPasajeros.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantPasajeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtCantPasajeros.Location = new System.Drawing.Point(162, 91);
            this.txtCantPasajeros.Name = "txtCantPasajeros";
            this.txtCantPasajeros.Size = new System.Drawing.Size(33, 16);
            this.txtCantPasajeros.TabIndex = 13;
            this.txtCantPasajeros.Text = "-----";
            // 
            // txtPlaca
            // 
            this.txtPlaca.AutoSize = true;
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtPlaca.Location = new System.Drawing.Point(106, 132);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(88, 16);
            this.txtPlaca.TabIndex = 12;
            this.txtPlaca.Text = "----------------";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.txtCodigo.Location = new System.Drawing.Point(106, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(83, 16);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.Text = "---------------";
            // 
            // pictureBoxvehiculo
            // 
            this.pictureBoxvehiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxvehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxvehiculo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxvehiculo.Image")));
            this.pictureBoxvehiculo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxvehiculo.InitialImage")));
            this.pictureBoxvehiculo.Location = new System.Drawing.Point(222, 46);
            this.pictureBoxvehiculo.Name = "pictureBoxvehiculo";
            this.pictureBoxvehiculo.Size = new System.Drawing.Size(192, 100);
            this.pictureBoxvehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxvehiculo.TabIndex = 10;
            this.pictureBoxvehiculo.TabStop = false;
            this.pictureBoxvehiculo.Click += new System.EventHandler(this.PictureBoxvehiculo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(22, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Placa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(3, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cantidad de pasajeros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(22, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Codigo";
            // 
            // comboBoxBuscarVehiculo
            // 
            this.comboBoxBuscarVehiculo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuscarVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.comboBoxBuscarVehiculo.FormattingEnabled = true;
            this.comboBoxBuscarVehiculo.Location = new System.Drawing.Point(22, 3);
            this.comboBoxBuscarVehiculo.Name = "comboBoxBuscarVehiculo";
            this.comboBoxBuscarVehiculo.Size = new System.Drawing.Size(198, 27);
            this.comboBoxBuscarVehiculo.TabIndex = 0;
            this.comboBoxBuscarVehiculo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBuscarVehiculo_SelectedIndexChanged);
            // 
            // labelmodelo
            // 
            this.labelmodelo.AutoSize = true;
            this.labelmodelo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmodelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.labelmodelo.Location = new System.Drawing.Point(106, 183);
            this.labelmodelo.Name = "labelmodelo";
            this.labelmodelo.Size = new System.Drawing.Size(83, 16);
            this.labelmodelo.TabIndex = 15;
            this.labelmodelo.Text = "---------------";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.label18.Location = new System.Drawing.Point(22, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 19);
            this.label18.TabIndex = 14;
            this.label18.Text = "Modelo";
            // 
            // IniciarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 610);
            this.Controls.Add(this.PanelPlanilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IniciarViaje";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelPlanilla.ResumeLayout(false);
            this.panelVehiculos.ResumeLayout(false);
            this.panelVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxconductor)).EndInit();
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxvehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtimeFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelPlanilla;
        private System.Windows.Forms.DateTimePicker dtimeHoraSalida;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.Panel panelVehiculos;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBuscarVehiculo;
        private System.Windows.Forms.PictureBox pictureBoxvehiculo;
        private System.Windows.Forms.PictureBox pictureBoxconductor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxBuscarConductor;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.Label txtCantPasajeros;
        private System.Windows.Forms.Label txtPlaca;
        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Label txtLicencia;
        private System.Windows.Forms.Label txtCelular;
        private System.Windows.Forms.Label txtIdentificacion;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label labelmaximo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelcontador;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelIdentificacion;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Label labelmodelo;
        private System.Windows.Forms.Label label18;
    }
}