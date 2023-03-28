using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace model_lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // проверка графиков
            for (int i = 0; i < 99; i++)
            {
                chart1.Series[0].Points.AddXY(i, 3);
                chart2.Series[0].Points.AddXY(i, 3);
            }
            // проверка поля вывода статистики
            StatField.Text = "wdsedfg\n";
            StatField.Text += "wdsedfg\n";
            StatField.Text += "wdsedfg\n";
            StatField.Text += "wdsedfg\n";
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
    }
}
