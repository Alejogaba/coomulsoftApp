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
using xDialog;
using Entity;
using BLL;

namespace Interfaz_Primaria
{
    public partial class IniciarViaje : Form
    {
        ClienteService clienteService = new ClienteService();
        ViajesService viajesService = new ViajesService();
        VehiculosService vehiculosService = new VehiculosService();
        ConductorService conductorService = new ConductorService();
        RutasService rutasService = new RutasService();
        int a = 0;
        DialogResult result;

        public IniciarViaje()
        {
            InitializeComponent();
            Cargar_vehiculos();
            Cargar_origen_y_destino();
        }
        public void Cargar_vehiculos()
        {
            comboBoxBuscarVehiculo.Items.Clear();
            foreach (var item in vehiculosService.Consultar())
            {
                comboBoxBuscarVehiculo.Items.Add(item.Codigo);
            }
        }

        public void Cargar_origen_y_destino()
        {
            comboBoxOrigen.Items.Clear();
            comboBoxDestino.Items.Clear();
            foreach (var item in rutasService.Consultar())
            {
                comboBoxOrigen.Items.Add(item.Ciudad_Origen);
                comboBoxDestino.Items.Add(item.Ciudad_Destino);
            }
        }
        public void Cargar_conductores(string veh)
        {
            comboBoxBuscarConductor.Items.Clear();
            foreach (var item in conductorService.Buscar_por_vehiculo(veh))
            {
                comboBoxBuscarVehiculo.Items.Add(item.Identificacion);
            }
        }
        public int Codigo_viaje()
        {
            if (a==0)
            {
                Viaje viaje = new Viaje();
                a = viaje.Generar_codigo_viaje();
                return a;
            }
            else
            {
                return a;
            }
            
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelPlanilla.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelPlanilla.Controls.Add(formulario);
                PanelPlanilla.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);
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

     

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public void Guardar ()
        {
            string origen, destino,  placa, codigo;
            int capacidad_pasajeros;
            DateTime fecha, salida;

            capacidad_pasajeros = int.Parse(txtCantPasajeros.Text);
            placa = txtPlaca.Text ;
            codigo = txtCodigo.Text;
            origen = comboBoxOrigen.Text;
            destino = comboBoxDestino.Text;
            fecha = Convert.ToDateTime(dtimeFecha.Text);
            salida = Convert.ToDateTime(dtimeHoraSalida.Text);
            if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(origen) || string.IsNullOrEmpty(Convert.ToString(capacidad_pasajeros)))
            {
                result = MsgBox.Show("HAY ESPACIO EN BLANCO", "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
            }
            else
            {

            }




                
          

        }

        public void Limpiar_cliente()
        {
            textBoxApellidos.Clear();
            textBoxid.Clear();
            textBoxNombres.Clear();
            textBoxDir.Clear();
            textBoxTel.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            int max =  int.Parse(txtCantPasajeros.Text);
            while (i <= max)
            {
                Limpiar_cliente();
                labelcontador.Text = Convert.ToString(i);
                string id, nombre, apellidos, direccion, tel;
                apellidos=textBoxApellidos.Text;
                id = textBoxid.Text;
                nombre= textBoxNombres.Text;
                direccion =textBoxDir.Text;
                tel=textBoxTel.Text;
                Cliente cliente = new Cliente(Codigo_viaje(), nombre, apellidos, id, tel, direccion);
                clienteService.Guardar(cliente);
            }
            this.button1.Enabled = false;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxBuscarVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehiculo con = new Vehiculo();
            string cod = comboBoxBuscarVehiculo.Text;
            con = vehiculosService.Buscar(cod);
            txtCodigo.Text = con.Codigo;
            txtPlaca.Text = con.Placa_Vehiculo;
            txtCantPasajeros.Text = Convert.ToString(con.Capacidad_pasajeros);
          

            MemoryStream ms = new MemoryStream(con.Imagen);
            Image returnImage = System.Drawing.Image.FromStream(ms);
            pictureBoxvehiculo.Image = returnImage;


            panelClientes.Enabled = true;
            panelVehiculos.Enabled = true;
            labelmaximo.Text= txtCantPasajeros.Text;
            Cargar_conductores(cod);
        }

        private void PanelVehiculos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBoxvehiculo_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxBuscarConductor_SelectedIndexChanged(object sender, EventArgs e)
        {

            Conductor con = new Conductor();
            string cod = comboBoxBuscarVehiculo.Text;
            con = conductorService.Buscar(cod);
            txtNombre.Text = con.Nombre;
            txtIdentificacion.Text = con.Identificacion;
            txtLicencia.Text = con.Licencia;
            txtCelular.Text = con.Telefono;
            MemoryStream ms = new MemoryStream(con.Imagen);
            Image returnImage = System.Drawing.Image.FromStream(ms);
            pictureBoxconductor.Image = returnImage;
        }

        private void ComboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            string origen, destino,vehiculo,conductor;
            DateTime hora_salida, fecha_salida;
            origen = comboBoxOrigen.Text;
            destino = comboBoxDestino.Text;
            vehiculo = comboBoxBuscarVehiculo.Text;
            conductor = comboBoxBuscarConductor.Text;
            hora_salida = Convert.ToDateTime(dtimeHoraSalida.Text);
            fecha_salida = Convert.ToDateTime(dtimeFecha.Text);
            Viaje viaje = new Viaje(Codigo_viaje(), conductor, vehiculo, fecha_salida, hora_salida, origen, destino);
            if (origen == destino)
            {
                result = MsgBox.Show("No ingrese el mismo destino y origen", "Advertencia", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
            }
            else
            {
                if (labelcontador.Text != txtCantPasajeros.Text)
                {
                    result = MsgBox.Show("Aun faltan pasajeros", "Advertencia", MsgBox.Buttons.OK, MsgBox.Icon.Warning);

                }
                else
                {
                    result = MsgBox.Show(viajesService.Guardar(viaje), "Advertencia", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                    this.Close();
                }
                
            }
            
        }
    }
}
