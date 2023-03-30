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
        Generator generator;

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
            StatField.Text = "wdsedfg\n";
            StatField.Text += "wdsedfg\n";
            StatField.Text += "wdsedfg\n";
            StatField.Text += "wdsedfg\n";
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
            int seqLength = Convert.ToInt32(InputSeqLenTb.Text);
            generator = new Generator(seqLength);
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
            DrawCharts(generator.Probability);

        }

        private void DrawCharts(double[] data)
        {
            if (chart1.Series.Count == 6)
            {
                MessageBox.Show("Превышено число ввода допустимых длин последовательностию. Диаграммы будут очищены. Пожалуйста, повторно нажмите на кнопку Запуск "); // Диаграммы???
                chart1.Series.Clear();
            }
            else
            {
                Series series = new Series();
                series.Color = GenerateColor();
                for (int i = 0; i < 100; i++)
                {
                    series.Points.AddXY(i, data[i]);
                }
                //series.IsXValueIndexed = false; -- не работает
                chart1.Series.Add(series);
            }
            



            //chart1.Series[0].Points.Clear();
            //chart1.Series[0].Color = GenerateColor();
            //for (int i = 0; i < 100; i++)
            //{
            //    chart1.Series[0].Points.AddXY(i, data[i]);
            //}
        }
    }
}
