using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace model_lab_1
{
    public partial class CountForm : Form
    {
        private Model model;
        // Словарь значений переменных
        public Dictionary<char, double> operandValues = new Dictionary<char, double>();
        // Начальная позиция указателя вершины стека на форме
        private Point startArrowPos; 
        // Постфиксная строка
        private string PostfixLine;

        public CountForm(string postfixLine)
        {
            InitializeComponent();

            model = new Model();
            model.PostfixLine = postfixLine;

            PostfixLine = postfixLine;
            originalLine.Text = postfixLine;
            postfixText.Text = postfixLine;

            resText.Text = "";
            stackForm.Rows.Add(12);
            // Задание начального положения указателя на форме
            startArrowPos = new Point(arrowLabel.Location.X, arrowLabel.Location.Y);

            // Отключение кнопок
            translateBtn.Enabled = false;
            beatBtn.Enabled = false;
        }

        // Обработчик нажатия на кнопку "Ввести числа"
        private void inputBtn_Click(object sender, EventArgs e)
        {
            // Заполнение словаря
            operandValues = model.FillDictionary();

            model.PostfixLine = PostfixLine;
            postfixText.Text = PostfixLine;
            resText.Text = "";
            
            // Открытие окна ввода значений переменных
            ValueForm valueForm = new ValueForm(operandValues);
            // Если на форме была нажата кнопка "Подтвердить"
            if (valueForm.ShowDialog() == DialogResult.OK)
            {
                model.operandValues = valueForm.operandValues;
                variableValuesBox.Text = "";
                // Вывод значений переменных на элемент формы
                foreach (KeyValuePair<char, double> pair in model.operandValues)
                {
                    variableValuesBox.Text += "Число '" + pair.Key.ToString() + "' = " + pair.Value.ToString() + "\n";
                }
                // Включение кнопок
                translateBtn.Enabled = true;
                beatBtn.Enabled = true;
                // Отключение кнопок
                inputBtn.Enabled = false;
            }
        }

        // Метод для выведения стека на форму
        private void RedrawForm()
        {
            postfixText.Text = model.PostfixLine;

            // Очистка стека на форме
            for (int i = 0; i < stackForm.Rows.Count; i++)
            {
                stackForm.Rows[i].Cells[0].Value = "";
            }

            // Добавление новых строк в стек на форме, если необходимо
            if (model.Stack.Count > stackForm.RowCount)
                stackForm.Rows.Add(model.Stack.Count - stackForm.RowCount);


            // Заполнение стека на форме
            for (int i = 0; i < model.Stack.Count; i++)
            {
                stackForm.Rows[stackForm.Rows.Count - 1 - i].Cells[0].Value = model.Stack[i];
            }


            // Выделение вершины стека
            if (model.Pointer != -1)
            {
                // Выделение строки - вершины стека в таблице-стеке на форме
                stackForm.Rows[stackForm.RowCount - model.Pointer - 1].Cells[0].Selected = true;
                // Расчет новой координаты Y для указателя вершины стека на форме
                int newY = startArrowPos.Y - 1 - (model.Pointer * 20);
                arrowLabel.Location = new Point(startArrowPos.X, newY);

            }
        }

        // Обработчик нажатия на кнопку "Такт"
        private void beatBtn_Click(object sender, EventArgs e)
        {
            // Отключение кнопок
            translateBtn.Enabled = false;
            inputBtn.Enabled = false;
            // Вычисление
            int index = model.CountExpression();
            // Перерисовка формы
            RedrawForm();
            // Вывод сообщения, если необходимо
            ShowMessage(index);
        }

        // Вывод сообщений
        private void ShowMessage(int index)
        {
            // В зависимости от кода результата
            switch (index)
            {
                case 0:
                    break;
                case 1:
                    resText.Text = model.ResText;
                    MessageBox.Show("Успешное окончание вычисления!");
                    beatBtn.Enabled = true;
                    translateBtn.Enabled=true;
                    inputBtn.Enabled = true;
                    break;
                case 2:
                    MessageBox.Show("Попытка деления на ноль!");
                    inputBtn.Enabled = true;
                    beatBtn.Enabled = false;
                    translateBtn.Enabled = false;
                    break;
                case 3:
                    MessageBox.Show("Попытка извлечь квадратный корень из отрицательного числа!");
                    inputBtn.Enabled = true;
                    beatBtn.Enabled = false;
                    translateBtn.Enabled = false;
                    break;
                case 4:
                    MessageBox.Show("Число за пределами области определения десятичного логарифма!");
                    inputBtn.Enabled = true;
                    beatBtn.Enabled = false;
                    translateBtn.Enabled = false;
                    break;
            }
        }

        // Событие таймера для визуального отображения
        // процесса вычисления в автоматическом режиме
        private void timer1_Tick(object sender, EventArgs e)
        {
            int index = model.CountExpression();
            RedrawForm();
            // Если преобразование завершилось успешно или найдена ошибка
            if (index == 1 || index == 2 || index == 3 || index == 4)
            {
                // Отключение таймера
                timer1.Enabled = false;
                timer1.Stop();
            }
            ShowMessage(index);
        }

        // Обработчик нажатия на кнопку "Перевести"
        private void translateBtn_Click(object sender, EventArgs e)
        {
            beatBtn.Enabled = false;
            inputBtn.Enabled = false;
            // Включение таймера
            timer1.Start();
        }
    }
}
