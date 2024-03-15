namespace SystemSchool.Forms.StatisticsForms
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
            this.buttonPieCharts = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
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
            this.buttonBarCharts.Click += new System.EventHandler(this.buttonBarCharts_Click);
            // 
            // buttonPieCharts
            // 
            this.buttonPieCharts.BackColor = System.Drawing.Color.White;
            this.buttonPieCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPieCharts.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPieCharts.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPieCharts.Location = new System.Drawing.Point(1020, 599);
            this.buttonPieCharts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPieCharts.Name = "buttonPieCharts";
            this.buttonPieCharts.Size = new System.Drawing.Size(121, 23);
            this.buttonPieCharts.TabIndex = 4;
            this.buttonPieCharts.Text = "Pie Charts";
            this.buttonPieCharts.UseVisualStyleBackColor = false;
            this.buttonPieCharts.Click += new System.EventHandler(this.buttonPieCharts_Click);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chart.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(3, 79);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1201, 485);
            this.chart.TabIndex = 5;
            this.chart.Text = "chart";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemSchool.Properties.Resources.icons8_school_80;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBoxBack.Location = new System.Drawing.Point(1181, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 7;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1216, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.buttonPieCharts);
            this.Controls.Add(this.buttonBarCharts);
            this.Controls.Add(this.buttonChartLines);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonChartLines;
        private System.Windows.Forms.Button buttonBarCharts;
        private System.Windows.Forms.Button buttonPieCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}