using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xDialog;
using BLL;
using Entity;
using System.IO;

namespace Interfaz_Primaria
{
    public partial class AddVehiculo : Form
    {
        VehiculosService service = new VehiculosService();
        DialogResult result;
        public AddVehiculo()
        {
            InitializeComponent();
            Cargar_combobox();
            this.ttMensajes.SetToolTip(this.btnBorrar, "Borrar la foto");
            this.ttMensajes.SetToolTip(this.btnCargar, "Subir la foto");
        }

        public void Cargar_combobox()
        {
            comboBoxBuscarCodigo.Items.Clear();
            foreach (var item in service.Consultar())
            {
                comboBoxBuscarCodigo.Items.Add(item.Codigo);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void ComboBoxBuscarCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            string cod = txtCodigo.Text;
            result = MsgBox.Show(service.Eliminar(cod), "Informacion", MsgBox.Buttons.OK, MsgBox.Icon.Info);
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            pictureBoxVehiculo.Image = pictureBoxVehiculo.InitialImage;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ofdSeleccionarImagen.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofdSeleccionarImagen.FileName;
                pictureBoxVehiculo.Image = Image.FromFile(ruta);
            }

        }

        private void PictureBoxVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pictureBoxVehiculo.Image = pictureBoxVehiculo.InitialImage;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Guardar()
        {
            byte[] byteArrayImagen = ImageToByteArray(pictureBoxVehiculo.Image);
            string placa, codigo, nombre_modelo, año_modelo, tipo;
               int capacidad_pasajeros;
            float gasolina, capacidad_maletero;
            placa = txtPlaca.Text + "-" + txtPlaca2.Text;
            codigo = txtCodigo.Text;
            nombre_modelo = txtNombreModelo.Text;
            año_modelo = txtAñoModelo.Text;
            tipo = txtTipo.Text;
            capacidad_pasajeros = int.Parse(txtCapacidadPasajeros.Text);
            gasolina = float.Parse(txtGasolina.Text);
            capacidad_maletero = float.Parse(txtCapacidaMaletero.Text);

            if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre_modelo) || string.IsNullOrEmpty(año_modelo) || string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(Convert.ToString(capacidad_pasajeros)) || string.IsNullOrEmpty(Convert.ToString(gasolina)) || string.IsNullOrEmpty(Convert.ToString(capacidad_maletero)))
            {
                result = MsgBox.Show("HAY ESPACIO EN BLANCO", "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
            }
            else
            {
                Vehiculo vehiculo = new Vehiculo(byteArrayImagen, codigo, placa, nombre_modelo, tipo, capacidad_pasajeros, capacidad_maletero, gasolina);
                  result = MsgBox.Show(service.Guardar(vehiculo), "Informacion", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                Cargar_combobox();
            }


        }
        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
