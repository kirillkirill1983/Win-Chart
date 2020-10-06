using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinChart
{
    public partial class Form1 : Form
    {
        Excel.Application ExcelApp = new Excel.Application();// Excel 
        Excel.Workbook ExcelWB; //work book
        Excel.Worksheet ExcelShit;// list Excel
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelWB = ExcelApp.Workbooks.Open(@"D:\Bks\raw_0.xlsx");
            ExcelShit = ExcelWB.Worksheets["Лист1"];
            int totalColumns = ExcelShit.UsedRange.Columns.Count;
            int totalRows = ExcelShit.UsedRange.Rows.Count;
            Range dataRangeTemperatura = null;
            Range dataRangeTime = null;
            List<string> CellsListTemperatura = new List<string>();
            List<string> CellListTime = new List<string>();
           

            for (int row = 1; row < totalRows; row++) // 
            {
                dataRangeTemperatura = (Range)ExcelShit.Cells[row, 2];
                dataRangeTime = (Range)ExcelShit.Cells[row, 1];
                CellsListTemperatura.Add(dataRangeTemperatura.Value);
                CellListTime.Add(dataRangeTime.Value);
            }

            
            
            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            string[] textTemperatura = CellsListTemperatura.ToArray();
            int[] grafTemperatura = new int[totalRows];
            chart1.ChartAreas[0].AxisY.Minimum=1000;
            
            for (int i = 1; i < totalRows-1; i++)
            {
                grafTemperatura[i] = Convert.ToInt32(textTemperatura[i]);
            }
            for (int i = 1; i < totalRows-1; i++)
            {

                chart1.Series[0].Points.AddXY(i, grafTemperatura[i]);

            }

            ExcelApp.Quit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelWB = ExcelApp.Workbooks.Open(@"D:\Bks\raw_1.xlsx");
            ExcelShit = ExcelWB.Worksheets["Лист1"];
            int totalColumns = ExcelShit.UsedRange.Columns.Count;
            int totalRows = ExcelShit.UsedRange.Rows.Count;
            Range dataRangeTemperatura = null;
            Range dataRangeTime = null;
            List<string> CellsListTemperatura = new List<string>();
            List<string> CellListTime = new List<string>();


            for (int row = 1; row < totalRows; row++) // 
            {
                dataRangeTemperatura = (Range)ExcelShit.Cells[row, 2];
                dataRangeTime = (Range)ExcelShit.Cells[row, 1];
                CellsListTemperatura.Add(dataRangeTemperatura.Value);
                CellListTime.Add(dataRangeTime.Value);
            }



            chart2.Series[0].Points.Clear();
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            string[] textTemperatura = CellsListTemperatura.ToArray();
            int[] grafTemperatura = new int[totalRows];
            chart2.ChartAreas[0].AxisY.Minimum = 800;

            for (int i = 1; i < totalRows - 1; i++)
            {
                grafTemperatura[i] = Convert.ToInt32(textTemperatura[i]);
            }
            for (int i = 1; i < totalRows - 1; i++)
            {

                chart2.Series[0].Points.AddXY(i, grafTemperatura[i]);

            }

            ExcelApp.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcelWB = ExcelApp.Workbooks.Open(@"D:\Bks\raw_2.xlsx");
            ExcelShit = ExcelWB.Worksheets["Лист1"];
            int totalColumns = ExcelShit.UsedRange.Columns.Count;
            int totalRows = ExcelShit.UsedRange.Rows.Count;
            Range dataRangeTemperatura = null;
            Range dataRangeTime = null;
            List<string> CellsListTemperatura = new List<string>();
            List<string> CellListTime = new List<string>();


            for (int row = 1; row < totalRows; row++) // 
            {
                dataRangeTemperatura = (Range)ExcelShit.Cells[row, 2];
                dataRangeTime = (Range)ExcelShit.Cells[row, 1];
                CellsListTemperatura.Add(dataRangeTemperatura.Value);
                CellListTime.Add(dataRangeTime.Value);
            }



            chart3.Series[0].Points.Clear();
            chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            string[] textTemperatura = CellsListTemperatura.ToArray();
            int[] grafTemperatura = new int[totalRows];
            chart3.ChartAreas[0].AxisY.Minimum = 700;

            for (int i = 1; i < totalRows - 1; i++)
            {
                grafTemperatura[i] = Convert.ToInt32(textTemperatura[i]);
            }
            for (int i = 1; i < totalRows - 1; i++)
            {

                chart3.Series[0].Points.AddXY(i, grafTemperatura[i]);

            }

            ExcelApp.Quit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExcelWB = ExcelApp.Workbooks.Open(@"D:\Bks\raw_3.xlsx");
            ExcelShit = ExcelWB.Worksheets["Лист1"];
            int totalColumns = ExcelShit.UsedRange.Columns.Count;
            int totalRows = ExcelShit.UsedRange.Rows.Count;
            Range dataRangeTemperatura = null;
            Range dataRangeTime = null;
            List<string> CellsListTemperatura = new List<string>();
            List<string> CellListTime = new List<string>();


            for (int row = 1; row < totalRows; row++) // 
            {
                dataRangeTemperatura = (Range)ExcelShit.Cells[row, 2];
                dataRangeTime = (Range)ExcelShit.Cells[row, 1];
                CellsListTemperatura.Add(dataRangeTemperatura.Value);
                CellListTime.Add(dataRangeTime.Value);
            }



            chart4.Series[0].Points.Clear();
            chart4.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            string[] textTemperatura = CellsListTemperatura.ToArray();
            int[] grafTemperatura = new int[totalRows];
            chart4.ChartAreas[0].AxisY.Minimum = 700;

            for (int i = 1; i < totalRows - 1; i++)
            {
                grafTemperatura[i] = Convert.ToInt32(textTemperatura[i]);
            }
            for (int i = 1; i < totalRows - 1; i++)
            {

                chart4.Series[0].Points.AddXY(i, grafTemperatura[i]);

            }

            ExcelApp.Quit();
        }
    }
}
