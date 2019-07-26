﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Interfaz_Primaria
{
    public partial class ReportePasajeros : Form
    {
        ClienteService clienteService = new ClienteService();
        ViajesService viajesService = new ViajesService();

        public ReportePasajeros()
        {
            InitializeComponent();
            this.ttMensajes.SetToolTip(this.btnBusqueda, "Buscar Reporte");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            try
            {
                foreach (var item in clienteService.Consultar_por_identificacion(id))
                {
                    dataGridView1.DataSource = viajesService.Buscar(item.Codigo_viaje);
                }
            }
            catch (Exception)
            {

      
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = SystemColors.Control;
        }
    }
}
