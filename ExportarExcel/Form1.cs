using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; //Estas son las los llamados a los paquetes nuggets
using Microsoft.Office.Interop.Excel;  
using ExcelDataReader;
using System.IO;

namespace ExportarExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnimportar_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de Excel|*.xlsx;*.xls|Archivos de Excel 97-2003|*.xls";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });

                            dataGridView1.DataSource = dataSet.Tables[0];
                        }
                    }
                    dataGridView1.Columns[0].HeaderText = "Calle";
                    dataGridView1.Columns[1].HeaderText = "Num";
                    dataGridView1.Columns[2].HeaderText = "Colonia";
                    dataGridView1.Columns[3].HeaderText = "Delegacion";

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11);
                }
            }


        }

        private void tbnexportar_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView1);

        }

        private void ExportToExcel(DataGridView dataGridView)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            int columnCount = dataGridView.ColumnCount;
            for (int i = 0; i < columnCount; i++)
                for (int j = 0; j < columnCount; j++)
                {
                    worksheet.Cells[i + 1, j + 1] = dataGridView.Columns[i].HeaderText;
                }


            int rowCount = dataGridView.RowCount;
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < columnCount; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                }
            string tempFile = System.IO.Path.GetTempFileName()+".xls";
            workbook.SaveAs(tempFile);
        }




    }
}
