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
using Entity;
using BLL;



namespace Interfaz_Primaria
{
    public partial class FormRutas : Form
    {
      
        RutasService service = new RutasService();
        DialogResult result;
        

        public FormRutas()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnBuscar, "Buscar Ruta");
        }

        
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ciudad = textBoxCiudad.Text;
            string dpto = textBoxDpto.Text;
            string destino = textBoxDestino.Text;
            string dpto2 = textBoxDptoDestino.Text;
            try
            {
                StringBuilder queryadress = new StringBuilder();
                queryadress.Append("https://www.google.com.co/maps/dir/");
                if (string.IsNullOrEmpty(textBoxCiudad.Text) || string.IsNullOrEmpty(textBoxDestino.Text) ||
                    string.IsNullOrEmpty(textBoxDpto.Text) || string.IsNullOrEmpty(textBoxDptoDestino.Text))
                {
                    result = MsgBox.Show("No deje campos vacios", "Advertencia", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
                }
                else
                {
                    queryadress.Append(ciudad + "," + "+" + dpto + "/");
                    queryadress.Append(destino + "," + "+" + dpto2);
                    webControl1.WebView.Url = queryadress.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }



        private void Button2_Click(object sender, EventArgs e)
        {
            string ciudad = textBoxCiudad.Text;
            string dpto = textBoxDpto.Text;
            string destino = textBoxDestino.Text;
            string dpto2 = textBoxDptoDestino.Text;
            int tarifa = int.Parse(txtTarifa.Text);
            Rutas rutas = new Rutas(ciudad, dpto, destino, dpto2,tarifa);
            result = MsgBox.Show(service.Guardar(rutas), "Advertencia", MsgBox.Buttons.OK, MsgBox.Icon.Warning);

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string origen = textBoxCiudad.Text;
            string destino = textBoxDestino.Text;
            result = MsgBox.Show(service.Eliminar(origen,destino), "Advertencia", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
        }
    }
}
