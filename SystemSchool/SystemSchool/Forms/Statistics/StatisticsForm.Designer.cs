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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonChartLines = new System.Windows.Forms.Button();
            this.buttonBarCharts = new System.Windows.Forms.Button();
            this.buttonPizzaCharts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1031, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(13, 680);
            this.vScrollBar1.TabIndex = 0;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(12, 71);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(1024, 488);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // buttonChartLines
            // 
            this.buttonChartLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChartLines.Location = new System.Drawing.Point(81, 591);
            this.buttonChartLines.Name = "buttonChartLines";
            this.buttonChartLines.Size = new System.Drawing.Size(104, 23);
            this.buttonChartLines.TabIndex = 2;
            this.buttonChartLines.Text = "Chart Lines";
            this.buttonChartLines.UseVisualStyleBackColor = true;
            this.buttonChartLines.Click += new System.EventHandler(this.buttonChartLines_Click);
            // 
            // buttonBarCharts
            // 
            this.buttonBarCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarCharts.Location = new System.Drawing.Point(200, 591);
            this.buttonBarCharts.Name = "buttonBarCharts";
            this.buttonBarCharts.Size = new System.Drawing.Size(104, 23);
            this.buttonBarCharts.TabIndex = 3;
            this.buttonBarCharts.Text = "Bar charts";
            this.buttonBarCharts.UseVisualStyleBackColor = true;
            // 
            // buttonPizzaCharts
            // 
            this.buttonPizzaCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPizzaCharts.Location = new System.Drawing.Point(320, 591);
            this.buttonPizzaCharts.Name = "buttonPizzaCharts";
            this.buttonPizzaCharts.Size = new System.Drawing.Size(104, 23);
            this.buttonPizzaCharts.TabIndex = 4;
            this.buttonPizzaCharts.Text = "PizzaCharts";
            this.buttonPizzaCharts.UseVisualStyleBackColor = true;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1042, 681);
            this.Controls.Add(this.buttonPizzaCharts);
            this.Controls.Add(this.buttonBarCharts);
            this.Controls.Add(this.buttonChartLines);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.vScrollBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button buttonChartLines;
        private System.Windows.Forms.Button buttonBarCharts;
        private System.Windows.Forms.Button buttonPizzaCharts;
    }
}