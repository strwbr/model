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
    public partial class MainForm : Form
    {
        //Generator generator;

        public MainForm()
        {
            InitializeComponent();
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
            // Генерация в зависимости от выбранного генератора
            if (SysRb.Checked)
            {
                // системный генератор
                generator.Generate(Generator.SYSTEM_RANDOM);
            }
            else
            {
                // генератор на основе метода Лемера
                generator.Generate(Generator.LEMER_RANDOM);
            }
            // Отрисовка гистограммы и графика функций f(X) и F(X)
            DrawCharts(generator.Probability, generator.DistributionFunction, seqLength);
            // Отображение статистики
            ShowStatistics(seqLength, generator.MathExpect, generator.Dispersion);
        }

        // Вывод статистики: длина последовательности, мат.ожидание, дисперсия
        private void ShowStatistics(int len, double mathExpect, double dispersion)
        {
            StatField.Text += "-- " + (SysRb.Checked ? "Встроенный" : "Лемер") + " --\n";
            StatField.Text += "Длина посл-ти: " + len.ToString() + "\n";
            StatField.Text += "Мат. ожидание: " + mathExpect.ToString() + "\n";
            StatField.Text += "Дисперсия: " + dispersion.ToString() + "\n";
            StatField.Text += "-------------------------\n";
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

        // Добавление легенды к графикам
        private void AddLegendForCharts(int seqLen, Color color)
        {
            Label colorLbl = new Label();
            colorLbl.BackColor = color;
            colorLbl.Width = 30;

            Label textLbl = new Label();
            textLbl.Text = seqLen.ToString() + " (" + (SysRb.Checked ? "В" : "Л") + ")";
            textLbl.Width = 70;
            textLbl.TextAlign = ContentAlignment.MiddleLeft;

            legendPanel.Controls.Add(colorLbl);
            legendPanel.Controls.Add(textLbl);
        }

        // Обработчик нажатия на кнопку "Рассчитать"
        private void CountPiBtn_Click(object sender, EventArgs e)
        {
            Generator generator = new Generator(Convert.ToInt32(InputPiTb.Text));
            double temp = generator.Pi();
            PiLbl.Text = temp.ToString();
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

        // обработчик нажатия на кнопку "Очистить"
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
