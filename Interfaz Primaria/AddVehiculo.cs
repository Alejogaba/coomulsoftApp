﻿using System;
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
        VehiculosService servicevehiculo = new VehiculosService();
        ConductorService serviceconductor = new ConductorService();

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
            foreach (var item in servicevehiculo.Consultar())
            {
                comboBoxBuscarCodigo.Items.Add(item.Codigo);
            }
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
        public void Guardar ()
        {
            byte[] byteArrayImagen = ImageToByteArray(pictureBoxVehiculo.Image);
            string placa, codigo, nombre_modelo, año_modelo, tipo,codigo_antiguo;
               int capacidad_pasajeros;
            float capacidad_maletero;
            placa = txtPlaca.Text;
            codigo = txtCodigo.Text;
            nombre_modelo = txtNombreModelo.Text;
            año_modelo = txtAñoModelo.Text;
            tipo = txtTipo.Text;
            capacidad_pasajeros = int.Parse(txtCapacidadPasajeros.Text);
            capacidad_maletero = 0;

            if (string.IsNullOrEmpty(placa)||string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre_modelo) || string.IsNullOrEmpty(año_modelo) || string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(Convert.ToString(capacidad_pasajeros)) || string.IsNullOrEmpty(Convert.ToString(capacidad_maletero)))
            {
                result = MsgBox.Show("NO DEJE ESPACIOS EN BLANCO", "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
            }
            else
            {
                Vehiculo vehiculo = new Vehiculo(byteArrayImagen, codigo, nombre_modelo, placa, año_modelo, tipo, capacidad_pasajeros, capacidad_maletero);
                result = MsgBox.Show(servicevehiculo.Guardar(vehiculo), "Informacion", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                Cargar_combobox();
                panelconductor.Enabled = true;
                cargarconductor();


            }


        }
        public void Modificar()
        {
            byte[] byteArrayImagen = ImageToByteArray(pictureBoxVehiculo.Image);
            string placa, codigo, nombre_modelo, año_modelo, tipo, codigo_antiguo;
            int capacidad_pasajeros;
            float capacidad_maletero;
            placa = txtPlaca.Text;
            codigo = txtCodigo.Text;
            nombre_modelo = txtNombreModelo.Text;
            año_modelo = txtAñoModelo.Text;
            tipo = txtTipo.Text;
            capacidad_pasajeros = int.Parse(txtCapacidadPasajeros.Text);
            capacidad_maletero = 0;
            codigo_antiguo = comboBoxBuscarCodigo.Text;

            if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre_modelo) || string.IsNullOrEmpty(año_modelo) || string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(Convert.ToString(capacidad_pasajeros)) || string.IsNullOrEmpty(Convert.ToString(capacidad_maletero)))
            {
                result = MsgBox.Show("NO DEJE ESPACIOS EN BLANCO", "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
            }
            else
            {
                

                    if (string.IsNullOrEmpty(codigo_antiguo))
                    {
                        result = MsgBox.Show("Seleccione vehiculo a modificar de la lista", "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
                    }
                    else
                    {
                        Vehiculo vehiculo = new Vehiculo(byteArrayImagen, codigo, nombre_modelo, placa, año_modelo, tipo, capacidad_pasajeros, capacidad_maletero);
                        result = MsgBox.Show(servicevehiculo.Guardar(vehiculo), "Informacion", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                        Cargar_combobox();
                        panelconductor.Enabled = true;
                        cargarconductor();
                    }
                


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
            Limpiar();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string cod = txtCodigo.Text;
            result = MsgBox.Show(servicevehiculo.Eliminar(cod), "Informacion", MsgBox.Buttons.OK, MsgBox.Icon.Info);

            Limpiar();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            pictureBoxVehiculo.Image = pictureBoxVehiculo.InitialImage;
        }

        private void ComboBoxBuscarCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cod = comboBoxBuscarCodigo.Text;
            Vehiculo con = new Vehiculo();
            
            con = servicevehiculo.Buscar(cod);
            txtCodigo.Text = con.Codigo;
            txtAñoModelo.Text = con.Anio_Modelo;
            txtCapacidadPasajeros.Text = Convert.ToString(con.Capacidad_pasajeros);
          
            txtPlaca.Text = con.Placa_Vehiculo;
            txtTipo.Text = con.Tipo_vehiculo;
            txtNombreModelo.Text = con.Modelo;
            //txtNombreModelo.Text = con.
            
            MemoryStream ms = new MemoryStream(con.Imagen);
            Image returnImage = System.Drawing.Image.FromStream(ms);
           pictureBoxVehiculo.Image = returnImage;

            panelconductor.Enabled = true;
            cargarconductor();
        }

        public void cargarconductor()
        {
            comboBoxconductor.Items.Clear();
            foreach (var item in serviceconductor.Filtro_sin_asignar())
            {
                comboBoxconductor.Items.Add(item.Identificacion);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cod = comboBoxconductor.Text;
            Conductor con = new Conductor();
            con = serviceconductor.Buscar(cod);
            labelnombre.Text = con.Nombre;
            labelapellido.Text = con.Apellido;
            labetelefonno.Text = con.Telefono;
            MemoryStream ms = new MemoryStream(con.Imagen);
            Image returnImage = System.Drawing.Image.FromStream(ms);
            pictureBoxconductor.Image = returnImage;

        }

        private void BtnAsignarVehiculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxconductor.Text) || string.IsNullOrEmpty(comboBoxBuscarCodigo.Text))
            {
                result = MsgBox.Show("Seleccione un conductor y vehiculo de la lista", "Informacion", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
            }
            else
            {
                string codigo_vehiculo, cedula;
                codigo_vehiculo = txtCodigo.Text;
                cedula = comboBoxconductor.Text;
                result = MsgBox.Show(serviceconductor.Asignar_vehiculo(codigo_vehiculo, cedula), "Informacion", MsgBox.Buttons.OK, MsgBox.Icon.Info);
               
                Limpiar_conductor();
                cargarconductor();
            }
            
        }

        private void BtnDesasignarVehiculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxconductor.Text) || string.IsNullOrEmpty(comboBoxBuscarCodigo.Text))
            {
                result = MsgBox.Show("Seleccione un conductor y vehiculo de la lista", "Informacion", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
            }
            else
            {
                string cedula = comboBoxconductor.Text;
                serviceconductor.Desasignar_vehiculo(cedula);
                Limpiar_conductor();
                
                cargarconductor();
            }

        }

        public void Limpiar_conductor()
        {
            labelnombre.Text = "----------------------------------------------------------";
            labetelefonno.Text = "----------------------------------------------------------";
            labelapellido.Text = "----------------------------------------------------------";
            pictureBoxconductor.Image = pictureBoxconductor.InitialImage; 
        }

        public void Limpiar()
        {
            txtAñoModelo.Clear();
            txtCapacidadPasajeros.Clear();
            txtCodigo.Clear();

            txtNombreModelo.Clear();
            txtPlaca.Clear();
           
            txtTipo.Clear();
            pictureBoxVehiculo.Image = pictureBoxVehiculo.InitialImage;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}
