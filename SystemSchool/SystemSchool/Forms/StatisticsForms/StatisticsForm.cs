using Entities;
using Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SystemSchool.Forms.StatisticsForms
{
    public partial class StatisticsForm : Form
    {
        private readonly AmountEntitiesService _amountEntitiesService;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsForm"/> class.
        /// </summary>
        /// <param name="amountEntitiesService">The service for calculating the amount of entities.</param>
        public StatisticsForm(AmountEntitiesService amountEntitiesService)
        {
            _amountEntitiesService = amountEntitiesService;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the StatisticsForm control.
        /// </summary>
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            // Automatically trigger the bar charts button click event when the form loads
            buttonBarCharts_Click(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the buttonChartLines control to display line charts.
        /// </summary>
        private async void buttonChartLines_Click(object sender, EventArgs e)
        {
            // Clear existing chart series, titles, and legends
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            // Add legend
            chart.Legends.Add("Legend");
            chart.Legends[0].LegendStyle = LegendStyle.Table;
            chart.Legends[0].Docking = Docking.Bottom;
            chart.Legends[0].Alignment = StringAlignment.Center;
            chart.Legends[0].BorderColor = Color.Black;
            chart.Legends[0].Title = "Legend";

            // Add title
            Title title = new Title("Record per month");
            title.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
            chart.Titles.Add(title);

            // Set chart palette
            chart.Palette = ChartColorPalette.BrightPastel;

            // Add series for different entities and set chart type to line
            chart.Series.Add("Classroom");
            chart.Series.Add("User");
            chart.Series.Add("Student");
            chart.Series.Add("Course");

            foreach (var series in chart.Series)
            {
                series.ChartType = SeriesChartType.Line;
            }

            // Populate series with data for each month
            for (int i = 1; i <= 12; i += 2)
            {
                string monthRange = GetMonthRange(i);
                chart.Series["Classroom"].Points.AddXY(monthRange, await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(i, i + 1));
                chart.Series["User"].Points.AddXY(monthRange, await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(i, i + 1));
                chart.Series["Student"].Points.AddXY(monthRange, await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(i, i + 1));
                chart.Series["Course"].Points.AddXY(monthRange, await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(i, i + 1));
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonBarCharts control to display bar charts.
        /// </summary>
        private async void buttonBarCharts_Click(object sender, EventArgs e)
        {
            // Clear existing chart series, titles, and legends
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            // Add title
            Title title = new Title("Record per year");
            title.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
            chart.Titles.Add(title);

            // Add legend
            chart.Legends.Add("Legend");
            chart.Legends["Legend"].LegendStyle = LegendStyle.Table;
            chart.Legends["Legend"].Docking = Docking.Bottom;
            chart.Legends["Legend"].Alignment = StringAlignment.Center;
            chart.Legends["Legend"].BorderColor = Color.Black;
            chart.Legends["Legend"].Title = "Legend";

            // Set chart palette
            chart.Palette = ChartColorPalette.Excel;

            // Add series for different entities
            chart.Series.Add("Classroom");
            chart.Series.Add("User");
            chart.Series.Add("Student");
            chart.Series.Add("Course");

            // Populate series with data for each entity for the whole year
            chart.Series["Classroom"].Points.Add(await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(1, 12));
            chart.Series["User"].Points.Add(await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(1, 12));
            chart.Series["Student"].Points.Add(await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(1, 12));
            chart.Series["Course"].Points.Add(await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(1, 12));
        }

        /// <summary>
        /// Handles the Click event of the buttonPieCharts control to display pie charts.
        /// </summary>
        private async void buttonPieCharts_Click(object sender, EventArgs e)
        {
            // Clear existing chart series, titles, and legends
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            // Add title
            Title title = new Title("Record per year");
            title.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
            chart.Titles.Add(title);

            // Add legend
            chart.Legends.Add("Legend");
            chart.Legends["Legend"].LegendStyle = LegendStyle.Table;
            chart.Legends["Legend"].Docking = Docking.Bottom;
            chart.Legends["Legend"].Alignment = StringAlignment.Center;
            chart.Legends["Legend"].BorderColor = Color.Black;
            chart.Legends["Legend"].Title = "Legend";

            // Set chart palette
            chart.Palette = ChartColorPalette.Excel;

            // Calculate the number of entities for each category
            int classroomAmount = await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Classroom>(1, 12);
            int userAmount = await _amountEntitiesService.AmountEntitiesByDateCreationAsync<User>(1, 12);
            int studentAmount = await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Student>(1, 12);
            int courseAmount = await _amountEntitiesService.AmountEntitiesByDateCreationAsync<Course>(1, 12);

            // Add series for pie chart
            chart.Series.Add("Pie");
            chart.Series["Pie"].ChartType = SeriesChartType.Pie;

            // Add data points to pie chart series
            chart.Series["Pie"].Points.AddXY($"Classroom ({await _amountEntitiesService.CalculatePencentageAsync(classroomAmount):0.00}%)", classroomAmount);
            chart.Series["Pie"].Points.AddXY($"User ({await _amountEntitiesService.CalculatePencentageAsync(userAmount):0.00}%)", userAmount);
            chart.Series["Pie"].Points.AddXY($"Student ({await _amountEntitiesService.CalculatePencentageAsync(studentAmount):0.00}%)", studentAmount);
            chart.Series["Pie"].Points.AddXY($"Course ({await _amountEntitiesService.CalculatePencentageAsync(courseAmount):0.00}%)", courseAmount);
        }

        /// <summary>
        /// Returns the month range based on the given month.
        /// </summary>
        /// <param name="month">The starting month of the range.</param>
        /// <returns>The formatted month range string.</returns>
        private string GetMonthRange(int month)
        {
            switch (month)
            {
                case 1:
                case 2:
                    return "Jan-Feb";
                case 3:
                case 4:
                    return "Mar-April";
                case 5:
                case 6:
                    return "May-June";
                case 7:
                case 8:
                    return "July-Aug";
                case 9:
                case 10:
                    return "Sept-Oct";
                case 11:
                case 12:
                    return "Nov-Dec";
                default:
                    return "";
            }
        }

        /// <summary>
        /// Handles the Click event of the pictureBoxBack control to navigate back to the main form.
        /// </summary>
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the main form
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
