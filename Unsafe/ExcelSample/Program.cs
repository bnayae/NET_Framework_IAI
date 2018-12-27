using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://www.codeproject.com/Articles/20228/Using-C-to-Create-an-Excel-Document
// http://www.dotnetperls.com/excel

namespace ExcelSample
{
    class Program
    {
        //[STAThread]
        static void Main(string[] args)
        {
            var rnd = new Random();
            var excell_app = new CreateExcelDoc();

            //creates the main header
            excell_app.CreateHeaders(5, 2, "Total of Products", "B5", "D5", 2, "YELLOW", true, 10, "n");
            
            //creates subheaders
            excell_app.CreateHeaders(6, 2, "Sold Product", "B6", "B6", 0, "GRAY", true, 10, "");
            excell_app.CreateHeaders(6, 3, "Initial Total", "C6", "C6", 0, "GRAY", true, 10, "");
            excell_app.CreateHeaders(6, 4, "%", "D6", "D6", 0, "DarkGRAY", true, 10, "");

            string format = "=B{0}/C{0}";
            //add Data to cells          
            for (int i = 7; i < 20; i++)
            {
                excell_app.addData(i, 2, rnd.Next(100, 1000).ToString(), "B" + i, "B" + i, "#,##0");
                excell_app.addData(i, 3, rnd.Next(100, 1000).ToString(), "C" + i, "C" + i, "#,##0");
                excell_app.addData(i, 4, string.Format(format, i), "D" + i, "D" + i, "0.0%"); // calculate cell
            }

            excell_app.AddChart();

            Console.ReadKey();
        }

        class CreateExcelDoc
        {
            const string topLeft = "B6";
            const string bottomRight = "C19";
            const string graphTitle = "Graph Title";
            const string xAxis = "Time";
            const string yAxis = "Value";

            private Application app = null;
            private Workbook workbook = null;
            private Worksheet worksheet = null;
            private Range workSheet_range = null;

            #region Ctor

            public CreateExcelDoc()
            {
                try
                {
                    app = new Application();
                    app.Visible = true;
                    workbook = app.Workbooks.Add(1);
                    worksheet = (Worksheet)workbook.Sheets[1];
                }
                catch (Exception e)
                {
                    Console.Write("Error");
                }
                finally
                {
                }
            }

            #endregion // Ctor

            #region CreateHeaders


            #endregion // CreateHeaders
            public void CreateHeaders(int row, int col, string htext, string cell1,
                    string cell2, int mergeColumns, string b, bool font, int size, string fcolor)
            {
                worksheet.Cells[row, col] = htext;
                workSheet_range = worksheet.get_Range(cell1, cell2);
                workSheet_range.Merge(mergeColumns);
                switch (b)
                {
                    case "YELLOW":
                        workSheet_range.Interior.Color = System.Drawing.Color.Yellow.ToArgb();
                        break;
                    case "GRAY":
                        workSheet_range.Interior.Color = System.Drawing.Color.Gray.ToArgb();
                        break;
                    case "GAINSBORO":
                        workSheet_range.Interior.Color =
                System.Drawing.Color.Gainsboro.ToArgb();
                        break;
                    case "Turquoise":
                        workSheet_range.Interior.Color =
                System.Drawing.Color.Turquoise.ToArgb();
                        break;
                    case "PeachPuff":
                        workSheet_range.Interior.Color =
                System.Drawing.Color.PeachPuff.ToArgb();
                        break;
                    default:
                        //  workSheet_range.Interior.Color = System.Drawing.Color..ToArgb();
                        break;
                }

                workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
                workSheet_range.Font.Bold = font;
                workSheet_range.ColumnWidth = size;
                if (fcolor.Equals(""))
                {
                    workSheet_range.Font.Color = System.Drawing.Color.White.ToArgb();
                }
                else
                {
                    workSheet_range.Font.Color = System.Drawing.Color.Black.ToArgb();
                }
            }

            public void addData(int row, int col, string data,
                string cell1, string cell2, string format)
            {
                worksheet.Cells[row, col] = data;
                workSheet_range = worksheet.get_Range(cell1, cell2);
                workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
                workSheet_range.NumberFormat = format;
            }

            public void AddChart()
            {
                // Add chart.
                var charts = worksheet.ChartObjects() as
                    Microsoft.Office.Interop.Excel.ChartObjects;
                var chartObject = charts.Add(260, 50, 300, 300) as
                    Microsoft.Office.Interop.Excel.ChartObject;
                var chart = chartObject.Chart;

                // Set chart range.
                var range = worksheet.get_Range(topLeft, bottomRight);
                chart.SetSourceData(range);

                // Set chart properties.
                chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlLine;
                chart.ChartWizard(Source: range,
                    Title: graphTitle,
                    CategoryTitle: xAxis,
                    ValueTitle: yAxis);
            }
        }
    }
}
