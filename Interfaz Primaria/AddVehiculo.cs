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

namespace Interfaz_Primaria
{
    public partial class AddVehiculo : Form
    {
        DialogResult result;
        public AddVehiculo()
        {
            InitializeComponent();
            this.ttMensajes.SetToolTip(this.btnBorrar, "Borrar la foto");
            this.ttMensajes.SetToolTip(this.btnCargar, "Subir la foto");
        }



        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

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
            string placa, codigo, nombre_modelo, año_modelo, tipo, capacidad_pasajeros, gasolina, capacidad_maletero;
            placa = txtPlaca.Text + "-" + txtPlaca2.Text;
            codigo = txtCodigo.Text;
            nombre_modelo = txtNombreModelo.Text;
            año_modelo = txtAñoModelo.Text;
            tipo = txtTipo.Text;
            capacidad_pasajeros = txtCapacidadPasajeros.Text;
            gasolina = txtGasolina.Text;
            capacidad_maletero = txtCapacidaMaletero.Text;

            if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre_modelo) || string.IsNullOrEmpty(año_modelo) || string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(capacidad_pasajeros) || string.IsNullOrEmpty(gasolina) || string.IsNullOrEmpty(capacidad_maletero))
            {
                result = MsgBox.Show("HAY ESPACIO EN BLANCO", "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public void Limpiar()
        {
            txtAñoModelo.Clear();
            txtCapacidadPasajeros.Clear();
            txtCapacidaMaletero.Clear();
            txtCodigo.Clear();
            txtGasolina.Clear();
            txtNombreModelo.Clear();
            txtPlaca.Clear();
            txtPlaca2.Clear();
            txtTipo.Clear();
        }
    }
}
