using System;
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
    public partial class AdmConductores : Form
    {
        ConductorService service = new ConductorService();
        public AdmConductores()
        {
            InitializeComponent();
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

        public void Guardar()
        {
            string nom, apellido, ced, est_licencia, licencia, cuenta_banco, direccion, telefono, email;
            try
            {
                
                
            }
            catch (Exception)
            {

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
