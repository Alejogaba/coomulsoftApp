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
            CargarRutas();
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
            Rutas rutas2 = new Rutas(destino, dpto2, ciudad, dpto, tarifa);
            
               
                    if (ciudad == destino)
                    {
                        result = MsgBox.Show("No ingrese el mismo valor en Origen y Destino", "Advertencia", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
                    }
                    else
                    {
                        try
                        {
                            result = MsgBox.Show(service.Guardar(rutas), "Informacion", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                            service.Guardar(rutas2);
                            actualizar();
                        }
                        catch (Exception ex)
                        {
                            result = MsgBox.Show(ex.Message, "Advertencia", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                        }
                        
                        
                    }
                
            
            

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string origen = textBoxCiudad.Text;
            string destino = textBoxDestino.Text;
            result = MsgBox.Show(service.Eliminar(origen,destino), "Advertencia", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
            service.Eliminar(destino, origen);
            actualizar();
        }

        private void textBoxDestino_Enter(object sender, EventArgs e)
        {
            if (textBoxDestino.Text == "           Ciudad")
            {
                textBoxDestino.Text = "";


            }
        }

        private void textBoxDestino_Leave(object sender, EventArgs e)
        {
            if (textBoxDestino.Text == "")
            {
                textBoxDestino.Text = "           Ciudad";


            }
        }

        private void textBoxDptoDestino_Enter(object sender, EventArgs e)
        {
            if (textBoxDptoDestino.Text == "    Departamento")
            {
                textBoxDptoDestino.Text = "";


            }
        }

        private void textBoxDptoDestino_Leave(object sender, EventArgs e)
        {
            if (textBoxDptoDestino.Text == "")
            {
                textBoxDptoDestino.Text = "    Departamento";


            }
        }

        private void textBoxCiudad_Enter(object sender, EventArgs e)
        {
            if (textBoxCiudad.Text == "           Ciudad")
            {
                textBoxCiudad.Text = "";


            }
        }

        private void textBoxCiudad_Leave(object sender, EventArgs e)
        {
            if (textBoxCiudad.Text == "")
            {
                textBoxCiudad.Text = "           Ciudad";


            }

        }

        private void textBoxDpto_Enter(object sender, EventArgs e)
        {
            if (textBoxDpto.Text == "    Departamento")
            {
                textBoxDpto.Text = "";


            }
        }

        private void textBoxDpto_Leave(object sender, EventArgs e)
        {
            if (textBoxDpto.Text == "")
            {
                textBoxDpto.Text = "    Departamento";


            }
        }

        private void txtTarifa_Enter(object sender, EventArgs e)
        {
            if (txtTarifa.Text == "           Tarifa")
            {
                txtTarifa.Text = "";


            }
        }

        private void txtTarifa_Leave(object sender, EventArgs e)
        {
            if (txtTarifa.Text == "")
            {
                txtTarifa.Text = "           Tarifa";


            }

        }

        public void CargarRutas()
        {
            dataGridViewRutas.DataSource = service.Consultar();
            dataGridViewRutas.Refresh();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            actualizar();
        }
        public void actualizar()
        {
            IList<Rutas> datos = service.Consultar();
            DataTable data;
            data = ToDataTables<Rutas>(datos);
            dataGridViewRutas.DataSource = data;
        }
        public DataTable ToDataTables<T>(IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prp = props[i];
                table.Columns.Add(prp.Name, prp.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);

                }

                table.Rows.Add(values);
            }
            return table;
        }
    }
}
