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
    public partial class Rutas : Form
    {
        DialogResult result;
        public Rutas()
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

        }
    }
}
