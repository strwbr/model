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

namespace model_lab_3
{
    public partial class Form1 : Form
    {
        //Generator generator;

        public Form1()
        {
            InitializeComponent();

            // проверка графиков
            //for (int i = 0; i < 99; i++)
            //{
            //    chart1.Series[0].Points.AddXY(i, 3);
            //    chart2.Series[0].Points.AddXY(i, 3);
            //}
            // проверка поля вывода статистики
            StatField.Text = "";
        }

        // Генерация цвета для графика
        private Color GenerateColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        // Обработчик изменения содержимого поля ввода длины последовательности
        private void InputSeqLenTb_TextChanged(object sender, EventArgs e)
        {
            // try catch нужен для того, чтобы не вылетело при пустой строке
            try
            {
                int num = Convert.ToInt32(InputSeqLenTb.Text);
                bool accepted = CheckInputValue(num);
                InputSeqLenTb.BackColor = accepted ? Color.White : Color.Red;
                StartBtn.Enabled = accepted;
            }
            catch (FormatException) { }

        }

        // Обработчик изменения содержимого поля ввода объема выборки для Pi
        private void InputPiTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(InputPiTb.Text);
                bool accepted = CheckInputValue(num);
                InputPiTb.BackColor = accepted ? Color.White : Color.Red;
                CountPiBtn.Enabled = accepted;
            }
            catch (FormatException) { }
        }

        // Проверка введенной длины последовательности на принадлежность диапазону [100; 10000] 
        private bool CheckInputValue(int num)
        {
            return num >= 100 && num <= 10000;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (chart1.Series.Count == 6)
            {
                MessageBox.Show("Превышено число ввода допустимых длин последовательностию. Диаграммы будут очищены. Пожалуйста, повторно нажмите на кнопку Запуск "); // Диаграммы???
                Clear();
                return;
            }
            int seqLength = Convert.ToInt32(InputSeqLenTb.Text);
            Generator generator = new Generator(seqLength);
            if (SysRb.Checked)
            {
                generator.Generate(Generator.SYSTEM_RANDOM);
                // system random
            }
            else
            {
                generator.Generate(Generator.LEMER_RANDOM);
                // lemer random
            }
            DrawCharts(generator.Probability, generator.DistributionFunction);
            ShowStatistics(seqLength, generator.MathExpect, generator.Dispersion);
        }

        private void ShowStatistics(int len, double mathExpect, double dispersion)
        {
            StatField.Text += "Длина посл-ти: " + len.ToString() + "\n";
            StatField.Text += "Мат. ожидание: " + mathExpect.ToString() + "\n";
            StatField.Text += "Дисперсия: " + dispersion.ToString() + "\n";
            StatField.Text += "-------------------------\n";
        }

        private void DrawCharts(double[] dataForChart1, double[] dataForChart2)
        {
            Series series1 = new Series();
            Series series2 = new Series();
            series2.ChartType = SeriesChartType.StepLine;
            Color color = GenerateColor();
            series1.Color = color;
            series2.Color = color;
            for (int i = 0; i < 100; i++)
            {
                series1.Points.AddXY(i, dataForChart1[i]);
                series2.Points.AddXY(i, dataForChart2[i]);
            }
            //series.IsXValueIndexed = false; -- не работает
            chart1.Series.Add(series1);
            chart2.Series.Add(series2);




            //chart1.Series[0].Points.Clear();
            //chart1.Series[0].Color = GenerateColor();
            //for (int i = 0; i < 100; i++)
            //{
            //    chart1.Series[0].Points.AddXY(i, data[i]);
            //}
        }

        private void CountPiBtn_Click(object sender, EventArgs e)
        {
            Generator generator = new Generator(Convert.ToInt32(InputPiTb.Text));
            double temp = generator.Pi();
            PiLbl.Text = temp.ToString();
        }

        private void ClearChartSeries()
        {
            chart1.Series.Clear();
            chart2.Series.Clear();
        }

        private void Clear()
        {
            ClearChartSeries();
            StatField.Text = "";
            InputSeqLenTb.Text = "100";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
