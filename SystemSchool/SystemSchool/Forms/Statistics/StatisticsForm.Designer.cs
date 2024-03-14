namespace SystemSchool.Forms.Statistics
{
    partial class StatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonChartLines = new System.Windows.Forms.Button();
            this.buttonBarCharts = new System.Windows.Forms.Button();
            this.buttonPizzaCharts = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChartLines
            // 
            this.buttonChartLines.BackColor = System.Drawing.Color.White;
            this.buttonChartLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChartLines.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChartLines.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonChartLines.Location = new System.Drawing.Point(855, 599);
            this.buttonChartLines.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonChartLines.Name = "buttonChartLines";
            this.buttonChartLines.Size = new System.Drawing.Size(121, 23);
            this.buttonChartLines.TabIndex = 2;
            this.buttonChartLines.Text = "Chart Lines";
            this.buttonChartLines.UseVisualStyleBackColor = false;
            this.buttonChartLines.Click += new System.EventHandler(this.buttonChartLines_Click);
            // 
            // buttonBarCharts
            // 
            this.buttonBarCharts.BackColor = System.Drawing.Color.White;
            this.buttonBarCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarCharts.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBarCharts.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonBarCharts.Location = new System.Drawing.Point(684, 599);
            this.buttonBarCharts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBarCharts.Name = "buttonBarCharts";
            this.buttonBarCharts.Size = new System.Drawing.Size(121, 23);
            this.buttonBarCharts.TabIndex = 3;
            this.buttonBarCharts.Text = "Bar charts";
            this.buttonBarCharts.UseVisualStyleBackColor = false;
            // 
            // buttonPizzaCharts
            // 
            this.buttonPizzaCharts.BackColor = System.Drawing.Color.White;
            this.buttonPizzaCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPizzaCharts.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPizzaCharts.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPizzaCharts.Location = new System.Drawing.Point(1020, 599);
            this.buttonPizzaCharts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPizzaCharts.Name = "buttonPizzaCharts";
            this.buttonPizzaCharts.Size = new System.Drawing.Size(121, 23);
            this.buttonPizzaCharts.TabIndex = 4;
            this.buttonPizzaCharts.Text = "Pizza Charts";
            this.buttonPizzaCharts.UseVisualStyleBackColor = false;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(-1, 67);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1201, 485);
            this.chart.TabIndex = 5;
            this.chart.Text = "chart";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1216, 681);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.buttonPizzaCharts);
            this.Controls.Add(this.buttonBarCharts);
            this.Controls.Add(this.buttonChartLines);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonChartLines;
        private System.Windows.Forms.Button buttonBarCharts;
        private System.Windows.Forms.Button buttonPizzaCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}