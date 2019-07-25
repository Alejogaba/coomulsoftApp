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

namespace Interfaz_Primaria
{
    public partial class ReporteViajes : Form
    {
        ViajesService service = new ViajesService();
        
        public ReporteViajes()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(dateTimePicker1.Text);
            dataGridView1.DataSource = service.Consultar_por_fecha(fecha);
        }
    }
}
