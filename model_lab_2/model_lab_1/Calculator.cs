using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace model_lab_1
{
    public partial class Calculator : Form
    {
        // Отображаемая строка
        private ArrayList DisplayInfixLine = new ArrayList();
        // Преобразованная строка (где ф-ии заменены)
        private ArrayList TransformInfixLine = new ArrayList();

        // Событие ввода строки
        public event Action<string, string> EnterLine;

        public Calculator()
        {
            InitializeComponent();
            infixText.Text = "";
        }

        // МОИ СОБОЛЕЗНОВАНИЯ РАЗОБРАТЬСЯ В ЭТОМ:)
        private void Symbol_Click(object sender, EventArgs e)
        {
            // к строке добавляется текст с кнопки, к-ая вызвала событие
            string newText = (sender as Button).Text;

            byte lastSymbolID = (byte)((DisplayInfixLine.Count > 0) ?
                GetWeight(DisplayInfixLine[DisplayInfixLine.Count - 1].ToString())
                : 0);
            byte currentSymbolID = GetWeight(newText);

            switch (currentSymbolID)
            {
                case 1:
                    if (lastSymbolID != 1 && lastSymbolID != 3)
                    {
                        DisplayInfixLine.Add(newText);
                        TransformInfixLine.Add(newText);
                    }
                    else
                        MessageBox.Show("Переменная не может быть после переменной или закрывающейся скобки!");
                    break;
                case 2:
                    if (lastSymbolID != 0 && lastSymbolID != 2 && lastSymbolID != 4 && lastSymbolID != 5)
                    {
                        DisplayInfixLine.Add(newText);
                        TransformInfixLine.Add(newText);
                    }
                    else
                        MessageBox.Show("Ошибка при вводе символа операции!");
                    break;
                case 3:
                    if (lastSymbolID != 0 && lastSymbolID != 2 && lastSymbolID != 4 && lastSymbolID != 5)
                    {
                        DisplayInfixLine.Add(newText);
                        TransformInfixLine.Add(newText);
                    }
                    else MessageBox.Show("Ошибка при вводе закрывающейся скобки!");
                    break;
                case 4:
                    if (lastSymbolID != 3)
                    {
                        DisplayInfixLine.Add(newText + "(");
                        TransformInfixLine.Add(newText[0].ToString().ToUpper() + "(");
                    }
                    else MessageBox.Show("После закрывающейся скобки не может быть функция!");
                    break;

                case 5:
                    if (lastSymbolID != 1 && lastSymbolID != 3)
                    {
                        DisplayInfixLine.Add(newText);
                        TransformInfixLine.Add(newText);
                    }
                    else MessageBox.Show("Ошибка при вводе открывающейся скобки!");
                    break;
            }

            string line = "";
            foreach (string s in DisplayInfixLine)
            {
                line += s;
                infixText.Text = line;
            };
        }


        // Расчет веса лексемы
        // переменная = 1
        // ариф. операция = 2
        // ) = 3
        // мат.функция = 4
        // ( = 5
        private byte GetWeight(string str)
        {
            byte id = 4;

            //string str = DisplayInfixLine[DisplayInfixLine.Count - 1].ToString();

            if (str.Length == 1)
            {

                switch (str)
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    case "^":
                        id = 2; break;
                    case ")":
                        id = 3; break;
                    case "(":
                        id = 5; break;
                    default:
                        id = 1; break;
                }

            }
            return id;
        }

        // Обработчик нажатия на кнопку "Готово"
        private void exit_btn_Click(object sender, EventArgs e)
        {
            // Если была введена строка
            if (DisplayInfixLine.Count != 0)
            {
                string line1 = "";
                string line2 = "";
                for (byte i = 0; i < DisplayInfixLine.Count; i++)
                {
                    line1 += DisplayInfixLine[i];
                    line2 += TransformInfixLine[i];
                }
                // Вызов события
                EnterLine?.Invoke(line1, line2);
                Close(); // Закрытие формы
            }
        }
        // Обработчик нажатия на кнопку "С" - очистка всей строки
        private void clear_all_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine.Clear();
            TransformInfixLine.Clear();

            infixText.Text = "";
        }
        // Обработчик нажатия на кнопку "<-" - удаление одного символа
        private void clear_btn_Click(object sender, EventArgs e)
        {
            // Если строка не пуста
            if (DisplayInfixLine.Count != 0)
            {
                DisplayInfixLine.RemoveAt(DisplayInfixLine.Count - 1);
                TransformInfixLine.RemoveAt(TransformInfixLine.Count - 1);
            }

            string line = "";
            foreach (string s in DisplayInfixLine)
            {
                line += s;
                infixText.Text = line;
            };
            infixText.Text = line;
        }

        //// Проверка, является ли последний символ в строке переменной
        //private bool CheckLetter(char ch)
        //{
        //    bool flag = false; // флаг для определения символа как буква (переменная) 
        //    // Получение последнего символа в строке
        //    char lastSmbl = (InfixLine.Length != 0)
        //        ? char.Parse(InfixLine.Substring(InfixLine.Length - 1))
        //        : '|';
        //    switch (lastSmbl)
        //    {
        //        case 'a':
        //        case 'b':
        //        case 'c':
        //        case 'd':
        //        case 'e':
        //        case 'f':
        //        case 'g':
        //        case 'h':
        //        case 'i':
        //        case 'j':
        //            {
        //                flag = true;
        //                MessageBox.Show("Нельзя вводить более одной переменной подряд!");
        //                break;
        //            }
        //    }
        //    return flag;
        //}

        //// Проверка, является ли последний символ в строке символом математической операции или открывающейся скобкой
        //private bool CheckOperationSymbol(char ch)
        //{
        //    bool flag = false; // флаг для определения символа как операция 
        //    // Получение последнего символа в строке
        //    char lastSmbl = (InfixLine.Length != 0)
        //        ? char.Parse(InfixLine.Substring(InfixLine.Length - 1))
        //        : '|';

        //    switch (lastSmbl)
        //    {
        //        case '+':
        //        case '-':
        //        case '*':
        //        case '/':
        //        case '^':
        //        case '|':
        //        case '(':
        //            {
        //                flag = true;
        //                MessageBox.Show("Ошибка при вводе символа операции!");
        //                break;
        //            }
        //    }
        //    return flag;
        //}
    }
}
