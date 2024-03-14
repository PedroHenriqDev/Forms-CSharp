using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SystemSchool.Forms.Statistics
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void buttonChartLines_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            chart.Titles.Add("Chart");

            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            chart.Series.Add("Month");
            chart.Series[0].ChartType = SeriesChartType.Line;

        }
    }
}
