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

        private void ExportToExcel(DataGridView dataGridView)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            int columnCount = dataGridView.ColumnCount;
            int rowCount = dataGridView.RowCount;

            // Establecer encabezados
            for (int i = 0; i < columnCount; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
            }

            // Copiar datos desde el DataGridView
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                }
            }

            // Guardar el archivo Excel
            string tempFile = System.IO.Path.GetTempFileName() + ".xls";
            workbook.SaveAs(tempFile);
        }

        private void btnimportarr_Click(object sender, EventArgs e)
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

                            dgv.DataSource = dataSet.Tables[0];
                        }
                    }
                    dgv.Columns[0].HeaderText = "Calle";
                    dgv.Columns[1].HeaderText = "Num";
                    dgv.Columns[2].HeaderText = "Colonia";
                    dgv.Columns[3].HeaderText = "Delegacion";

                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgv.AutoResizeColumns();
                    dgv.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11);
                }
            }
        }

        private void btnexportarr_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgv);
        }
    }
}
