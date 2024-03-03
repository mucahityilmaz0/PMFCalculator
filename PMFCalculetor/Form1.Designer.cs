namespace PMFCalculetor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chooseImage = new Button();
            pictureBox1 = new PictureBox();
            PMFText = new TextBox();
            calculate = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            drawChart = new Button();
            refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chooseImage
            // 
            chooseImage.Location = new Point(70, 8);
            chooseImage.Name = "chooseImage";
            chooseImage.Size = new Size(138, 76);
            chooseImage.TabIndex = 0;
            chooseImage.Text = "Choose Image";
            chooseImage.UseVisualStyleBackColor = true;
            chooseImage.Click += chooseImage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PMFText
            // 
            PMFText.Location = new Point(330, 105);
            PMFText.Multiline = true;
            PMFText.Name = "PMFText";
            PMFText.Size = new Size(107, 427);
            PMFText.TabIndex = 2;
            // 
            // calculate
            // 
            calculate.Location = new Point(303, 8);
            calculate.Name = "calculate";
            calculate.Size = new Size(134, 76);
            calculate.TabIndex = 3;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(471, 105);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(661, 427);
            chart1.TabIndex = 4;
            chart1.Text = "chart1";
            // 
            // drawChart
            // 
            drawChart.Location = new Point(510, 8);
            drawChart.Name = "drawChart";
            drawChart.Size = new Size(175, 76);
            drawChart.TabIndex = 5;
            drawChart.Text = "Draw Chart";
            drawChart.UseVisualStyleBackColor = true;
            drawChart.Click += drawChart_Click;
            // 
            // refresh
            // 
            refresh.Location = new Point(945, 8);
            refresh.Name = "refresh";
            refresh.Size = new Size(167, 76);
            refresh.TabIndex = 6;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 544);
            Controls.Add(refresh);
            Controls.Add(drawChart);
            Controls.Add(chart1);
            Controls.Add(calculate);
            Controls.Add(PMFText);
            Controls.Add(pictureBox1);
            Controls.Add(chooseImage);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseImage;
        private PictureBox pictureBox1;
        private TextBox PMFText;
        private Button calculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button drawChart;
        private Button refresh;
    }
}
