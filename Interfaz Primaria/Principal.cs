﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Primaria
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        

        private void Principal_Load(object sender, EventArgs e)
        {
            btnReporte.Location = new Point(0, 270);
            PanelDesplegableReportes.Hide();

        }
        #region Funcionalidaddes del formulario 
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            //base.OnPaint(e);
            //ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
//METODO PARA ABRIR FORMULARIO DENTRO DEL PANEL
private void AbrirFormulario<MiForm>()where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            // si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdmConductores>();
            //btnAdmVehiculos.BackColor = Color.FromArgb(47, 79, 79);
            btnAdmConductores.BackColor = Color.FromArgb(7, 124, 131);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdmVehiculos>();
            //btnAdmVehiculos.BackColor = Color.FromArgb(47, 79, 79);
            btnAdmVehiculos.BackColor = Color.FromArgb(7, 124, 131);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (PanelDesplegableReportes.Visible ==true)
            {
                PanelDesplegableReportes.Visible = false;
            }
            else
            {
                PanelDesplegableReportes.Visible = true;
            }
            btnReporte.Location = new Point(0, 270);
            PanelDesplegableReportes.Location = new Point(3, 346);
            if (PanelDesplegableReportes.Visible == false)
            {
                btnReporte.Location = new Point(0, 270); 
            }
        }
        private void CloseForms(object sender,FormClosedEventArgs e)
        {
            if (Application.OpenForms["AdmConductores"] == null)
                btnAdmConductores.BackColor = Color.FromArgb(58, 58, 60);
            if (Application.OpenForms["AdmVehiculos"] == null)
                btnAdmVehiculos.BackColor = Color.FromArgb(58, 58, 60);
            if (Application.OpenForms["Reportes"] == null)
                btnReporte.BackColor = Color.FromArgb(58, 58, 60);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Logi mv = new Logi();
            //mv.Show();

            //this.Close();
         Application.Exit();
        }
        int lx, ly;
        int sw, sh;

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            btnViajes.BackColor = Color.FromArgb(7, 124, 131);
        }

        private void btnPasajeros_Click(object sender, EventArgs e)
        {
            btnPasajeros.BackColor = Color.FromArgb(7, 124, 131);
        }

        private void btnConductores_Click(object sender, EventArgs e)
        {
            btnConductores.BackColor = Color.FromArgb(7, 124, 131);
        }

        private void btnAddVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AddVehiculo>();
        }

        private void btnNuevoViaje_Click(object sender, EventArgs e)
        {
            AbrirFormulario<IniciarViaje>();
        }

        private void btnAddConductor_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AddConductor>();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnTamañoNormal.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void btnTamañoNormal_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnTamañoNormal.Visible = false;
            this.Size = new Size(sw,sh);
            this.Location = new Point(lx, ly);
        }
    }
}