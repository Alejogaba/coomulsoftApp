﻿namespace Interfaz_Primaria
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnNuevoViaje = new System.Windows.Forms.Button();
            this.PanelDesplegableReportes = new System.Windows.Forms.Panel();
            this.btnConductores = new System.Windows.Forms.Button();
            this.btnPasajeros = new System.Windows.Forms.Button();
            this.btnViajes = new System.Windows.Forms.Button();
            this.btnAdmVehiculos = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnAdmConductores = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnTamañoNormal = new System.Windows.Forms.PictureBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.PanelDesplegableReportes.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTamañoNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1200, 650);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormularios.BackColor = System.Drawing.Color.White;
            this.panelFormularios.Controls.Add(this.pictureBox1);
            this.panelFormularios.Controls.Add(this.label1);
            this.panelFormularios.Location = new System.Drawing.Point(200, 40);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1000, 610);
            this.panelFormularios.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(456, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 115);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 77F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(160, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 122);
            this.label1.TabIndex = 1;
            this.label1.Text = "COOMULSOFT";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.btnRutas);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnNuevoViaje);
            this.panelMenu.Controls.Add(this.PanelDesplegableReportes);
            this.panelMenu.Controls.Add(this.btnAdmVehiculos);
            this.panelMenu.Controls.Add(this.btnReporte);
            this.panelMenu.Controls.Add(this.btnAdmConductores);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 610);
            this.panelMenu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "COOMULSOFT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.FlatAppearance.BorderSize = 0;
            this.btnRutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRutas.Image = ((System.Drawing.Image)(resources.GetObject("btnRutas.Image")));
            this.btnRutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutas.Location = new System.Drawing.Point(0, 544);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(200, 42);
            this.btnRutas.TabIndex = 4;
            this.btnRutas.Text = "                     Rutas";
            this.btnRutas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutas.UseVisualStyleBackColor = true;
            this.btnRutas.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(55, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(101, 101);
            this.btnHome.TabIndex = 5;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // btnNuevoViaje
            // 
            this.btnNuevoViaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevoViaje.FlatAppearance.BorderSize = 0;
            this.btnNuevoViaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevoViaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNuevoViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoViaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoViaje.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoViaje.Image")));
            this.btnNuevoViaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoViaje.Location = new System.Drawing.Point(3, 130);
            this.btnNuevoViaje.Name = "btnNuevoViaje";
            this.btnNuevoViaje.Size = new System.Drawing.Size(200, 42);
            this.btnNuevoViaje.TabIndex = 0;
            this.btnNuevoViaje.Text = "            Iniciar Nuevo Viaje";
            this.btnNuevoViaje.UseVisualStyleBackColor = true;
            this.btnNuevoViaje.Click += new System.EventHandler(this.btnNuevoViaje_Click);
            // 
            // PanelDesplegableReportes
            // 
            this.PanelDesplegableReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.PanelDesplegableReportes.Controls.Add(this.btnConductores);
            this.PanelDesplegableReportes.Controls.Add(this.btnPasajeros);
            this.PanelDesplegableReportes.Controls.Add(this.btnViajes);
            this.PanelDesplegableReportes.Location = new System.Drawing.Point(3, 369);
            this.PanelDesplegableReportes.Name = "PanelDesplegableReportes";
            this.PanelDesplegableReportes.Size = new System.Drawing.Size(194, 169);
            this.PanelDesplegableReportes.TabIndex = 3;
            // 
            // btnConductores
            // 
            this.btnConductores.FlatAppearance.BorderSize = 0;
            this.btnConductores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConductores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnConductores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConductores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConductores.Image = ((System.Drawing.Image)(resources.GetObject("btnConductores.Image")));
            this.btnConductores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConductores.Location = new System.Drawing.Point(3, 115);
            this.btnConductores.Name = "btnConductores";
            this.btnConductores.Size = new System.Drawing.Size(188, 51);
            this.btnConductores.TabIndex = 2;
            this.btnConductores.Text = "    Conductores";
            this.btnConductores.UseVisualStyleBackColor = true;
            this.btnConductores.Click += new System.EventHandler(this.btnConductores_Click);
            // 
            // btnPasajeros
            // 
            this.btnPasajeros.FlatAppearance.BorderSize = 0;
            this.btnPasajeros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPasajeros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasajeros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPasajeros.Image = ((System.Drawing.Image)(resources.GetObject("btnPasajeros.Image")));
            this.btnPasajeros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasajeros.Location = new System.Drawing.Point(3, 57);
            this.btnPasajeros.Name = "btnPasajeros";
            this.btnPasajeros.Size = new System.Drawing.Size(188, 51);
            this.btnPasajeros.TabIndex = 1;
            this.btnPasajeros.Text = "                   Pasajeros";
            this.btnPasajeros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasajeros.UseVisualStyleBackColor = true;
            this.btnPasajeros.Click += new System.EventHandler(this.btnPasajeros_Click);
            // 
            // btnViajes
            // 
            this.btnViajes.FlatAppearance.BorderSize = 0;
            this.btnViajes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnViajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViajes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViajes.Image = ((System.Drawing.Image)(resources.GetObject("btnViajes.Image")));
            this.btnViajes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViajes.Location = new System.Drawing.Point(3, 0);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(188, 51);
            this.btnViajes.TabIndex = 0;
            this.btnViajes.Text = "                   Viajes";
            this.btnViajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViajes.UseVisualStyleBackColor = true;
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // btnAdmVehiculos
            // 
            this.btnAdmVehiculos.FlatAppearance.BorderSize = 0;
            this.btnAdmVehiculos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdmVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdmVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmVehiculos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmVehiculos.Image")));
            this.btnAdmVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmVehiculos.Location = new System.Drawing.Point(0, 256);
            this.btnAdmVehiculos.Name = "btnAdmVehiculos";
            this.btnAdmVehiculos.Size = new System.Drawing.Size(200, 42);
            this.btnAdmVehiculos.TabIndex = 3;
            this.btnAdmVehiculos.Text = "        Adm Vehiculos";
            this.btnAdmVehiculos.UseVisualStyleBackColor = true;
            this.btnAdmVehiculos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(0, 323);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(200, 42);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "                     Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdmConductores
            // 
            this.btnAdmConductores.FlatAppearance.BorderSize = 0;
            this.btnAdmConductores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdmConductores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdmConductores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmConductores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmConductores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmConductores.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmConductores.Image")));
            this.btnAdmConductores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmConductores.Location = new System.Drawing.Point(0, 192);
            this.btnAdmConductores.Name = "btnAdmConductores";
            this.btnAdmConductores.Size = new System.Drawing.Size(200, 42);
            this.btnAdmConductores.TabIndex = 1;
            this.btnAdmConductores.Text = "             Adm Conductores";
            this.btnAdmConductores.UseVisualStyleBackColor = true;
            this.btnAdmConductores.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Controls.Add(this.btnMaximizar);
            this.panelTitulo.Controls.Add(this.btnTamañoNormal);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1200, 40);
            this.panelTitulo.TabIndex = 0;
            this.panelTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitulo_Paint);
            this.panelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1105, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1165, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 40);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1134, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 40);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnTamañoNormal
            // 
            this.btnTamañoNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamañoNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTamañoNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnTamañoNormal.Image")));
            this.btnTamañoNormal.Location = new System.Drawing.Point(1133, 0);
            this.btnTamañoNormal.Name = "btnTamañoNormal";
            this.btnTamañoNormal.Size = new System.Drawing.Size(26, 40);
            this.btnTamañoNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnTamañoNormal.TabIndex = 0;
            this.btnTamañoNormal.TabStop = false;
            this.btnTamañoNormal.Visible = false;
            this.btnTamañoNormal.Click += new System.EventHandler(this.btnTamañoNormal_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 350);
            this.Name = "Principal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.PanelDesplegableReportes.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTamañoNormal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button btnAdmVehiculos;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnAdmConductores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnTamañoNormal;
        private System.Windows.Forms.Panel PanelDesplegableReportes;
        private System.Windows.Forms.Button btnConductores;
        private System.Windows.Forms.Button btnPasajeros;
        private System.Windows.Forms.Button btnViajes;
        private System.Windows.Forms.Button btnNuevoViaje;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip ttMensaje;
    }
}

