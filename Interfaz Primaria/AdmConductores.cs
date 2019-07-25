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
using Entity;
using xDialog;

namespace Interfaz_Primaria
{
    public partial class AdmConductores : Form
    {
        ConductorService Service = new ConductorService();
        DialogResult result;
        public AdmConductores()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnBorrarFoto, "Borrar la foto");
            this.ttMensaje.SetToolTip(this.btnCargarFoto, "Subir la foto");
            this.ttMensaje.SetToolTip(this.btnBuscar, "Buscar Conductor");
            this.ttMensaje.SetToolTip(this.btnRefresh, "Actualizar tabla");
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

        public void Guardar()
        {
            string nombre, apellido, id, tel, dire, email, licencia, est_lic, cuenta_ban,imagen;
            DateTime lic_fecha,fecha_nac;
            nombre = txtNombres.Text;
            apellido = txtApellidos.Text;
            id = txtId.Text;
            tel = txtTelefono.Text;
            dire = txtDireccion.Text;
            email = txtEmail.Text;
            imagen = MarcoDeFoto.ImageLocation;
            licencia = txtEmail.Text;
            est_lic = "ok";
            cuenta_ban = "Bancolombia N°134324342 Ahorros";
            lic_fecha = Convert.ToDateTime(dtimeLicVence.Text);
            fecha_nac = Convert.ToDateTime(dtimeFechaNacimiento.Text);

            Conductor conductor = new Conductor(nombre, apellido, id, fecha_nac, tel, dire, imagen, licencia,est_lic,lic_fecha,email,cuenta_ban);
            result = MsgBox.Show(Service.Guardar(conductor), "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridAddConductores.DataSource = Service.Consultar();
            }
            catch (Exception ex)
            {
                MsgBox.Show("Error"+ex.Message, "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }
            
        }

        private void comboBoxBuscarPorCedula_Leave(object sender, EventArgs e)
        {
            if (comboBoxBuscarPorCedula.Text == "")
            {
                comboBoxBuscarPorCedula.Text = "      BUSCAR POR NUMERO DE CEDULA";
                comboBoxBuscarPorCedula.ForeColor = Color.DimGray;
            }
        }

        private void comboBoxBuscarPorCedula_Enter(object sender, EventArgs e)
        {
            if (comboBoxBuscarPorCedula.Text == "      BUSCAR POR NUMERO DE CEDULA")
            {
                comboBoxBuscarPorCedula.Text = "";
                comboBoxBuscarPorCedula.ForeColor = Color.LightGray;

            }
        }
    }
}
