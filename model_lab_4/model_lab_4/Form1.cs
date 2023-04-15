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

namespace model_lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            int seqLength = Convert.ToInt32(InputSeqLenTb.Text);
            Generator generator = new Generator(seqLength);
            generator.Generate();
            DrawCharts(generator.Probability, generator.DistributionFunction, seqLength);
            ShowStatistics(seqLength, generator.MathExpect, generator.Dispersion);
        }

        // Визуализация гистограмм и графиков функций f(X) и F(X)
        private void DrawCharts(double[] dataForChart1, double[] dataForChart2, int seqLen)
        {
            Series seriesForChart1 = new Series();
            Series seriesForChart2 = new Series();
            //seriesForChart2.ChartType = SeriesChartType.StepLine;

            // Задание цвета для гистограммы и графика (цвет одинаковый)
            Color color = GenerateColor();
            seriesForChart1.Color = color;
            seriesForChart2.Color = color;

            for (int i = 0; i < 100; i++)
            {
                seriesForChart1.Points.AddXY(i, dataForChart1[i]);
                //seriesForChart2.Points.AddXY(i, dataForChart2[i]);
            }
            chart1.Series.Add(seriesForChart1);
            //chart2.Series.Add(seriesForChart2);

            // Добавление легенды
            //AddLegendForCharts(seqLen, color);
        }

        // Вывод статистики: длина последовательности, мат.ожидание, дисперсия
        private void ShowStatistics(int len, double mathExpect, double dispersion)
        {
            StatField.Text += "Длина посл-ти: " + len.ToString() + "\n";
            StatField.Text += "Мат. ожидание: " + mathExpect.ToString() + "\n";
            StatField.Text += "Дисперсия: " + dispersion.ToString() + "\n";
            StatField.Text += "-------------------------\n";
        }

        // Генерация цвета для графика
        private Color GenerateColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}
