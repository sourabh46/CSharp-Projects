using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphPlotApplication
{
    public partial class SimpleGraphApplication : Form
    {
        public SimpleGraphApplication()
        {
            InitializeComponent();
        }
        /// <summary>
        /// OnClick Event of "btnShow" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("X_Value", typeof(int));
            dt.Columns.Add("Y_Value", typeof(double));

            StreamReader sr = new StreamReader(@"data.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] strarr = line.Split(',');
                object[] data = new object[] { int.Parse(strarr[0], System.Globalization.CultureInfo.InvariantCulture), Double.Parse((strarr[1]), System.Globalization.CultureInfo.InvariantCulture) };
                dt.Rows.Add(data);
            }
            chartXValueVsYValue.DataSource = dt;
            chartXValueVsYValue.Series["Series1"].XValueMember = "X_Value";
            chartXValueVsYValue.Series["Series1"].YValueMembers = "Y_Value";
            chartXValueVsYValue.Series["Series1"].ChartType = SeriesChartType.Line;
            chartXValueVsYValue.ChartAreas[0].AxisY.LabelStyle.Format = "";
            chartXValueVsYValue.Series[0].LegendText = "Measurement";
            chartXValueVsYValue.ChartAreas[0].AxisX.Title = "Time (in seconds)";
            chartXValueVsYValue.ChartAreas[0].AxisX.Interval = 30;
            chartXValueVsYValue.ChartAreas[0].AxisY.Title = "Value";
            chartXValueVsYValue.ChartAreas[0].AxisY.Interval = 0.05;
            if (sr != null)
            {
                sr.Close();
            }
        }
    }
}
