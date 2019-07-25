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

namespace Interfaz_Primaria
{
    public partial class IniciarViaje : Form
    {
        DialogResult result;
        public IniciarViaje()
        {
            InitializeComponent();
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
            AbrirFormulario<Planilla>();
            //Form formulario = new Planilla();
            //formulario.Show();
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
    }
}
