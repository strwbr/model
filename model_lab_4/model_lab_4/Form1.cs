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
            // Если построено 6 гистограмм/графиков
            if (chartProbability.Series.Count == 6)
            {
                // Очистка диаграммы
                MessageBox.Show("Превышено число ввода допустимых длин последовательностию. Диаграммы будут очищены. Пожалуйста, повторно нажмите на кнопку Запуск "); // Диаграммы???
                Clear();
                return;
            }

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
            seriesForChart2.ChartType = SeriesChartType.StepLine;

            // Задание цвета для гистограммы и графика (цвет одинаковый)
            Color color = GenerateColor();
            seriesForChart1.Color = color;
            seriesForChart2.Color = color;

            for (int i = 0; i < 100; i++)
            {
                seriesForChart1.Points.AddXY(i, dataForChart1[i]);
                seriesForChart2.Points.AddXY(i, dataForChart2[i]);
            }
            chartProbability.Series.Add(seriesForChart1);
            chartDistributionFunc.Series.Add(seriesForChart2);

            // Добавление легенды
            AddLegendForCharts(seqLen, color);
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

        // Добавление легенды к графикам
        private void AddLegendForCharts(int seqLen, Color color)
        {
            Label colorLbl = new Label();
            colorLbl.BackColor = color;
            colorLbl.Width = 30;

            Label textLbl = new Label();
            textLbl.Text = seqLen.ToString();
            textLbl.Width = 70;
            textLbl.TextAlign = ContentAlignment.MiddleLeft;

            legendPanel.Controls.Add(colorLbl);
            legendPanel.Controls.Add(textLbl);
        }

        // Очистка диаграмм
        private void ClearChartSeries()
        {
            chartProbability.Series.Clear();
            chartDistributionFunc.Series.Clear();
        }

        // Очистка формы
        private void Clear()
        {
            ClearChartSeries();
            legendPanel.Controls.Clear();
            StatField.Text = "";
            InputSeqLenTb.Text = "100";
        }
    }
}
