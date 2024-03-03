using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;

namespace PMFCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string selectedImagePath;
        private void chooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(selectedImagePath);
            }
        }

        double[] pmf = new double[256];

        private void calculate_Click(object sender, EventArgs e)
        {
            using (Mat image = CvInvoke.Imread(selectedImagePath, ImreadModes.Grayscale))
            {
                Image<Gray, byte> grayImage = image.ToImage<Gray, byte>();

                DenseHistogram histogram = new DenseHistogram(256, new RangeF(0, 256));

                histogram.Calculate(new Image<Gray, byte>[] { grayImage }, false, null);

                float[] histogramValues = new float[256];
                histogram.CopyTo(histogramValues);

                double totalPixels = grayImage.Width * grayImage.Height;

                for (int i = 0; i < 256; i++)
                {
                    pmf[i] = histogramValues[i] / totalPixels;

                }
                string pmfText = "\r\n";
                foreach (var value in pmf)
                {
                    pmfText += value.ToString("F6") + "\r\n";
                }

                PMFText.Text = pmfText;

            }
        }

        private void drawChart_Click(object sender, EventArgs e)
        {
            int[] X = new int[256];
            double[] uf = new double[256];
            for (int i = 0; i <= 255; i++)
            {
                X[i] = i;
                uf[i] = pmf[i];
            }

            for (int i = 0; i < X.Length; i++)
            {
                chart1.Series["Series1"].Points.AddXY(X[i], uf[i]);
                if (i > 0)
                {
                    chart1.Series["Series1"].Points.AddXY(X[i], 0);
                    chart1.Series["Series1"].Points.AddXY(X[i], uf[i]);
                }
            }

            chart1.ChartAreas[0].AxisX.Title = "X kesin uzayi";
            chart1.ChartAreas[0].AxisY.Title = "Uyelik Dereceleri";
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Series1"].Color = Color.Blue;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            PMFText.Clear();
            pictureBox1.Image = null;
            chart1.Series.Add("Series1");
            chart1.ChartAreas.Add("ChartAreas");
        }
    }
}
