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


        private async void StatisticsForm_Load(object sender, EventArgs e)
        {
             buttonBarCharts_Click(sender, e);
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

            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            chart.Series.Add("Classroom");
            chart.Series.Add("User");
            chart.Series.Add("Student");
            chart.Series.Add("Course");

            chart.Series["Classroom"].ChartType = SeriesChartType.Line;
            chart.Series["Classroom"].Points.AddXY("Jan-Feb", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(1, 2));
            chart.Series["Classroom"].Points.AddXY("Mar-April", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(3, 4));
            chart.Series["Classroom"].Points.AddXY("May-June", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(5, 6));
            chart.Series["Classroom"].Points.AddXY("July-Aug", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(7, 8));
            chart.Series["Classroom"].Points.AddXY("Sept-Oct", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(9, 10));
            chart.Series["Classroom"].Points.AddXY("Nov-Dec", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(11, 12));

            chart.Series["User"].ChartType = SeriesChartType.Line;
            chart.Series["User"].Points.AddXY("Jan-Feb", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(1, 2));
            chart.Series["User"].Points.AddXY("Mar-April", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(3, 4));
            chart.Series["User"].Points.AddXY("May-June", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(5, 6));
            chart.Series["User"].Points.AddXY("July-Aug", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(7, 8));
            chart.Series["User"].Points.AddXY("Sept-Oct", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(9, 10));
            chart.Series["User"].Points.AddXY("Nov-Dec", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(11, 12));

            chart.Series["Student"].ChartType = SeriesChartType.Line;
            chart.Series["Student"].Points.AddXY("Jan-Feb", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(1, 2));
            chart.Series["Student"].Points.AddXY("Mar-April", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(3, 4));
            chart.Series["Student"].Points.AddXY("May-June", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(5, 6));
            chart.Series["Student"].Points.AddXY("July-Aug", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(7, 8));
            chart.Series["Student"].Points.AddXY("Sept-Oct", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(9, 10));
            chart.Series["Student"].Points.AddXY("Nov-Dec", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(11, 12));

            chart.Series["Course"].ChartType = SeriesChartType.Line;
            chart.Series["Course"].Points.AddXY("Jan-Feb", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(1, 2));
            chart.Series["Course"].Points.AddXY("Mar-April", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(3, 4));
            chart.Series["Course"].Points.AddXY("May-June", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(5, 6));
            chart.Series["Course"].Points.AddXY("July-Aug", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(7, 8));
            chart.Series["Course"].Points.AddXY("Sept-Oct", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(9, 10));
            chart.Series["Course"].Points.AddXY("Nov-Dec", await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(11, 12));
        }

        private async void buttonBarCharts_Click(object sender, EventArgs e)
        {
            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;

            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            Title title = new Title("Record per year");
            title.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
            chart.Titles.Add(title);
            chart.Legends.Add("Legend");
            chart.Legends["Legend"].LegendStyle = LegendStyle.Table;
            chart.Legends["Legend"].Docking = Docking.Bottom;
            chart.Legends["Legend"].Alignment = StringAlignment.Center;
            chart.Legends["Legend"].BorderColor = Color.Black;
            chart.Legends["Legend"].Title = "Legend";

            chart.Palette = ChartColorPalette.Excel;
            chart.Series.Add("Classroom");
            chart.Series.Add("User");
            chart.Series.Add("Student");
            chart.Series.Add("Course");

            chart.Series["Classroom"].Points.Add(await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(1, 12));
            chart.Series["User"].Points.Add(await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(1, 12));
            chart.Series["Student"].Points.Add(await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(1, 12));
            chart.Series["Course"].Points.Add(await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(1, 12));
        }

        private async void buttonPieCharts_Click(object sender, EventArgs e)
        {
            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            Title title = new Title("Record per year");
            title.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
            chart.Titles.Add(title);
            chart.Legends.Add("Legend");
            chart.Legends["Legend"].LegendStyle = LegendStyle.Table;
            chart.Legends["Legend"].Docking = Docking.Bottom;
            chart.Legends["Legend"].Alignment = StringAlignment.Center;
            chart.Legends["Legend"].BorderColor = Color.Black;
            chart.Legends["Legend"].Title = "Legend";

            int classroomAmount = await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(1, 12);
            int userAmount = await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(1, 12);
            int studentAmount = await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(1, 12);
            int courseAmount = await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(1, 12);

            chart.Series.Add("Pie");
            chart.Series["Pie"].ChartType = SeriesChartType.Pie;

            chart.Series["Pie"].Points.AddXY($"Classroom ({await _amountEntitiesService.CalculatePencentageAsync(classroomAmount):0.00}%)", classroomAmount);
            chart.Series["Pie"].Points.AddXY($"User ({await _amountEntitiesService.CalculatePencentageAsync(userAmount):0.00}%)", userAmount);
            chart.Series["Pie"].Points.AddXY($"Student ({await _amountEntitiesService.CalculatePencentageAsync(studentAmount):0.00}%)", studentAmount);
            chart.Series["Pie"].Points.AddXY($"Course ({await _amountEntitiesService.CalculatePencentageAsync(courseAmount):0.00}%)", courseAmount);
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
