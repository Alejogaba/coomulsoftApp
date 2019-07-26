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
using BLL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Entity;

namespace Interfaz_Primaria
{
    public partial class ReporteConductores : Form
    {
        ConductorService service = new ConductorService();
        public ReporteConductores()
        {
            InitializeComponent();
            cargargrid();
            Organizar_grid();
            

        }

        public void Organizar_grid()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            
       }
        

        public void Filtragrid()
        {
            string ced = textBox1.Text;
            IList<Conductor> datos = service.Filtro(ced);
            DataTable data;
            data = ToDataTables<Conductor>(datos);
            dataGridView1.DataSource = data;
        }

        public void cargargrid()
        {
            IList<Conductor> datos = service.Consultar();
            DataTable data;
            data = ToDataTables<Conductor>(datos);

            dataGridView1.DataSource = service.Consultar();
        }

      



        public void exportar_pdf()
        {

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(dataGridView1.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;

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
    



    private void Button1_Click_1(object sender, EventArgs e)
        {
            exportar_pdf();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            Filtragrid();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                exportar_pdf();
            }
            catch (Exception)
            {
            }
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            cargargrid();
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = SystemColors.Control;
        }

        private void BtnBusqueda_MouseEnter(object sender, EventArgs e)
        {
            btnBusqueda.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void BtnBusqueda_MouseLeave(object sender, EventArgs e)
        {
            btnBusqueda.BackColor = SystemColors.Control;
        }
    }
}
