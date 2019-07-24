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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmConductores));
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dataGridAddConductores = new System.Windows.Forms.DataGridView();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelapellidos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxlicencia = new System.Windows.Forms.TextBox();
            this.textBoxapell = new System.Windows.Forms.TextBox();
            this.textBoxnom = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarPorCedula = new System.Windows.Forms.TextBox();
            this.textBoxtelefono = new System.Windows.Forms.TextBox();
            this.textBoxdireccion = new System.Windows.Forms.TextBox();
            this.textBoxlicencia_estado = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerlicencia = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickernacimiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddConductores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinalizar.Location = new System.Drawing.Point(629, 262);
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
            this.dataGridAddConductores.Location = new System.Drawing.Point(215, 380);
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
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(197, 33);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(227, 20);
            this.textBoxid.TabIndex = 9;
            // 
            // textBoxlicencia
            // 
            this.textBoxlicencia.Location = new System.Drawing.Point(197, 165);
            this.textBoxlicencia.Name = "textBoxlicencia";
            this.textBoxlicencia.Size = new System.Drawing.Size(227, 20);
            this.textBoxlicencia.TabIndex = 11;
            // 
            // textBoxapell
            // 
            this.textBoxapell.Location = new System.Drawing.Point(197, 98);
            this.textBoxapell.Name = "textBoxapell";
            this.textBoxapell.Size = new System.Drawing.Size(227, 20);
            this.textBoxapell.TabIndex = 13;
            // 
            // textBoxnom
            // 
            this.textBoxnom.Location = new System.Drawing.Point(197, 64);
            this.textBoxnom.Name = "textBoxnom";
            this.textBoxnom.Size = new System.Drawing.Size(227, 20);
            this.textBoxnom.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(857, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscarPorCedula
            // 
            this.txtBuscarPorCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarPorCedula.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarPorCedula.Location = new System.Drawing.Point(611, 36);
            this.txtBuscarPorCedula.Name = "txtBuscarPorCedula";
            this.txtBuscarPorCedula.Size = new System.Drawing.Size(227, 20);
            this.txtBuscarPorCedula.TabIndex = 16;
            this.txtBuscarPorCedula.Text = "      BUSCAR POR NUMERO DE CEDULA";
            this.txtBuscarPorCedula.Enter += new System.EventHandler(this.txtBuscarPorCedula_Enter);
            this.txtBuscarPorCedula.Leave += new System.EventHandler(this.txtBuscarPorCedula_Leave);
            // 
            // textBoxtelefono
            // 
            this.textBoxtelefono.Location = new System.Drawing.Point(197, 304);
            this.textBoxtelefono.Name = "textBoxtelefono";
            this.textBoxtelefono.Size = new System.Drawing.Size(227, 20);
            this.textBoxtelefono.TabIndex = 21;
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.Location = new System.Drawing.Point(197, 269);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(227, 20);
            this.textBoxdireccion.TabIndex = 22;
            // 
            // textBoxlicencia_estado
            // 
            this.textBoxlicencia_estado.Location = new System.Drawing.Point(198, 236);
            this.textBoxlicencia_estado.Name = "textBoxlicencia_estado";
            this.textBoxlicencia_estado.Size = new System.Drawing.Size(136, 20);
            this.textBoxlicencia_estado.TabIndex = 23;
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(197, 339);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(227, 20);
            this.textBoxemail.TabIndex = 24;
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
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(832, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 25);
            this.button3.TabIndex = 33;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(732, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 25);
            this.button4.TabIndex = 34;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Location = new System.Drawing.Point(675, 70);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(163, 168);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // dateTimePickerlicencia
            // 
            this.dateTimePickerlicencia.Location = new System.Drawing.Point(197, 198);
            this.dateTimePickerlicencia.Name = "dateTimePickerlicencia";
            this.dateTimePickerlicencia.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerlicencia.TabIndex = 36;
            // 
            // dateTimePickernacimiento
            // 
            this.dateTimePickernacimiento.Location = new System.Drawing.Point(198, 135);
            this.dateTimePickernacimiento.Name = "dateTimePickernacimiento";
            this.dateTimePickernacimiento.Size = new System.Drawing.Size(226, 20);
            this.dateTimePickernacimiento.TabIndex = 37;
            // 
            // AdmConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 610);
            this.Controls.Add(this.dateTimePickernacimiento);
            this.Controls.Add(this.dateTimePickerlicencia);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.textBoxlicencia_estado);
            this.Controls.Add(this.textBoxdireccion);
            this.Controls.Add(this.textBoxtelefono);
            this.Controls.Add(this.dataGridAddConductores);
            this.Controls.Add(this.txtBuscarPorCedula);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxnom);
            this.Controls.Add(this.textBoxapell);
            this.Controls.Add(this.textBoxlicencia);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelapellidos);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.labelnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmConductores";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddConductores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxlicencia;
        private System.Windows.Forms.TextBox textBoxapell;
        private System.Windows.Forms.TextBox textBoxnom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarPorCedula;
        private System.Windows.Forms.TextBox textBoxtelefono;
        private System.Windows.Forms.TextBox textBoxdireccion;
        private System.Windows.Forms.TextBox textBoxlicencia_estado;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DateTimePicker dateTimePickerlicencia;
        private System.Windows.Forms.DateTimePicker dateTimePickernacimiento;
    }
}