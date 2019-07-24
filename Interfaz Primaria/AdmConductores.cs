using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Primaria
{
    public partial class AdmConductores : Form
    {
        public AdmConductores()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnBorrarFoto, "Borrar la foto");
            this.ttMensaje.SetToolTip(this.btnCargarFoto, "Subir la foto");
            this.ttMensaje.SetToolTip(this.btnBuscar, "Buscar Conductor");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarPorCedula_Enter(object sender, EventArgs e)
        {
            if(txtBuscarPorCedula.Text == "      BUSCAR POR NUMERO DE CEDULA")
            {
                txtBuscarPorCedula.Text = "";
                txtBuscarPorCedula.ForeColor = Color.LightGray;

            }
        }

        private void txtBuscarPorCedula_Leave(object sender, EventArgs e)
        {
            if (txtBuscarPorCedula.Text=="")
            {
                txtBuscarPorCedula.Text = "      BUSCAR POR NUMERO DE CEDULA";
                txtBuscarPorCedula.ForeColor = Color.DimGray;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {

            if (ofdSeleccionarImagen.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofdSeleccionarImagen.FileName;
                MarcoDeFoto.Image = Image.FromFile(ruta);

            }
        }
    }
}
