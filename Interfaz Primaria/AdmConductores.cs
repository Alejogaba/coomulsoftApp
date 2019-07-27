using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string estado_licencia;
        public AdmConductores()
        {
            InitializeComponent();
            cargar();
           
            this.ttMensaje.SetToolTip(this.btnBorrarFoto, "Borrar la foto");
            this.ttMensaje.SetToolTip(this.btnCargarFoto, "Subir la foto");
            
           
        }

        public void cargar()
        {
            foreach (var item in Service.Consultar())
            {
                comboBoxBuscarPorCedula.Items.Add(item.Identificacion);
            }
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
            byte[] byteArrayImagen = ImageToByteArray(MarcoDeFoto.Image);

            string nombre, apellido, id, tel, dire, email, licencia,imagen;
            DateTime lic_fecha,fecha_nac;
            nombre = txtNombres.Text;
            apellido = txtApellidos.Text;
            id = txtId.Text;
            tel = txtTelefono.Text;
            dire = txtDireccion.Text;
            email = txtEmail.Text;
            licencia = txtEmail.Text;
       
           
            lic_fecha = Convert.ToDateTime(dtimeLicVence.Text);
            fecha_nac = Convert.ToDateTime(dtimeFechaNacimiento.Text);

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(dire) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(licencia))
            {
                result = MsgBox.Show("HAY ESPACIO EN BLANCO", "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
            }
            else
            {
                Conductor conductor = new Conductor(nombre, apellido, id, fecha_nac, tel, dire, byteArrayImagen, licencia, estado_licencia, lic_fecha, email);
                result = MsgBox.Show(Service.Guardar(conductor), "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                cargar();
                comboBoxBuscarPorCedula.Refresh();
            }
            
        }

        public void Modificar()
        {
            byte[] byteArrayImagen = ImageToByteArray(MarcoDeFoto.Image);

            string nombre, apellido, id, tel, dire, email, licencia, antigua_ced;
            DateTime lic_fecha, fecha_nac;
            nombre = txtNombres.Text;
            apellido = txtApellidos.Text;
            id = txtId.Text;
            tel = txtTelefono.Text;
            dire = txtDireccion.Text;
            email = txtEmail.Text;
            licencia = txtEmail.Text;
            antigua_ced = comboBoxBuscarPorCedula.Text;


            lic_fecha = Convert.ToDateTime(dtimeLicVence.Text);
            fecha_nac = Convert.ToDateTime(dtimeFechaNacimiento.Text);

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(dire) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(licencia))
            {
                result = MsgBox.Show("HAY ESPACIO EN BLANCO", "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
            }
            else
            {
                
                        Conductor conductor = new Conductor(nombre, apellido, id, fecha_nac, tel, dire, byteArrayImagen, licencia, estado_licencia, lic_fecha, email);
                        result = MsgBox.Show(Service.Modificar(conductor,antigua_ced) , "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                    
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            Guardar();

            Limpiar();
        }


        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
            
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

       

        private void Button3_Click(object sender, EventArgs e)
        {
            string eliminar = txtId.Text;
            result = MsgBox.Show(Service.Eliminar(eliminar), "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
            
            Limpiar();
        }

        public void Limpiar()
        {
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtId.Clear();
            txtLicencia.Clear();
            txtNombres.Clear();
            txtTelefono.Clear();
            dtimeFechaNacimiento.ResetText();
            pictureBoxLicencia.Image = pictureBoxLicencia.InitialImage;

        }
      
        private void AdmConductores_Load(object sender, EventArgs e)
        {
          
        }
      

        private void ComboBoxBuscarPorCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string ced = comboBoxBuscarPorCedula.Text;
                Conductor con = new Conductor();
                con = Service.Buscar(ced);
                txtNombres.Text = con.Nombre;
                MemoryStream ms = new MemoryStream(con.Imagen);
                Image returnImage = System.Drawing.Image.FromStream(ms);
                MarcoDeFoto.Image = returnImage;
                txtApellidos.Text = con.Apellido;
                txtDireccion.Text = con.Direccion;
                txtEmail.Text = con.Email;
                txtLicencia.Text = con.Licencia;
                txtTelefono.Text = con.Telefono;
                txtId.Text = con.Identificacion;
                dtimeFechaNacimiento.Text = Convert.ToString(con.Fecha_naciemiento);
                dtimeLicVence.Text = Convert.ToString(con.Fecha_vencimiento_licencia);

                


            }
            catch (Exception ex)
            {
                result = MsgBox.Show("Error! " + ex.Message, "Error", MsgBox.Buttons.OK, MsgBox.Icon.Info);
            }

            
        }

        private void OfdSeleccionarImagen_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BtnBorrarFoto_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        public void Comprobar_licencia()
        {
            DateTime actual = DateTime.Now;
            DateTime vence = Convert.ToDateTime(dtimeLicVence.Text);
            int a = DateTime.Compare(vence, actual);
            
            if (a<0)
            {
                result = MsgBox.Show("Licencia Vencida", "Advertencia", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
                pictureBoxLicencia.BackgroundImage = Properties.Resources.trafficlight_red_40428;
                estado_licencia= "Vencida";
                
            }
            else
            {
                pictureBoxLicencia.BackgroundImage = Properties.Resources.trafficlight_green_40427;
                estado_licencia= "Ok";
            }
        }

        private void DtimeLicVence_ValueChanged(object sender, EventArgs e)
        {
            Comprobar_licencia();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}
