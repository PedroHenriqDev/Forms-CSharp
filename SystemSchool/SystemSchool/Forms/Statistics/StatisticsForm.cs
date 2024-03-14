using Entities;
using Services;
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

        private readonly AmountEntitiesService _amountEntitiesService;

        public StatisticsForm(AmountEntitiesService amountEntitiesService)
        {
            _amountEntitiesService = amountEntitiesService;
            InitializeComponent();
        }

        private async void buttonChartLines_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            chart.Legends.Add("Legend");
            chart.Legends[0].LegendStyle = LegendStyle.Table;
            chart.Legends[0].Docking = Docking.Bottom;
            chart.Legends[0].Alignment = StringAlignment.Center;
            chart.Legends[0].BorderColor = Color.Black;
            chart.Legends[0].Title = "Legend";

            Title title = new Title("Record per month");
            title.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
            chart.Titles.Add(title);

            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            chart.Series.Add("Classroom");
            chart.Series.Add("User");
            chart.Series.Add("Student");
            chart.Series.Add("Course");

            chart.Series[0].ChartType = SeriesChartType.Line;
            chart.Series[0].Points.AddXY("Jan-Feb", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(1, 2));
            chart.Series[0].Points.AddXY("Mar-April", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(3, 4));
            chart.Series[0].Points.AddXY("May-June", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(5, 6));
            chart.Series[0].Points.AddXY("July-Aug", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(7, 8));
            chart.Series[0].Points.AddXY("Sept-Oct", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(9, 10));
            chart.Series[0].Points.AddXY("Nov-Dec", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(11, 12));

            chart.Series[1].ChartType = SeriesChartType.Line;
            chart.Series[1].Points.AddXY("Jan-Feb", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(1, 2));
            chart.Series[1].Points.AddXY("Mar-April", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(3, 4));
            chart.Series[1].Points.AddXY("May-June", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(5, 6));
            chart.Series[1].Points.AddXY("July-Aug", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(7, 8));
            chart.Series[1].Points.AddXY("Sept-Oct", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(9, 10));
            chart.Series[1].Points.AddXY("Nov-Dec", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(11, 12));

            chart.Series[2].ChartType = SeriesChartType.Line;
            chart.Series[2].Points.AddXY("Jan-Feb", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(1, 2));
            chart.Series[2].Points.AddXY("Mar-April", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(3, 4));
            chart.Series[2].Points.AddXY("May-June", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(5, 6));
            chart.Series[2].Points.AddXY("July-Aug", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(7, 8));
            chart.Series[2].Points.AddXY("Sept-Oct", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(9, 10));
            chart.Series[2].Points.AddXY("Nov-Dec", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(11, 12));

            chart.Series[3].ChartType = SeriesChartType.Line;
            chart.Series[3].Points.AddXY("Jan-Feb", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(1, 2));
            chart.Series[3].Points.AddXY("Mar-April", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(3, 4));
            chart.Series[3].Points.AddXY("May-June", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(5, 6));
            chart.Series[3].Points.AddXY("July-Aug", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(7, 8));
            chart.Series[3].Points.AddXY("Sept-Oct", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(9, 10));
            chart.Series[3].Points.AddXY("Nov-Dec", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(11, 12));
        }

        private async void buttonBarCharts_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            Title title = new Title("Record per year");
            title.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
            chart.Titles.Add(title);
            chart.Legends.Add("Legend");
            chart.Legends[0].LegendStyle = LegendStyle.Table;
            chart.Legends[0].Docking = Docking.Bottom;
            chart.Legends[0].Alignment = StringAlignment.Center;
            chart.Legends[0].BorderColor = Color.Black;
            chart.Legends[0].Title = "Legend";

            chart.Palette = ChartColorPalette.Excel;
            chart.Series.Add("Classrooms");
            chart.Series.Add("User");
            chart.Series.Add("Students");
            chart.Series.Add("Course");

            chart.Series[0].Points.Add(await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(1, 12));
            chart.Series[1].Points.Add(await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(1, 12));
            chart.Series[2].Points.Add(await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(1, 12));
            chart.Series[3].Points.Add(await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(1, 12));
        }
    }
}
