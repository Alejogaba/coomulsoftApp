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
    public partial class ReporteConductores : Form
    {
        ConductorService service = new ConductorService();
        public ReporteConductores()
        {
            InitializeComponent();
            dataGridView1.DataSource = service.Consultar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = service.Buscar(textBox1.Text);

        }
    }
}
