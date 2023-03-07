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
        private string postfixLine = "";
        private Dictionary<char, double> operandValues = new Dictionary<char, double>();
        private ArrayList Stack = new ArrayList(); // стек 
        private byte Pointer = 0; // Указатель на вершину стека (по факту кол-во активных символов, типа +,-...)

        private InputValuesForm inputValuesForm;

        public CountForm(string postfixLine)
        {
            InitializeComponent();
            this.postfixLine = postfixLine;
            originalLine.Text = postfixLine;
            stackForm.Rows.Add(10); // 10 строк в стеке == 10 строк в таблице решений
        }

        private void inputBtn_Click(object sender, EventArgs e)
        {
            foreach (char ch in postfixLine)
            {
                switch (ch)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'i':
                    case 'j':
                        operandValues.Add(ch, 0);
                        break;
                }
            }
            //открыть окно
            inputValuesForm = new InputValuesForm(operandValues);
            if (inputValuesForm.ShowDialog() == DialogResult.OK)
            {
                operandValues = inputValuesForm.operandValues; //дай бог
                foreach (KeyValuePair<char, double> pair in operandValues)
                {
                    richTextBox1.Text += "Число '" + pair.Key.ToString() + "' = " + pair.Value.ToString() + "\n";
                }
            }

        }

        // Метод для выведения стека на форму
        private void RedrawStack()
        {
            // Очистка стека на форме
            for (byte i = 0; i < stackForm.Rows.Count; i++)
            {
                stackForm.Rows[i].Cells[0].Value = "";
            }

            // Добавление новых строк в стек на форме, если необходимо
            if (Stack.Count > stackForm.RowCount)
                stackForm.Rows.Add(Stack.Count - stackForm.RowCount);

            //Stack.Reverse();

            // Заполнение стека на форме
            for (byte i = 0; i < Stack.Count; i++)
            {
                stackForm.Rows[stackForm.Rows.Count - 1 - i].Cells[0].Value = Stack[i];
            }

            // Выделение верхушки стека
            if (Pointer != 0)
                stackForm.Rows[stackForm.RowCount - Pointer].Cells[0].Selected = true;
        }

        private void CountExpression()
        {
            char current = (postfixLine.Length != 0) ? postfixLine[0] : '|'; //надо стопнуть
            double res = 0;
            postfixLine = (postfixLine.Length != 0)
                ? postfixLine.Substring(1)
                : "";
            postfixText.Text = postfixLine;
            switch (current)
            {
                //бинар
                case '|':
                    resText.Text = Stack[Pointer - 1].ToString();
                    MessageBox.Show("Успешное окончание вычисления!");
                    break;
                case '-':
                    res = (double)Stack[Pointer - 2] - (double)Stack[Pointer - 1];
                    Stack[Pointer - 2] = res;
                    Pointer--;
                    break;
                case '+':
                    res = (double)Stack[Pointer - 2] + (double)Stack[Pointer - 1];
                    Stack[Pointer - 2] = res;
                    Pointer--;
                    break;
                case '*':
                    res = (double)Stack[Pointer - 2] * (double)Stack[Pointer - 1];
                    Stack[Pointer - 2] = res;
                    Pointer--;
                    break;
                case '^':
                    res = Math.Pow((double)Stack[Pointer - 2], (double)Stack[Pointer - 1]);
                    Stack[Pointer - 2] = res;
                    Pointer--;
                    break;
                //бинар на ноль
                case '/':
                    //уточнить ПРО ТОЧНОСТЬЬЬЬ
                    if ((double)Stack[Pointer - 1] == 0)
                    {
                        MessageBox.Show("Попытка деления на ноль!");
                    }
                    else
                    {
                        res = (double)Stack[Pointer - 2] / (double)Stack[Pointer - 1];
                        Stack[Pointer - 2] = res;
                        Pointer--;
                    }
                    break;
                //унар (здесь мб не надо поинтер--)
                case 'S':
                    if ((double)Stack[Pointer - 1] < 0)
                    {
                        MessageBox.Show("Попытка извлечь квадратный корень из отрицательного числа!");
                    }
                    else
                    {
                        res = Math.Sqrt((double)Stack[Pointer - 1]);
                        Stack[Pointer - 1] = res;
                    }
                    break;
                case 'C':
                    //считает от РАДИАН
                    res = Math.Cos((double)Stack[Pointer - 1]);
                    Stack[Pointer - 1] = res;
                    break;
                case 'A':
                    res = Math.Abs((double)Stack[Pointer - 1]);
                    Stack[Pointer - 1] = res;
                    break;
                case 'L':
                    if ((double)Stack[Pointer - 1] <= 0)
                    {
                        MessageBox.Show("Число за пределами области определения десятичного логарифма!");
                    }
                    else
                    {
                        res = Math.Log10((double)Stack[Pointer - 1]);
                        Stack[Pointer - 1] = res;
                    }
                    break;
                default:
                    Stack.Add(operandValues[current]);
                    Pointer++;
                    break;
            }
        }

        private void beatBtn_Click(object sender, EventArgs e)
        {
            CountExpression();
            RedrawStack();
        }

    }
}
