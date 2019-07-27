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
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;
using Entity;

namespace Interfaz_Primaria
{
    public partial class ReporteViajes : Form
    {
        ViajesService service = new ViajesService();
        
        public ReporteViajes()
        {
            InitializeComponent();
            this.ttMensajes.SetToolTip(this.btnBusqueda, "Buscar Reporte");
            cargar();
        }

        public void cargar()
        {
            dataGridView1.DataSource = service.Consultar();
            dataGridView1.Refresh();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(dateTimePicker1.Text);
            dataGridView1.DataSource = service.Consultar_por_fecha(fecha);
        }
      
        public void exportar_pdf()
        {
           
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(dataGridView1.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth=1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add header
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
               
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfPTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new Phrase(cell.Value.ToString()));

                }
            }
           
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }




        }
        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxPdf.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void PictureBoxPdf_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPdf.BackColor = SystemColors.Control;
        }

        private void PictureBoxPdf_Click(object sender, EventArgs e)
        {
            exportar_pdf();
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

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            cargar();
        }
        public void Filtragridfecha()
        {
            DateTime fecha= Convert.ToDateTime(dateTimePicker1.Text);
            IList<Viaje> datos = service.Consultar_por_fecha(fecha);
            DataTable data;
            data = ToDataTables<Viaje>(datos);
            dataGridView1.DataSource = data;
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Filtragridfecha();
        }
    }
}
